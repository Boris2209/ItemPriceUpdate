using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemPriceUpdate
{
    public class Log
    {
        private TextBox logTextBox;
        public Log(TextBox logTextBox) 
        {
            this.logTextBox = logTextBox;
        }

        public void Add(string message) 
        {
            logTextBox.Text += (DateTime.Now + " " + message + "\r\n");
        }
    }
}
