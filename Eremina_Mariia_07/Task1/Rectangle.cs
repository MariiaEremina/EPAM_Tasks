using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Figure
    {
        protected double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return width * height;
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Это прямоугольник со сторонами {0} и {1}", width, height);
        //}

        public override void Draw(ICanvas canvas)
        {
            canvas.DrawRec(width, height);
            
        }
    }
}
