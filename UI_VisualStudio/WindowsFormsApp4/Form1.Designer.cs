namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myNameUnderLogo = new System.Windows.Forms.Label();
            this.pictureBoxMarmaraLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panelSeperator = new System.Windows.Forms.Panel();
            this.chartSensor1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.buttonSerialConnect = new System.Windows.Forms.Button();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSerialDisconnect = new System.Windows.Forms.Button();
            this.textBoxReceiveData = new System.Windows.Forms.TextBox();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer4Logging = new System.Windows.Forms.Timer(this.components);
            this.textBoxTimeInterval = new System.Windows.Forms.TextBox();
            this.labelTimeInterval = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonStartTimer = new System.Windows.Forms.Button();
            this.buttonStopLogging = new System.Windows.Forms.Button();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.labelFileType = new System.Windows.Forms.Label();
            this.buttonXmlRead = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.buttonXmlClear = new System.Windows.Forms.Button();
            this.chartSensor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarmaraLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelLeftMenu.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.ui_bg_left;
            this.panelLeftMenu.Controls.Add(this.button4);
            this.panelLeftMenu.Controls.Add(this.button3);
            this.panelLeftMenu.Controls.Add(this.button2);
            this.panelLeftMenu.Controls.Add(this.button1);
            this.panelLeftMenu.Controls.Add(this.myNameUnderLogo);
            this.panelLeftMenu.Controls.Add(this.pictureBoxMarmaraLogo);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(212, 483);
            this.panelLeftMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Image = global::WindowsFormsApp4.Properties.Resources.aboutme_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.Location = new System.Drawing.Point(3, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "About Me";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Image = global::WindowsFormsApp4.Properties.Resources.main_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.Location = new System.Drawing.Point(3, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Data Logging Configuration";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Image = global::WindowsFormsApp4.Properties.Resources.serial_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.Location = new System.Drawing.Point(4, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Serial Port Configuration";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Image = global::WindowsFormsApp4.Properties.Resources.main_icon1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(4, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Virtualization";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myNameUnderLogo
            // 
            this.myNameUnderLogo.AutoSize = true;
            this.myNameUnderLogo.BackColor = System.Drawing.Color.Transparent;
            this.myNameUnderLogo.Font = new System.Drawing.Font("Dutch801 Rm BT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myNameUnderLogo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.myNameUnderLogo.Location = new System.Drawing.Point(47, 131);
            this.myNameUnderLogo.Name = "myNameUnderLogo";
            this.myNameUnderLogo.Size = new System.Drawing.Size(120, 22);
            this.myNameUnderLogo.TabIndex = 1;
            this.myNameUnderLogo.Text = "Selçuk Altınay";
            this.myNameUnderLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxMarmaraLogo
            // 
            this.pictureBoxMarmaraLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMarmaraLogo.Image = global::WindowsFormsApp4.Properties.Resources.marmara_universitesi_logo1;
            this.pictureBoxMarmaraLogo.Location = new System.Drawing.Point(51, 20);
            this.pictureBoxMarmaraLogo.Name = "pictureBoxMarmaraLogo";
            this.pictureBoxMarmaraLogo.Size = new System.Drawing.Size(111, 109);
            this.pictureBoxMarmaraLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarmaraLogo.TabIndex = 0;
            this.pictureBoxMarmaraLogo.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxClose.Image = global::WindowsFormsApp4.Properties.Resources.closebutton;
            this.pictureBoxClose.Location = new System.Drawing.Point(924, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(38, 37);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSeperator
            // 
            this.panelSeperator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelSeperator.Location = new System.Drawing.Point(212, 0);
            this.panelSeperator.Name = "panelSeperator";
            this.panelSeperator.Size = new System.Drawing.Size(10, 483);
            this.panelSeperator.TabIndex = 1;
            this.panelSeperator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelSeperator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panelSeperator.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // chartSensor1
            // 
            this.chartSensor1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartSensor1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSensor1.Legends.Add(legend3);
            this.chartSensor1.Location = new System.Drawing.Point(253, 20);
            this.chartSensor1.Name = "chartSensor1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            series3.YValuesPerPoint = 6;
            this.chartSensor1.Series.Add(series3);
            this.chartSensor1.Size = new System.Drawing.Size(368, 451);
            this.chartSensor1.TabIndex = 2;
            this.chartSensor1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.labelBaudRate.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaudRate.Location = new System.Drawing.Point(253, 253);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(83, 19);
            this.labelBaudRate.TabIndex = 4;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(342, 253);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudRate.TabIndex = 6;
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.BackColor = System.Drawing.Color.Transparent;
            this.labelDataBits.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataBits.Location = new System.Drawing.Point(253, 290);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(73, 19);
            this.labelDataBits.TabIndex = 4;
            this.labelDataBits.Text = "Data Bits";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(342, 290);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDataBits.TabIndex = 6;
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.BackColor = System.Drawing.Color.Transparent;
            this.labelComPort.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComPort.Location = new System.Drawing.Point(487, 291);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(76, 19);
            this.labelComPort.TabIndex = 4;
            this.labelComPort.Text = "Com Port";
            // 
            // buttonSerialConnect
            // 
            this.buttonSerialConnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSerialConnect.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialConnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSerialConnect.Location = new System.Drawing.Point(257, 331);
            this.buttonSerialConnect.Name = "buttonSerialConnect";
            this.buttonSerialConnect.Size = new System.Drawing.Size(212, 32);
            this.buttonSerialConnect.TabIndex = 7;
            this.buttonSerialConnect.Text = "Connect";
            this.buttonSerialConnect.UseVisualStyleBackColor = false;
            this.buttonSerialConnect.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.BackColor = System.Drawing.Color.Transparent;
            this.labelParity.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParity.Location = new System.Drawing.Point(487, 254);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(49, 19);
            this.labelParity.TabIndex = 4;
            this.labelParity.Text = "Parity";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBoxParity.Location = new System.Drawing.Point(576, 254);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(257, 379);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(440, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // buttonSerialDisconnect
            // 
            this.buttonSerialDisconnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSerialDisconnect.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialDisconnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSerialDisconnect.Location = new System.Drawing.Point(496, 330);
            this.buttonSerialDisconnect.Name = "buttonSerialDisconnect";
            this.buttonSerialDisconnect.Size = new System.Drawing.Size(200, 32);
            this.buttonSerialDisconnect.TabIndex = 9;
            this.buttonSerialDisconnect.Text = "Disconnect";
            this.buttonSerialDisconnect.UseVisualStyleBackColor = false;
            this.buttonSerialDisconnect.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBoxReceiveData
            // 
            this.textBoxReceiveData.Location = new System.Drawing.Point(725, 253);
            this.textBoxReceiveData.Multiline = true;
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(206, 149);
            this.textBoxReceiveData.TabIndex = 11;
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(831, 65);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(100, 149);
            this.textBoxSendData.TabIndex = 11;
            // 
            // buttonSendData
            // 
            this.buttonSendData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSendData.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendData.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSendData.Location = new System.Drawing.Point(831, 220);
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.Size = new System.Drawing.Size(100, 27);
            this.buttonSendData.TabIndex = 12;
            this.buttonSendData.Text = "Send Data";
            this.buttonSendData.UseVisualStyleBackColor = false;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(576, 289);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(92, 21);
            this.comboBoxComPort.TabIndex = 13;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(674, 288);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(23, 23);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(101)))));
            this.panel1.Location = new System.Drawing.Point(951, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 289);
            this.panel1.TabIndex = 3;
            // 
            // timer4Logging
            // 
            this.timer4Logging.Interval = 2000;
            this.timer4Logging.Tick += new System.EventHandler(this.timer4Logging_Tick);
            // 
            // textBoxTimeInterval
            // 
            this.textBoxTimeInterval.Location = new System.Drawing.Point(453, 227);
            this.textBoxTimeInterval.Name = "textBoxTimeInterval";
            this.textBoxTimeInterval.Size = new System.Drawing.Size(121, 20);
            this.textBoxTimeInterval.TabIndex = 15;
            this.textBoxTimeInterval.Text = "2000";
            this.textBoxTimeInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTimeInterval
            // 
            this.labelTimeInterval.AutoSize = true;
            this.labelTimeInterval.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeInterval.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeInterval.Location = new System.Drawing.Point(315, 228);
            this.labelTimeInterval.Name = "labelTimeInterval";
            this.labelTimeInterval.Size = new System.Drawing.Size(102, 19);
            this.labelTimeInterval.TabIndex = 4;
            this.labelTimeInterval.Text = "Time Interval";
            this.labelTimeInterval.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(453, 202);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(121, 20);
            this.textBoxPath.TabIndex = 16;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Transparent;
            this.labelPath.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(315, 203);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(41, 19);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Path";
            this.labelPath.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonStartTimer
            // 
            this.buttonStartTimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStartTimer.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartTimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStartTimer.Location = new System.Drawing.Point(597, 200);
            this.buttonStartTimer.Name = "buttonStartTimer";
            this.buttonStartTimer.Size = new System.Drawing.Size(99, 47);
            this.buttonStartTimer.TabIndex = 17;
            this.buttonStartTimer.Text = "Start Data Logging";
            this.buttonStartTimer.UseVisualStyleBackColor = false;
            this.buttonStartTimer.Click += new System.EventHandler(this.buttonStartTimer_Click);
            // 
            // buttonStopLogging
            // 
            this.buttonStopLogging.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonStopLogging.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopLogging.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStopLogging.Location = new System.Drawing.Point(703, 200);
            this.buttonStopLogging.Name = "buttonStopLogging";
            this.buttonStopLogging.Size = new System.Drawing.Size(102, 47);
            this.buttonStopLogging.TabIndex = 18;
            this.buttonStopLogging.Text = "Stop Data Logging";
            this.buttonStopLogging.UseVisualStyleBackColor = false;
            this.buttonStopLogging.Click += new System.EventHandler(this.buttonStopLogging_Click);
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Items.AddRange(new object[] {
            "xml",
            "txt"});
            this.comboBoxFileType.Location = new System.Drawing.Point(453, 255);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFileType.TabIndex = 19;
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType_SelectedIndexChanged);
            // 
            // labelFileType
            // 
            this.labelFileType.AutoSize = true;
            this.labelFileType.BackColor = System.Drawing.Color.Transparent;
            this.labelFileType.Font = new System.Drawing.Font("Dutch801 Rm BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileType.Location = new System.Drawing.Point(315, 257);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(74, 19);
            this.labelFileType.TabIndex = 4;
            this.labelFileType.Text = "File Type";
            this.labelFileType.Click += new System.EventHandler(this.labelFileType_Click);
            // 
            // buttonXmlRead
            // 
            this.buttonXmlRead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonXmlRead.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXmlRead.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXmlRead.Location = new System.Drawing.Point(851, 394);
            this.buttonXmlRead.Name = "buttonXmlRead";
            this.buttonXmlRead.Size = new System.Drawing.Size(100, 33);
            this.buttonXmlRead.TabIndex = 20;
            this.buttonXmlRead.Text = "XML Read";
            this.buttonXmlRead.UseVisualStyleBackColor = false;
            this.buttonXmlRead.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelInformation.Font = new System.Drawing.Font("Adobe Arabic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(263, 138);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(653, 219);
            this.labelInformation.TabIndex = 4;
            this.labelInformation.Text = resources.GetString("labelInformation.Text");
            this.labelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonXmlClear
            // 
            this.buttonXmlClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonXmlClear.Font = new System.Drawing.Font("Dutch801 Rm BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXmlClear.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXmlClear.Location = new System.Drawing.Point(597, 251);
            this.buttonXmlClear.Name = "buttonXmlClear";
            this.buttonXmlClear.Size = new System.Drawing.Size(208, 27);
            this.buttonXmlClear.TabIndex = 21;
            this.buttonXmlClear.Text = "Clear Xml File";
            this.buttonXmlClear.UseVisualStyleBackColor = false;
            this.buttonXmlClear.Click += new System.EventHandler(this.buttonXmlClear_Click);
            // 
            // chartSensor2
            // 
            this.chartSensor2.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartSensor2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSensor2.Legends.Add(legend4);
            this.chartSensor2.Location = new System.Drawing.Point(597, 20);
            this.chartSensor2.Name = "chartSensor2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Pressure";
            this.chartSensor2.Series.Add(series4);
            this.chartSensor2.Size = new System.Drawing.Size(368, 451);
            this.chartSensor2.TabIndex = 2;
            this.chartSensor2.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.ui_bg1;
            this.ClientSize = new System.Drawing.Size(965, 483);
            this.Controls.Add(this.buttonXmlClear);
            this.Controls.Add(this.buttonXmlRead);
            this.Controls.Add(this.comboBoxFileType);
            this.Controls.Add(this.buttonStopLogging);
            this.Controls.Add(this.buttonStartTimer);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxTimeInterval);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.buttonSendData);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.buttonSerialDisconnect);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonSerialConnect);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.labelFileType);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelTimeInterval);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.chartSensor2);
            this.Controls.Add(this.chartSensor1);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.panelSeperator);
            this.Controls.Add(this.panelLeftMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarmaraLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelSeperator;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMarmaraLogo;
        private System.Windows.Forms.Label myNameUnderLogo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensor1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Button buttonSerialConnect;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSerialDisconnect;
        private System.Windows.Forms.TextBox textBoxReceiveData;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer4Logging;
        private System.Windows.Forms.TextBox textBoxTimeInterval;
        private System.Windows.Forms.Label labelTimeInterval;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Button buttonStopLogging;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Label labelFileType;
        private System.Windows.Forms.Button buttonXmlRead;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button buttonXmlClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSensor2;
    }
}

