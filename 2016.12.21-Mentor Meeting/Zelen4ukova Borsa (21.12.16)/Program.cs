using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelen4ukova_Borsa__21._12._16_
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVeg = double.Parse(Console.ReadLine());
            var priceFruit = double.Parse(Console.ReadLine());
            var weightVeg = int.Parse(Console.ReadLine());
            var weightFruit = int.Parse(Console.ReadLine());

            var veg = priceVeg * weightVeg;
            var fruit = priceFruit * weightFruit;

            var profit = (veg + fruit) / 1.94;

            Console.WriteLine(profit);
        }
    }
}
