using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericAssign
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> things1 = new Employee<string>();
            things1.Things = new List<string>();

            things1.Things.Add("Blue");
            things1.Things.Add("Yellow");
            things1.Things.Add("Purple");
            things1.Things.Add("Red");

            foreach (string s in things1.Things)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

            Employee<int> things2 = new Employee<int>();
            things2.Things = new List<int>();

            things2.Things.Add(2);
            things2.Things.Add(11);
            things2.Things.Add(37);
            things2.Things.Add(9);

            foreach (int u in things2.Things)
            {
                Console.WriteLine(u);
            }
            Console.ReadLine();
        }
    }
}
