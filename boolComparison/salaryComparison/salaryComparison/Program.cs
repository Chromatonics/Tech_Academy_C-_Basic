using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
           
            Console.WriteLine("Enter Hourly Rate:");
            int wage1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hours Worked:");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");

            Console.WriteLine("Enter Hourly Rate:");
            int wage2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hours Worked:");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1");
            int salary1 = wage1 * hours1 * 52;
            Console.WriteLine(salary1);
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2");
            int salary2 = wage2 * hours2 * 52;
            Console.WriteLine(salary2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more than person 2?");
            bool compare = salary1 > salary2;
            Console.WriteLine(compare);
            Console.ReadLine();

        }
    }
}

