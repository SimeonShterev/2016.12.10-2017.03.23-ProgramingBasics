using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            var electricityPerMonth = 0.0;
            var waterPermonth = 20.0;
            var internetPerMonth = 15.0;
            var sumOfUtilities = 0.0;
            var electricityTotal = 0.0;


            for (int i = 1; i <= months; i++)
            {
                electricityPerMonth = double.Parse(Console.ReadLine());
                sumOfUtilities = sumOfUtilities + waterPermonth + internetPerMonth + electricityPerMonth;
                electricityTotal += electricityPerMonth;

            }

            var other = sumOfUtilities * 1.2;
            var average = (electricityTotal + waterPermonth * months + internetPerMonth * months + other) / months;

            Console.WriteLine("Electricity: {0:f2} lv", electricityTotal);
            Console.WriteLine("Water: {0:f2} lv", waterPermonth * months);
            Console.WriteLine("Internet: {0:f2} lv", internetPerMonth * months);
            Console.WriteLine("Other: {0:f2} lv", other);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
