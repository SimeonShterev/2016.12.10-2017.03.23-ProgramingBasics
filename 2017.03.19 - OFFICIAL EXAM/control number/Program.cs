using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNum = int.Parse(Console.ReadLine());

            var sum = 0;
            var moves = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    if (sum >= controlNum)
                    {
                        Console.WriteLine("{0} moves", moves);
                        Console.WriteLine("Score: {0} >= {1}", sum, controlNum);
                        return;
                    }
                    sum = sum + (i * 2) + (j * 3);
                    moves++;                  
                }           
            }
            Console.WriteLine("{0} moves", moves);
        }
    }
}
