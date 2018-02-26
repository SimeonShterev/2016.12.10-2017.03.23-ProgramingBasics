using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareMeters = int.Parse(Console.ReadLine());
            var kgGrapesPerSquareMeter = double.Parse(Console.ReadLine());
            var wineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var wineProduced = squareMeters * kgGrapesPerSquareMeter * 0.4 / 2.5;

            if (wineNeeded > wineProduced)
            {
                var lessWine = wineNeeded - wineProduced;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", (int)lessWine);
            }
            else
            {
                var moreWine = wineProduced - wineNeeded;
                var winePerWorker = moreWine / workers;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.",
                                   (int)wineProduced, Math.Ceiling(moreWine), Math.Ceiling(winePerWorker));
            }

        }

    }
}
