using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.Write(new string('-', n / 2 - 1));
                Console.Write(new string('*', 2));
                Console.WriteLine(new string('-', n / 2 - 1));

                for (int i = 1; i < n/2; i++)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - i) + "*" + new string('-', 2*i) + "*" + new string('-', n / 2 - 1 - i));
                }

                for (int i = n / 2 - 2; i >= 1; i--)
                {
                    Console.WriteLine(new string('-', n / 2 - 1 - i) + "*" + new string('-', 2 * i) + "*" + new string('-', n / 2 - 1 - i));
                }

                Console.Write(new string('-', n / 2 - 1));
                Console.Write(new string('*', 2));
                Console.WriteLine(new string('-', n / 2 - 1));
            }
            else
            {
                Console.Write(new string('-', n / 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', n / 2));

                for (int i = 1; i <= n / 2; i++)
                {
                    Console.WriteLine(new string('-', n / 2 - i) + "*" + new string('-', 2 * i - 1) + "*" + new string('-', n / 2 - i));
                }

                for (int i = n / 2 - 1; i >= 1; i--)
                {
                    Console.WriteLine(new string('-', n / 2 - i) + "*" + new string('-', 2 * i - 1) + "*" + new string('-', n / 2 - i));
                }

                Console.Write(new string('-', n / 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', n / 2));
            }
        }
    }
}

