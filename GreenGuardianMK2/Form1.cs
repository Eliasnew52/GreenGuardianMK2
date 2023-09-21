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
using Newtonsoft.Json;

namespace GreenGuardianMK2
{
    public partial class Form1 : Form
    {

        /* ID del Dispositivo Conectado*/
        string Device_ID;
        /*Instancia de la DB*/
        DataSender DBInput = new DataSender();

        public Form1()
        {
            
            InitializeComponent();
            PortCheck();
            Size = new Size(Size.Width, Size.Height);   
            string[] PortList = SerialPort.GetPortNames();
            CBSerialPorts.Items.AddRange(PortList);
        }
        public class SensorData
        {
            public int Temperatura { get; set; }
            public int Humedad { get; set; }
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
           PortCheck();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SerialPort1.Close();
            PortCheck();
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
                SerialPort1.WriteLine("$GetDeviceID");

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
                TxtDevice_ID.Text = ("Desconectado");
                TxtDevice_ID.ForeColor = Color.DarkGray;
               
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

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (SerialPort1.IsOpen && SerialPort1.BytesToRead > 0)
            {
                // Lee el JSON desde el puerto serie
                string serialData = SerialPort1.ReadLine();

                if (serialData.StartsWith("DeviceID:"))
                {
                    try
                    {
                        // Extrae y almacena el DEVICE ID
                        Device_ID = serialData.Substring(9); // 9 es la longitud de "DeviceID:"

                        // Actualiza algún control en tu HMI para mostrar el DEVICE ID
                        // Por ejemplo, si tienes un TextBox llamado txtDeviceID:
                        TxtDevice_ID.Invoke((MethodInvoker)(() => TxtDevice_ID.Text = Device_ID.ToString()));
                        TxtDevice_ID.ForeColor = Color.Green;

                        // También puedes detener la recepción de datos si ya tienes el DEVICE ID
                        //SerialPort1.DataReceived -= SerialPort1_DataReceived;
                    }
                    catch
                    {
                        MessageBox.Show("Error Obteniendo el ID");
                    }
                }
                else
                {
                    try
                    {
                        // Deserializa el JSON en un objeto C#
                        SensorData sensorData = JsonConvert.DeserializeObject<SensorData>(serialData);

                        // Accede a los valores del sensor desde el objeto deserializado
                        int temperatura = sensorData.Temperatura;
                        int humedad = sensorData.Humedad;
                        string JSONSensorData = JsonConvert.SerializeObject(sensorData);
                        try
                        {
                            Boolean Band = DBInput.STATS_UPDATE(int.Parse(Device_ID),JSONSensorData);                       }
                        catch
                        {
                            Console.WriteLine("Error al hacer Insercion a la DB");
                        }
                        

                        // Actualiza la interfaz gráfica con los valores leídos
                        Data_Chart_Humedad.Invoke((MethodInvoker)(() => Data_Chart_Humedad.Series["Humedad"].Points.AddY(humedad)));
                        //Data_Chart_Temperatura.Invoke((MethodInvoker)(() => Data_Chart_Temperatura.Series["Temperatura"].Points.AddY(temperatura)));
                    }
                    catch (JsonException ex)
                    {
                        continue;
                    }
                }
            }
        }

        private void ChartPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnShoot_Click(object sender, EventArgs e)
        {
            CommandInput("$Shoot");
        }

        private void BtnShootOff_Click(object sender, EventArgs e)
        {
            CommandInput("$ShootOff");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }

}
