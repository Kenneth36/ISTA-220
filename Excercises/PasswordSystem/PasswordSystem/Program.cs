using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice;
            
            while (true)
            {
                try
                {
                    //Introduction to user and displays option menu

                    Console.Write("****Welcome to JERRY LEE's Password System BRINK*****\n");
                    Console.Write("Please choose one of the following:\n");
                    Console.Write("1: Save a new password for a new user\n" +
                                  "2: Authenticate a specific username/password\n" +
                                  "3: Exit application\n");
                    Console.Write("***************************************************\n");
                    Console.WriteLine("\n");

                    userChoice = Console.ReadLine();

                    //"if...else" statements based on user's reponse

                    if (int.Parse(userChoice) == 1)
                    {
                        NewPassword.Run();
                        break;
                    }
                    else if (int.Parse(userChoice) == 2)
                    {
                        AuthorizePassword.Run();
                        break;
                    }
                    else if (int.Parse(userChoice) == 3)
                    {
                        Console.WriteLine("Thank you, have a nice day");
                        break;
                    }
                    else
                        Console.WriteLine("Sorry, please choose one of the following three options");
                }

                catch(Exception)
                {
                    Console.WriteLine("Please make your selection (1: Save a new password for a specific user," + 
                        "2: Authenticate a specific username/password," + "3: Exit application");
                }
              
            }
            
        }
    }
}
