using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace change_tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyCollected = double.Parse(Console.ReadLine());
            var floorWidth = double.Parse(Console.ReadLine());
            var floorHeight = double.Parse(Console.ReadLine());
            var triangleTileBot = double.Parse(Console.ReadLine());
            var triangleTileHeight = double.Parse(Console.ReadLine());
            var pricePerTile = double.Parse(Console.ReadLine());
            var salaryWorker = double.Parse(Console.ReadLine());

            var floor = floorHeight * floorWidth;
            var tile = triangleTileBot * triangleTileHeight / 2;
            var tilesNeeded = Math.Ceiling((floor / tile) + 5);
            var moneyNeeded =tilesNeeded * pricePerTile + salaryWorker;
            if (moneyCollected >= moneyNeeded)
            {
                Console.WriteLine("{0:f2} lv left.", (moneyCollected-moneyNeeded));
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.", (moneyNeeded - moneyCollected));
            }
        }
    }
}
