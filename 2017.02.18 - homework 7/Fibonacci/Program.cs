using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibonacci = int.Parse(Console.ReadLine()); // there another way to solve that. Try for(int i=0;i<fibonacci;i++)
            var firstNum = 1;                              //                                      i+1 = i + (i-1)
            var secondNum = 1;
            var nextNum = 1;

            for (int i =0; i <= fibonacci - 2; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }
            Console.WriteLine(nextNum);
        }
    }
}
