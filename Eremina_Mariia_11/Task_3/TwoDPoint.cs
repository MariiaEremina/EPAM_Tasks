using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class TwoDPoint
    {
        public readonly int x, y;

        public TwoDPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            TwoDPoint p = obj as TwoDPoint;
            if ((Object)p == null)
            {
                return false;
            }
            return (x == p.x) && (y == p.y);
        }

        public bool Equals(TwoDPoint p)
        {
			if ((object)p == null)
            {
                return false;
            }
			return (x == p.x) && (y == p.y);
        }

        public static bool operator ==(TwoDPoint a, TwoDPoint b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(TwoDPoint a, TwoDPoint b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return string.Format("x:{0} y:{1}", x, y);
        }
    }
}
