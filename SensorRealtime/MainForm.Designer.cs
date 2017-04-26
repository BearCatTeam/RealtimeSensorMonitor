using System.Drawing;
using Graph = System.Windows.Forms.DataVisualization.Charting;
namespace SensorRealtime
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.displayTab = new System.Windows.Forms.TabPage();
            this.stopDisplayBt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updateRateCb = new System.Windows.Forms.ComboBox();
            this.startDisplay = new System.Windows.Forms.Button();
            this.secValueLb_dpTab = new System.Windows.Forms.Label();
            this.minValueLb_dpTab = new System.Windows.Forms.Label();
            this.secondLb = new System.Windows.Forms.Label();
            this.minuteLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.durationBar_dpTab = new System.Windows.Forms.TrackBar();
            this.parameterListCb = new System.Windows.Forms.ComboBox();
            this.realtime_lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportTab = new System.Windows.Forms.TabPage();
            this.savingTimeRemainLb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tank1Bt = new System.Windows.Forms.Button();
            this.tank2Bt = new System.Windows.Forms.Button();
            this.tank3Bt = new System.Windows.Forms.Button();
            this.pumpe1Bt = new System.Windows.Forms.Button();
            this.pumpe2Bt = new System.Windows.Forms.Button();
            this.pumpe3Bt = new System.Windows.Forms.Button();
            this.adg1Bt = new System.Windows.Forms.Button();
            this.adg2Bt = new System.Windows.Forms.Button();
            this.adg3Bt = new System.Windows.Forms.Button();
            this.tempzulauf1Bt = new System.Windows.Forms.Button();
            this.tempzulauf2Bt = new System.Windows.Forms.Button();
            this.tempruecklauf1Bt = new System.Windows.Forms.Button();
            this.tempruecklauf2Bt = new System.Windows.Forms.Button();
            this.tempaussenBt = new System.Windows.Forms.Button();
            this.tempinnenBt = new System.Windows.Forms.Button();
            this.spannungsteuerungBt = new System.Windows.Forms.Button();
            this.spannungpumpe1Bt = new System.Windows.Forms.Button();
            this.spannungpumpe2Bt = new System.Windows.Forms.Button();
            this.spannungpumpe3Bt = new System.Windows.Forms.Button();
            this.tempkuehlungBt = new System.Windows.Forms.Button();
            this.luftfeuchteinnenBt = new System.Windows.Forms.Button();
            this.gas1Bt = new System.Windows.Forms.Button();
            this.gas2Bt = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.secValueLb_epTab = new System.Windows.Forms.Label();
            this.minValueLb_epTab = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.durationBar_epTab = new System.Windows.Forms.TrackBar();
            this.saveDirectoryBrowser = new System.Windows.Forms.SaveFileDialog();
            this.saveChartbt = new System.Windows.Forms.Button();
            this.tabContainer.SuspendLayout();
            this.displayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar_dpTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtime_lineChart)).BeginInit();
            this.exportTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar_epTab)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.displayTab);
            this.tabContainer.Controls.Add(this.exportTab);
            this.tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContainer.Location = new System.Drawing.Point(0, 0);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1411, 664);
            this.tabContainer.TabIndex = 0;
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.saveChartbt);
            this.displayTab.Controls.Add(this.stopDisplayBt);
            this.displayTab.Controls.Add(this.label3);
            this.displayTab.Controls.Add(this.updateRateCb);
            this.displayTab.Controls.Add(this.startDisplay);
            this.displayTab.Controls.Add(this.secValueLb_dpTab);
            this.displayTab.Controls.Add(this.minValueLb_dpTab);
            this.displayTab.Controls.Add(this.secondLb);
            this.displayTab.Controls.Add(this.minuteLb);
            this.displayTab.Controls.Add(this.label2);
            this.displayTab.Controls.Add(this.label1);
            this.displayTab.Controls.Add(this.durationBar_dpTab);
            this.displayTab.Controls.Add(this.parameterListCb);
            this.displayTab.Controls.Add(this.realtime_lineChart);
            this.displayTab.Location = new System.Drawing.Point(4, 34);
            this.displayTab.Name = "displayTab";
            this.displayTab.Padding = new System.Windows.Forms.Padding(3);
            this.displayTab.Size = new System.Drawing.Size(1403, 626);
            this.displayTab.TabIndex = 0;
            this.displayTab.Text = "Display";
            this.displayTab.UseVisualStyleBackColor = true;
            // 
            // stopDisplayBt
            // 
            this.stopDisplayBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopDisplayBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopDisplayBt.ForeColor = System.Drawing.Color.Crimson;
            this.stopDisplayBt.Location = new System.Drawing.Point(1165, 14);
            this.stopDisplayBt.Name = "stopDisplayBt";
            this.stopDisplayBt.Size = new System.Drawing.Size(113, 65);
            this.stopDisplayBt.TabIndex = 13;
            this.stopDisplayBt.Text = "Stop";
            this.stopDisplayBt.UseVisualStyleBackColor = true;
            this.stopDisplayBt.Click += new System.EventHandler(this.stopDisplayBt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(935, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rate (s)";
            // 
            // updateRateCb
            // 
            this.updateRateCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateRateCb.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateRateCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateRateCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRateCb.FormattingEnabled = true;
            this.updateRateCb.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.updateRateCb.Location = new System.Drawing.Point(940, 42);
            this.updateRateCb.Name = "updateRateCb";
            this.updateRateCb.Size = new System.Drawing.Size(90, 34);
            this.updateRateCb.TabIndex = 11;
            // 
            // startDisplay
            // 
            this.startDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDisplay.ForeColor = System.Drawing.Color.Green;
            this.startDisplay.Location = new System.Drawing.Point(1036, 14);
            this.startDisplay.Name = "startDisplay";
            this.startDisplay.Size = new System.Drawing.Size(123, 65);
            this.startDisplay.TabIndex = 2;
            this.startDisplay.Text = "Start";
            this.startDisplay.UseVisualStyleBackColor = true;
            this.startDisplay.Click += new System.EventHandler(this.startDisplay_Click);
            // 
            // secValueLb_dpTab
            // 
            this.secValueLb_dpTab.AutoSize = true;
            this.secValueLb_dpTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secValueLb_dpTab.ForeColor = System.Drawing.Color.Red;
            this.secValueLb_dpTab.Location = new System.Drawing.Point(422, 14);
            this.secValueLb_dpTab.Name = "secValueLb_dpTab";
            this.secValueLb_dpTab.Size = new System.Drawing.Size(24, 25);
            this.secValueLb_dpTab.TabIndex = 10;
            this.secValueLb_dpTab.Text = "0";
            // 
            // minValueLb_dpTab
            // 
            this.minValueLb_dpTab.AutoSize = true;
            this.minValueLb_dpTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minValueLb_dpTab.ForeColor = System.Drawing.Color.Red;
            this.minValueLb_dpTab.Location = new System.Drawing.Point(340, 14);
            this.minValueLb_dpTab.Name = "minValueLb_dpTab";
            this.minValueLb_dpTab.Size = new System.Drawing.Size(24, 25);
            this.minValueLb_dpTab.TabIndex = 9;
            this.minValueLb_dpTab.Text = "1";
            // 
            // secondLb
            // 
            this.secondLb.AutoSize = true;
            this.secondLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLb.Location = new System.Drawing.Point(461, 14);
            this.secondLb.Name = "secondLb";
            this.secondLb.Size = new System.Drawing.Size(46, 25);
            this.secondLb.TabIndex = 8;
            this.secondLb.Text = "sec";
            // 
            // minuteLb
            // 
            this.minuteLb.AutoSize = true;
            this.minuteLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteLb.Location = new System.Drawing.Point(370, 14);
            this.minuteLb.Name = "minuteLb";
            this.minuteLb.Size = new System.Drawing.Size(46, 25);
            this.minuteLb.TabIndex = 6;
            this.minuteLb.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duration:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Parameter";
            // 
            // durationBar_dpTab
            // 
            this.durationBar_dpTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationBar_dpTab.LargeChange = 6;
            this.durationBar_dpTab.Location = new System.Drawing.Point(239, 42);
            this.durationBar_dpTab.Maximum = 55;
            this.durationBar_dpTab.Minimum = 1;
            this.durationBar_dpTab.Name = "durationBar_dpTab";
            this.durationBar_dpTab.Size = new System.Drawing.Size(695, 56);
            this.durationBar_dpTab.TabIndex = 1;
            this.durationBar_dpTab.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.durationBar_dpTab.Value = 1;
            this.durationBar_dpTab.ValueChanged += new System.EventHandler(this.durationBar_dpTab_ValueChanged);
            // 
            // parameterListCb
            // 
            this.parameterListCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parameterListCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parameterListCb.FormattingEnabled = true;
            this.parameterListCb.Items.AddRange(new object[] {
            "tank1",
            "tank2",
            "tank3",
            "pumpe1",
            "pumpe2",
            "pumpe3",
            "adg1",
            "adg2",
            "adg3",
            "temp-zulauf1",
            "temp-zulauf2",
            "temp-ruecklauf1",
            "temp-ruecklauf2",
            "temp-aussen",
            "temp-innen",
            "spannung-steuerung",
            "spannung-pumpe1",
            "spannung-pumpe2",
            "spannung-pumpe3",
            "temp-kuehlung",
            "luftfeuchte-innen",
            "gas1",
            "gas2"});
            this.parameterListCb.Location = new System.Drawing.Point(8, 42);
            this.parameterListCb.Name = "parameterListCb";
            this.parameterListCb.Size = new System.Drawing.Size(212, 37);
            this.parameterListCb.TabIndex = 0;
            this.parameterListCb.SelectedValueChanged += new System.EventHandler(this.parameterListCb_SelectedValueChanged);
            // 
            // realtime_lineChart
            // 
            this.realtime_lineChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "draw";
            this.realtime_lineChart.ChartAreas.Add(chartArea3);
            this.realtime_lineChart.Location = new System.Drawing.Point(8, 85);
            this.realtime_lineChart.Name = "realtime_lineChart";
            this.realtime_lineChart.Size = new System.Drawing.Size(1387, 538);
            this.realtime_lineChart.TabIndex = 0;
            // 
            // exportTab
            // 
            this.exportTab.Controls.Add(this.savingTimeRemainLb);
            this.exportTab.Controls.Add(this.label8);
            this.exportTab.Controls.Add(this.label4);
            this.exportTab.Controls.Add(this.flowLayoutPanel1);
            this.exportTab.Controls.Add(this.saveButton);
            this.exportTab.Controls.Add(this.secValueLb_epTab);
            this.exportTab.Controls.Add(this.minValueLb_epTab);
            this.exportTab.Controls.Add(this.label5);
            this.exportTab.Controls.Add(this.label6);
            this.exportTab.Controls.Add(this.label7);
            this.exportTab.Controls.Add(this.durationBar_epTab);
            this.exportTab.Location = new System.Drawing.Point(4, 34);
            this.exportTab.Name = "exportTab";
            this.exportTab.Padding = new System.Windows.Forms.Padding(3);
            this.exportTab.Size = new System.Drawing.Size(1085, 626);
            this.exportTab.TabIndex = 1;
            this.exportTab.Text = "Export";
            this.exportTab.UseVisualStyleBackColor = true;
            // 
            // savingTimeRemainLb
            // 
            this.savingTimeRemainLb.AutoSize = true;
            this.savingTimeRemainLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savingTimeRemainLb.ForeColor = System.Drawing.Color.Red;
            this.savingTimeRemainLb.Location = new System.Drawing.Point(575, 11);
            this.savingTimeRemainLb.Name = "savingTimeRemainLb";
            this.savingTimeRemainLb.Size = new System.Drawing.Size(24, 25);
            this.savingTimeRemainLb.TabIndex = 21;
            this.savingTimeRemainLb.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "sec";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Saving Time Remain:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.tank1Bt);
            this.flowLayoutPanel1.Controls.Add(this.tank2Bt);
            this.flowLayoutPanel1.Controls.Add(this.tank3Bt);
            this.flowLayoutPanel1.Controls.Add(this.pumpe1Bt);
            this.flowLayoutPanel1.Controls.Add(this.pumpe2Bt);
            this.flowLayoutPanel1.Controls.Add(this.pumpe3Bt);
            this.flowLayoutPanel1.Controls.Add(this.adg1Bt);
            this.flowLayoutPanel1.Controls.Add(this.adg2Bt);
            this.flowLayoutPanel1.Controls.Add(this.adg3Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempzulauf1Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempzulauf2Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempruecklauf1Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempruecklauf2Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempaussenBt);
            this.flowLayoutPanel1.Controls.Add(this.tempinnenBt);
            this.flowLayoutPanel1.Controls.Add(this.spannungsteuerungBt);
            this.flowLayoutPanel1.Controls.Add(this.spannungpumpe1Bt);
            this.flowLayoutPanel1.Controls.Add(this.spannungpumpe2Bt);
            this.flowLayoutPanel1.Controls.Add(this.spannungpumpe3Bt);
            this.flowLayoutPanel1.Controls.Add(this.tempkuehlungBt);
            this.flowLayoutPanel1.Controls.Add(this.luftfeuchteinnenBt);
            this.flowLayoutPanel1.Controls.Add(this.gas1Bt);
            this.flowLayoutPanel1.Controls.Add(this.gas2Bt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1069, 541);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // tank1Bt
            // 
            this.tank1Bt.AutoSize = true;
            this.tank1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tank1Bt.Location = new System.Drawing.Point(3, 3);
            this.tank1Bt.Name = "tank1Bt";
            this.tank1Bt.Size = new System.Drawing.Size(260, 82);
            this.tank1Bt.TabIndex = 0;
            this.tank1Bt.Tag = "tank1";
            this.tank1Bt.Text = "Tank 1";
            this.tank1Bt.UseVisualStyleBackColor = false;
            this.tank1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tank2Bt
            // 
            this.tank2Bt.AutoSize = true;
            this.tank2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tank2Bt.Location = new System.Drawing.Point(269, 3);
            this.tank2Bt.Name = "tank2Bt";
            this.tank2Bt.Size = new System.Drawing.Size(260, 82);
            this.tank2Bt.TabIndex = 1;
            this.tank2Bt.Tag = "tank2";
            this.tank2Bt.Text = "Tank 2";
            this.tank2Bt.UseVisualStyleBackColor = false;
            this.tank2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tank3Bt
            // 
            this.tank3Bt.AutoSize = true;
            this.tank3Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tank3Bt.Location = new System.Drawing.Point(535, 3);
            this.tank3Bt.Name = "tank3Bt";
            this.tank3Bt.Size = new System.Drawing.Size(260, 82);
            this.tank3Bt.TabIndex = 2;
            this.tank3Bt.Tag = "tank3";
            this.tank3Bt.Text = "Tank 3";
            this.tank3Bt.UseVisualStyleBackColor = false;
            this.tank3Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // pumpe1Bt
            // 
            this.pumpe1Bt.AutoSize = true;
            this.pumpe1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.pumpe1Bt.Location = new System.Drawing.Point(801, 3);
            this.pumpe1Bt.Name = "pumpe1Bt";
            this.pumpe1Bt.Size = new System.Drawing.Size(260, 82);
            this.pumpe1Bt.TabIndex = 3;
            this.pumpe1Bt.Tag = "pumpe1";
            this.pumpe1Bt.Text = "Pumpe 1";
            this.pumpe1Bt.UseVisualStyleBackColor = false;
            this.pumpe1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // pumpe2Bt
            // 
            this.pumpe2Bt.AutoSize = true;
            this.pumpe2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.pumpe2Bt.Location = new System.Drawing.Point(3, 91);
            this.pumpe2Bt.Name = "pumpe2Bt";
            this.pumpe2Bt.Size = new System.Drawing.Size(260, 82);
            this.pumpe2Bt.TabIndex = 4;
            this.pumpe2Bt.Tag = "pumpe2";
            this.pumpe2Bt.Text = "Pumpe 2";
            this.pumpe2Bt.UseVisualStyleBackColor = false;
            this.pumpe2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // pumpe3Bt
            // 
            this.pumpe3Bt.AutoSize = true;
            this.pumpe3Bt.BackColor = System.Drawing.Color.LightGreen;
            this.pumpe3Bt.Location = new System.Drawing.Point(269, 91);
            this.pumpe3Bt.Name = "pumpe3Bt";
            this.pumpe3Bt.Size = new System.Drawing.Size(260, 82);
            this.pumpe3Bt.TabIndex = 5;
            this.pumpe3Bt.Tag = "pumpe3";
            this.pumpe3Bt.Text = "Pumpe 3";
            this.pumpe3Bt.UseVisualStyleBackColor = false;
            this.pumpe3Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // adg1Bt
            // 
            this.adg1Bt.AutoSize = true;
            this.adg1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.adg1Bt.Location = new System.Drawing.Point(535, 91);
            this.adg1Bt.Name = "adg1Bt";
            this.adg1Bt.Size = new System.Drawing.Size(260, 82);
            this.adg1Bt.TabIndex = 6;
            this.adg1Bt.Tag = "adg1";
            this.adg1Bt.Text = "Adg 1";
            this.adg1Bt.UseVisualStyleBackColor = false;
            this.adg1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // adg2Bt
            // 
            this.adg2Bt.AutoSize = true;
            this.adg2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.adg2Bt.Location = new System.Drawing.Point(801, 91);
            this.adg2Bt.Name = "adg2Bt";
            this.adg2Bt.Size = new System.Drawing.Size(260, 82);
            this.adg2Bt.TabIndex = 7;
            this.adg2Bt.Tag = "adg2";
            this.adg2Bt.Text = "Adg 2";
            this.adg2Bt.UseVisualStyleBackColor = false;
            this.adg2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // adg3Bt
            // 
            this.adg3Bt.AutoSize = true;
            this.adg3Bt.BackColor = System.Drawing.Color.LightGreen;
            this.adg3Bt.Location = new System.Drawing.Point(3, 179);
            this.adg3Bt.Name = "adg3Bt";
            this.adg3Bt.Size = new System.Drawing.Size(260, 82);
            this.adg3Bt.TabIndex = 8;
            this.adg3Bt.Tag = "adg3";
            this.adg3Bt.Text = "Adg 3";
            this.adg3Bt.UseVisualStyleBackColor = false;
            this.adg3Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempzulauf1Bt
            // 
            this.tempzulauf1Bt.AutoSize = true;
            this.tempzulauf1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tempzulauf1Bt.Location = new System.Drawing.Point(269, 179);
            this.tempzulauf1Bt.Name = "tempzulauf1Bt";
            this.tempzulauf1Bt.Size = new System.Drawing.Size(260, 82);
            this.tempzulauf1Bt.TabIndex = 9;
            this.tempzulauf1Bt.Tag = "temp-zulauf1";
            this.tempzulauf1Bt.Text = "Temp Zulauf 1";
            this.tempzulauf1Bt.UseVisualStyleBackColor = false;
            this.tempzulauf1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempzulauf2Bt
            // 
            this.tempzulauf2Bt.AutoSize = true;
            this.tempzulauf2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tempzulauf2Bt.Location = new System.Drawing.Point(535, 179);
            this.tempzulauf2Bt.Name = "tempzulauf2Bt";
            this.tempzulauf2Bt.Size = new System.Drawing.Size(260, 82);
            this.tempzulauf2Bt.TabIndex = 10;
            this.tempzulauf2Bt.Tag = "temp-zulauf2";
            this.tempzulauf2Bt.Text = "Temp Zulauf 2";
            this.tempzulauf2Bt.UseVisualStyleBackColor = false;
            this.tempzulauf2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempruecklauf1Bt
            // 
            this.tempruecklauf1Bt.AutoSize = true;
            this.tempruecklauf1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tempruecklauf1Bt.Location = new System.Drawing.Point(801, 179);
            this.tempruecklauf1Bt.Name = "tempruecklauf1Bt";
            this.tempruecklauf1Bt.Size = new System.Drawing.Size(260, 82);
            this.tempruecklauf1Bt.TabIndex = 11;
            this.tempruecklauf1Bt.Tag = "temp-ruecklauf1";
            this.tempruecklauf1Bt.Text = "Temp Ruecklauf 1";
            this.tempruecklauf1Bt.UseVisualStyleBackColor = false;
            this.tempruecklauf1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempruecklauf2Bt
            // 
            this.tempruecklauf2Bt.AutoSize = true;
            this.tempruecklauf2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.tempruecklauf2Bt.Location = new System.Drawing.Point(3, 267);
            this.tempruecklauf2Bt.Name = "tempruecklauf2Bt";
            this.tempruecklauf2Bt.Size = new System.Drawing.Size(260, 82);
            this.tempruecklauf2Bt.TabIndex = 12;
            this.tempruecklauf2Bt.Tag = "temp-ruecklauf2";
            this.tempruecklauf2Bt.Text = "Temp Ruecklauf 2";
            this.tempruecklauf2Bt.UseVisualStyleBackColor = false;
            this.tempruecklauf2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempaussenBt
            // 
            this.tempaussenBt.AutoSize = true;
            this.tempaussenBt.BackColor = System.Drawing.Color.LightGreen;
            this.tempaussenBt.Location = new System.Drawing.Point(269, 267);
            this.tempaussenBt.Name = "tempaussenBt";
            this.tempaussenBt.Size = new System.Drawing.Size(260, 82);
            this.tempaussenBt.TabIndex = 13;
            this.tempaussenBt.Tag = "temp-aussen";
            this.tempaussenBt.Text = "Temp Aussen";
            this.tempaussenBt.UseVisualStyleBackColor = false;
            this.tempaussenBt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempinnenBt
            // 
            this.tempinnenBt.AutoSize = true;
            this.tempinnenBt.BackColor = System.Drawing.Color.LightGreen;
            this.tempinnenBt.Location = new System.Drawing.Point(535, 267);
            this.tempinnenBt.Name = "tempinnenBt";
            this.tempinnenBt.Size = new System.Drawing.Size(260, 82);
            this.tempinnenBt.TabIndex = 14;
            this.tempinnenBt.Tag = "temp-innen";
            this.tempinnenBt.Text = "Temp Innen";
            this.tempinnenBt.UseVisualStyleBackColor = false;
            this.tempinnenBt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // spannungsteuerungBt
            // 
            this.spannungsteuerungBt.AutoSize = true;
            this.spannungsteuerungBt.BackColor = System.Drawing.Color.LightGreen;
            this.spannungsteuerungBt.Location = new System.Drawing.Point(801, 267);
            this.spannungsteuerungBt.Name = "spannungsteuerungBt";
            this.spannungsteuerungBt.Size = new System.Drawing.Size(260, 82);
            this.spannungsteuerungBt.TabIndex = 15;
            this.spannungsteuerungBt.Tag = "spannung-steuerung";
            this.spannungsteuerungBt.Text = "Spannung Steuerung";
            this.spannungsteuerungBt.UseVisualStyleBackColor = false;
            this.spannungsteuerungBt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // spannungpumpe1Bt
            // 
            this.spannungpumpe1Bt.AutoSize = true;
            this.spannungpumpe1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.spannungpumpe1Bt.Location = new System.Drawing.Point(3, 355);
            this.spannungpumpe1Bt.Name = "spannungpumpe1Bt";
            this.spannungpumpe1Bt.Size = new System.Drawing.Size(260, 82);
            this.spannungpumpe1Bt.TabIndex = 16;
            this.spannungpumpe1Bt.Tag = "spannung-pumpe1";
            this.spannungpumpe1Bt.Text = "Spannung Pumpe 1";
            this.spannungpumpe1Bt.UseVisualStyleBackColor = false;
            this.spannungpumpe1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // spannungpumpe2Bt
            // 
            this.spannungpumpe2Bt.AutoSize = true;
            this.spannungpumpe2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.spannungpumpe2Bt.Location = new System.Drawing.Point(269, 355);
            this.spannungpumpe2Bt.Name = "spannungpumpe2Bt";
            this.spannungpumpe2Bt.Size = new System.Drawing.Size(260, 82);
            this.spannungpumpe2Bt.TabIndex = 17;
            this.spannungpumpe2Bt.Tag = "spannung-pumpe2";
            this.spannungpumpe2Bt.Text = "Spannung Pumpe 2";
            this.spannungpumpe2Bt.UseVisualStyleBackColor = false;
            this.spannungpumpe2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // spannungpumpe3Bt
            // 
            this.spannungpumpe3Bt.AutoSize = true;
            this.spannungpumpe3Bt.BackColor = System.Drawing.Color.LightGreen;
            this.spannungpumpe3Bt.Location = new System.Drawing.Point(535, 355);
            this.spannungpumpe3Bt.Name = "spannungpumpe3Bt";
            this.spannungpumpe3Bt.Size = new System.Drawing.Size(260, 82);
            this.spannungpumpe3Bt.TabIndex = 18;
            this.spannungpumpe3Bt.Tag = "spannung-pumpe3";
            this.spannungpumpe3Bt.Text = "Spannung Pumpe 3";
            this.spannungpumpe3Bt.UseVisualStyleBackColor = false;
            this.spannungpumpe3Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // tempkuehlungBt
            // 
            this.tempkuehlungBt.AutoSize = true;
            this.tempkuehlungBt.BackColor = System.Drawing.Color.LightGreen;
            this.tempkuehlungBt.Location = new System.Drawing.Point(801, 355);
            this.tempkuehlungBt.Name = "tempkuehlungBt";
            this.tempkuehlungBt.Size = new System.Drawing.Size(260, 82);
            this.tempkuehlungBt.TabIndex = 19;
            this.tempkuehlungBt.Tag = "temp-kuehlung";
            this.tempkuehlungBt.Text = "Temp Kuehlung";
            this.tempkuehlungBt.UseVisualStyleBackColor = false;
            this.tempkuehlungBt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // luftfeuchteinnenBt
            // 
            this.luftfeuchteinnenBt.AutoSize = true;
            this.luftfeuchteinnenBt.BackColor = System.Drawing.Color.LightGreen;
            this.luftfeuchteinnenBt.Location = new System.Drawing.Point(3, 443);
            this.luftfeuchteinnenBt.Name = "luftfeuchteinnenBt";
            this.luftfeuchteinnenBt.Size = new System.Drawing.Size(260, 82);
            this.luftfeuchteinnenBt.TabIndex = 20;
            this.luftfeuchteinnenBt.Tag = "luftfeuchte-innen";
            this.luftfeuchteinnenBt.Text = "Luftfeuchte Innen";
            this.luftfeuchteinnenBt.UseVisualStyleBackColor = false;
            this.luftfeuchteinnenBt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // gas1Bt
            // 
            this.gas1Bt.AutoSize = true;
            this.gas1Bt.BackColor = System.Drawing.Color.LightGreen;
            this.gas1Bt.Location = new System.Drawing.Point(269, 443);
            this.gas1Bt.Name = "gas1Bt";
            this.gas1Bt.Size = new System.Drawing.Size(260, 82);
            this.gas1Bt.TabIndex = 21;
            this.gas1Bt.Tag = "gas1";
            this.gas1Bt.Text = "Gas 1";
            this.gas1Bt.UseVisualStyleBackColor = false;
            this.gas1Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // gas2Bt
            // 
            this.gas2Bt.AutoSize = true;
            this.gas2Bt.BackColor = System.Drawing.Color.LightGreen;
            this.gas2Bt.Location = new System.Drawing.Point(535, 443);
            this.gas2Bt.Name = "gas2Bt";
            this.gas2Bt.Size = new System.Drawing.Size(260, 82);
            this.gas2Bt.TabIndex = 22;
            this.gas2Bt.Tag = "gas2";
            this.gas2Bt.Text = "Gas 2";
            this.gas2Bt.UseVisualStyleBackColor = false;
            this.gas2Bt.Click += new System.EventHandler(this.selectMultiParametersBt_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Green;
            this.saveButton.Location = new System.Drawing.Point(898, 11);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 60);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // secValueLb_epTab
            // 
            this.secValueLb_epTab.AutoSize = true;
            this.secValueLb_epTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secValueLb_epTab.ForeColor = System.Drawing.Color.Red;
            this.secValueLb_epTab.Location = new System.Drawing.Point(183, 11);
            this.secValueLb_epTab.Name = "secValueLb_epTab";
            this.secValueLb_epTab.Size = new System.Drawing.Size(24, 25);
            this.secValueLb_epTab.TabIndex = 16;
            this.secValueLb_epTab.Text = "0";
            // 
            // minValueLb_epTab
            // 
            this.minValueLb_epTab.AutoSize = true;
            this.minValueLb_epTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minValueLb_epTab.ForeColor = System.Drawing.Color.Red;
            this.minValueLb_epTab.Location = new System.Drawing.Point(100, 11);
            this.minValueLb_epTab.Name = "minValueLb_epTab";
            this.minValueLb_epTab.Size = new System.Drawing.Size(24, 25);
            this.minValueLb_epTab.TabIndex = 15;
            this.minValueLb_epTab.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duration:";
            // 
            // durationBar_epTab
            // 
            this.durationBar_epTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.durationBar_epTab.LargeChange = 6;
            this.durationBar_epTab.Location = new System.Drawing.Point(8, 39);
            this.durationBar_epTab.Maximum = 55;
            this.durationBar_epTab.Minimum = 1;
            this.durationBar_epTab.Name = "durationBar_epTab";
            this.durationBar_epTab.Size = new System.Drawing.Size(884, 56);
            this.durationBar_epTab.TabIndex = 11;
            this.durationBar_epTab.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.durationBar_epTab.Value = 1;
            this.durationBar_epTab.ValueChanged += new System.EventHandler(this.durationbar_epTab_ValueChanged);
            // 
            // saveDirectoryBrowser
            // 
            this.saveDirectoryBrowser.Filter = "Excel File (.xlsx)|*.xlsx|JPEG Image (.jpg)|*.jpg";
            this.saveDirectoryBrowser.RestoreDirectory = true;
            this.saveDirectoryBrowser.ShowHelp = true;
            this.saveDirectoryBrowser.SupportMultiDottedExtensions = true;
            this.saveDirectoryBrowser.Title = "Save Data";
            // 
            // saveChartbt
            // 
            this.saveChartbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChartbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChartbt.ForeColor = System.Drawing.Color.Tomato;
            this.saveChartbt.Location = new System.Drawing.Point(1284, 14);
            this.saveChartbt.Name = "saveChartbt";
            this.saveChartbt.Size = new System.Drawing.Size(113, 65);
            this.saveChartbt.TabIndex = 14;
            this.saveChartbt.Text = "SAVE";
            this.saveChartbt.UseVisualStyleBackColor = true;
            this.saveChartbt.Click += new System.EventHandler(this.saveChartbt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 664);
            this.Controls.Add(this.tabContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sensors Realtime Monitor";
            this.tabContainer.ResumeLayout(false);
            this.displayTab.ResumeLayout(false);
            this.displayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar_dpTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtime_lineChart)).EndInit();
            this.exportTab.ResumeLayout(false);
            this.exportTab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBar_epTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage displayTab;
        private System.Windows.Forms.TabPage exportTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar durationBar_dpTab;
        private System.Windows.Forms.ComboBox parameterListCb;
        private System.Windows.Forms.Label minuteLb;
        private System.Windows.Forms.Label secValueLb_dpTab;
        private System.Windows.Forms.Label minValueLb_dpTab;
        private System.Windows.Forms.Label secondLb;
        private System.Windows.Forms.Button startDisplay;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label secValueLb_epTab;
        private System.Windows.Forms.Label minValueLb_epTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar durationBar_epTab;
        private Graph.Chart realtime_lineChart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button tank1Bt;
        private System.Windows.Forms.Button tank2Bt;
        private System.Windows.Forms.Button tank3Bt;
        private System.Windows.Forms.Button pumpe1Bt;
        private System.Windows.Forms.Button pumpe2Bt;
        private System.Windows.Forms.Button pumpe3Bt;
        private System.Windows.Forms.Button adg1Bt;
        private System.Windows.Forms.Button adg2Bt;
        private System.Windows.Forms.Button adg3Bt;
        private System.Windows.Forms.Button tempzulauf1Bt;
        private System.Windows.Forms.Button tempzulauf2Bt;
        private System.Windows.Forms.Button tempruecklauf1Bt;
        private System.Windows.Forms.Button tempruecklauf2Bt;
        private System.Windows.Forms.Button tempaussenBt;
        private System.Windows.Forms.Button tempinnenBt;
        private System.Windows.Forms.Button spannungsteuerungBt;
        private System.Windows.Forms.Button spannungpumpe1Bt;
        private System.Windows.Forms.Button spannungpumpe2Bt;
        private System.Windows.Forms.Button spannungpumpe3Bt;
        private System.Windows.Forms.Button tempkuehlungBt;
        private System.Windows.Forms.Button luftfeuchteinnenBt;
        private System.Windows.Forms.Button gas1Bt;
        private System.Windows.Forms.Button gas2Bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox updateRateCb;
        private System.Windows.Forms.SaveFileDialog saveDirectoryBrowser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label savingTimeRemainLb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stopDisplayBt;
        private System.Windows.Forms.Button saveChartbt;
    }
}

