using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using ClosedXML.Excel;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using Graph = System.Windows.Forms.DataVisualization.Charting;

namespace SensorRealtime
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource cts;
        private List<string> multiParameterSelected;

        public MainForm()
        {
            InitializeComponent();
            if (this.updateRateCb.SelectedItem == null) this.updateRateCb.SelectedItem = this.updateRateCb.Items[0];
            this.multiParameterSelected = new List<string>();
            this.saveDirectoryBrowser.AddExtension = true;
        }
        /// 
        /// Helper Methods
        ///
        private async Task<JObject> parseJsonAsync(string jsonString)
        {
            JObject data = JObject.Parse(jsonString);
            return data;
        }

        private async Task<JObject> getDataAsync()
        {
            using (HttpClient httpHandler = new HttpClient())
            {
                var jsonString = await httpHandler.GetStringAsync("http://ivlab.azurewebsites.net/getData");
                JObject data = await this.parseJsonAsync(jsonString);
                return data;
            }
        }

        private int getMinuteFromTrackBar(int trackBarValue)
        {
            return Math.Abs((((trackBarValue - 1) * 10) / 60) + 1);
        }

        private int getSecondFromTrackBar(int trackBarValue, int minuteOfSec)
        {
            return ((trackBarValue - 1) * 10) - ((minuteOfSec - 1) * 60);
        }

        private async Task displayLineChartAsync(int totalTimeInSec, int rate, string selectedParameter, CancellationToken ct)
        {
            try
            {
                this.startDisplay.Text = "Refresh";
                JObject data;
                Stopwatch sw = new Stopwatch();
                data = await getDataAsync();
                await this.decorateLineChartAsync(data, selectedParameter, totalTimeInSec, rate);
                for (int i = 0; i < totalTimeInSec; i += rate)
                {
                    sw.Restart();
                    ct.ThrowIfCancellationRequested();
                    data = await this.getDataAsync();
                    ct.ThrowIfCancellationRequested();
                    float actual = float.Parse(data[selectedParameter][5]["actual"].ToString());
                    this.realtime_lineChart.Series[selectedParameter].Points.AddXY(i, actual);
                    sw.Stop();
                    await Task.Delay(rate * 1000 - (int)sw.ElapsedMilliseconds);
                }
                this.startDisplay.Text = "Start";
            } catch (OperationCanceledException oce)
            {
                Console.WriteLine(oce.ToString());
            }
        }

        private async Task decorateLineChartAsync(JObject data, string selectedParameter, int totalTimeInSec, int rate)
        {
            string description = data[selectedParameter][0]["description"].ToString();
            float min = float.Parse(data[selectedParameter][1]["min"].ToString());
            float minDisplay = float.Parse(data[selectedParameter][2]["minDisplay"].ToString());
            float max = float.Parse(data[selectedParameter][3]["max"].ToString());
            float maxDisplay = float.Parse(data[selectedParameter][4]["maxDisplay"].ToString());
            this.realtime_lineChart.ChartAreas["draw"].AxisX.Minimum = 0;
            this.realtime_lineChart.ChartAreas["draw"].AxisX.Maximum = totalTimeInSec;
            this.realtime_lineChart.ChartAreas["draw"].AxisX.Interval = rate;
            this.realtime_lineChart.ChartAreas["draw"].AxisY.Minimum = minDisplay;
            this.realtime_lineChart.ChartAreas["draw"].AxisY.Maximum = maxDisplay;
            this.realtime_lineChart.ChartAreas["draw"].AxisY.Interval = 10;
            this.realtime_lineChart.Series.Add(selectedParameter);
            this.realtime_lineChart.Series[selectedParameter].LegendText = description;
            this.realtime_lineChart.Series[selectedParameter].ChartType = Graph.SeriesChartType.Line;
            this.realtime_lineChart.Series[selectedParameter].Color = Color.LightGreen;
            this.realtime_lineChart.Series[selectedParameter].BorderWidth = 3;
            this.realtime_lineChart.Legends.Add(description);
            this.realtime_lineChart.Legends[description].BorderColor = Color.Tomato;
        }

        private async Task clearPreviousChartData()
        {
            this.realtime_lineChart.Series.Clear();
            this.realtime_lineChart.Legends.Clear();
        }
        private async Task exportExcelAsync(int totalTimeInSec, List<string> multiParameterSelected, string savePath)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                JObject data;
                Stopwatch sw = new Stopwatch();
                await this.addWorkSheetAsync(wb, multiParameterSelected);
                for(int i = 0; i<totalTimeInSec; i+=10)
                {
                    sw.Restart();
                    data = await getDataAsync(); 
                    await this.formatWorkSheetsAsync(wb, data, multiParameterSelected);
                    await this.addDataToWorkSheetsAsync(wb, data, multiParameterSelected, DateTime.Now.ToString("HH:mm:ss"), Math.Abs(i/10));
                    this.savingTimeRemainLb.Text = (totalTimeInSec - i).ToString();
                    sw.Stop();
                    await Task.Delay(10 * 1000 - (int)sw.ElapsedMilliseconds);
                }
                wb.SaveAs(savePath);
            }
        }

        private async Task addWorkSheetAsync(XLWorkbook workbook, List<string> multiParamaterSelected)
        {
            foreach(string paramName in multiParamaterSelected)
            {
                workbook.AddWorksheet(paramName);
            }
        }

        private async Task formatWorkSheetsAsync(XLWorkbook workbook, JObject data, List<string> multiParameterSelected)
        {
            foreach (string paramName in multiParameterSelected)
            {
                var ws = workbook.Worksheet(paramName);
                ws.Cell(1, 1).Value = paramName;
                string description = data[paramName][0]["description"].ToString();
                
                ws.Cell(1, 2).Value = description.Substring(description.IndexOf('(') + 1).Replace(")", "").Replace("in ", "");
                ws.Cell(2, 1).Value = "Min value";
                ws.Cell(2, 2).Value = "Max value"; 
                ws.Cell(2, 3).Value = "Current value";
                ws.Cell(2, 4).Value = "Timestamp";
            }
        }

        private async Task addDataToWorkSheetsAsync(XLWorkbook workbook, JObject data, List<string> multiParameterSelected, string timeStamp, int dataRowIndex)
        {
            foreach (string paramName in multiParameterSelected)
            {
                var ws = workbook.Worksheet(paramName);
                float min = float.Parse(data[paramName][1]["min"].ToString());
                float minDisplay = float.Parse(data[paramName][2]["minDisplay"].ToString());
                float max = float.Parse(data[paramName][3]["max"].ToString());
                float maxDisplay = float.Parse(data[paramName][4]["maxDisplay"].ToString());
                float actual = float.Parse(data[paramName][5]["actual"].ToString());
                ws.Cell(dataRowIndex + 3, 1).Value = min;
                ws.Cell(dataRowIndex + 3, 2).Value = max;
                ws.Cell(dataRowIndex + 3, 3).Value = actual;
                ws.Cell(dataRowIndex + 3, 4).Value = timeStamp;
            }
        }
        ///
        /// Event Handler Methods
        /// 
        private void durationBar_dpTab_ValueChanged(object sender, EventArgs e)
        {
            int min = this.getMinuteFromTrackBar(this.durationBar_dpTab.Value);
            this.minValueLb_dpTab.Text = min.ToString(); this.minValueLb_dpTab.Refresh();
            int sec = this.getSecondFromTrackBar(this.durationBar_dpTab.Value, min);
            this.secValueLb_dpTab.Text = sec.ToString(); this.secValueLb_dpTab.Refresh();
        }

        private void durationbar_epTab_ValueChanged(object sender, EventArgs e)
        {
            int min = this.getMinuteFromTrackBar(this.durationBar_epTab.Value);
            this.minValueLb_epTab.Text = min.ToString(); this.minValueLb_epTab.Refresh();
            int sec = this.getSecondFromTrackBar(this.durationBar_epTab.Value, min);
            this.secValueLb_epTab.Text = sec.ToString(); this.secValueLb_epTab.Refresh();
        }

        private async void startDisplay_Click(object sender, EventArgs e)
        {
            if (this.parameterListCb.SelectedItem == null) {
                MessageBox.Show("Please select a parameter to display !", "Notice");
                return;
            }
            if (cts != null) {
                cts.Cancel();
                cts = null;
            }
            this.cts = new CancellationTokenSource();
            int min = this.getMinuteFromTrackBar(this.durationBar_dpTab.Value);
            int sec = this.getSecondFromTrackBar(this.durationBar_dpTab.Value, min);
            await this.clearPreviousChartData();
            await this.displayLineChartAsync(min * 60 + sec, int.Parse(this.updateRateCb.SelectedItem.ToString()), 
                                                this.parameterListCb.SelectedItem.ToString(), this.cts.Token);
        }

        private void updateRateCb_Leave(object sender, EventArgs e)
        {
            if (this.updateRateCb.SelectedItem == null)
            {
                this.updateRateCb.SelectedItem = this.updateRateCb.Items[0];
            }
        }

        private void parameterListCb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.startDisplay.Text = "Start";
        }

        private void selectMultiParametersBt_Click(object sender, EventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton == null) return;
            if (senderButton.BackColor == System.Drawing.Color.LightGreen)
            {
                this.multiParameterSelected.Add(senderButton.Tag.ToString());
                senderButton.BackColor = System.Drawing.Color.Tomato;
            }
            else if (senderButton.BackColor == System.Drawing.Color.Tomato)
            {
                this.multiParameterSelected.Remove(senderButton.Tag.ToString());
                senderButton.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            this.saveDirectoryBrowser.ShowDialog();
            string savePath = this.saveDirectoryBrowser.FileName;
            int min = this.getMinuteFromTrackBar(this.durationBar_epTab.Value);
            int sec = this.getSecondFromTrackBar(this.durationBar_epTab.Value, min);
            int totalTimeInSec = (min * 60) + sec; this.savingTimeRemainLb.Text = totalTimeInSec.ToString();
            await this.exportExcelAsync(totalTimeInSec, this.multiParameterSelected, savePath);
            MessageBox.Show("Data has been saved!");
        }
    }
}
