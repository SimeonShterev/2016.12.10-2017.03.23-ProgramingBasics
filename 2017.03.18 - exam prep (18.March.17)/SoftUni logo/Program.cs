using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (2 * n); i++)
            {
                Console.Write(new string('.', ((6 * n - 3) - (i - 1) * 3)));
                Console.Write(new string('#',((i-1)*6)+1));
                Console.Write(new string('.', ((6 * n - 3) - (i - 1) * 3)));
                Console.WriteLine();
            }
            for (int i = 1; i <= (n - 2); i++)
            {
                Console.Write("|" + new string('.', (i * 3) - 1));
                Console.Write(new string('#', (n - i - 1) * 3));
                Console.Write(new string('#', 6 * n + 1));
                Console.Write(new string('#', (n - i - 1) * 3));
                Console.Write(new string('.', (i * 3)));
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("|" + new string('.', 3 * n - 4));
                Console.Write(new string('#', 6 * n + 1));
                Console.WriteLine(new string('.', 3 * n - 3));
            }

            Console.Write("@" + new string('.', 3 * n - 4));
            Console.Write(new string('#', 6 * n + 1));
            Console.WriteLine(new string('.', 3 * n - 3));
        }
    }
}
