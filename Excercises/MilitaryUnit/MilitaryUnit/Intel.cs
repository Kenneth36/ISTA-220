using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Intel : MilitaryUnit
    {
        public void GatherInfo()
        {
            Console.WriteLine("GatherInfo: Gathering the information SECRET LIKE");
        }

        public void GatherEquipment()
        {
            Console.WriteLine("Gather Equipment: Gathering equipment");
        }

        public void NinjaCreep()
        {
            Console.WriteLine("Ninja Creep: NINJA CREEP (Shhhhhhhh)");
        }

        public override void Deploy()
        {
            Console.WriteLine("Deploy: We're deployed right now. Please leave a message");
        }

        public override void PerformMission()
        {
            Console.WriteLine("Perform Mission: Performing mission: Getting the work done!");
        }
    }
}
