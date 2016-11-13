using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_43__Swimming_Pool_
{
    class Temperature
    {
        public int degree = 0;
        public string scale = "F";
        Random random_temp = new Random();
        public Temperature()
        {
            degree = random_temp.Next(98, 104);
        }
        public override string ToString()
        {
            return string.Format("Temperature: {0} F", degree);
        }
   }
}
