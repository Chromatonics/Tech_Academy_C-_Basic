using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor1
{
    public class Constructor
    {
         public int Day { get; set; }
         public int Month { get; set; }
         public int Year { get; set; }

         public Constructor(int day) : this(day, 1) { }

         public Constructor(int day, int month) : this(day, month, 1900) { }

         public Constructor(int day, int month, int year)
         {
             this.Day = day;
             this.Month = month;
             this.Year = year;
         }

        public override string ToString()
        {
            return "Day: " + Day + "   Month: " + Month + "   Year: " + Year;
        }

    }
    
}

