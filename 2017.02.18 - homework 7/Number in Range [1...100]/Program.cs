using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number in Range 0..100");
            var number = 0;
            
            while (number<1 || number>100)
            {
                Console.WriteLine("Enter a number");
                number = int.Parse(Console.ReadLine());
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("Error");
                }
            }
            Console.WriteLine("This number is {0}", number);
        }
    }
}
