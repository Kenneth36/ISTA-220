using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PasswordSystem
{
    class NewPassword
    {
        static Dictionary<string, string> Credentials = new Dictionary<string, string>();

        public static void Run()
        {
            string userName;
            string passWord;

            Console.Write("Enter your user name :");
            userName = Console.ReadLine();
            Console.Write("Enter your password :");
            passWord = ReadPassword();

            Console.WriteLine("\nPlease check to see that no one is looking over your shoulder...");
            Console.WriteLine("\nWe will now confirm the password and user name you entered.");
            Console.WriteLine("\nPlease take note to remember this info. All input will be erased after 10 seconds");
            Console.Write("\nThe user name and password entered is: \n"
                + "User Name: " + userName
                + "\nPassword: " + passWord);

            Credentials.Add(userName, passWord);

            Thread.Sleep(10000);
            Console.Clear();
        }

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);

            while (info.Key != ConsoleKey.Enter)
            {
                if(info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }

                else if(info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        //this will remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);

                        //this will get the location of the cursor
                        int pos = Console.CursorLeft;

                        //this moves the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);

                        //this will replace the cursor with space
                        Console.Write("");

                        //this moves the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // a new line is added because the user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }
    }
}

