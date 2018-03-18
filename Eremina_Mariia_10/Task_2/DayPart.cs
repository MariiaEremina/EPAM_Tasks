using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public delegate void OperationDelegate();

    static class DayPart
    {
        public delegate void OperationDelegate();

        static OperationDelegate MorningGreeting = new OperationDelegate(Morning);
        static OperationDelegate DayGreeting = new OperationDelegate(Day);
        static OperationDelegate EveningGreeting = new OperationDelegate(Evening);

        private static Dictionary<int, OperationDelegate> operations=
             new Dictionary<int, OperationDelegate>
                {
            { 4, MorningGreeting},
            { 5, MorningGreeting},
            { 6, MorningGreeting},
            { 7, MorningGreeting},
            { 8, MorningGreeting},
            { 9, MorningGreeting},
            { 10, MorningGreeting},
            { 11, MorningGreeting},
            { 12, DayGreeting},
            { 13, DayGreeting},
            { 14, DayGreeting},
            { 15, DayGreeting},
            { 16, DayGreeting},
            { 17, DayGreeting},
            { 18, EveningGreeting},
            { 19, EveningGreeting},
            { 20, EveningGreeting},
            { 21, EveningGreeting},
            { 22, EveningGreeting},
            { 23, EveningGreeting},
            { 0, EveningGreeting},
            { 1, EveningGreeting},
            { 2, EveningGreeting},
            { 3, EveningGreeting},
                };



        //private void SayHelloDictionary()
        //{
           
        //    operations =
        //        new Dictionary<int, OperationDelegate>
        //        {
        //    { 4, MorningGreeting},
        //    { 5, MorningGreeting},
        //    { 6, MorningGreeting},
        //    { 7, MorningGreeting},
        //    { 8, MorningGreeting},
        //    { 9, MorningGreeting},
        //    { 10, MorningGreeting},
        //    { 11, MorningGreeting},
        //    { 12, DayGreeting},
        //    { 13, DayGreeting},
        //    { 14, DayGreeting},
        //    { 15, DayGreeting},
        //    { 16, DayGreeting},
        //    { 17, DayGreeting},
        //    { 18, EveningGreeting},
        //    { 19, EveningGreeting},
        //    { 20, EveningGreeting},
        //    { 21, EveningGreeting},
        //    { 22, EveningGreeting},
        //    { 23, EveningGreeting},
        //    { 0, EveningGreeting},
        //    { 1, EveningGreeting},
        //    { 2, EveningGreeting},
        //    { 3, EveningGreeting},
        //        };
        //}

        public static OperationDelegate SayHello (int time)
        {
            //if (operations.ContainsKey(time))
            //{
                return operations[time];
            //}
            //else throw new Exception();
        }

        private static void Morning ()
        {
            Console.Write("Good morning,");
        }

        private static void Day()
        {
            Console.Write("Hello,");
        }

        private static void Evening()
        {
            Console.Write("Good evening,");
        }

        public static void PerformOperation(int op, OperationDelegate operation)
        {
            if (operations.ContainsKey(op))
            {
                operations[op] = operation;
            }
        }
    }
}
