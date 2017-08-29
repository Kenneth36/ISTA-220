using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Food
    {
        public string name;
        public int stockPile;
        public int whatIsLeft;
        public Food(string n, int sP, int isLeft)
        {
            this.name = n;
            this.stockPile = sP;
            this.whatIsLeft = isLeft;
        }
    }
}
