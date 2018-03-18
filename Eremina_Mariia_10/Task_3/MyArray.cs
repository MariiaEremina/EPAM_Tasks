using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    class MyArray
    {
        public delegate bool Operation(string str1, string str2);
        //public delegate void SortOp(string[] arr, Operation action);
        public delegate void SortOp(string[] arr, Operation action);
        static readonly object locker = new object();

        private string[] words;

        public MyArray(string[] arr)
            {
            words = Words;
            }

        public string[] Words
        {
            set
            {
                words = value;
            }
            get
            {
                return words;
            }
        }

        //public static void SortOnThread(string[] words, SortOp Sort, Action callback)
        public void SortOnThread(SortOp Sort)
        {
            Thread th1 = new Thread(() =>
            {
                Sort(words, Compare);
                foreach (var x in words)
                {
                    Console.WriteLine(x);
                }
                //callback();


            });
            th1.Start();
        }

        public void Sort(string[] arr, Operation action)
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

    }
}
