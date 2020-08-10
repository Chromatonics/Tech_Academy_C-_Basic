using System;
using System.Collections.Generic;
using System.Text;

namespace assignment169
{
    public class Integer
    {
        public void Divide()
        {
            Console.WriteLine("Enter Number: ");
            string yourNum = Console.ReadLine();
            long yNum = Convert.ToInt32(yourNum);
            long yourProduct = yNum / 2;
            Console.WriteLine(yourProduct);
        }
    }
}
