using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speedInTheBeggining = int.Parse(Console.ReadLine());
            var timeWithNormalSpeed = int.Parse(Console.ReadLine());
            var timeForIncreasinSpeed = int.Parse(Console.ReadLine());
            var timeForDiscreasingSpeed = int.Parse(Console.ReadLine());

            var distanceInTheBeggining = speedInTheBeggining * timeWithNormalSpeed / 60.0;
            var distanceInTheMiddle = speedInTheBeggining * 1.1 * timeForIncreasinSpeed / 60;
            var distanceInTheEnd = speedInTheBeggining * 1.1 * 0.95 * timeForDiscreasingSpeed / 60;
            var distance = distanceInTheBeggining + distanceInTheMiddle + distanceInTheEnd;

            Console.WriteLine("{0:f2}", distance);

        }
    }
}
