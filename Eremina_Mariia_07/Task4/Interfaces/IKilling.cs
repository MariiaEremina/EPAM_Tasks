using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Interfaces
{
    interface IKilling
    {
        int WhoIsNear();
        void Kill(WhoIsNear);
    }
}
