using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathematics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Number:");
            string yourNum = Console.ReadLine();
            long yNum = Convert.ToInt32(yourNum);
            long yourProduct = yNum * 50;
            Console.WriteLine(yourProduct);
            Console.ReadLine();

            Console.WriteLine("Enter Number:");
            string twoNum = Console.ReadLine();
            int tNum = Convert.ToInt32(twoNum);
            int yourSum = tNum + 25;
            Console.WriteLine(yourSum);
            Console.ReadLine();

            Console.WriteLine("Enter Number:");
            string threeNum = Console.ReadLine();
            decimal thNum = Convert.ToDecimal(threeNum);
            decimal thNum2 = 12.5m;
            decimal yourDiv = Decimal.Divide(thNum, thNum2);
            Console.WriteLine(yourDiv);
            Console.ReadLine();

            Console.WriteLine("Enter Number:");
            string fourNum = Console.ReadLine();
            int fNum = Convert.ToInt32(fourNum);
            bool yourBool = (fNum > 50);
            Console.WriteLine(yourBool);
            Console.ReadLine();

            Console.WriteLine("Enter Number:");
            string fiveNum = Console.ReadLine();
            int iNum = Convert.ToInt32(fiveNum);
            int yourRemain = iNum % 7;
            Console.WriteLine(yourRemain);
            Console.ReadLine();
        }
    }
    }