using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Platoon : MilitaryUnit
    {
        public void March()
        {
            Console.WriteLine("MARCHING: We love to party (we love to party) Parrrrttty Hearrrty (parrrrrttty hearrrty");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping: We gotta sleep");
        }

        public void Eat()
        {
            Console.WriteLine("Eatting: Can't talk right now.....EATTTING");
        }

        public override void Deploy()
        {
            Console.WriteLine("DEPLOYED: Nothing to Say about THAT");
        }

        public override void PerformMission()
        {
            Console.WriteLine("Performing Mission:  GETTER DONE!!!!!");
        }

    }
}
