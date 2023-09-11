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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CBSerialPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDesconectar = new Guna.UI2.WinForms.Guna2Button();
            this.BtnConectar = new Guna.UI2.WinForms.Guna2Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LED_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnLED_On = new Guna.UI2.WinForms.Guna2Button();
            this.BtnLED_Off = new Guna.UI2.WinForms.Guna2Button();
            this.ChartPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Data_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NavBar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.LED_Panel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart)).BeginInit();
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
            this.NavBar.Size = new System.Drawing.Size(1924, 155);
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
            this.pictureBox1.Location = new System.Drawing.Point(-5, -28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 205);
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
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 900);
            this.panel1.TabIndex = 2;
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // CBSerialPorts
            // 
            this.CBSerialPorts.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBSerialPorts.FormattingEnabled = true;
            this.CBSerialPorts.Location = new System.Drawing.Point(12, 98);
            this.CBSerialPorts.Name = "CBSerialPorts";
            this.CBSerialPorts.Size = new System.Drawing.Size(235, 53);
            this.CBSerialPorts.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(42, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puerto Serial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(5, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado del Dispositivo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnDesconectar.Location = new System.Drawing.Point(31, 512);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(194, 73);
            this.BtnDesconectar.TabIndex = 8;
            this.BtnDesconectar.Text = "Desconectar";
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
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
            this.BtnConectar.Location = new System.Drawing.Point(31, 417);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(194, 73);
            this.BtnConectar.TabIndex = 9;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusLabel.Location = new System.Drawing.Point(42, 323);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(164, 31);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Desconectado";
            // 
            // LED_Panel
            // 
            this.LED_Panel.BackColor = System.Drawing.Color.Transparent;
            this.LED_Panel.BorderColor = System.Drawing.Color.White;
            this.LED_Panel.BorderRadius = 10;
            this.LED_Panel.BorderThickness = 4;
            this.LED_Panel.Controls.Add(this.BtnLED_Off);
            this.LED_Panel.Controls.Add(this.BtnLED_On);
            this.LED_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LED_Panel.Location = new System.Drawing.Point(284, 601);
            this.LED_Panel.Name = "LED_Panel";
            this.LED_Panel.Size = new System.Drawing.Size(473, 311);
            this.LED_Panel.TabIndex = 3;
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
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChartPanel.BorderColor = System.Drawing.Color.White;
            this.ChartPanel.BorderRadius = 10;
            this.ChartPanel.BorderThickness = 4;
            this.ChartPanel.Controls.Add(this.Data_Chart);
            this.ChartPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChartPanel.Location = new System.Drawing.Point(284, 180);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(722, 397);
            this.ChartPanel.TabIndex = 4;
            // 
            // Data_Chart
            // 
            this.Data_Chart.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.Data_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Data_Chart.Legends.Add(legend2);
            this.Data_Chart.Location = new System.Drawing.Point(20, 15);
            this.Data_Chart.Name = "Data_Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.LabelBackColor = System.Drawing.Color.Silver;
            series2.LabelBorderColor = System.Drawing.Color.Silver;
            series2.Legend = "Legend1";
            series2.Name = "Humedad";
            this.Data_Chart.Series.Add(series2);
            this.Data_Chart.Size = new System.Drawing.Size(672, 361);
            this.Data_Chart.TabIndex = 0;
            this.Data_Chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.LED_Panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
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
            ((System.ComponentModel.ISupportInitialize)(this.Data_Chart)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart Data_Chart;
    }
}

