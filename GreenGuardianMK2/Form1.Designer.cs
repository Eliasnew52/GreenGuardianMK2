namespace GreenGuardianMK2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BtnConectar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDesconectar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBSerialPorts = new System.Windows.Forms.ComboBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.LED_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLED_Off = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLED_On = new Guna.UI2.WinForms.Guna2Button();
            this.ChartPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Data_Chart_Humedad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Data_Chart_Temperatura = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnShoot = new Guna.UI2.WinForms.Guna2Button();
            this.BtnShootOff = new Guna.UI2.WinForms.Guna2Button();
            this.NavBar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.LED_Panel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart_Humedad)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart_Temperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NavBar.Controls.Add(this.label2);
            this.NavBar.Controls.Add(this.label1);
            this.NavBar.Controls.Add(this.LogoPanel);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1582, 138);
            this.NavBar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(300, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "HMI Software ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(295, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green Guardian";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LogoPanel.BorderThickness = 10;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(294, 155);
            this.LogoPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.BtnConectar);
            this.panel1.Controls.Add(this.BtnDesconectar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CBSerialPorts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 738);
            this.panel1.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusLabel.Location = new System.Drawing.Point(15, 208);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(164, 31);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Desconectado";
            // 
            // BtnConectar
            // 
            this.BtnConectar.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnConectar.BorderRadius = 10;
            this.BtnConectar.BorderThickness = 4;
            this.BtnConectar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnConectar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConectar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConectar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConectar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConectar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnConectar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BtnConectar.ForeColor = System.Drawing.Color.White;
            this.BtnConectar.Location = new System.Drawing.Point(13, 263);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(169, 63);
            this.BtnConectar.TabIndex = 9;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.BorderColor = System.Drawing.Color.Gainsboro;
            this.BtnDesconectar.BorderRadius = 10;
            this.BtnDesconectar.BorderThickness = 4;
            this.BtnDesconectar.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnDesconectar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesconectar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDesconectar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDesconectar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDesconectar.FillColor = System.Drawing.Color.Firebrick;
            this.BtnDesconectar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDesconectar.ForeColor = System.Drawing.Color.White;
            this.BtnDesconectar.Location = new System.Drawing.Point(14, 344);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(168, 59);
            this.BtnDesconectar.TabIndex = 8;
            this.BtnDesconectar.Text = "Desconectar";
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dispositivo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puerto Serial";
            // 
            // CBSerialPorts
            // 
            this.CBSerialPorts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSerialPorts.FormattingEnabled = true;
            this.CBSerialPorts.Location = new System.Drawing.Point(13, 75);
            this.CBSerialPorts.Name = "CBSerialPorts";
            this.CBSerialPorts.Size = new System.Drawing.Size(177, 36);
            this.CBSerialPorts.TabIndex = 0;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // LED_Panel
            // 
            this.LED_Panel.BackColor = System.Drawing.Color.Transparent;
            this.LED_Panel.BorderColor = System.Drawing.Color.White;
            this.LED_Panel.BorderRadius = 10;
            this.LED_Panel.BorderThickness = 4;
            this.LED_Panel.Controls.Add(this.BtnShootOff);
            this.LED_Panel.Controls.Add(this.BtnShoot);
            this.LED_Panel.Controls.Add(this.BtnLED_Off);
            this.LED_Panel.Controls.Add(this.BtnLED_On);
            this.LED_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Panel.Location = new System.Drawing.Point(30, 32);
            this.LED_Panel.Name = "LED_Panel";
            this.LED_Panel.Size = new System.Drawing.Size(473, 306);
            this.LED_Panel.TabIndex = 3;
            // 
            // BtnLED_Off
            // 
            this.BtnLED_Off.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLED_Off.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLED_Off.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLED_Off.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLED_Off.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLED_Off.ForeColor = System.Drawing.Color.White;
            this.BtnLED_Off.Location = new System.Drawing.Point(253, 218);
            this.BtnLED_Off.Name = "BtnLED_Off";
            this.BtnLED_Off.Size = new System.Drawing.Size(180, 45);
            this.BtnLED_Off.TabIndex = 1;
            this.BtnLED_Off.Text = "Apagar";
            this.BtnLED_Off.Click += new System.EventHandler(this.BtnLED_Off_Click);
            // 
            // BtnLED_On
            // 
            this.BtnLED_On.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLED_On.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLED_On.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLED_On.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLED_On.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnLED_On.ForeColor = System.Drawing.Color.White;
            this.BtnLED_On.Location = new System.Drawing.Point(35, 218);
            this.BtnLED_On.Name = "BtnLED_On";
            this.BtnLED_On.Size = new System.Drawing.Size(180, 45);
            this.BtnLED_On.TabIndex = 0;
            this.BtnLED_On.Text = "Encender";
            this.BtnLED_On.Click += new System.EventHandler(this.BtnLED_On_Click);
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChartPanel.BorderColor = System.Drawing.Color.White;
            this.ChartPanel.BorderRadius = 10;
            this.ChartPanel.BorderThickness = 4;
            this.ChartPanel.Controls.Add(this.Data_Chart_Humedad);
            this.ChartPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartPanel.Location = new System.Drawing.Point(216, 144);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(722, 339);
            this.ChartPanel.TabIndex = 4;
            this.ChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChartPanel_Paint);
            // 
            // Data_Chart_Humedad
            // 
            this.Data_Chart_Humedad.BackColor = System.Drawing.Color.DarkGray;
            this.Data_Chart_Humedad.BorderlineWidth = 4;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.Data_Chart_Humedad.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 10;
            legend1.BackColor = System.Drawing.Color.Gray;
            legend1.BorderColor = System.Drawing.Color.White;
            legend1.BorderWidth = 4;
            legend1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.Data_Chart_Humedad.Legends.Add(legend1);
            this.Data_Chart_Humedad.Location = new System.Drawing.Point(20, 13);
            this.Data_Chart_Humedad.Name = "Data_Chart_Humedad";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelBackColor = System.Drawing.Color.Silver;
            series1.LabelBorderColor = System.Drawing.Color.Silver;
            series1.Legend = "Legend1";
            series1.Name = "Humedad";
            this.Data_Chart_Humedad.Series.Add(series1);
            this.Data_Chart_Humedad.Size = new System.Drawing.Size(672, 307);
            this.Data_Chart_Humedad.TabIndex = 0;
            this.Data_Chart_Humedad.Text = "Stats";
            title1.Name = "MM";
            this.Data_Chart_Humedad.Titles.Add(title1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(944, 144);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(560, 716);
            this.guna2Panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(112, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resumen Meteorologico";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 4;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Location = new System.Drawing.Point(18, 52);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(530, 224);
            this.guna2Panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(141, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado del Cultivo";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 4;
            this.guna2Panel3.Controls.Add(this.LED_Panel);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Location = new System.Drawing.Point(18, 331);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(530, 366);
            this.guna2Panel3.TabIndex = 5;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 4;
            this.guna2Panel4.Controls.Add(this.Data_Chart_Temperatura);
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel4.Location = new System.Drawing.Point(216, 489);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(722, 371);
            this.guna2Panel4.TabIndex = 5;
            // 
            // Data_Chart_Temperatura
            // 
            this.Data_Chart_Temperatura.BackColor = System.Drawing.Color.DarkGray;
            this.Data_Chart_Temperatura.BorderlineWidth = 4;
            chartArea2.BackColor = System.Drawing.Color.Gray;
            chartArea2.Name = "ChartArea1";
            this.Data_Chart_Temperatura.ChartAreas.Add(chartArea2);
            legend2.AutoFitMinFontSize = 10;
            legend2.BackColor = System.Drawing.Color.Gray;
            legend2.BorderColor = System.Drawing.Color.White;
            legend2.BorderWidth = 4;
            legend2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.Data_Chart_Temperatura.Legends.Add(legend2);
            this.Data_Chart_Temperatura.Location = new System.Drawing.Point(20, 15);
            this.Data_Chart_Temperatura.Name = "Data_Chart_Temperatura";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            this.Data_Chart_Temperatura.Series.Add(series2);
            this.Data_Chart_Temperatura.Size = new System.Drawing.Size(672, 328);
            this.Data_Chart_Temperatura.TabIndex = 0;
            this.Data_Chart_Temperatura.Text = "Stats";
            title2.Name = "MM";
            this.Data_Chart_Temperatura.Titles.Add(title2);
            // 
            // BtnShoot
            // 
            this.BtnShoot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShoot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShoot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShoot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShoot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnShoot.ForeColor = System.Drawing.Color.White;
            this.BtnShoot.Location = new System.Drawing.Point(35, 31);
            this.BtnShoot.Name = "BtnShoot";
            this.BtnShoot.Size = new System.Drawing.Size(180, 45);
            this.BtnShoot.TabIndex = 2;
            this.BtnShoot.Text = "Shoot Ultrasonic Wave";
            this.BtnShoot.Click += new System.EventHandler(this.BtnShoot_Click);
            // 
            // BtnShootOff
            // 
            this.BtnShootOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnShootOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnShootOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnShootOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnShootOff.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnShootOff.ForeColor = System.Drawing.Color.White;
            this.BtnShootOff.Location = new System.Drawing.Point(243, 31);
            this.BtnShootOff.Name = "BtnShootOff";
            this.BtnShootOff.Size = new System.Drawing.Size(180, 45);
            this.BtnShootOff.TabIndex = 3;
            this.BtnShootOff.Text = "Ultrasonic Off";
            this.BtnShootOff.Click += new System.EventHandler(this.BtnShootOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1582, 876);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Green Guardian MK2 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LED_Panel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart_Humedad)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart_Temperatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel LogoPanel;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort SerialPort1;
        private Guna.UI2.WinForms.Guna2Button BtnDesconectar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBSerialPorts;
        private Guna.UI2.WinForms.Guna2Button BtnConectar;
        private System.Windows.Forms.Label StatusLabel;
        private Guna.UI2.WinForms.Guna2Panel LED_Panel;
        private Guna.UI2.WinForms.Guna2Button BtnLED_Off;
        private Guna.UI2.WinForms.Guna2Button BtnLED_On;
        private Guna.UI2.WinForms.Guna2Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart Data_Chart_Humedad;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart Data_Chart_Temperatura;
        private Guna.UI2.WinForms.Guna2Button BtnShoot;
        private Guna.UI2.WinForms.Guna2Button BtnShootOff;
    }
}

