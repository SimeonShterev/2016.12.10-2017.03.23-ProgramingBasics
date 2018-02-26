using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var rest = 0;
            var result = 0;

            while (number%10!=0 || number/10!=0) // or while (number!=0)
            {
                rest = number % 10;
                result = rest + result;
                number = number / 10;
            }

            Console.WriteLine(result);
        }
    }
}
