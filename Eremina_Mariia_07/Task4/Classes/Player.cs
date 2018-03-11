using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Interfaces;

namespace Task4.Classes
{
    public class Player : IMovable, IMortal
    {
        public object View ()
        {
            ///////
            object whatInFrontOfMe;
            return whatInFrontOfMe;
        }

        public void MoveAhead(int speed)
        {

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

        public void Turn()
        {

        }

        public int ChooseSide()
        {
            
        }

        public bool AmIAlive()
        {
            
        }

        public void Die()
        {

        }

        public int[] HowMuchBonuses()
        {

        }

        public bool IsWin()
        {
            return false;
        }
    }
}
