using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int newN = n;
            int spec = (newN - 2) * 2;

            Console.WriteLine(new string('.', n) + new string('*', 3 * n) + new string('.', n));

            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string('.', i) + "*");
                Console.Write(new string('.', 3 * n + ((n - i -1) * 2)));
                Console.WriteLine("*" + new string('.', i));
            }

            Console.WriteLine(new string('*', 5 * n));

            for (int i = 1; i <= (2 * n); i++)
            {
                Console.Write(new string('.', i) + "*");
                Console.Write(new string('.', 3 * n + spec));
                Console.WriteLine("*" + new string('.', i));
                spec -= 2;
            }

            Console.WriteLine(new string('.',2*n+1) + new string('*', n-2) + new string('.', 2 * n + 1));
        }
    }
}
