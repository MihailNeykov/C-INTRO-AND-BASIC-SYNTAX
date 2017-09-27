using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthPerCent = new string('|', health);
            string healthRest = new string('.', maxHealth - health);
            string energyPerCent = new string('|', energy);
            string energyRest = new string('.', maxEnergy - energy);

            Console.WriteLine("Name: {0}\nHealth: |{1}{2}|\nEnergy: |{3}{4}|", name, healthPerCent, healthRest, energyPerCent, energyRest);



        }
    }
}
