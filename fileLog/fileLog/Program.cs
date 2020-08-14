using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            string yNum = Console.ReadLine();
            int tNum = Convert.ToInt32(yNum);

            using (StreamWriter file = new StreamWriter(@"C:\Users\Andrew Smith\Desktop\fileLogc#.txt", true))
            {
                file.WriteLine(yNum);
            }

            string result = "";
            using (StreamReader sr = new StreamReader(@"C:\Users\Andrew Smith\Desktop\fileLogc#.txt"))
            {
                while ((result = sr.ReadLine()) != null)
                {
                    Console.WriteLine(result);
                }
            }
            Console.ReadKey();
        }
    }
}
