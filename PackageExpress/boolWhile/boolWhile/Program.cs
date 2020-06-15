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
            Console.WriteLine("Guess letter");
            string letter = Console.ReadLine();
            bool isGuessed = letter == "a";

            while (!isGuessed)
            {
                switch (letter)
                {
                    case "a":
                        Console.WriteLine("you guessed a. you are correct");
                        isGuessed = true;
                        break;
                    case "b":
                        Console.WriteLine("you guessed b. try again");
                        Console.WriteLine("guess a word");
                        letter = Console.ReadLine();
                        break;
                    case "c":
                        Console.WriteLine("you guessed c. try again");
                        Console.WriteLine("guess a word");
                        letter = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("wrong");
                        Console.WriteLine("guess a letter");
                        letter = Console.ReadLine();
                        break;

                }
            }
            Console.ReadLine();
        }
            
        }
    }

