using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenGuardianMK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncender_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.Open();
                MessageBox.Show("ARDUINO CONECTADA");
            }
            catch(Exception error) 
            {
                MessageBox.Show(error.Message);
            }
            
        }
    }
}
