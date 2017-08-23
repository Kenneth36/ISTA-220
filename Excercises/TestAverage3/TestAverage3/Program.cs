using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAverage3
{
    class Program
    {
       // int ans = 0;
        int testGrade = 0;
        double sum, count, totalAverage;

        public void readScore()
        {
            // Console.WriteLine("Would you like to calculate test scores? [Y=1/N=2]: ");
           // ans = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your test scores [press -1 to calculate score]:");
            testGrade = Int32.Parse(Console.ReadLine());



            while (true)
            {
                count++;
              //  Console.WriteLine("Please enter your test scores: ");
              //  testGrade = Int32.Parse(Console.ReadLine());

                if (testGrade < 0)break;
                sum += Double.Parse(Console.ReadLine());


                /*
                 Console.WriteLine("Please enter your test scores: ");
                 Console.WriteLine("Would you like to add more? [Y=1/N=2]: ");
                 ans = Int32.Parse(Console.ReadLine());
                 count += Double.Parse(Console.ReadLine());
                 sum += Double.Parse(Console.ReadLine());
                 */

            }

            Console.ReadLine();
                Console.WriteLine("Thank you, have a nice day.");

            Console.WriteLine("\n");
        }

        public void computeScore()
        {
            double score = 0;

            totalAverage = sum / count;

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
            else if (totalAverage <= 100 || totalAverage <= 90)
            {
                score = 5;
            }
            else
            {
                score = 6;
            }

            switch (score)
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
                    Console.WriteLine($"Grade Point Average: {totalAverage} Grade: B");
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
