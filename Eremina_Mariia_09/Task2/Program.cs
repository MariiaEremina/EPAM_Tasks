using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> arr = new DynamicArray<int> ();
            int i = 0;
            foreach (int num in arr)
            {
                i++;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
