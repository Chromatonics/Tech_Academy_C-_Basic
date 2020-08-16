using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssign1
{
    class Triplet
    {
        public int Math(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public double Math(double a, double b)
        {
            double sub = a - b;
            return sub;
        }

        public int Math(string c)
        {
            int d = Convert.ToInt32(c);
            int pro = d * 3;
            return pro;
        }

    }
}
