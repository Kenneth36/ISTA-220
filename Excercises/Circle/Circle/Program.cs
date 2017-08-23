using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double area;

            Console.WriteLine("Please enter a number ");
            r = Double.Parse(Console.ReadLine());

            double circum = 2 * Math.PI * r;
            area = Math.PI * (r * r);

            Console.WriteLine($"The area ofthe circle is: {area:#.###}");
            Console.WriteLine($"The circumference of the circle is: {circum:#.###}");
        }
    }
}
