using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grape_and_rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaOfVineYard = double.Parse(Console.ReadLine());
            var grapesPerSquareMeter = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());

            var grapes = grapesPerSquareMeter * areaOfVineYard - waste;
            var grapesForRakia = grapes * 0.45;
            var grapesToSellKg = grapes * 0.55;

            var rakiaForSelling = grapesForRakia * 9.80 / 7.5;
            var grapesForSelling = grapesToSellKg * 1.50;

            Console.WriteLine("{0:f2}", rakiaForSelling);
            Console.WriteLine("{0:f2}", grapesForSelling);
        }
    }
}
