﻿using System;

namespace abstractAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.SayName();

            Employee welcome = new Employee();
            welcome.Quit();
            Console.ReadLine();
        }
    }
}
