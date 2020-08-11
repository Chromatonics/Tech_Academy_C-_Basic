using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericAssign 
{
    class Employee
    {
        public void Things<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
