using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= (n / 2); i++) 
            {
                Console.WriteLine(new string('.', n / 2 - i) + '#' + new string('.', (i - 1) * 2) + '#' + new string('.', n / 2 - i));
            }
            for (int i = n/4; i >=1; i--)
            {
                Console.WriteLine(new string('.', n / 4 - i) + '#' + new string('.', n-2*i+4) + '#' + new string('.', n / 4 - i));
            }
            Console.WriteLine(new string('-', n));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('.', i - 1) + new string('\\', n / 2 + 1 - i) + new string('/', n / 2 + 1 - i) + new string('.', i - 1));
            }
        }
    }
}
