using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace overloadEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.Id = 4;
            sample.SayName();

            Employee five = new Employee();
            five.FirstName = "Bob";
            five.LastName = "Boberson";
            five.Id = 5;
            five.SayName();

            Console.WriteLine(sample.Id == five.Id);
            Console.ReadLine();
        }

        //public static equalID(Person Id)
        //{

        //}
    }
}
