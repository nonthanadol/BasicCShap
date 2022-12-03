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


namespace Basic_ModbusTCP_DeltaPLC
{
 
    public partial class Form1 : Form
    {
        ModbusClient modbus= new ModbusClient();   
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
                label4.Text = "Connected";
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //M0 = 2049
            modbus.WriteSingleCoil(2049,checkBox1.Checked);// ModbusAddress,Value
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modbus.Disconnect();
            label4.Text = "Disconnected";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //M0 = 2050
            modbus.WriteSingleCoil(2050, checkBox2.Checked);// ModbusAddress,Value
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Y0 = 1281
            modbus.WriteSingleCoil(1281, checkBox3.Checked);// ModbusAddress,Value
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //Y1 = 1282
            modbus.WriteSingleCoil(1282, checkBox4.Checked); // ModbusAddress,Value
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            // Write D0 = 404097
            modbus.WriteSingleRegister(404097,Convert.ToInt32(textBox3.Text)); // ModbusAddress,Value
            modbus.WriteSingleRegister(404098,Convert.ToInt32(textBox4.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Read
            int[] D = modbus.ReadHoldingRegisters(404097,2); // ModbusAddress,quantity
            textBox5.Text = D[0].ToString();
            textBox6.Text = D[1].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            /*Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            form2.Show();
            form1.Hide();*/
            UserControl1 control = new UserControl1();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.BringToFront();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            form2.Show();
            //form1.Hide();
        }
    }
}
