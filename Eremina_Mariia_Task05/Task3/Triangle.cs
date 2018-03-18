using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if ((sideOne+sideTwo > sideThree) && (sideTwo+sideThree > sideOne) && (sideThree+sideOne > sideTwo))
            {
                CheckLength(sideOne);
                CheckLength(sideTwo);
                CheckLength(sideThree);
                SideOne = sideOne;
                SideTwo = sideTwo;
                SideThree = sideThree;
            }
            else throw new ArgumentException("Unable to calc triangle area. Provided triangle is not triangle.");
        }

        public double SideOne { get; private set; }

        public double SideTwo { get; private set; }

        public double SideThree { get; private set; }

        public double CalcArea()
        {
            double p = CalcPer();
            double area = Math.Sqrt(p*(p-SideOne)*(p-SideTwo)*(p-SideThree));
            if (double.IsInfinity(area))
            {
                throw new OverflowException("Unable to calc triangle area. Result is too long.");
            }
            return area;
        }

        public double CalcPer()
        {
            double per = SideOne + SideTwo + SideThree;
            if (double.IsInfinity(per))
            {
                throw new OverflowException("Unable to calc triangle area. Result is too long.");
            }
            return per;
        }


        private static void CheckLength(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Unable to calc triangle area. Side length must be positive.");
            }
        }

    }
}
