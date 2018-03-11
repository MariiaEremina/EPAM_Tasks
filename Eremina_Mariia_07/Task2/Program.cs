using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число: ");
            double start = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            double step = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ваша прогрессия: ");
            GeometricProgression series = new GeometricProgression(start, step);
            PrintSeries(series);
            Console.ReadKey();
        }
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }
}
