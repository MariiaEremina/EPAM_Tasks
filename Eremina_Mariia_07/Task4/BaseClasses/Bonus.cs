using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4.Interfaces;

namespace Task4.BaseClasses
{
    abstract public class Bonus: IMortal
    {
        protected  int howMuchGives;
        protected int whatTypeGives;

        public bool AmIAlive()
        {
            
        }
        public  void Die()
        {

        }
        public int WhoKilledMe()
        {
           
        }

        public void GivePrize(int howMuchGives, int whatTypeGives)
        {
            if (WhoKilledMe()==Player.Number)
            {

            }
        }
    }
}
