using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_43__Swimming_Pool_
{
    class Pool
    {
        public static int Count = 0;
        public Location Loc { get; set; }
        public Temperature T {get; set;} 
        public Pool (Location z, Temperature temp)
        {
            Loc = z;
            T = temp;
            ++Count;
            Console.WriteLine(Count);
            Console.WriteLine(temp);
            Console.WriteLine(z);
        }
        public override string ToString()
        {
            return string.Format("Pool Count = {0}", Count);
        }
    }
}
