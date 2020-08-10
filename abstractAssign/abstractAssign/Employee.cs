using System;
using System.Collections.Generic;
using System.Text;

namespace abstractAssign
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
    }
}
