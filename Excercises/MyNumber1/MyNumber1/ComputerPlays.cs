using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNumber1
{
    class ComputerPlays
    {
        public static void Run()
        {
            Console.WriteLine("Please pick a number between 1 and 100: ");
            int[] list = new int[100];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;

                int guess = 0;
                

                while(true)
                {
                    guess = int.Parse(Console.ReadLine());

                    if (guess >= 1 && guess <= 100)
                    {
                        Console.WriteLine("Now I will guess which number you chose.\n");
                      
                         GetLucky(guess, list);
                        break;
                    }
                    else
                        Console.WriteLine("Sorry, your value is out of range.");
                }
            }
            
        }

        public static void GetLucky(int guess, int[] list)
        {
            int low = list[0];
            int high = list.Length - 1;
            int mid = list.Length / 2;
            int option = 0;

            do
            {
                Console.WriteLine($"Is {mid} the right number? (1: Too High, 2: Too Low, 3: Correct)\n");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                if (option == 1)
                {
                    Console.WriteLine("Back to the drawing board. Let me guess again...");
                    high = --mid;

                }
                else if (option == 2)
                {
                    Console.WriteLine("I'm getting close Monty...Let me try it again...");
                    low = ++mid;
                }
                else if (option == 3)
                {
                    Console.WriteLine($"Yes!! I got it! I knew it all along...the answer is {mid}");
                }
                else
                    Console.WriteLine("Sorry, I didn't catch that.");

            } while (option != 3);

           

        }
    }
}
