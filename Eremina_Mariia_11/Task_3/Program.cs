using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash p1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash p2 = new TwoDPointWithHash(10, 10);
            TwoDPointWithHash p3 = new TwoDPointWithHash(1, 10);
            TwoDPointWithHash p4 = new TwoDPointWithHash(10, 1);
            TwoDPointWithHash p5 = new TwoDPointWithHash(1, 2);
            TwoDPointWithHash p6 = new TwoDPointWithHash(1, 1);
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine(p4.GetHashCode());
            Console.WriteLine(p5.GetHashCode());
            Console.WriteLine(p6.GetHashCode());
            Console.ReadKey();
        }
    }
}
