using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double area;

            Console.WriteLine("Please enter the value for 'a': ");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value for 'b': ");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the value for 'c': ");
            c = Double.Parse(Console.ReadLine());
            
            double p = (( a + b + c) / 2);
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"The area of a triangle is: {area:#.###}");
        }
    }
}
