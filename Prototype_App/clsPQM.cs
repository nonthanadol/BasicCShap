using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Prototype_App;

namespace Prototype_App_PQM

{
    public delegate void HMES_log(object sender, string msg);
    public class clsPQM
    {
        iVariableShare _Common;

        string MES_InterfaceID;
        ushort MES_Status;
        string MES_StatusCode;
        uint MES_PassQty;
        uint MES_FailQty;
        uint MES_ErrorCount;
        float MES_ErrorTime;
        float MES_CycleTime;
        float MES_RunningTime;
        float MES_WaitingTime;
        bool MES_SelfCheck;
        uint MES_InputQty;

        DialogResult dialogResult;

        private HttpWebRequest request;

        public event HMES_log onMES_log;

        public clsPQM(iVariableShare common, string URL)
        {
            _Common = common;
            this.URL = URL;
        }

        public string URL { get; private set; }

        public override string ToString()
        {
            return "MES(URL:" + URL + ")";
        }
        public void Send()
        {
            Send(transfer());
        }

        private void Send(string strSendData)
        {
            request = (HttpWebRequest)WebRequest.Create(URL);
            lock (request)
            {
                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = Encoding.UTF8.GetByteCount(strSendData);
                //request.ProtocolVersion = HttpVersion.Version10;
                byte[] bSendDataArray = Encoding.UTF8.GetBytes(strSendData);
                try
                {
                    using (Stream streamRequset = request.GetRequestStream())
                    {
                        streamRequset.Write(bSendDataArray, 0, bSendDataArray.Length);
                        streamRequset.Flush();
                        streamRequset.Close();
                    }
                    using (HttpWebResponse WebResponse = (HttpWebResponse)request.GetResponse())
                    {
                        if (WebResponse.StatusCode == HttpStatusCode.Created || WebResponse.StatusCode == HttpStatusCode.OK)
                        {
                            //Console.WriteLine(WebResponse.StatusCode);                          
                            _Common.iPQMconnectStatus = "Connected";


                            if (onMES_log != null)
                                onMES_log(this, "Send success");

                        }
                        else
                        {
                           //Console.WriteLine(WebResponse.StatusCode);
                            _Common.iPQMconnectStatus = "Disconnect";


                            //if (onMES_log != null)
                            //    onMES_log(this, "Wrong Fomat");
                            //{
                            //    _Common.bPQMFail = true; dialogResult = MessageBox.Show("URL : " + URL + ",Wrong Fomat", "PQM alarm", MessageBoxButtons.OK);
                            //    if (dialogResult == DialogResult.OK) { _Common.bPQMFail = false; }
                            //}
                        }
                    }

                }
                catch (Exception ex)
                {
                    _Common.iPQMconnectStatus = "Disconnect";


                    //if (onMES_log != null)
                    //    onMES_log(this, "Send Fail," + ex.Message);
                    //{
                    //    _Common.bPQMFail = true; dialogResult = MessageBox.Show("URL : " + URL + ",Send Fail Check and Confirm about Server," + ex.Message, "PQM alarm", MessageBoxButtons.OK);
                    //    if (dialogResult == DialogResult.OK) { _Common.bPQMFail = false; }
                    //}

                }
            }
        }
        private string transfer()
        {
            //MES_InterfaceID = _Common.Para.ReadValue("MES", "InterfaceID").ToString();
            MES_InterfaceID = _Common.iInterfaceID;
            MES_Status = Convert.ToUInt16(_Common.iPQM_Status);
            MES_StatusCode = Convert.ToString(_Common.iPQM_Status_Code);
            MES_PassQty = Convert.ToUInt16(_Common.iPQM_PassQty);
            MES_FailQty = Convert.ToUInt16(_Common.iPQM_FailQty);
            MES_ErrorCount = Convert.ToUInt16(_Common.iPQM_Error_Count);
            MES_ErrorTime = (float)_Common.iPQM_Error_Time;
            MES_CycleTime = (float)_Common.iPQM_Cycle_Time;
            MES_RunningTime = (float)_Common.iPQM_Running_Time;
            MES_WaitingTime = (float)_Common.iPQM_Waiting_Time;
            MES_SelfCheck = Convert.ToBoolean(_Common.iPQM_Self_Check);
            MES_InputQty = Convert.ToUInt16(_Common.iPQM_InputQty);


            string strSendData;

            strSendData = "[{";
            strSendData += "\"factory\":\"" + "EVSBG" + "\",";
            strSendData += "\"interfaceID\":\"" + MES_InterfaceID + "\",";
            strSendData += "\"status\":" + MES_Status + ",";
            strSendData += "\"statusCode\":\"" + MES_StatusCode + "\",";
            strSendData += "\"passQty\":" + MES_PassQty + ",";
            strSendData += "\"failQty\":" + MES_FailQty + ",";
            strSendData += "\"errorCnt\":" + MES_ErrorCount + ",";
            strSendData += "\"errorTimes\":" + MES_ErrorTime + ",";
            strSendData += "\"cycleTime\":" + MES_CycleTime + ",";
            strSendData += "\"runningTime\":" + MES_RunningTime + ",";
            strSendData += "\"waitingTime\":" + MES_WaitingTime + ",";
            strSendData += "\"selfCheck\":" + (MES_SelfCheck ? "1" : "0") + ",";
            strSendData += "\"inputQty\":" + MES_InputQty + ",";
            strSendData += "\"barcode\":\"" + "" + "\",";
            strSendData += "\"model\":\"" + "" + "\"";
            strSendData += "}]";

            return strSendData;
        }
    }
}