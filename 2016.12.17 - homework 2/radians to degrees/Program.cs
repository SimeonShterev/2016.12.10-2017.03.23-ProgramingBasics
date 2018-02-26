using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radians_to_degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degrees = Math.Round(radians * 180 / Math.PI, 0);
            Console.WriteLine(degrees);
        }
    }
}
