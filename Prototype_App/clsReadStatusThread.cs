using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_App
{
    class clsReadStatusThread
    {
        private MainForm _mainForm;
        private clsPLC _clsplc;
        iVariableShare _Common = new iVariableShare();
        
        public clsReadStatusThread(iVariableShare common) 
        {
            _Common = common;
            _clsplc = new clsPLC(_Common);
            _mainForm = new MainForm();

        }

    }
}