using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Sheep : Animals
    {
        public Sheep (string n):base(n)
        {
            this.name = n;
        }

        public override string Sound()
        {
            return "BAAAA (have you any wool?)";
        }
    }
}
