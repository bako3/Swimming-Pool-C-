using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//#define NumofPool 7

namespace Exercise_43__Swimming_Pool_
{
    class Program
    {
    

        static void Main(string[] args)
        {
            int zx = 0;     //current location in x-direction
            int zy = 0;     //current location in y-direction
            double nearest = 0;     //the closest distance to the current location
            Temperature t1 = new Temperature();
            Temperature t2 = new Temperature();
            Temperature t3 = new Temperature();
            Temperature t4 = new Temperature();
            Temperature t5 = new Temperature();
            Temperature t6 = new Temperature();
            Temperature t7 = new Temperature();
            Location a = new Location(4, 8);
            Location b = new Location (1, 3);
            Location c = new Location(4, 2);
            Location d = new Location(13, 1);
            Location e = new Location(12, 9);
            Location f = new Location(10, 5);
            Location g = new Location(6, 6);
            Pool A = new Pool(a, t1);
            Pool B = new Pool(b, t2);
            Pool C = new Pool(c, t3);
            Pool D = new Pool(d, t4);
            Pool E = new Pool(e, t5);
            Pool F = new Pool(f, t6);
            Pool G = new Pool(g, t7);

            for (int counter = 1; counter <= 7; counter++)
            {
                #region Finding the distances
                double d1 = Math.Sqrt((a.x - zx) * (a.x - zx) + (a.y - zy) * (a.y - zy));
                double d2 = Math.Sqrt((b.x - zx) * (b.x - zx) + (b.y - zy) * (b.y - zy));
                double d3 = Math.Sqrt((c.x - zx) * (c.x - zx) + (c.y - zy) * (c.y - zy));
                double d4 = Math.Sqrt((d.x - zx) * (d.x - zx) + (d.y - zy) * (d.y - zy));
                double d5 = Math.Sqrt((e.x - zx) * (e.x - zx) + (e.y - zy) * (e.y - zy));
                double d6 = Math.Sqrt((f.x - zx) * (f.x - zx) + (f.y - zy) * (f.y - zy));
                double d7 = Math.Sqrt((g.x - zx) * (g.x - zx) + (g.y - zy) * (g.y - zy));
                #endregion
                #region Finding the nearest
                nearest = d1;
                if (nearest > d2)
                    nearest = d2;
                if (nearest > d3)
                    nearest = d3;
                if (nearest > d4)
                    nearest = d4;
                if (nearest > d5)
                    nearest = d5;
                if (nearest > d6)
                    nearest = d6;
                if (nearest > d7)
                    nearest = d7;
                #endregion
                #region Assign new start location
                if (d1 == nearest)
                {
                    Console.WriteLine("Pool A");
                    zx = a.x;
                    zy = a.y;
                    a.x = 100;
                    a.y = 100;
                }
                if (d2 == nearest)
                {
                    Console.WriteLine("Pool B");
                    zx = b.x;
                    zy = b.y;
                    b.x = 100;
                    b.y = 100;
                }
                if (d3 == nearest)
                {
                    Console.WriteLine("Pool C");
                    zx = c.x;
                    zy = c.y;
                    c.x = 100;
                    c.y = 100;
                }
                if (d4 == nearest)
                {
                    Console.WriteLine("Pool D");
                    zx = d.x;
                    zy = d.y;
                    d.x = 100;
                    d.y = 100;
                }
                if (d5 == nearest)
                {
                    Console.WriteLine("Pool E");
                    zx = e.x;
                    zy = e.y;
                    e.x = 100;
                    e.y = 100;
                }
                if (d6 == nearest)
                {
                    Console.WriteLine("Pool F");
                    zx = f.x;
                    zy = f.y;
                    f.x = 100;
                    f.y = 100;
                }
                if (d7 == nearest)
                {
                    Console.WriteLine("Pool G");
                    zx = g.x;
                    zy = g.y;
                    g.x = 100;
                    g.y = 100;
                }
                #endregion

            }
        }
    }
}


//if the location is changed to 100, that means it is has been visited