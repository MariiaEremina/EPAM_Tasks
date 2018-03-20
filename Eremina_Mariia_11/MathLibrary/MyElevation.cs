using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class MyElevation
    {
        public static double Elevation (int number, int index)
        {
            if (index== 0)
            {
                return 1;
            }
            else 
            {
                double result = 1;
                for (int i=0; i<Math.Abs(index); i++)
                {
                    result = result * number;
                }
                if (index > 0)
                {
                    return result;
                }
                else
                {
                    result = 1 / result;
                    return result;
                }
            }
            
           
        }
    }
}
