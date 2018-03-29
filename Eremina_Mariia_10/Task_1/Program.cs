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
        

        static void Main(string[] args)
        {
            string path = args[0];

            if (File.Exists(path))
            {
                string allText = File.ReadAllText(path);
                if (!(String.IsNullOrEmpty(allText)))
                {
                    string[] words = MakeArr(allText);
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

        public static void Sort(string[] arr, Func <string, string, int> compare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (compare(arr[j], arr[j + 1])>0)
                    {
                        string tmpString = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmpString;
                    }
                }
            }
        }

        public static int Compare (string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return 1;
            }
            else if (str1.Length == str2.Length)
            {
                int i = 0;
                int k = 0;
                while (i == 0 && k < str1.Length)
                {
                    i = str1[k].CompareTo(str2[k]);
                    k++;
                }
               
                return i;
            }
            else
            {
                return 0;
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
