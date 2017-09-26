using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame
{
    class Program
    {
        private static Table table = new Table();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Casino Royal's Roulette Table");


        }


        static void GamePlay()
        {
            Random r = new Random();
            while (true)
            {
                try
                {
                    Console.Write("Please enter a number if you wish to play ('Q' to Quit / 'S' to Spin): "); // prompt user to play
                    string input = Console.ReadLine(); // reads user input
                    if (input.ToUpper() == "Q")
                    {
                        Console.WriteLine("Thank you, please come back to see us");
                        break;
                    }
                    else if (input.ToUpper() == "S") // "S" to spin the wheel
                    {
                        GetWinnings(r.Next(38));
                    }
                    else if (input == "00") // if 00 aka "37" is enterd
                    {
                        GetWinnings(37);
                    }
                    else
                    {
                        int value = int.Parse(input); // will change input into an int
                        if (value >= 0 && value <= 36)
                            GetWinnings(value);
                        else
                            Console.WriteLine("Please enter a value between 0 and 36 or 00");
                    }
                }

                catch (Exception) // catches all other int values that are not 'Q', 'S', or 00
                {
                    Console.WriteLine("Please enter a value between 0 and 36 or 00");
                }
            }
        }

        static void GetWinnings(int i) // returns winnings bets for the numbers provided
        {
            if (i == 37) // this line checks to see if the number is 37 
                Console.WriteLine("The following bets have won on 00");
            else
                Console.WriteLine($"The following bets on {i} are the winner");

            if (i > 0 && i < 37)
            {
                Console.WriteLine($"Corner Winners are: {Corner(i)}");
                Console.WriteLine($"The Column Winner is: {Column(i)}");
                Console.WriteLine($"The High / Low Winner is: {High_Low(i)} ");
                Console.WriteLine($"The Even / Odd Winner is: {Even_Odd(i)}");
                Console.WriteLine($"The Color Winner is: {table.GetColor(i)}");
            }

        }

        static string Corner (int i)
        {
            if (table.Column(i) == 0)
            {
                if (table.Row(i) == 0)
                {
                    return
                        $"({table.GetNum(table.Row(i), table.Column(i))} ," +
                        $"{table.GetNum(table.Row(i), (table.Column(i) + 1))} ," +
                        $"{table.GetNum((table.Row(i) + 1), (table.Column(i)))} ," +
                        $"{table.GetNum((table.Row(i) + 1), (table.Column(i) + 1))}");
                }

                else if (table.Row(i) == 11)
                {
                    return
                        $"({table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                        $"{table.GetNum((table.Row(i) - 1), (table.Column(i) + 1))} , " +
                        $"{table.GetNum(table.Row(i), table.Column(i))}, " +
                        $"{table.GetNum(table.Row(i), (table.Column(i) + 1))}),");
                }
                else
                {
                    return

                    $"({table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) - 1), (table.Column(i) + 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))})," +
                    $" ({table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))}," +
                    $" {table.GetNum((table.Row(i) + 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) + 1), (table.Column(i) + 1))})";

                }
            }

            else if (table.Column(i) == 1)
            {
                if (table.Row(i) == 0)
                {
                    return $"({table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) + 1), (table.Column(i) - 1))}," +
                    $" {table.GetNum((table.Row(i) + 1), table.Column(i))})," +
                    $" ({table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))}," +
                    $" {table.GetNum((table.Row(i) + 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) + 1), (table.Column(i) + 1))})";
                }

                else if (table.Row(i) == 11)
                {
                    return $"({table.GetNum((table.Row(i) - 1), (table.Column(i) - 1))}," +
                    $" {table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))})," +
                    $" ({table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) - 1), (table.Column(i) + 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))})";
                }

                else
                {
                    return
                    $"" +
                    $"({table.GetNum((table.Row(i) - 1), (table.Column(i) - 1))}," +
                    $" {table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))})," +
                    $" ({table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) - 1), (table.Column(i) + 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))})," +
                    $" ({table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) + 1), (table.Column(i) - 1))}," +
                    $" {table.GetNum((table.Row(i) + 1), table.Column(i))})," +
                    $" ({table.GetNum(table.Row(i), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) + 1))}," +
                    $" {table.GetNum((table.Row(i) + 1), table.Column(i))}," +
                    $" {table.GetNum((table.Row(i) + 1), (table.Column(i) + 1))})" +
                    $"";
                }
            }

            else
            {
                if (table.Row(i) == 0)
                {
                    return $"({table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                  $" {table.GetNum(table.Row(i), table.Column(i))}," +
                  $" {table.GetNum((table.Row(i) + 1), (table.Column(i) - 1))}," +
                  $" {table.GetNum((table.Row(i) + 1), table.Column(i))})";
                }

                else if (table.Row(i) == 11)
                {
                    return $"({table.GetNum((table.Row(i) - 1), (table.Column(i) - 1))}," +
                    $" {table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                    $" {table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                    $" {table.GetNum(table.Row(i), table.Column(i))})";
                }

                else
                {
                    return
                   $"({table.GetNum((table.Row(i) - 1), (table.Column(i) - 1))}," +
                   $" {table.GetNum((table.Row(i) - 1), table.Column(i))}," +
                   $" {table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                   $" {table.GetNum(table.Row(i), table.Column(i))})," +
                   $" ({table.GetNum(table.Row(i), (table.Column(i) - 1))}," +
                   $" {table.GetNum(table.Row(i), table.Column(i))}," +
                   $" {table.GetNum((table.Row(i) + 1), (table.Column(i) - 1))}," +
                   $" {table.GetNum((table.Row(i) + 1), table.Column(i))})";
                }
            }
            }

        }


        static string Column (int i) // returns the column as a result of the input
        {
            if (table.Column(i) == 0)
                return "first ";
            else if (table.Column(i) == 1)
                return "Second";
            else
                return "Third";
        }

        static string High_Low (int i) // returns the half of the numbers the input is in
        {
            if (i > 0 && i < 19)
                return "low (1-18)";
            else return
                    "high (19-36)";
        }

        static string Even_Odd (int i)
        {
            if (i % 2 == 0)
                return "even";
            else return
                    "odd";
        }

    }
}