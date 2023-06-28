using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using System.IO.Ports;

namespace Test485
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient;
        private List<string> availablePorts;
        public Form1()
        {
            InitializeComponent();
            availablePorts = new List<string>();
            RefreshPortList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of the ModbusClient class
            modbusClient = new ModbusClient();
            modbusClient.Baudrate = 9600; // Set the baud rate
            modbusClient.Parity = Parity.Even; // Set the parity to Even
            modbusClient.StopBits = StopBits.One; // Set the stop bits
            modbusClient.ConnectionTimeout = 1000; // Set the connection timeout in milliseconds
           // modbusClient.DataBits = 7; // Set the data bits to 7
        }

        private void RefreshPortList()
        {
            // Clear the existing port list
            availablePorts.Clear();
            cmbPort.Items.Clear();

            // Get the list of available COM ports
            string[] ports = SerialPort.GetPortNames();

            // Add the ports to the list
            availablePorts.AddRange(ports);
            cmbPort.Items.AddRange(ports);

            if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modbusClient.Connected)
                {
                    // Get the selected COM port
                    string selectedPort = cmbPort.SelectedItem as string;

                    if (selectedPort == null)
                    {
                        MessageBox.Show("No COM port selected.");
                        return;
                    }

                    // Connect to the Modbus RTU slave device
                    modbusClient.SerialPort = selectedPort;
                    modbusClient.Connect();

                    if (modbusClient.Connected)
                    {
                        MessageBox.Show("Connected to Modbus RTU device.");
                    }
                }
                else
                {
                    MessageBox.Show("Already connected to a Modbus RTU device.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect: " + ex.Message);
            }
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshPortList();
        }
    }
}
