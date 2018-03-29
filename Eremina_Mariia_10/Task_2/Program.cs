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
        delegate void Message(string name, DateTime time);
        static Message greetByUs;
        static Message goodByeByUs;
        public static Random random = new Random();

        static void Main(string[] args)
        {
            var employees = new List<Person>();
            employees.Add(new Person { Name = "Mary" });
            employees.Add(new Person { Name = "Kate" });
            employees.Add(new Person { Name = "Hugo" });
            employees.Add(new Person { Name = "John" });

            foreach (var person in employees)
            {
                person.Came += Arrive;
                person.Departure += Depart;
            }

            employees = Mix(employees);
            foreach (var person in employees)
            {
                person.OnCame();
            }

            employees = Mix(employees);
            foreach (var person in employees)
            {
                person.OnDeparture();
            }

            Console.ReadKey();

        }

        public static void Arrive(Person sender, TimeArgs e)
        {
            Console.WriteLine("{0} came at {1} o'clock.", sender.Name, e.time.Hour);
            greetByUs?.Invoke(sender.Name, e.time);
            greetByUs += sender.Greet;
            goodByeByUs += sender.GoodBye;
        }

        public static void Depart(Person sender, TimeArgs e)
        {
            Console.WriteLine("{0} left.", sender.Name);
            greetByUs -= sender.Greet;
            goodByeByUs -= sender.GoodBye;
            goodByeByUs?.Invoke(sender.Name, e.time);
        }

        public static List<Person> Mix(List<Person> emp)
        {
            for (int i = (emp.Count - 1); i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = emp[j];
                emp[j] = emp[i];
                emp[i] = temp;
            }
            return emp;
        }
    }
}
