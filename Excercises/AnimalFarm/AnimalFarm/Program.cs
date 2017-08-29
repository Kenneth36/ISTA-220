using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {       

        static void performAct()  // loop that holds array for animals
        {
            Animals[,] animals = new Animals[9, 3]
            {
                {new Cow ("Otis"), new Cow("Clive"), new Cow ("Davis") },                  // Row 0
                {new Chicken ("Chicken Little"), new Chicken("Huey"), new Chicken("Cluck-Cluck") }, // Row 1
                {new Frog("Kermit"), new Frog("Owen"), new Frog("Pixle") },                   // Row 2  
                {new  Goat("Billy Goats"), new Goat("Gamblin' Rain"), new Goat("Horns") },       // Row 3
                {new Horse("Mr. Ed"), new Horse("Thirty-Thirty"), new Horse("Hauce") },            // Row 4
                {new Pig ("Ms. Piggy"), new Pig("Taylor"), new Pig("Piglet") },          // Row 5
                {new Rabbit("Bugs Bunny"), new Rabbit ("Roger"), new Rabbit ("Bucky") },       // Row 6
                {new Rooster ("Foghorn Leghor"), new Rooster ("Loud Mouth"), new Rooster ("Speak Easy") }, // Row 7
                {new Sheep("Bo Peep"), new Sheep("Hot Sauce"), new Sheep("Jumpy") },           // Row 8


            };

            Food hay = new Food("hay", 30, 0);
            Food seed = new Food("seed", 20, 0);
            Food cornfeed = new Food("corn feed", 50, 0);
            Food pigslop = new Food("pig slop", 40, 0);   
            animals[0, 0].Talk("It's fun house at the Animal House");
            animals[1, 0].Talk("The sky is falling!!");
            animals[2, 0].Talk("Duck Tales (woohoo)");
            animals[3, 0].Talk("Kermit the frog here");
            animals[4, 0].Talk("Hello Wilbur, I'm Mr. Ed");
            animals[5, 0].Talk();
            animals[6, 0].Talk("What's up Doc?");
            animals[7, 0].Talk("I say, I say, hello");
            animals[8, 0].Talk();
            animals[0, 1].Talk();
            animals[1, 1].Talk();
            animals[2, 1].Talk();
            animals[3, 1].Talk();
            animals[4, 1].Talk();
            animals[5, 1].Talk();
            animals[6, 1].Talk();
            animals[7, 1].Talk();
            animals[8, 1].Talk();
            animals[0, 2].Talk();
            animals[1, 2].Talk();
            animals[2, 2].Talk();
            animals[3, 2].Talk();
            animals[4, 2].Talk();
            animals[5, 2].Talk();
            animals[6, 2].Talk();
            animals[7, 2].Talk();
            animals[8, 2].Talk();
            animals[0,0].Eat(hay);
            animals[2, 2].Eat(seed);
            animals[1,2].Eat(cornfeed);
            animals[5, 1].Eat(pigslop);
        }

        static void Main(string[] args)
        {
            try
            {
                performAct();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            
        }
    }
}
