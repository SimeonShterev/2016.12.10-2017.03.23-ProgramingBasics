using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_1_cicle
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainingDays = int.Parse(Console.ReadLine());

            for (int currentDay =remainingDays; currentDay > 0; currentDay--)
            {
                Console.WriteLine("ostavat {0} dni", currentDay);
            }
            Console.WriteLine("systezanieto zapochva");
        }
    }
}
