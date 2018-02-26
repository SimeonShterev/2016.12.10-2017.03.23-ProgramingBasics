using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holyday = Console.ReadLine().ToLower();

            var allFlowers = laleta + rozi + hrizantemi;
            var promotionLaleta = 0.0;
            var promotionRozi = 0.0;
            var promotionAllFlowers = 0.0;
            var allflowersPrice = 0.0;

            var hrizantemiPrice = 0.0;
            var roziPrice = 0.0;
            var laletaPrice = 0.0;


            if (season == "spring" || season == "summer")
            {
                hrizantemiPrice = 2.00;
                roziPrice = 4.10;
                laletaPrice = 2.50;
            }
            else if (season == "autumn" || season == "winter")
            {
                hrizantemiPrice = 3.75;
                roziPrice = 4.50;
                laletaPrice = 4.15;
            }

            if (holyday == "y")
            {
                hrizantemiPrice *= 1.15;
                roziPrice *= 1.15;
                laletaPrice *= 1.15;
            }
           
            if (season == "spring" && laleta > 7)
            {
                promotionLaleta = 0.05;
            }
            if (season == "winter" && rozi >= 10)
            {
                promotionRozi += 0.10;
            }
            if (allFlowers > 20)
            {              
                promotionAllFlowers += 0.20;
            }

            allflowersPrice = (hrizantemi * hrizantemiPrice + rozi * roziPrice + laleta * laletaPrice) *
                              (1 - promotionRozi) *(1-promotionAllFlowers) * (1 - promotionLaleta) + 2;
            Console.WriteLine("{0:f2}", allflowersPrice);
        }
    }
}
