using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Tank : MilitaryUnit
    {
        public void Repair()
        {
            Console.WriteLine("Repair: Repairing our stuff, getting READYYYY");
        }

        public void GatherArtillery()
        {
            Console.WriteLine("GatherArtillery: We Got the AMMO, We Got the AMMO");
        }

        public void Fire()
        {
            Console.WriteLine("Fire: FIRRRRREEEEEEE");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploy: Sorry, currently deployed right now. Leave a message");
        }

        public override void PerformMission()
        {
            Console.WriteLine("Perform Mission: Putting in WORK for this mission");
        }
    }
}
