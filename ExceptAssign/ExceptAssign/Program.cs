using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers1 = new List<int>() { 2, 3, 5, 7 };
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                foreach (var i in numbers1)
                {
                    var result = i / numberOne;
                    Console.WriteLine(result);
                }
           
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use a real number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please no divide by zero");
            }
            Console.WriteLine("Continued on Program Execution");
            Console.ReadLine();
        }
    }
}