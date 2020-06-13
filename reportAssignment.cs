using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
           

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What Course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum = Console.ReadLine();
            int page = Convert.ToInt32(pageNum);

            Console.WriteLine("Do you need help with Anything? Answer 'true' or 'false'");
            string boolHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(boolHelp);

            Console.WriteLine("Were there any positive experiences you would like to share? Please give specifics");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hourStud = Console.ReadLine();
            int hours = Convert.ToInt32(hourStud);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            string closeOut = Console.ReadLine();
    }
}

