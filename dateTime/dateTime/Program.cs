using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine(localDate);
            Console.ReadLine();

            Console.WriteLine("Enter a number ");
            string value1 = Console.ReadLine();
            int value2 = Convert.ToInt32(value1);

            DateTime dt2 = localDate.AddHours(value2);
            Console.WriteLine(dt2);
            Console.ReadLine();
        }
    }
}
