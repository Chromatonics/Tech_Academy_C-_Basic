using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssign2
{
    public class Optional
    {
        static public void scholar(int x, int y = 2)
                                   
        {
            int z = x + y;
            Console.WriteLine(z);
        }
    }
}
