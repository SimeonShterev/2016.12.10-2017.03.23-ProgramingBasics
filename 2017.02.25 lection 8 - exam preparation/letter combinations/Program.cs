using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letter_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var lastLetter = char.Parse(Console.ReadLine());
            var exceptionLetter = char.Parse(Console.ReadLine());
            int broq4 = 0;

            for (char i = firstLetter; i <= lastLetter; i++)
            {
                if (i == exceptionLetter)
                {
                    continue;
                }

                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    if (j == exceptionLetter)
                    {
                        continue;
                    }

                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        if(k==exceptionLetter)
                        {
                            continue;
                        }
                        Console.WriteLine("{0}{1}{2}",i,j,k);
                        broq4++;
                    }
                   
                }
            }
            Console.WriteLine(broq4);

           
        }
    }
}
