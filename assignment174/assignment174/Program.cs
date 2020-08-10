using System;

namespace assignment174
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee();
            sample.FirstName = "Sample";
            sample.LastName = "Student";
            sample.SayName();
            Console.ReadLine();
        }
    }
}
