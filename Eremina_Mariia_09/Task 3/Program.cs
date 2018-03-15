using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args[0];

            if (File.Exists(path))
            {
                string allString = File.ReadAllText(path);
                if (allString.Length != 0)
                {
                    Dictionary<string, int> dic = new Dictionary<string, int>();
                    Operations(allString, dic);
                    foreach (var x in dic.OrderBy(x => x.Key))
                    {
                        Console.WriteLine("<{0}> - <{1}>", x.Key, x.Value);
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

        public static void Operations (string allString, Dictionary<string, int> dic)
        {
            string[] words = MakeArr(allString);
            for (int i = 0; i<words.Length; i++)
            {
                if (dic.ContainsKey(words[i]))
                {
                    dic[words[i]]++; 
                }
                else
                {
                    dic.Add(words[i], 1);
                }
            }
        }

        public static string [] MakeArr (string allString)
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
