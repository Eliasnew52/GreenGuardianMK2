using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenGuardianMK2
{
    //Necesito Crear una Variable Global que almacene el Puerto Serial para todos los forms

    public partial class MainScreen : Form
    {
        
        
       
        public MainScreen()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            string[] PortList = SerialPort.GetPortNames();
            CBPortList.Items.AddRange(PortList);

        }

        /* Esta Funcion Valida el Estado Actual del Puerto*/
        public void PortCheck()
        {
            if (SerialPort1.IsOpen)
            {
                BtnConnect.Enabled = false;
                BtnDisconnect.Enabled = true;
                CBPortList.Enabled = false;
                SuccessLabel.Visible = true;
            }
            else
            {
                BtnConnect.Enabled = true;
                BtnDisconnect.Enabled = false;
                CBPortList.Enabled = true;
                SuccessLabel.Visible = false;
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.PortName = CBPortList.Text;
                SerialPort1.Open();

                BtnDisconnect.Enabled = true;
                BtnConnect.Enabled = false;
                CBPortList.Enabled = false;
                PBPort.Value = 100;
                SuccessLabel.Visible = true;
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                SerialPort1.Close();

                BtnDisconnect.Enabled = false;
                BtnConnect.Enabled = true;
                CBPortList.Enabled = true;
                PBPort.Value = 0;
                SuccessLabel.Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void BtnOn_Click(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.WriteLine("$On");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void BtnOff_Click(object sender, EventArgs e)
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

        private void CBPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
