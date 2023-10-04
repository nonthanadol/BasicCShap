//using Prototype_App_PQM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_App
{
    public class iVariableShare
    {
        public string iPQMconnectStatus { get; set; }
        public string iPLCconnectStatus { get; set; }
        public int iPQM_Status { get; set; }
        public string iPQM_Status_Code { get; set; }
        public int iPQM_PassQty { get; set; }
        public int iPQM_FailQty { get; set; }
        public int iPQM_Error_Count { get; set; }
        public uint iPQM_Error_Time { get; set; }
        public uint iPQM_Cycle_Time { get; set; }
        public uint iPQM_Running_Time { get; set; }
        public uint iPQM_Waiting_Time { get; set; }
        public int iPQM_Self_Check { get; set; }
        //public string iPQM_InputQty { get; set; }            
        public string iPQM_Barcode { get; set; }

        public string iPQM_InputQty = null;

        public string iInterfaceID = Properties.Settings.Default.InterfaceID;
       


    }


}