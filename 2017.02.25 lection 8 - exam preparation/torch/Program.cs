using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torch
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int upperPart = 1; upperPart <= (n / 2); upperPart++)
            {
                Console.Write(new string('.', n / 2 - upperPart) + "#");
                Console.Write(new string('.', upperPart * 2 - 2) + "#");
                Console.Write(new string('.', n / 2 - upperPart));
                Console.WriteLine();
            }

            for (int middlePart = (n / 2); middlePart > (n / 4); middlePart--)
            {
                Console.Write(new string('.', n / 2 - middlePart) + "#");
                Console.Write(new string('.', middlePart * 2 - 2) + "#");
                Console.Write(new string('.', n / 2 - middlePart));
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', n));

            for (int lowerPart = n / 2; lowerPart >= 1; lowerPart--)
            {
                Console.Write(new string('.', n / 2 - lowerPart));
                Console.Write(new string('\\', lowerPart) + new string('/', lowerPart));
                Console.Write(new string('.', n / 2 - lowerPart));
                Console.WriteLine();
            }
        }
    }
}
