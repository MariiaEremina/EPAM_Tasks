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
            int[] numberArr = new int[] {1,2,3,4,5,6,7,8,9 };
            DynamicArray<int> testArr = new DynamicArray<int>(numberArr);
            Console.WriteLine(testArr.ForPrint());
            testArr.Add(15);
            Console.WriteLine(testArr.ForPrint());
            //testArr.AddRange(numberArr);
            //Console.WriteLine(testArr.ForPrint());
            testArr.Remove(0);
            Console.WriteLine(testArr.ForPrint());
            testArr.Remove(6);
            Console.WriteLine(testArr.ForPrint());
            testArr.Remove(testArr.Length - 1);
            Console.WriteLine(testArr.ForPrint());
            testArr.Insert(0, 88);
            Console.WriteLine(testArr.ForPrint());
            testArr.Insert(6, 88);
            Console.WriteLine(testArr.ForPrint());
            testArr.Insert(testArr.Length, 88);
            Console.WriteLine(testArr.ForPrint());
            Console.ReadKey();
        }
    }
}
