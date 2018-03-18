using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task_2

{

    public delegate void Message(string name);
    public delegate void Arrive(string name);
    public delegate void Hello();

    public class Person
    {
        public string Name { get; set; }

        public void Greet(string anotherPerson)
        {
            Console.Write ("'");
            DayPart.OperationDelegate hallo = DayPart.SayHello(Program.arr[0]);
            hallo();
           
            Console.WriteLine(" {0}!', {1} said.", anotherPerson, Name);
        }

        public void GoodBye(string anotherPerson)
        {
            
            Console.WriteLine("Goodbye, {0}!', {1} said.", anotherPerson, Name);
        }

        public void Arrival (int time)
        {
            Console.WriteLine("{0} hours, {1} came.", time, Name);
        }

        public void Depart()
        {
            Console.WriteLine("{0} goes home.", Name);
        }

        public event Message Came;
        
        public void OnCame()
        {
            //DateTime date = DateTime.Now;
            //int i = date.Hour;
            //Arrival(i);

            Arrival(Program.arr[0]);
            if (Came != null)
            {
                Came(Name);
                
            }
            Console.WriteLine();
        }

        public event Message Departure;

        public void OnDeparture()
        {
            Depart();
            if (Departure != null)
            {
                Departure(Name);

            }
            Console.WriteLine();
        }

        //public Person()
        //{
        //    Task.Factory.StartNew(() => {
        //        Thread.Sleep(5000);
        //        OnCame();
        //    });
        //}
    }


}




