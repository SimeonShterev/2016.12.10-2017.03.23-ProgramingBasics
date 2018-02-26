using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaOfHouse = double.Parse(Console.ReadLine());
            var windowsNum = int.Parse(Console.ReadLine());
            var areaStyrofoamPerPack = double.Parse(Console.ReadLine());
            var priceOfStyrofoam = double.Parse(Console.ReadLine());

            var areaToCover = (areaOfHouse - windowsNum * 2.4) * 1.1;
            var styrofoamPacksNeeded = Math.Ceiling(areaToCover / areaStyrofoamPerPack);
            var moneyNeeded = styrofoamPacksNeeded * priceOfStyrofoam;

            if (moneyNeeded > budget)
            {
                Console.WriteLine("Need more: {0:f2}", moneyNeeded - budget);
            }
            else
            {
                Console.WriteLine("Spent: {0:f2}", moneyNeeded);
                Console.WriteLine("Left: {0:f2}", budget - moneyNeeded);
            }

        }
    }
}
