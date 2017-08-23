using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverage1
{
    class Program
    {
        int count;
        double sum, totalAverage;

        public void readScore()
        {
            Console.WriteLine("Please enter your test scores: ");

            for (count = 0; count < 10; count++)
            {
                sum += Double.Parse(Console.ReadLine());
            }
           
            Console.WriteLine("\n");
        }

        public void computeScore()
        {
            double score = 0;

            totalAverage = sum/ count;



            if (totalAverage <= 59 || totalAverage <= 50)
            {
                score = 1;
            }
            else if (totalAverage <= 69 || totalAverage <= 60)
            {
                score = 2;
            }
            else if (totalAverage <= 79 || totalAverage <= 70)
            {
                score = 3;
            }
            else if (totalAverage <= 89 || totalAverage <= 80)
            {
                score = 4;
            }
            else if (totalAverage <= 100 || totalAverage >= 90)
            {
                score = 5;
            }
            else
            {
                score = 6;
            }

            switch(score)
            {
                case 1:
                    Console.WriteLine($"Sum of final grade: {sum:#.###}");
                    Console.WriteLine($"Grade Point Average: {totalAverage} Grade: F");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine($"Sum of final grade: {sum:#.###}");
                    Console.WriteLine($"Grade Point Average: {totalAverage} Grade: D");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine($"Sum of final grade: {sum:#.###}");
                    Console.WriteLine($"Grade Point Average:{totalAverage} Grade: C");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine($"Sum of final grade: {sum:#.###}");
                    Console.WriteLine($"Grade Point Average:{totalAverage} Grade: B");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine($"Sum of final grade: {sum:#.###}");
                    Console.WriteLine($"Grade Point Average: {totalAverage} Grade: A");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Grade Point Average: #Null In-Void");
                    Console.ReadLine();
                    break;

            }
        }

        static void Main(string[] args)
        {
            Program calculate = new Program();
            calculate.readScore();
            calculate.computeScore();
        }
    }
}
