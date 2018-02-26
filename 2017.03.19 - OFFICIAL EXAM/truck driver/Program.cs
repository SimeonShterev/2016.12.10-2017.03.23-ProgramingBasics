using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truck_driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            var kilometersPerMonth = double.Parse(Console.ReadLine());
            var moneyEarned = 0.0;
            var moneyAfterPayingBills = 0.0;
            var s = Console.ReadLine();
           
            if (kilometersPerMonth <= 5000)
            {
                switch(season)
                {
                    case "spring":
                    case "autumn":
                    moneyEarned = kilometersPerMonth * 0.75 * 4;
                        break;
                    case "summer":
                        moneyEarned = kilometersPerMonth * 0.90 * 4;
                        break;
                    case "winter":
                        moneyEarned = kilometersPerMonth * 1.05 * 4;
                        break;
                }
            }

            if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
            {
                switch(season)
                {
                    case "spring":
                    case "autumn":
                        moneyEarned = kilometersPerMonth * 0.95 * 4;
                        break;
                    case "summer":
                        moneyEarned = kilometersPerMonth * 1.10 * 4;
                        break;
                    case "winter":
                        moneyEarned = kilometersPerMonth * 1.25 * 4;
                        break;
                }
            }

            if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
            {
                moneyEarned = kilometersPerMonth * 1.45 * 4;
            }

            moneyAfterPayingBills = moneyEarned * 0.90;

            Console.WriteLine("{0:f2}", moneyAfterPayingBills);
        }
    }
}
