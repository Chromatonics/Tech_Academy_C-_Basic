using System;
using System.Collections.Generic;
using System.Text;

namespace abstractAssign
{
    public class Employee : Person , IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("Welcome New Worker!");
        }
    }
}
