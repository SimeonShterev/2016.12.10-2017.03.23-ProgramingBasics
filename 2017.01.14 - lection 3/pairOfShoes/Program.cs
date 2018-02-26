using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairOfShoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int shoePairs = int.Parse(Console.ReadLine());

            bool isLadyHappy = shoePairs >= 3;
            Console.WriteLine(isLadyHappy);
        }
    }
}
