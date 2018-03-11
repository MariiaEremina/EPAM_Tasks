using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface ICanvas
    {
        void DrawRound(int x, int y, int r);
        void DrawRec(double width, double height);
        void DrawLine(int x1, int y1, int x2, int x3);
    }
}
