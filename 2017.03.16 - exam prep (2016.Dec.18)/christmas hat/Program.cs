using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas_hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('.', n * 2 - 1) + "/|\\" + new string('.', n * 2 - 1));
            Console.WriteLine(new string('.', n * 2 - 1) + "\\|/" + new string('.', n * 2 - 1));

            for (int midPart = (2 * n - 1); midPart >= 0; midPart--)
            {
                Console.Write(new string('.', midPart) + "*");
                Console.Write(new string('-', ((2 * n - 1) - midPart)) + "*");
                Console.Write(new string('-', ((2 * n - 1) - midPart)) + "*");
                Console.WriteLine(new string('.', midPart));
            }

            Console.WriteLine(new string('*', (4*n+1)));

            for (int i = 1; i <= (2 * n + 1); i++)
            {
                Console.Write("*");
                if (i == (2 * n + 1))
                {
                    break;
                }
                Console.Write(".");
            }
            Console.WriteLine( );

            Console.WriteLine(new string('*', (4 * n + 1)));
        }
    }
}
