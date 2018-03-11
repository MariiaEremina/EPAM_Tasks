using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanvas canvas = new ConsoleCanvas();
            //Circle circle1 = new Circle(5);
            Ring circle1 = new Ring(5, 3);
            circle1.Draw(canvas);
            Console.ReadKey();
        }
    }
}
