using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Interfaces;

namespace Task4.Classes
{
    abstract public class Enemy: IMovable, IKilling, IImpassable
    {
        public int speed;

        abstract public void MoveAhead(int speed);

        public object View()
        {
            //////
            object whatInFrontOfMe;
            return whatInFrontOfMe;
        }

        public bool AmIMoving()
             
        {
            object viewObject = View();
            if (viewObject is IImpassable)
            {
                return false;
            }
            else return true;
        }

        abstract public void Turn();

        abstract public int ChooseSide();

        public int WhoIsNear()
        {
            
        }
        public void Kill(WhoIsNear)
        {
  
        }

    }
}
