using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class MyEvent
    {
        public delegate void Method();
        public event Method onFinish;

        public void Finish()
        {
            onFinish();
        }
    }
}
