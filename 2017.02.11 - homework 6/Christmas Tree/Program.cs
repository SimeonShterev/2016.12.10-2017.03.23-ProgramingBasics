using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string(' ', n) + " |");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n-i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.Write(" | ");

                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
