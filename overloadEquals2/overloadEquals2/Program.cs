using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEquals2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employeeA = new Person();
            employeeA.FirstName = "Mark";
            employeeA.LastName = "Bobert";
            employeeA.Id = 3;

            Person employeeB = new Person();
            employeeB.FirstName = "Mark";
            employeeB.LastName = "Bobert";
            employeeB.Id = 3;

            Employee employee = new Employee();
            employee.Comparison1(employeeA, employeeB);
            Console.ReadLine();
        }
    }
}
