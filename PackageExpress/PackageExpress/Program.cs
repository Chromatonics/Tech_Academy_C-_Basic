using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            try
            {
                Console.WriteLine("Please enter package weight:");
                string weight = Console.ReadLine();
                int packWeight = Convert.ToInt32(weight);

                if (packWeight > 50)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Please enter package height:");
                string height = Console.ReadLine();
                int packHeight = Convert.ToInt32(height);

                Console.WriteLine("Please enter package width:");
                string width = Console.ReadLine();
                int packWidth = Convert.ToInt32(width);

                Console.WriteLine("Please enter package length:");
                string length = Console.ReadLine();
                int packLength = Convert.ToInt32(length);

                int dimensions = packHeight + packWidth + packLength;
                if (dimensions > 50)
                {
                    throw new Exception();
                }
                int quote = dimensions * packWeight / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");

                Console.WriteLine("Thank you!");
                Console.ReadLine();
            }   
            catch(ArgumentException)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
        }
    }
}
