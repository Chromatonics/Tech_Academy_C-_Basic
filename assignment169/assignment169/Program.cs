using System;
using System.Security.Cryptography.X509Certificates;

namespace assignment169
{
    class Program
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Integer divi = new Integer();
            divi.Divide();
            Console.ReadLine();

            NumberManipulator n = new NumberManipulator();
            int a = 100;
            n.getValue(out a);
            Console.WriteLine("Value of: {0}", a);
            Console.ReadLine();

            int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
        }
    }
}
