﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAssign2
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number");
                int d1 = Convert.ToInt32(Console.ReadLine());
                Optional.my_mul(d1);
                Console.ReadLine();

                Console.WriteLine("Enter a second number if you wish");
                int d2 = Convert.ToInt32(Console.ReadLine());
                Optional.my_mul(d1, d2);
                Console.ReadLine();  
            }
        }
    }
}
