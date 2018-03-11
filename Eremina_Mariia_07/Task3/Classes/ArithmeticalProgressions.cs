using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Classes
{
    public class ArithmeticalProgression : IIndexableSeries
    {
        double start, step;
        int currentIndex;

        public ArithmeticalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 0;
        }

        public double GetCurrent()
        {
            return start + step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 0;
        }

        public double this[int index]
		{
			get
			{
				return start + step * index;
			}
		}
    }
}
