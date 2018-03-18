using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    //public enum Names { Mary, Kate, Hugo, John };

    class Program
    {
        private static object syncLock = new object();
        public static int[] arr = new int[1];

        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Mary" };
            Person person2 = new Person { Name = "Kate" };
            Person person3 = new Person { Name = "Hugo" };
            Person person4 = new Person { Name = "John" };

            Queue(person1, person2, person3, person4);

            Thread th1 = new Thread(() => Run(1));
            th1.Start();

            Thread th2 = new Thread(() =>
           {
               Thread.Sleep(5);
               person1.OnCame();
               Thread.Sleep(15);
               person2.OnCame();
               Thread.Sleep(10);
               person3.OnCame();
               Thread.Sleep(15);
               person4.OnCame();
               Thread.Sleep(15);
               Console.WriteLine();
               person1.OnDeparture();
               person2.OnDeparture();
               person3.OnDeparture();
               person4.OnDeparture();
           });
            th2.Start();


            Console.ReadKey();

        }

        static void Run(int count)
        {
            lock (syncLock)
            {
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < 24; j++)
                    {
                        arr[0] = j;
                        Thread.Sleep(3);
                    }
                }
            }
        }

        static void Queue(Person person1, Person person2, Person person3, Person person4)
        {
            person2.Came += person1.Greet;

            person3.Came += person1.Greet;
            person3.Came += person2.Greet;

            person4.Came += person1.Greet;
            person4.Came += person2.Greet;
            person4.Came += person3.Greet;

            person1.Departure += person2.GoodBye;
            person1.Departure += person3.GoodBye;
            person1.Departure += person4.GoodBye;

            person2.Departure += person3.GoodBye;
            person2.Departure += person4.GoodBye;

            person3.Departure += person4.GoodBye;
        }
    }
}
