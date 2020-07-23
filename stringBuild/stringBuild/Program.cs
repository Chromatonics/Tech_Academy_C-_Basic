using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "This is";
            string two = " a freakin";
            string three = " blast!";
            string superString = one + two + three;
            Console.WriteLine(superString);
            Console.ReadLine();

            
            string name = "hello world";
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("Today is a lovely day.");
            sb.Append(" The sun is shining.");
            sb.Append(" The birds are singing.");
            sb.Append(" All is right with the world.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
