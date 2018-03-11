using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Interfaces
{
    interface IMovable
    {
        void MoveAhead(int speed);
        bool AmIMoving();
        void Turn();
        int ChooseSide();
    }
}
