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
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\DotNetCourse\DotNetCourse\12 - Работа с файловой системой");

            string filePath = Path.Combine(dir.FullName, "disposable_task_file.txt");

            FileInfo file = new FileInfo(filePath);
            string fileContent;

            //using (StreamReader sr = file.OpenText())
            //{
            //    fileContent = sr.ReadToEnd();

            //}

            //string[] stringArr = MakeArr(fileContent);
            //int[] squareArr = Square(stringArr);

            //using (StreamWriter sw = file.AppendText())
            //{
            //    foreach (int num in squareArr)
            //    {
            //        sw.WriteLine(num);
            //    }

            //}


            using (FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {

                StreamReader sr = new StreamReader(fs);
                
                    fileContent = sr.ReadToEnd();

                

                string[] stringArr = MakeArr(fileContent);
                int[] squareArr = Square(stringArr);

                fs.Seek(0, SeekOrigin.Begin);
                StreamWriter sw = new StreamWriter(fs);

                foreach (int num in squareArr)
                    {
                        sw.WriteLine(num);
                    }
                sw.Close();

                
            }
        }

        static string[] MakeArr(string sr)
        {
            string pattern = @"(\D)";
            string replacement = " ";
            string result = Regex.Replace(sr, pattern, replacement);
            string[] arr = sr.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
            return arr;
        }

        static int [] Square (string[] arr)
        {
            int[] sq = new int[(arr.Length)];
            for (int i=0; i<arr.Length; i++)
            {
                int number = Int32.Parse(arr[i]);
                sq[i] = number * number;
            }
            return sq;
        }

    }
}
