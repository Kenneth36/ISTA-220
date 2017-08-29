using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Rabbit : Animals
    {
        public Rabbit (string n):base(n)
        {
            this.name = n;
        }

        public override string Sound()
        {
            return "hop hop";
        }
    }
}
