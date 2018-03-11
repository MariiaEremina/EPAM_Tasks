using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ConsoleCanvas : ICanvas
    {
        public ConsoleCanvas()
        {

        }

        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine("Отрезок с началом в координатах {0},{1}, концом в координатах {2}, {3}", x1, y1, x2, y2);
        }

        public void DrawRec(double width, double height)
        {
            if (width>height)
            {
                double i = width;
                width = height;
                height = i;
            }
            Console.WriteLine("Прямоугольник с шириной {0} и длиной{1}", width, height);
        }

        public void DrawRound(int x, int y, int r)
        {
            Console.WriteLine("Окружность с центром {0},{1}, радиус {2}", x, y, r);
        }
    }
}
