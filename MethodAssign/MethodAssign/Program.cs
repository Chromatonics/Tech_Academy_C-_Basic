using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class math
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Picka number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            int r;
            int s;
            int t;
            calculate n = new calculate();

            r = n.divideNum(a, b);
            Console.WriteLine( a + " divided by " + b + " equals " + r);
            Console.ReadLine();

            s = n.multiplyNum(a, b);
            Console.WriteLine(a + " multiplied by " + b + " equals " + s);
            Console.ReadLine();

            t = n.addNum(a, b);
            Console.WriteLine(a + " added to " + b + " equals " + t);
            Console.ReadLine();
        }
    }
}
