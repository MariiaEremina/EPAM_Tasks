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
                string allText = File.ReadAllText(path);
                if (!(String.IsNullOrEmpty(allText)))
                {
                    //var wordsDictionary = FillWithCountedWords(allText);
                    WordsCounter wordsCounter = new WordsCounter(allText);
                    Console.WriteLine(wordsCounter.GetKeyWords());

                    //foreach (var x in wordsDictionary.OrderBy(x => x.Key))
                    //{
                    //    Console.WriteLine("<{0}> - <{1}>", x.Key, x.Value);
                    //}
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

        //public static Dictionary<string, int> FillWithCountedWords (string allText)
        //{
        //    Dictionary<string, int> localWordsDictionary = new Dictionary<string, int>();
        //    string[] words = MakeArr(allText);
        //    for (int i = 0; i<words.Length; i++)
        //    {
        //        if (localWordsDictionary.ContainsKey(words[i]))
        //        {
        //            localWordsDictionary[words[i]]++; 
        //        }
        //        else
        //        {
        //            localWordsDictionary.Add(words[i], 1);
        //        }
        //    }
        //    return localWordsDictionary;
        //}

        //public static string [] MakeArr (string allText)
        //{
        //    allText = allText.ToLower();
        //    string pattern = @"[\p{P}||\r+||\n||\p{Pd}]";
        //    string replacement = " ";
        //    string result = Regex.Replace(allText, pattern, replacement);
        //    string[] words = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    return words;
        //}
    }
}
