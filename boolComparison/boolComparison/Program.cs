using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess word");
            string word = Console.ReadLine();
            bool isGuessed = word == "cat";

            do
            {
                switch (word)
                {
                    case "cat":
                        Console.WriteLine("you guessed cat. you are correct");
                        isGuessed = true;
                        break;
                    case "dog":
                        Console.WriteLine("you guessed dog. try again");
                        Console.WriteLine("guess a word");
                        word = Console.ReadLine();
                        break;
                    case "ferret":
                        Console.WriteLine("you guessed ferret. try again");
                        Console.WriteLine("guess a word");
                        word = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("wrong");
                        Console.WriteLine("guess a word");
                        word = Console.ReadLine();
                        break;

                }
            }
            while (!isGuessed);
    

            Console.ReadLine();
        }
    }
}

