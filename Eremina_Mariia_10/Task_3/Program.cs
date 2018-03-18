using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        public delegate bool Operation(string str1, string str2);
        //public delegate void SortOp(string[] arr, Operation action);
        public delegate void SortOp(string[] arr, Operation action);
        static readonly object locker = new object();



        static void Main(string[] args)
        {
            string path = args[0];

            if (File.Exists(path))
            {
                string allString = File.ReadAllText(path);
                if (allString.Length != 0)
                {
                    //Action callback1 = () => Finish("Thread finished");
                    string[] words = MakeArr(allString);
                    //Sort(words, Compare);


                    //SortOnThread(words, Sort, callback1);
                    SortOnThread(words, Sort);

                    //for (int i = 0; i < 100; i++)
                    //{
                    //    Console.WriteLine("00000000000000000000000000");

                    //}

                    //foreach (var x in words)
                    //{
                    //    Console.WriteLine(x);
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
        //static void Fini(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //public static void SortOnThread(string[] words, SortOp Sort, Action callback)
        public static void SortOnThread(string[] words, SortOp Sort)
        {
            Thread th1 = new Thread(() =>
            {
                Sort(words, Compare);
                //foreach (var x in words)
                //{
                //    Console.WriteLine(x);
                   
                //}
                MyEvent finish = new MyEvent();
                Handler handler = new Handler();
                finish.onFinish += handler.Message;
                finish.Finish();
                //callback();


            });
            th1.Start();
        }

        public static void Sort(string[] arr, Operation action)
        {
            lock (locker)
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

        public static bool Compare(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            else if (str1.Length == str2.Length)
            {
                int i = str1[0].CompareTo(str2[0]);
                if (i > 0)
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
