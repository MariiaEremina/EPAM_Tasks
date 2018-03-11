using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle: Figure
    {
        protected int x, y, r;

        public Circle()
        {
            x = y = r = 0;
        }

        public Circle(int r) : this()
        {
            this.r = r;
        }

        public virtual double GetLength
        {
            get
            {
                return 2 * Math.PI * r;
            }
        }

        //public override string ToString()
        //{
        //    return "окружность с радиусом " + r;
        //}

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(x, y, r);
        }
    }
}
