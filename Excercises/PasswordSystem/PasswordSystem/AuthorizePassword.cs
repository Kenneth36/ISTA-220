using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordSystem
{
    class AuthorizePassword
    {
        static Dictionary<string, string> Credentials = new Dictionary<string, string>();

        public static void Run()
        {

            string userName;
            string passWord;

            Console.Write("Enter your user name :");
            userName = Console.ReadLine();
            Console.Write("Enter your password :");
            passWord = Console.ReadLine();

            // this sends password to the ReadPassword() method in NewPassword 
            passWord = NewPassword.ReadPassword();


            // checks to see if userName and passWord exists in the system's files
            if(Credentials.ContainsKey(userName))
            {
                Console.WriteLine($"The username: {userName} does exist in our files.");

                if (passWord.Equals(Credentials[userName]))
                {
                    Console.WriteLine($"{userName}'s password matches the correct password.");
                }
                else
                    Console.WriteLine($"Sorry, you f***@d up somewhere. {userName}'s password does not match the correct password.");
            }

            else
            {
                Console.WriteLine($"Sorry to inform you, but the username {userName} does not exist in our files.");
            }


        }
    }
}
