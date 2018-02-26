using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biggest_and_smallest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var biggestNum = int.MinValue;
            var smallestNum = int.MaxValue;
            var n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                int eachNumber = int.Parse(Console.ReadLine());

                if (eachNumber > biggestNum)
                {
                    biggestNum = eachNumber;
                }

                if (eachNumber < smallestNum)
                {
                    smallestNum = eachNumber;
                }
            }
            Console.WriteLine("the biggest number is {0}", biggestNum);
            Console.WriteLine("the smalest number is {0}", smallestNum);
        }
    }
}
