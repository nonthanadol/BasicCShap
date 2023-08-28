using System;

namespace Tutorial.Interface
{
    class VarShare
    {
        public string _varShare = "Test";
       
        string value;
       
        public string GetValue(int value)
        {
            string txt;
            if (value == 1)
            {
                txt = "ture";
                this.value = "TURE";
            }
            else
            {
                txt = "False";
                this.value = "FALSE";
            }
            return txt+value+this.value;
        }

    }
}