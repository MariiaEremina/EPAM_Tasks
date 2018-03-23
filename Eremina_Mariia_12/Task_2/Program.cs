using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main()
        {

            DirectoryInfo dir = new DirectoryInfo(@"folder");
            var i="0";
            while (!(i == "1" || i == "2"))
            {
                Console.WriteLine("Нажмите 1, чтобы войти в режим наблюдения, 2, чтобы войти в режим отката изменений.");
                i = Console.ReadLine();
            }
            if (i=="1")
            {
                Control();
                string final;
                do
                {
                    final = Console.ReadLine();
                }
                while (final != "x");
            }
            else
            {
                Console.WriteLine("Список созданных папок: ");
                foreach (string d1 in Directory.GetDirectories(@"backup"))
                {
                    Console.WriteLine(d1.Substring(7));
                }
                Console.WriteLine("Скопируйте желаемые дату и время: ");
                string date = Console.ReadLine();
                Directory.Delete(@"folder", true); 
                Directory.CreateDirectory(@"folder");
                string datepath = $"backup\\{date}";
                CopyDir(datepath, @"folder");
                Console.ReadKey();
            }
           
        }

        public static void Control()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"folder";
            watcher.IncludeSubdirectories = true;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            //watcher.Created += new FileSystemEventHandler(OnChanged);
            //watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string name = DateTime.Now.ToString();
            name = name.Replace(":", "-");
            string path = "backup"+"\\" + name;
            CopyDir(@"folder", path);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            string name = DateTime.Now.ToString();
            name = name.Replace(":", "-");
            string path = "backup" + "\\" + name;
            CopyDir(@"folder", path);
        }

        //private static void OnRenamed(object source, RenamedEventArgs e)
        //{
        //    Thread.Sleep(5);
        //    string name = DateTime.Now.ToString();
        //    name = name.Replace(":", "-");
        //    string path = "backup" + "\\" + name;
        //    CopyDir(@"folder", path);
        //}

        static void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + "\\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + "\\" + Path.GetFileName(s));
            }
        }
    }
}
