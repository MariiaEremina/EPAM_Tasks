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
            string name = Console.ReadLine();
            string lName = Console.ReadLine();
            string fName = Console.ReadLine();
            if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
            {
                User one = new User(name, lName, fName, date);
                Console.WriteLine (one);
            }
            else throw new FormatException ("No date");
            Console.ReadKey();
        }
    }
}
