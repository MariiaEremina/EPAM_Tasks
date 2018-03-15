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
            LinkedListToDropOut list = new LinkedListToDropOut(100);
            int number = list.Remove;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
