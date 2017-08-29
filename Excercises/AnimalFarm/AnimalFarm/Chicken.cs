using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Chicken : Animals
    {
        public Chicken (string n):base(n)
        {
            this.name = n;
        }

        public override string Sound()
        {
            return "cluck-cluck";
        }
    }
}
