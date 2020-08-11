using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee printer = new Employee();

            printer.Things<string>("Blue");
            printer.Things("Yellow");
            printer.Things("Purple");
            printer.Things("Red");

            printer.Things<int>(100);
            printer.Things(200);
            printer.Things(300);
            printer.Things(400);
            Console.ReadLine();
        }
    }
}
