using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNumber1
{
    class HumanPlays
    {
        public static void Run()
        {
            Random random = new Random();
            int num = random.Next(1, 100);
            int guess = 0;

            while (num != guess)
            {
                Console.Write("Please guess a number between 1 and 100: \n");
                guess = int.Parse(Console.ReadLine());

                if(guess < num)
                {
                    Console.WriteLine("Sorry, your guess was too high. Please guess again: ");
                }
                else if (guess == num)
                {
                    Console.WriteLine($"Correct! {guess} was the right number.");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, your guess was too low. Please guess again: ");
                }
            }


        }
    }
}
