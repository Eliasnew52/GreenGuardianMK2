using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GreenGuardianMK2
{
    public partial class Form1 : Form
    {
        /* Instancias de los Formularios*/
        
      
        public Form1()
        {
            InitializeComponent();
            PortCheck();
            string[] PortList = SerialPort.GetPortNames();
            CBSerialPorts.Items.AddRange(PortList);
        }

        private void BtnEncender_Click(object sender, EventArgs e)
        {
         
            
        }
        public void PortCheck()
        {
            if (SerialPort1.IsOpen)
            {
                BtnConectar.Enabled = false;
                BtnDesconectar.Enabled = true;
                CBSerialPorts.Enabled = false;
                StatusLabel.Text = "Conectado";
                StatusLabel.ForeColor = Color.Green;
            }
            else
            {
                BtnConectar.Enabled = true;
                BtnDesconectar.Enabled = false;
                CBSerialPorts.Enabled = true;
                StatusLabel.Text = "Desconectado";
                StatusLabel.ForeColor = Color.DarkGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
           
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.PortName = CBSerialPorts.Text;
                SerialPort1.Open();
                PortCheck();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {

                SerialPort1.Close();
                PortCheck();
               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void CommandInput(string Command)
        {
            try
            {
                SerialPort1.WriteLine(Command);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnLED_On_Click(object sender, EventArgs e)
        {
            CommandInput("$On");
        }

        private void BtnLED_Off_Click(object sender, EventArgs e)
        {
            CommandInput("$Off");
        }
    }
}
