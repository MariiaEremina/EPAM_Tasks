using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class TimeArgs : EventArgs
    {
        public DateTime time { get; }

        public TimeArgs()
        {
            time = DateTime.Now;
        }
    }
}
