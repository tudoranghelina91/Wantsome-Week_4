using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalcDistance(Point p)
        {
            return Math.Sqrt((p.x - this.x) * (p.x - this.x) *
                             (p.y - this.y) * (p.y - this.y));
        }
    }
}
