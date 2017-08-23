using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        double a;
        double b;
        double c;

        public void readNum ()
        {
            Console.WriteLine("Please enter number for 'a': ");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number for 'b': ");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number for 'c': ");
            c = Double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
        }

        public void analyze()
        {
            int n;
            double num1;
            double num2;
            double underSq;

            underSq = (b * b) - (4 * a * c);

            if (a == 0)
                n = 1;
            else if (underSq > 0)
                n = 2;
            else if (underSq == 0)
                n = 3;
            else
                n = 4;

            switch(n)
            {
                case 1: Console.WriteLine("Sorry, not able to compute. Please try again.");
                    Console.ReadLine();
                    break;
                case 2:
                    num1 = ((-b) + Math.Sqrt(underSq)) / (2 * a);
                    num2 = ((-b) - Math.Sqrt(underSq)) / (2 * a);
                    Console.WriteLine("The Result of the Numbers are Real");
                    Console.WriteLine($"First number is: {num1:#.###}");
                    Console.WriteLine($"Second number is: {num2:#.###}");
                    Console.WriteLine("\n");
                    break;
                case 3:
                    num1 = num2 = ((-b) / (2 * a));
                    Console.WriteLine("The Result of the Numbers are Real");
                    Console.WriteLine($"First number is: {num1:#.###}");
                    Console.WriteLine($"Second number is: {num2:#.###}");
                    Console.WriteLine("\n");
                    break;
                case 4:
                    num1 = ((-b) / (2 * a));
                    num2 = Math.Sqrt(-underSq) / (2 * a);
                    Console.WriteLine("The Result of the Numbers are Imaginary");
                    Console.WriteLine($"First number is: {num1:#.###} + i");
                    Console.WriteLine($"Second number is: {num2:#.###} + i");
                    Console.WriteLine("\n");
                    break;
            }

        }

        static void Main(string[] args)
        {

            Program roots = new Program();
            roots.readNum();
            roots.analyze();     
            
        }
    }
}
