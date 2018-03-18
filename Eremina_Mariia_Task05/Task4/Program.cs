using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s1 = new MyString("string21");
            MyString s2 = new MyString("string2");
            MyString s3 = s1 - s2;
            string s = s3.ToString();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
