using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void testUnit()
        {
            Console.WriteLine("Intel - Secret Squiral Intel Guys");
            Intel milIntel = new Intel();
            milIntel.Train("Secret train, we ninjas");
            milIntel.GatherInfo();
            milIntel.GatherEquipment();
            milIntel.Deploy();
            milIntel.NinjaCreep();
            milIntel.PerformMission();

            Console.WriteLine("\nTank - We are the tank unit, we got TANKS"); // test tank
            Tank milTank = new Tank();
            milTank.Train("work,work,work,work");
            milTank.Repair();
            milTank.GatherArtillery();
            milTank.Fire();
            milTank.Deploy();
            milTank.PerformMission();

            Console.WriteLine("\nPlatoon Unit - We love to march :-) "); // test platoon
            Platoon milPlatoon = new Platoon();
            milPlatoon.Train("We got this training on lock");
            milPlatoon.March();
            milPlatoon.Sleep();
            milPlatoon.Eat();
            milPlatoon.Deploy();
            milPlatoon.PerformMission();
        }

        static void Main(string[] args)
        {
            try
            {
                testUnit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            
        }
    }
}
