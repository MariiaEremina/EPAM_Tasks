using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class MyFactorial
    {
        public static int Factorial(int i)
        {
            if (Pos(i))
            {
                return Calculating(i);
            }
            else throw new ArithmeticException();
        }
        
        private static int Calculating(int i)
        {
            int result;

            if (i == 1)
                return 1;
            result = Calculating(i - 1) * i;
            return result;
        }

        private static bool Pos (int i)
        {
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
