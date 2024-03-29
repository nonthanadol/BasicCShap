﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Basic_ModbusTCP_DeltaPLC
{
    public partial class UserControl1 : UserControl
    {
        public ModbusClient modbus = new ModbusClient();
        
        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }     
        private void button1_Click(object sender, EventArgs e)
        {
            modbus.IPAddress = Convert.ToString(textBox1.Text); // IP PLC
            modbus.Port = Convert.ToInt32(textBox2.Text);

            try
            {
                modbus.Connect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (modbus.Connected == true)
            {
                //TestClass.txt = "Connected";
                Form1.form1.lb.Text = TestClass.txt;
                //label4.Text = "Connected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            modbus.Disconnect();
            TestClass.txt = "Disconnected";
            Form1.form1.lb.Text = TestClass.txt;
            
            Form1 ff = new Form1();
            ff.textBox1.Text = "Disconnected";
        }

       
    }
}
