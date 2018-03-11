using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Classes;
using Task3.Interfaces;

namespace Task3
{
    class Program
    {
        static void Main()
        {

            IIndexableSeries progression = new ArithmeticalProgression(2, 2);
			Console.WriteLine("Progression:");
			PrintSeries(progression);
            Console.WriteLine("Index 1: ");
            PrintIndex(progression,1);

            IIndexableSeries list = new List(new double[] { 5, 8, 6, 3, 1 });
			Console.WriteLine("List:");
			PrintSeries(list);
            Console.WriteLine("Index 2: ");
            PrintIndex(list, 2);
            Console.ReadKey();
		}

		static void PrintSeries(IIndexableSeries series)
		{
			series.Reset();

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(series.GetCurrent());
				series.MoveNext();
			}
		}
        static void PrintIndex(IIndexableSeries series,int index)
        {
                Console.WriteLine(series[index]);
            
        }

    }
}
