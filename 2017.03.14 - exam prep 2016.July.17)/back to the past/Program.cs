using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back_to_the_past
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritance = double.Parse(Console.ReadLine());
            var yearTillLiving = int.Parse(Console.ReadLine());

            var yearStartsLiving = 1800;
            var age = 18;
            var moneyToLive = 0.0;

            for (int i = yearStartsLiving; i <= yearTillLiving; i++)
            {
                if (i % 2 == 0)
                {
                    moneyToLive += 12000;
                }
                else
                {
                    moneyToLive = moneyToLive + 12000 + (age * 50);
                }

                age++;
            }

            if (moneyToLive <= inheritance)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritance-moneyToLive);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", moneyToLive-inheritance);
            }
        }
    }
}
