using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_43__Swimming_Pool_
{
    class Location
    {
        public int x;
        public int y;
        public Location()
        {
            x = 0;
            y = 0;
        }
        public Location(int a, int b)
        {
            x = a;
            y = b;
        }
        public override string ToString()
        {
            return string.Format("Location:\n X:{0}\n Y:{1}\n", x, y);
        }
    }
}
