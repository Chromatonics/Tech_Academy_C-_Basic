using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadEquals2
{
    public class Employee : Person
    {
        public void Comparison1(Person employee1, Person employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("These are the same employee");
            }
        }

        
    }
}
