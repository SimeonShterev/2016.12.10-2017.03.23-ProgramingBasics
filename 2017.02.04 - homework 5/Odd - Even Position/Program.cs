using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= broi; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }

            Console.WriteLine("oddSum " + oddSum);
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("oddMin no");
            }
            else
            {
                Console.WriteLine("oddMin " + oddMin);
            }

            if (oddMax == double.MinValue)
            {
                Console.WriteLine("oddMax no");
            }
            else
            {
                Console.WriteLine("oddMax " + oddMax);
            }

            if (evenMax == double.MinValue)
            {

            }

            Console.WriteLine("evenSum " + evenSum);
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine("evenMin no");
            }
            else
            {
                Console.WriteLine("evenMin " + evenMin);
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("evenMax no");
            }
            else
            {
                Console.WriteLine("evenMax " + evenMax);
            }
        }
    }
}
