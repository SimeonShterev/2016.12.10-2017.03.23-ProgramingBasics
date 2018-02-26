using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriqPrice = double.Parse(Console.ReadLine());
            var kopyrkaPrice = double.Parse(Console.ReadLine());
            var palamudKG = double.Parse(Console.ReadLine());
            var safridKG = double.Parse(Console.ReadLine());
            var midiKG = double.Parse(Console.ReadLine());

            double palamud = palamudKG * skumriqPrice * 1.6;
            double safrid = safridKG * kopyrkaPrice * 1.8;
            double midi = midiKG * 7.5;

            var result = palamud + safrid + midi;
            Console.WriteLine("{0:f2}", result);
      
        }
    }
}
