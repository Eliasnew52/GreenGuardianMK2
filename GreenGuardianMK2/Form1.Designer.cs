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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NavBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnConfiguracion = new Guna.UI2.WinForms.Guna2Button();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.NavBar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.NavBar.Size = new System.Drawing.Size(1924, 160);
            this.NavBar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(296, 95);
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
            this.label1.Location = new System.Drawing.Point(277, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green Guardian";
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.BorderColor = System.Drawing.Color.Honeydew;
            this.LogoPanel.BorderThickness = 10;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(234, 160);
            this.LogoPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.BtnConfiguracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 895);
            this.panel1.TabIndex = 2;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfiguracion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnConfiguracion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnConfiguracion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnConfiguracion.FillColor = System.Drawing.Color.Transparent;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracion.HoverState.FillColor = System.Drawing.Color.MediumTurquoise;
            this.BtnConfiguracion.Location = new System.Drawing.Point(0, 24);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(230, 70);
            this.BtnConfiguracion.TabIndex = 0;
            this.BtnConfiguracion.Text = "Configuracion";
            this.BtnConfiguracion.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // SerialPort1
            // 
            this.SerialPort1.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel LogoPanel;
        private System.IO.Ports.SerialPort SerialPort1;
        private Guna.UI2.WinForms.Guna2Button BtnConfiguracion;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

