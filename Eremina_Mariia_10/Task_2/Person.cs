using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task_2

{
    public delegate void EventHandler (Person sender, TimeArgs e);

    public class Person
    {
        public string Name { get; set; }

        public void Greet(string anotherPerson, DateTime time)
        {
            if (time.Hour<6 || time.Hour>22)
            {
                Console.Write("'Seriously!? Go home, ");
            }
            else if (time.Hour < 11)
            {
                Console.Write("'Good morning, ");
            }
            else if (time.Hour < 16)
            {
                Console.Write("'Good afternoon, ");
            }
            else 
            {
                Console.Write("'Good evening, ");
            }

            Console.WriteLine(" {0}!', {1} said.", anotherPerson, Name);
        }

        public void GoodBye(string anotherPerson, DateTime time)
        {
            Console.WriteLine("Goodbye, {0}!', {1} said.", anotherPerson, Name);
        }

        public event EventHandler Came;

        public void OnCame()
        {
            Came?.Invoke(this, new TimeArgs());
        }

        public event EventHandler Departure;

        public void OnDeparture()
        {
            Departure?.Invoke(this, new TimeArgs());
        }
    }
}




