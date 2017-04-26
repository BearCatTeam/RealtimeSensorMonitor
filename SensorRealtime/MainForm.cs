using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net;
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
            await Task.Yield();
            JObject data = JObject.Parse(jsonString);
            return data;
        }

        private async Task<JObject> getDataAsync()
        {
            using (HttpClientHandler httpClientHandler = new HttpClientHandler())
            {
                httpClientHandler.UseProxy = false;
                using (HttpClient httpHandler = new HttpClient(httpClientHandler))
                {
                    var jsonString = await httpHandler.GetStringAsync("http://ivlab.azurewebsites.net/getData");
                    JObject data = await this.parseJsonAsync(jsonString);
                    return data;
                }
            }
        }

        private int getMinuteFromTrackBar(int trackBarValue)
        {
            return Task.Run<int>(()=>Math.Abs((((trackBarValue - 1) * 10) / 60) + 1)).Result;
        }

        private int getSecondFromTrackBar(int trackBarValue, int minuteOfSec)
        {
            return Task.Run<int>(()=>((trackBarValue - 1) * 10) - ((minuteOfSec - 1) * 60)).Result;
        }

        private async Task displayLineChartAsync(int totalTimeInSec, int rate, string selectedParameter, CancellationToken ct)
        {
            bool onFailed = false;
            try
            {
                this.startDisplay.Text = "Refresh";
                Stopwatch sw = new Stopwatch();
                JObject data = await getDataAsync();
                float actual;
                await this.decorateLineChartAsync(data, selectedParameter, totalTimeInSec, rate);
                for (int i = 0; i <= totalTimeInSec; i += rate)
                {
                    string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                    sw.Restart();
                    ct.ThrowIfCancellationRequested();
                    if ((i != 0) && (i != totalTimeInSec)) timeStamp = "";
                    ct.ThrowIfCancellationRequested();
                    data = await this.getDataAsync();
                    ct.ThrowIfCancellationRequested();
                    actual = float.Parse(data[selectedParameter][5]["actual"].ToString());
                    ct.ThrowIfCancellationRequested();
                    this.realtime_lineChart.ChartAreas["draw"].AxisX.CustomLabels.Add(i - 2, i + 2, timeStamp, 0, Graph.LabelMarkStyle.None);
                    ct.ThrowIfCancellationRequested();
                    this.realtime_lineChart.Series[selectedParameter].Points.AddXY(i, actual);
                    ct.ThrowIfCancellationRequested();
                    sw.Stop();
                    await Task.Delay(rate * 1000 - (int)sw.ElapsedMilliseconds);
                }
                this.startDisplay.Text = "Start";
            } catch (OperationCanceledException oce)
            {
                if (this.realtime_lineChart.Series.Contains(new Graph.Series(selectedParameter))) onFailed = true;
                Console.WriteLine(oce.ToString());
            } catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Slow internet connection! Please check you connection or set slower rate!");
                Console.WriteLine(aoore.ToString());
            }
            if (onFailed) await this.clearPreviousChartData();
        }

        private async Task decorateLineChartAsync(JObject data, string selectedParameter, int totalTimeInSec, int rate)
        {
            bool onFailed = false;
            try
            {
                await Task.Yield();
                this.realtime_lineChart.Series.Add(selectedParameter);
                string description = data[selectedParameter][0]["description"].ToString();
                description = description.Substring(description.IndexOf('(') + 1).Replace(")", "");
                this.realtime_lineChart.ChartAreas["draw"].AxisX.Minimum = 0;
                this.realtime_lineChart.ChartAreas["draw"].AxisX.Maximum = totalTimeInSec;
                this.realtime_lineChart.ChartAreas["draw"].AxisX.Interval = rate;
                this.realtime_lineChart.ChartAreas["draw"].AxisY.Minimum = float.Parse(data[selectedParameter][2]["minDisplay"].ToString());
                this.realtime_lineChart.ChartAreas["draw"].AxisY.Maximum = float.Parse(data[selectedParameter][4]["maxDisplay"].ToString());
                this.realtime_lineChart.ChartAreas["draw"].AxisY.Interval = 5;
                this.realtime_lineChart.Series[selectedParameter].MarkerStyle = Graph.MarkerStyle.Triangle;
                this.realtime_lineChart.Series[selectedParameter].MarkerSize = 10;
                this.realtime_lineChart.Series[selectedParameter].LegendText = description;
                this.realtime_lineChart.Series[selectedParameter].ChartType = Graph.SeriesChartType.Line;
                this.realtime_lineChart.Series[selectedParameter].Color = Color.BlueViolet;
                this.realtime_lineChart.Series[selectedParameter].BorderWidth = 3;
                this.realtime_lineChart.Legends.Add(description);
                this.realtime_lineChart.Legends[description].BorderColor = Color.Tomato;
                this.realtime_lineChart.Titles.Clear();
                this.realtime_lineChart.Titles.Add(selectedParameter);
            } catch (Exception e)
            {
                if (this.realtime_lineChart.Series.Contains(new Graph.Series(selectedParameter))) onFailed = true;
                Console.WriteLine(e.ToString());    
            }
            if (onFailed) await this.clearPreviousChartData();
        }

        private async Task clearPreviousChartData()
        {
            await Task.Yield();
            this.realtime_lineChart.ChartAreas["draw"].AxisX.CustomLabels.Clear();
            this.realtime_lineChart.Series.Clear();
            this.realtime_lineChart.Legends.Clear();
        }
        private async Task exportExcelAsync(int totalTimeInSec, List<string> multiParameterSelected, string savePath)
        {
            try
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    JObject data;
                    Stopwatch sw = new Stopwatch();
                    await this.addWorkSheetAsync(wb, multiParameterSelected);
                    for (int i = 0; i < totalTimeInSec; i += 10)
                    {
                        string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                        sw.Restart();
                        data = await getDataAsync();
                        if (i==0) await this.formatWorkSheetsAsync(wb, data, multiParameterSelected);
                        await this.addDataToWorkSheetsAsync(wb, data, multiParameterSelected, timeStamp, Math.Abs(i / 10));
                        this.savingTimeRemainLb.Text = (totalTimeInSec - i).ToString();
                        sw.Stop();
                        await Task.Delay(10 * 1000 - (int)sw.ElapsedMilliseconds);
                    }
                    wb.SaveAs(savePath);
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("Slow internet connection! Please check you connection or set slower rate!");
                Console.WriteLine(aoore.ToString());
            }
        }

        private async Task addWorkSheetAsync(XLWorkbook workbook, List<string> multiParamaterSelected)
        {
            await Task.Yield();
            foreach(string paramName in multiParamaterSelected)
            {
                workbook.AddWorksheet(paramName);
            }
        }

        private async Task formatWorkSheetsAsync(XLWorkbook workbook, JObject data, List<string> multiParameterSelected)
        {
            await Task.Yield();
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
            await Task.Yield();
            foreach (string paramName in multiParameterSelected)
            {
                var ws = workbook.Worksheet(paramName);
                float minDisplay = float.Parse(data[paramName][2]["minDisplay"].ToString());
                float maxDisplay = float.Parse(data[paramName][4]["maxDisplay"].ToString());
                float actual = float.Parse(data[paramName][5]["actual"].ToString());
                ws.Cell(dataRowIndex + 3, 1).Value = minDisplay;
                ws.Cell(dataRowIndex + 3, 2).Value = maxDisplay;
                ws.Cell(dataRowIndex + 3, 3).Value = actual;
                ws.Cell(dataRowIndex + 3, 4).Value = timeStamp;
            }
        }

        private async Task stopDisplayChart()
        {
            await Task.Yield();
            if (this.cts != null)
            {
                this.cts.Cancel();
                this.cts = null;
                this.startDisplay.Text = "Start";
            }
        }
        ///
        /// Event Handler Methods
        /// 
        private async void durationBar_dpTab_ValueChanged(object sender, EventArgs e)
        {
            await Task.Yield();
            int min = this.getMinuteFromTrackBar(this.durationBar_dpTab.Value);
            this.minValueLb_dpTab.Text = min.ToString(); 
            int sec = this.getSecondFromTrackBar(this.durationBar_dpTab.Value, min);
            this.secValueLb_dpTab.Text = sec.ToString(); 
        }

        private async void durationbar_epTab_ValueChanged(object sender, EventArgs e)
        {
            await Task.Yield();
            int min = this.getMinuteFromTrackBar(this.durationBar_epTab.Value);
            this.minValueLb_epTab.Text = min.ToString();
            int sec = this.getSecondFromTrackBar(this.durationBar_epTab.Value, min);
            this.secValueLb_epTab.Text = sec.ToString();
        }

        private async void startDisplay_Click(object sender, EventArgs e)
        {
            if (this.parameterListCb.SelectedItem == null) {
                MessageBox.Show("Please select a parameter to display !", "Notice");
                return;
            }
            if (this.cts != null) {
                this.cts.Cancel();
                this.cts = null;
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
            if (savePath == "") return;
            int min = this.getMinuteFromTrackBar(this.durationBar_epTab.Value);
            int sec = this.getSecondFromTrackBar(this.durationBar_epTab.Value, min);
            int totalTimeInSec = (min * 60) + sec; this.savingTimeRemainLb.Text = totalTimeInSec.ToString();
            this.saveButton.Enabled = false;
            await this.exportExcelAsync(totalTimeInSec, this.multiParameterSelected, savePath);
            MessageBox.Show("Data has been saved!");
            this.saveButton.Enabled = true;
        }

        private async void stopDisplayBt_Click(object sender, EventArgs e)
        {
            await this.stopDisplayChart();   
        }

        private async void saveChartbt_Click(object sender, EventArgs e)
        {
            await this.stopDisplayChart();
            this.saveDirectoryBrowser.ShowDialog();
            string savePath = this.saveDirectoryBrowser.FileName;
            if (savePath == "") return;
            else this.realtime_lineChart.SaveImage(savePath, Graph.ChartImageFormat.Jpeg);
            MessageBox.Show("Chart has been saved!");
        }
    }
}
