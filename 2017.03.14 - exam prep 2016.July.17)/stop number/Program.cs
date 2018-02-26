using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stop_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var lowNum = int.Parse(Console.ReadLine());
            var highNum = int.Parse(Console.ReadLine());
            var stopNum = int.Parse(Console.ReadLine());

            int highNumDividendTo6 = highNum - highNum % 6;

            for (int i = highNumDividendTo6; i >= lowNum; i-=6)
            {
                if (i % 6 == 0)
                {
                    Console.Write(i + " ");
                }
                if (i == stopNum+6)
                {
                    break;
                }
            }

        }
    }
}
