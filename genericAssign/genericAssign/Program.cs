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
            Employee<string> things1 = new Employee<string>();
            things1.Things = new List<string>();

            things1.Things= "Blue";
            things1.Things.Add("Yellow");
            things1.Things.Add("Purple");
            things1.Things.Add("Red");

            Console.WriteLine(things1);

            //printer.Things<int>(100);
            //printer.Things(200);
            //printer.Things(300);
            //printer.Things(400);
            Console.ReadLine();
        }
    }
}
