using System;

namespace boolean1.cs
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int yAge = Convert.ToInt32(yourAge);

            Console.WriteLine("Have you ever had a DUI?");
            string haveDUI = Console.ReadLine();
            bool hDUI = Convert.ToBoolean(haveDUI);

            Console.WriteLine("How many Speeding Tickets?");
            string speedTick = Console.ReadLine();
            int sTick = Convert.ToInt32(speedTick);


            Console.WriteLine("Qualified?");
            bool qualified = (yAge >= 15 && hDUI == false && sTick <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();

            //bool qualified = (yAge >= 15 && hDUI == false && sTick <= 3);
            //Console.WriteLine(qualified);


            //Console.WriteLine(true && false);

            //Console.WriteLine(true || true);

            //Console.WriteLine(true == true);

            //Console.WriteLine(true != true);

            //Console.WriteLine(true ^ true);

            //Console.ReadLine();
        }
    }
}
