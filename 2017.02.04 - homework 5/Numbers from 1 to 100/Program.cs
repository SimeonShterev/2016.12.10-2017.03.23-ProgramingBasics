using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_from_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number=1; number<=1000; number++)
            {
                if (number%10==7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
