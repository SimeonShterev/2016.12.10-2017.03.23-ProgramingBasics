using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            if (n%2==1)
            {
                for (int i = 1; i <= n/2 - 1; i++)
                {
                    Console.Write("*" + new string('/', 2 * n - 2) + "*");
                    Console.Write(new string(' ', n));
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                }

                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                Console.Write(new string('|', n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");

                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Console.Write("*" + new string('/', 2 * n - 2) + "*");
                    Console.Write(new string(' ', n));
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                }
            }
            else
            {
                for (int i = 1; i <= n / 2 - 2; i++)
                {
                    Console.Write("*" + new string('/', 2 * n - 2) + "*");
                    Console.Write(new string(' ', n));
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                }

                Console.Write("*" + new string('/', 2 * n - 2) + "*");
                Console.Write(new string('|', n));
                Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");

                for (int i = 1; i <= n / 2 - 1; i++)
                {
                    Console.Write("*" + new string('/', 2 * n - 2) + "*");
                    Console.Write(new string(' ', n));
                    Console.WriteLine("*" + new string('/', 2 * n - 2) + "*");
                }
            }


            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
