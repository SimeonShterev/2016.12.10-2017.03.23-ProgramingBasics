using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+ ");
            for (int minus = 1; minus <= (n - 2); minus++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            //----------------------------
            for (int minus=1; minus<=(n-2);minus ++)
            {
                Console.Write("| ");
                for ( int minus1=1; minus1<=(n-2); minus1++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            //------------------------------
            Console.Write("+ ");
            for (int minus = 1; minus <= (n - 2); minus++)
            {
                Console.Write("- ");
            }
            Console.WriteLine();
        }
    }
}
