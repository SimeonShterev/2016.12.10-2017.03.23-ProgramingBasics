using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_combination_slav_s_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var lasttLetter = char.Parse(Console.ReadLine());
            var letterToSkip = char.Parse(Console.ReadLine());
            int combinationsPrinted = 0;

            for (char i = firstLetter; i <= lasttLetter; i++)
            {
                for (char j = firstLetter; j <= lasttLetter; j++)
                {
                    for (char k = firstLetter; k <= lasttLetter; k++)
                    {
                        if (i == letterToSkip || j == letterToSkip || k == letterToSkip)
                            continue;
                        Console.WriteLine("{0}{1}{2}", i, j, k);
                        combinationsPrinted++;
                    }
                }
            }
            Console.WriteLine(combinationsPrinted); //100% works
        }
    }
}
