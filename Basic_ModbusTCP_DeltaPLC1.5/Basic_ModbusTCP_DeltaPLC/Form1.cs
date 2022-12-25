﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Basic_ModbusTCP_DeltaPLC
{
 
    public partial class Form1 : Form
    {
        public static Form1 form1 = new Form1();
        public Label lb;
        UserControl1 obj_uc1 = new UserControl1();
        private Thread obj_readThread;
        
        private void ReadStatus()
        {
          
            while (true)
            {

                if (obj_uc1.obj_modbus.Connected == true )
                {
                    bool[] Y = obj_uc1.obj_modbus.ReadCoils(1283,2);
                    bool[] X = obj_uc1.obj_modbus.ReadCoils(1025, 2);
                    int[] D = obj_uc1.obj_modbus.ReadHoldingRegisters(404099, 2);
                    while (obj_uc1.obj_modbus.Connected == true) 
                    {
                        label3.Text = Convert.ToString(Y[0]);
                        label6.Text = Convert.ToString(Y[1]);
                        label14.Text = Convert.ToString(X[1]);
                        label16.Text = Convert.ToString(X[0]);
                        label10.Text = Convert.ToString(D[0]);
                        label12.Text = Convert.ToString(D[1]);
                    }

                }
                else {
                    for (int i = 0; i < 6; i++)
                    {
                        label3.Text = "Disconect " + Convert.ToString(i); //Y3
                        label6.Text = "Disconect " + Convert.ToString(i); //Y4
                        label14.Text = "Disconect " + Convert.ToString(i); //X2
                        label16.Text = "Disconect " + Convert.ToString(i); //X1
                        label10.Text = "Disconect " + Convert.ToString(i); //D3
                        label12.Text = "Disconect " + Convert.ToString(i); //D4
                        Thread.Sleep(1000);

                    }
                }



                /* // Read the coils from the Modbus server
                ushort startAddress = Convert.ToUInt16(txtStartAddress.Text);
                ushort numCoils = Convert.ToUInt16(txtNumCoils.Text);
                bool[] coils = _modbusMaster.ReadCoils(1, startAddress, numCoils);

                // Display the coils in the list box
                this.Invoke((MethodInvoker)delegate
                {
                    lstCoils.Items.Clear();
                    foreach (bool coil in coils)
                    {
                        lstCoils.Items.Add(coil);
                    }
                });

                // Wait for a moment before reading the coils again */

                Thread.Sleep(500);
            }
        }
        public Form1()
        {
            InitializeComponent();
            form1 = this;
            lb = label1;
            
           
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            obj_readThread = new Thread(ReadStatus);
            obj_readThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
