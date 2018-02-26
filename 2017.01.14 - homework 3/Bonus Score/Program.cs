using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;

            if (number <= 100)
            {
                bonusPoints = 5;
            }
            if (number<=1000 && number>100)
            {
                bonusPoints = number * 0.2;   
            }
            if (number>1000)
            {
                bonusPoints = number * 0.1;
            }

            double additionalBonusPoints = 0.0;
            if (number % 2 == 0)
                additionalBonusPoints = 1;
            if (number % 10 == 5)
                additionalBonusPoints = 2;
            Console.WriteLine(bonusPoints+additionalBonusPoints);
            Console.WriteLine(number + bonusPoints + additionalBonusPoints);
        }
    }
}
