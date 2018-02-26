using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int firstNumber = 1;

            while (firstNumber <= maxNumber)
            {
                Console.WriteLine(firstNumber);
                firstNumber = 2 * firstNumber + 1;
            }
        }
    }
}
