using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Horse : Animals
    {
        public Horse (string n):base(n)
        {
            this.name = n;
        }

        public override string Sound()
        {
            return "neigh";
        }
    }
}
