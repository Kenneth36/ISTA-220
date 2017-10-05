using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class MilitaryUnit
    {
        public void Train(string makeItYourBattleCry)
        {
            Console.WriteLine($"Training the Unit: {makeItYourBattleCry}");
        }

        public virtual void Deploy ()
        {
            Console.WriteLine("Default implementation of the Deploy method");
        }

        public virtual void PerformMission()
        {
            Console.WriteLine("Default implementation of the Drive method");
        }

    }
}
