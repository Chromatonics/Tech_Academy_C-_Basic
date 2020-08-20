using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionAssign
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                var age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentException();
                }

                DateTime localDate = DateTime.Now;
                int year = localDate.Year;

                int span = year - age;
                Console.WriteLine("The year you were born was: " + span);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter a positive value greater than zero");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
