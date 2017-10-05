using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNumber1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string choice;

            while (true)
            {
                try
                {
                    Console.WriteLine("Welcome to my Numbers Guess Game!\n");
                    Console.WriteLine("Please choose one of the following:\n ");
                    Console.Write("Enter 1: Human Guess (I choose a number between 1 and 100\n" +
                                    "and you will guess which one it is).\n" + "\n");
                    Console.Write("Enter 2: Computer Guess (You choose a number between 1 and 100\n" +
                                  "and I will guess which one it is).\n" + "\n");
                  

                    choice = Console.ReadLine();

                    // "if...else" statements to determine which game to play

                    if (int.Parse(choice) == 1)
                    {
                        HumanPlays.Run();
                        break;
                    }
                    else if (int.Parse(choice) == 2)
                    {
                        ComputerPlays.Run();
                        break;
                    }
                    else
                        Console.WriteLine("Sorry, choice value is out of range.\n");
                }

                catch (Exception)
                {
                    Console.WriteLine("Please enter a number in order to play (1: Human Guess, 2: Computer Guess, 3: Computer Guess 2)");
                }



            }
        }


    }
}
