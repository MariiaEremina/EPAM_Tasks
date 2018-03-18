using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        public delegate bool Operation(string str1, string str2);

        static void Main(string[] args)
        {
            string path = args[0];

            if (File.Exists(path))
            {
                string allString = File.ReadAllText(path);
                if (allString.Length != 0)
                {
                    string[] words = MakeArr(allString);
                    Sort(words, Compare);

                    foreach (var x in words)
                    {
                        Console.WriteLine(x);
                    }
                }
                else
                {
                    Console.WriteLine("Файл пуст");
                }
            }
            else
            {
                Console.WriteLine("Файл не существует");
            }
            Console.ReadKey();
        }

        public static void Sort(string[] arr, Operation action)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (action(arr[j], arr[j + 1]))
                    {
                        string s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
            }
        }

        public static bool Compare (string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            else if (str1.Length == str2.Length)
            {
                int i = str1[0].CompareTo(str2[0]);
                if (i>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static string[] MakeArr(string allString)
        {
            allString = allString.ToLower();
            string pattern = @"[\p{P}||\r+||\n||\p{Pd}]";
            string replacement = " ";
            string result = Regex.Replace(allString, pattern, replacement);
            string[] words = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

       
    }
}
