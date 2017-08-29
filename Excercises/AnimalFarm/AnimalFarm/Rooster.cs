using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Rooster : Animals
    {
        public Rooster (string n):base(n)
        {
            this.name = n;
        }

        public override string Sound()
        {
            return "Cock-A-Doodle to a Do";
        }
    }
}
