namespace GreenGuardianMK2
{
    partial class MainScreen
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CBPortList = new System.Windows.Forms.ComboBox();
            this.SuccessLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PBPort = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.BtnDisconnect = new Guna.UI2.WinForms.Guna2Button();
            this.BtnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOff = new Guna.UI2.WinForms.Guna2Button();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.SpringGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1800, 126);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.CBPortList);
            this.guna2GroupBox1.Controls.Add(this.SuccessLabel);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.PBPort);
            this.guna2GroupBox1.Controls.Add(this.BtnDisconnect);
            this.guna2GroupBox1.Controls.Add(this.BtnConnect);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(7, 45, 7, 7);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(159)))), ((int)(((byte)(182)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 143);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(631, 505);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Configuracion del Puerto";
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(10, 0);
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // CBPortList
            // 
            this.CBPortList.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPortList.FormattingEnabled = true;
            this.CBPortList.Location = new System.Drawing.Point(197, 83);
            this.CBPortList.Name = "CBPortList";
            this.CBPortList.Size = new System.Drawing.Size(151, 35);
            this.CBPortList.TabIndex = 7;
            this.CBPortList.SelectedIndexChanged += new System.EventHandler(this.CBPortList_SelectedIndexChanged);
            // 
            // SuccessLabel
            // 
            this.SuccessLabel.AutoSize = true;
            this.SuccessLabel.BackColor = System.Drawing.Color.Transparent;
            this.SuccessLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.SuccessLabel.Location = new System.Drawing.Point(204, 358);
            this.SuccessLabel.Name = "SuccessLabel";
            this.SuccessLabel.Size = new System.Drawing.Size(359, 34);
            this.SuccessLabel.TabIndex = 6;
            this.SuccessLabel.Text = "Conectado Exitosamente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado:";
            // 
            // PBPort
            // 
            this.PBPort.Animated = true;
            this.PBPort.BackColor = System.Drawing.Color.Transparent;
            this.PBPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.PBPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PBPort.ForeColor = System.Drawing.Color.White;
            this.PBPort.Location = new System.Drawing.Point(34, 303);
            this.PBPort.Minimum = 0;
            this.PBPort.Name = "PBPort";
            this.PBPort.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBPort.Size = new System.Drawing.Size(140, 140);
            this.PBPort.TabIndex = 4;
            this.PBPort.Text = "Progreso";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.BackColor = System.Drawing.Color.Transparent;
            this.BtnDisconnect.BorderColor = System.Drawing.Color.White;
            this.BtnDisconnect.BorderRadius = 20;
            this.BtnDisconnect.BorderThickness = 2;
            this.BtnDisconnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDisconnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDisconnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDisconnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDisconnect.FillColor = System.Drawing.Color.Red;
            this.BtnDisconnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisconnect.ForeColor = System.Drawing.Color.White;
            this.BtnDisconnect.Location = new System.Drawing.Point(405, 170);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(180, 81);
            this.BtnDisconnect.TabIndex = 3;
            this.BtnDisconnect.Text = "Desconectar Puerto";
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.Transparent;
            this.BtnConnect.BorderColor = System.Drawing.Color.White;
            this.BtnConnect.BorderRadius = 20;
            this.BtnConnect.BorderThickness = 2;
            this.BtnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConnect.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnConnect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(405, 64);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(180, 81);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Conectar Puerto";
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puerto COM:";
            // 
            // BtnOn
            // 
            this.BtnOn.BackColor = System.Drawing.Color.Transparent;
            this.BtnOn.BorderColor = System.Drawing.Color.White;
            this.BtnOn.BorderRadius = 20;
            this.BtnOn.BorderThickness = 2;
            this.BtnOn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOn.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnOn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOn.ForeColor = System.Drawing.Color.White;
            this.BtnOn.Location = new System.Drawing.Point(785, 231);
            this.BtnOn.Name = "BtnOn";
            this.BtnOn.Size = new System.Drawing.Size(180, 81);
            this.BtnOn.TabIndex = 8;
            this.BtnOn.Text = "ON";
            this.BtnOn.Click += new System.EventHandler(this.BtnOn_Click);
            // 
            // BtnOff
            // 
            this.BtnOff.BackColor = System.Drawing.Color.Transparent;
            this.BtnOff.BorderColor = System.Drawing.Color.White;
            this.BtnOff.BorderRadius = 20;
            this.BtnOff.BorderThickness = 2;
            this.BtnOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnOff.FillColor = System.Drawing.Color.Red;
            this.BtnOff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOff.ForeColor = System.Drawing.Color.White;
            this.BtnOff.Location = new System.Drawing.Point(785, 354);
            this.BtnOff.Name = "BtnOff";
            this.BtnOff.Size = new System.Drawing.Size(180, 81);
            this.BtnOff.TabIndex = 8;
            this.BtnOff.Text = "OFF";
            this.BtnOff.Click += new System.EventHandler(this.BtnOff_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1800, 1000);
            this.ControlBox = false;
            this.Controls.Add(this.BtnOff);
            this.Controls.Add(this.BtnOn);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnDisconnect;
        private Guna.UI2.WinForms.Guna2Button BtnConnect;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PBPort;
        private System.Windows.Forms.Label SuccessLabel;
        private System.Windows.Forms.ComboBox CBPortList;
        private Guna.UI2.WinForms.Guna2Button BtnOn;
        private Guna.UI2.WinForms.Guna2Button BtnOff;
        private System.IO.Ports.SerialPort SerialPort1;
    }
}