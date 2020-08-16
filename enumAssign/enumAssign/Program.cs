using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace enumAssign
{
    class Program
    { 
        public enum daysofweek
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            var weekDay = Console.ReadLine();

           
            try
            {
                daysofweek day = (daysofweek)Enum.Parse(typeof(daysofweek), weekDay);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
        }


    }
}


