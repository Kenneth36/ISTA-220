using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Animals
    {
        public string name;

        public Animals(string n)
        {
            this.name = n;
        }

        public void Talk()
        {
            Console.WriteLine($"My name is{this.name}and I'm a {GetType().Name}. I say {Sound()} .");
        }

        public void Talk(string line)
        {
            Console.WriteLine($"My name is {this.name}and I'm a {GetType().Name} \"{line}\".");
        }

        public void Eat(Food food)
        {
            if (food.stockPile > 0)
            {
                Console.WriteLine($"{this.name} ate some {food.name}. {food.stockPile} lbs of {food.name} is left.");
            }
            else
                Console.WriteLine($"There is no more {food.name} left");
        }

        public virtual string Sound()
        {
            return "This is not the sound you are looking for"; 
        }
    }
}
