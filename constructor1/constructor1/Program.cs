using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int X = 0;

            var variation = "This is a variable";

            Constructor dayDay = new Constructor(1);
            Console.WriteLine(dayDay);
            Console.ReadLine();

            Constructor dayMonth = new Constructor(3, 6);
            Console.WriteLine(dayMonth);
            Console.ReadLine();

            Constructor daymonthY = new Constructor(23, 8, 2000);
            Console.WriteLine(daymonthY);
            Console.ReadLine();

        }
    }
}


