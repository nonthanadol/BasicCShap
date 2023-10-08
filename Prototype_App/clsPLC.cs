using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using Microsoft.Win32;
using System.Threading;

namespace Prototype_App
{
    public class clsPLC
    {

        ModbusClient _modbus = new ModbusClient();
        iVariableShare _Common = new iVariableShare();
        clsTool _Tool = new clsTool();
       
        int[] status;
        int[] statusCode;
        int[] passQty;
        int[] failQty;
        int[] errorCnt;
        int[] selfCheck;
        int[] cycleTime;
        int[] RunningTime;
        int[] WaitingTime;
        int[] errTime;
        int[] raw_Barcode;
        string Barcode;

        private Thread _readThread;      
        private bool isThreadRunning;


        public clsPLC(iVariableShare common)
        {
            isThreadRunning = false;

            _Common = common;
            _readThread = new Thread(ReadStatusThread);
            _readThread.Name = "readStatusThread";
        }

        public void callReadStatusThread() 
        {
            try 
            {
                if (!isThreadRunning)
                {
                    _readThread.Start();
                    isThreadRunning = true;
                   
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in callReadStatusThread: {ex.Message}");
            }


        }

        public void StopReadStatusThread()
        {
            if (isThreadRunning)
            {
                _readThread.Abort(); // You may want to use a safer way to stop the thread.
                isThreadRunning = false;
               
            }
        }

        public void ReadStatusThread()
        {
            //_readThread.Start();
            while (isThreadRunning) 
            {
                try
                {
                    if (_modbus.Connected == true)
                    {
                        readRegister();
                    }
                    else
                    {
                        StopReadStatusThread();
                    }
                }
                catch (ThreadAbortException)
                {
                    
                }
                Thread.Sleep(500);
            }        
        }
        public void connectPLC()
        {
           
            string ip = Properties.Settings.Default.IPAddress;
            string port = "502";


            _modbus.IPAddress = ip; // IP PLC
            _modbus.Port = Convert.ToInt32(port);

            try
            {
                _modbus.Connect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (_modbus.Connected == true)
            {
               _Common.iPLCconnectStatus = "Connected";

            }
            else
            {
                _Common.iPLCconnectStatus = "Connect Fail!!";

            }
            
            
        }

        public void disconnectPLC()
        {

            _modbus.Disconnect();           
            _Common.iPLCconnectStatus = "Disconnect!!";

        }
        public void readRegister()
        {

            try
            {
                if (_modbus.Connected == true)
                {

                    //bool[] X = obj_modbus.ReadDiscreteInputs(1025, 2); // ReadCoils(1025, 2);
                    status = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.Dstatus), 1);
                    statusCode = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DstatusCode), 1);
                    passQty = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DpassQty), 1);
                    failQty = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DfailQty), 1);
                    errorCnt = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DerrorCnt), 1);
                    selfCheck = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DselfCheck), 1);
                    cycleTime = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DcycleTime), 2);
                    RunningTime = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DrunningTime), 2);
                    WaitingTime = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DwaitingTime), 2);
                    errTime = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DerrTime), 2);


                    if (Properties.Settings.Default.EnableMES == true)
                    {
                        raw_Barcode = _modbus.ReadHoldingRegisters(Convert.ToInt32(Properties.Settings.Default.DerrTime), 9);
                        Barcode = _Tool.ConvertArrayIntToAsciiText(raw_Barcode);
                        _Common.iPQM_Barcode = Barcode;
                        //Console.WriteLine("Enable MES" + _Common.iPQM_Barcode + "##");
                    }

                    /*
                    int CycleTmr1 = cycleTime[0];
                    int CycleTmr2 = cycleTime[1];

                    uint DWcycleTime = (uint)((CycleTmr2 << 16) | CycleTmr1);
                    */

                    uint DWcycleTime = _Tool.combineWord(cycleTime[0], cycleTime[1]);
                    uint DWRunningTime = _Tool.combineWord(RunningTime[0], RunningTime[1]);
                    uint DWWaitingTime = _Tool.combineWord(WaitingTime[0], WaitingTime[1]);
                    uint DWerrTime = _Tool.combineWord(errTime[0], errTime[1]);

                    _Common.iPQM_Status = status[0];
                    _Common.iPQM_Status_Code = Convert.ToString(statusCode[0]);
                    _Common.iPQM_PassQty = passQty[0];
                    _Common.iPQM_FailQty = failQty[0];
                    _Common.iPQM_Error_Count = errorCnt[0];
                    _Common.iPQM_Self_Check = selfCheck[0];
                    _Common.iPQM_Cycle_Time = DWcycleTime;
                    _Common.iPQM_Running_Time = DWRunningTime;
                    _Common.iPQM_Waiting_Time = DWWaitingTime;
                    _Common.iPQM_Error_Time = DWerrTime;

                }
                else 
                {
                    _Common.iPLCconnectStatus = "Disconnect!!";
                    StopReadStatusThread();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}