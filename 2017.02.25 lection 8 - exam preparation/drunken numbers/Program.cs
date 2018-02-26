using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drunken_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var round = int.Parse(Console.ReadLine());
            int devisor = 0;
            int leftPart = 0;
            int rightPart = 0;
            int MitkoEachBeer = 0;
            int MitkoBeers = 0;
            int VladoEachBeer = 0;
            int VladoBeers = 0;

            for (int i = 1; i <= round; i++)
            {
                var drunkenBeersByBothINT = int.Parse(Console.ReadLine());
                string drunkenBeersByBothSTRING = Convert.ToString(drunkenBeersByBothINT);
                int lenght = (drunkenBeersByBothSTRING).Length;

                if (lenght % 2 == 0)
                {
                    devisor = (int)Math.Pow(10, (lenght / 2));
                    leftPart = drunkenBeersByBothINT / devisor;
                    rightPart = drunkenBeersByBothINT % devisor;

                    for (int j = 1; j <= (lenght / 2); j++)
                    {
                        MitkoEachBeer = leftPart % 10;
                        MitkoBeers = MitkoBeers + MitkoEachBeer;
                        leftPart /= 10;

                        VladoEachBeer = rightPart % 10;
                        VladoBeers = VladoBeers + VladoEachBeer;
                        rightPart = rightPart / 10;
                    }
                }

                if (lenght % 2 == 1)
                {
                    devisor = (int)Math.Pow(10, (lenght / 2));
                    leftPart = drunkenBeersByBothINT / devisor;
                    rightPart = drunkenBeersByBothINT % (devisor * 10);

                    for (int j = 0; j <= (lenght / 2); j++)
                    {
                        MitkoEachBeer = leftPart % 10;
                        MitkoBeers = MitkoBeers + MitkoEachBeer;
                        leftPart /= 10;

                        VladoEachBeer = rightPart % 10;
                        VladoBeers = VladoBeers + VladoEachBeer;
                        rightPart = rightPart / 10;
                    }
                }
            }
            if (MitkoBeers > VladoBeers)
            {
                Console.WriteLine("M " + (MitkoBeers - VladoBeers));
            }
            else if (MitkoBeers < VladoBeers)
            {
                Console.WriteLine("V " + (VladoBeers - MitkoBeers));
            }
            else if (MitkoBeers == VladoBeers)
            {
                Console.WriteLine("No " + MitkoBeers*2);
            }
        }
    }
}

