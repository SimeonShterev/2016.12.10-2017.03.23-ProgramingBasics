using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var firstDigit = number / 100;
            var secondDigit = (number % 100) / 10;
            var thirdDigit = number % 10;

            for (int rows = 1; rows <= (firstDigit + secondDigit); rows++)
            {
                for (int column = 1; column <= (firstDigit + thirdDigit); column++)
                {
                    if (number % 5 == 0)
                    {
                        number -= firstDigit;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= secondDigit;
                    }
                    else
                    {
                        number += thirdDigit;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
