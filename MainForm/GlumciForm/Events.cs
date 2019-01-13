using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.GlumciForm
{
    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(int labelNumber,string text)
        {
            this.Arg = labelNumber;     //Lolads commands
            this.Value = text;          //Set value for label.Text
        }

        private int arg;
        public int Arg
        {
            get { return arg; }
            private set
            {
                if(value <= 6 && value >= 0 )   //Label controller uses values from 1-6
                {
                    arg = value;
                }
            }
        }

        private string value;
        public string Value
        {
            get { return value; }
            private set
            { 
                if (Arg <= 6 && Arg >= 0)   //Label controller uses values from 1-6
                {
                    this.value = value;
                }
            }
        }
    }
}
