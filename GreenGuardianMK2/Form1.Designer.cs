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
            this.LogoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEncender = new Guna.UI2.WinForms.Guna2Button();
            this.BtnApagar = new Guna.UI2.WinForms.Guna2Button();
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.NavBar.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.Color.LimeGreen;
            this.NavBar.Controls.Add(this.LogoPanel);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1924, 160);
            this.NavBar.TabIndex = 0;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.Transparent;
            this.LogoPanel.BorderColor = System.Drawing.Color.SpringGreen;
            this.LogoPanel.BorderRadius = 10;
            this.LogoPanel.BorderThickness = 10;
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(12, 9);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(317, 145);
            this.LogoPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 895);
            this.panel1.TabIndex = 2;
            // 
            // BtnEncender
            // 
            this.BtnEncender.BackColor = System.Drawing.Color.Transparent;
            this.BtnEncender.BorderColor = System.Drawing.Color.White;
            this.BtnEncender.BorderRadius = 20;
            this.BtnEncender.BorderThickness = 5;
            this.BtnEncender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEncender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnEncender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnEncender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnEncender.FillColor = System.Drawing.Color.SpringGreen;
            this.BtnEncender.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender.ForeColor = System.Drawing.Color.White;
            this.BtnEncender.Location = new System.Drawing.Point(430, 433);
            this.BtnEncender.Name = "BtnEncender";
            this.BtnEncender.PressedColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnEncender.Size = new System.Drawing.Size(180, 78);
            this.BtnEncender.TabIndex = 3;
            this.BtnEncender.Text = "Encender";
            this.BtnEncender.Click += new System.EventHandler(this.BtnEncender_Click);
            // 
            // BtnApagar
            // 
            this.BtnApagar.BackColor = System.Drawing.Color.Transparent;
            this.BtnApagar.BorderColor = System.Drawing.Color.White;
            this.BtnApagar.BorderRadius = 20;
            this.BtnApagar.BorderThickness = 5;
            this.BtnApagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnApagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnApagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnApagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnApagar.FillColor = System.Drawing.Color.Red;
            this.BtnApagar.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar.ForeColor = System.Drawing.Color.White;
            this.BtnApagar.Location = new System.Drawing.Point(869, 433);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.PressedColor = System.Drawing.Color.DarkRed;
            this.BtnApagar.Size = new System.Drawing.Size(180, 78);
            this.BtnApagar.TabIndex = 4;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
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
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.BtnEncender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Green Guardian MK2 ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavBar.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel LogoPanel;
        private Guna.UI2.WinForms.Guna2Button BtnEncender;
        private Guna.UI2.WinForms.Guna2Button BtnApagar;
        private System.IO.Ports.SerialPort SerialPort1;
    }
}

