using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triplet addition = new Triplet();
            int sum1 = addition.Math(8, 17);
            Console.WriteLine(sum1);

            Triplet subtraction = new Triplet();
            double sub1 = subtraction.Math(2.78, 2.08);
            Console.WriteLine(sub1);

            Triplet product = new Triplet();
            int pro1 = product.Math("4");
            Console.WriteLine(pro1);

            Console.ReadLine();
        }
    }
}
