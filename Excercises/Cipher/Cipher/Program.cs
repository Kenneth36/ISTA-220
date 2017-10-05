using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Please enter a key: \n");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("To Encrypt press E to Decrypt press D: \n");
                string userChoice = Convert.ToString(Console.ReadLine()).ToUpper();
                Console.WriteLine("\n");

                switch (userChoice)
                {
                    case "E":
                        Console.Write("Enter plain text: ");
                        string inputE = Console.ReadLine();
                        Encrypt(key, inputE);
                        Console.ReadKey();
                        break;

                    case "D":
                        Console.Write("Enter cipher: ");
                        string inputD = Console.ReadLine();
                        Decrypt(key, inputD);
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Sorry, that is not an option!");
                        break;
                }
            }

            catch(Exception)
            {
                Console.WriteLine("You entered an incorrect value. Please press any key to continue.");
            }
        }

        static void Encrypt(int key, string inputE)
        {
            int size = inputE.Length;
            char[] letter = new char[size];
            char[] cipher = new char[size];

            for(int i = 0; i < size; i++)
            {
                letter[i] = Convert.ToChar(inputE.Substring(i, 1));
            }

            for (int ie = 0; ie < size; ie++)
            {
                int count = 0;
                int a = Convert.ToInt32(letter[ie]);
                for (int h = 1; h <= key; h++)
                {
                    if (count == 0)
                    {
                        if (a == 90)
                        {
                            a = 64;
                        }
                        else if (a == 122)
                        {
                            a = 96;
                        }
                        cipher[ie] = Convert.ToChar(a + h);
                        count++;
                    }

                    else
                    {
                        int b = Convert.ToInt32(cipher[ie]);
                        if (b == 90)
                        {
                            b = 64;
                        }
                        else if (b == 122)
                        {
                            b = 96;
                        }
                        cipher[ie] = Convert.ToChar(b + 1);
                    }
                }
            }

            string enterCipherText = "";

            for (int p = 0; p < size; p++)
            {
                enterCipherText = enterCipherText + cipher[p].ToString();
            }

            Console.WriteLine("Cipher text is as follows = ");
            Console.WriteLine(enterCipherText.ToUpper());
        }

        static void Decrypt (int key, string inputD)
        {
            int size = inputD.Length;
            char[] letter = new char[size];
            char[] cipher = new char[size];

            for(int i = 0; i < size; i++)
            {
                cipher[i] = Convert.ToChar(inputD.Substring(i, 1));
            }

            for (int ie = 0; ie < size; ie++)
            {
                int count = 0;
                int a = Convert.ToInt32(cipher[ie]);
                for (int h = 1; h <= key; h++)
                {
                    if (count == 0)
                    {
                        if(a == 65)
                        {
                            a = 91;
                        }
                        else if (a == 97)
                        {
                            a = 123;
                        }
                        letter[ie] = Convert.ToChar(a - h);
                        count++;
                    }

                    else
                    {
                        int b = Convert.ToInt32(letter[ie]);
                        if (b == 65)
                        {
                            b = 91;
                        }
                        else if (b == 97)
                        {
                            b = 123;
                        }
                        letter[ie] = Convert.ToChar(b - 1);
                    }
                }
            }

            string justPlainText = "";

            for(int p = 0; p < size; p++)
            {
                justPlainText = justPlainText + letter[p].ToString();
            }

            Console.WriteLine("Plain text is as follows = ");

            Console.WriteLine(justPlainText.ToLower());
        }
    }
}
