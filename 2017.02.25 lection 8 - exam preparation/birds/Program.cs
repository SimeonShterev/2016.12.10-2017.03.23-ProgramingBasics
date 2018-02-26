using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfBirdds = double.Parse(Console.ReadLine());
            var numberOffeathers = double.Parse(Console.ReadLine());
            double averageFeathers = 0.0;

            if (numberOfBirdds % 2 == 0)
            {
                averageFeathers = numberOffeathers / numberOfBirdds * 123123123.0;
            }
            else
            {
                averageFeathers = numberOffeathers / numberOfBirdds / 317.0;
            }
            Console.WriteLine("{0:f4}", averageFeathers); // ne se izpolzva math.round, a formatirane :D
        }
    }
}
