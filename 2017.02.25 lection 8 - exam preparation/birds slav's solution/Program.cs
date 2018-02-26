using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bird_slav_ssolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfBirds = int.Parse(Console.ReadLine());
            var totalBirdFeathers = int.Parse(Console.ReadLine());

            if (totalBirdFeathers == 0 && totalBirdFeathers == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                double feathersPerBird = totalBirdFeathers / (double)numberOfBirds; // castvame pone edna stoinost
                if (numberOfBirds % 2 == 0)
                {
                    feathersPerBird *= 123123123123;
                }
                else
                {
                    feathersPerBird /= 317;
                }
            }



        }
    }
}
