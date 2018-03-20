using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = MyFactorial.Factorial(6);
            double elevation = MyElevation.Elevation(5,3);
            double elevation1 = MyElevation.Elevation(2, -8);
            double elevation2 = MyElevation.Elevation(3, 0);
            Console.WriteLine(factorial);
            Console.WriteLine(elevation);
            Console.WriteLine(elevation1);
            Console.WriteLine(elevation2);
            Console.ReadKey();
        }
    }
}
