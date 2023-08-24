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
        MainScreen mainScreen = new MainScreen();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncender_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.WriteLine("$On");
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                SerialPort1.PortName = "COM4";
                SerialPort1.Open();
                MessageBox.Show("ARDUINO CONECTADA");
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
            */
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SerialPort1.IsOpen) 
            {
                try
                {
                    SerialPort1.Close();
                }
                catch (Exception error) 
                {
                    MessageBox.Show(error.Message);
                }
                
            }
            
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.WriteLine("$Off");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            mainScreen.MdiParent = this;
            mainScreen.Show();
            mainScreen.Location = new Point(0, 0);
            mainScreen.PortCheck();
        }
    }
}
