using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var hegthOfRoof = double.Parse(Console.ReadLine());

            var greenPaint = 0.0;
            var redPaint = 0.0;

            var frontWall = width * width;
            var sideWall = width * length;
            var allWalls = (2 * frontWall - 1.2 * 2) + (sideWall * 2 - 2 * 1.5 * 1.5);
            var roof = (2 * length * width) + (2 * hegthOfRoof * width / 2);

            greenPaint = allWalls / 3.4;
            redPaint = roof / 4.3;

            Console.WriteLine("Green paint = {0:f2}", greenPaint);
            Console.WriteLine("Red paint = {0:f2}", redPaint);
        }
    }
}
