using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Circle
    {
        protected int InnerR;

        public Ring()
        {
        }

        public Ring(int r, int ir) : base(r)
        {
            InnerR = ir;
        }

        public override double GetLength
        {
            get
            {
                return base.GetLength + 2 * Math.PI * InnerR;
            }
        }

        //public override string ToString()
        //{
        //    return "кольцо с внутренним радиусом " + InnerR;
        //}

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRound(x, y, r);
            canvas.DrawRound(x, y, InnerR);
        }
    }
}
