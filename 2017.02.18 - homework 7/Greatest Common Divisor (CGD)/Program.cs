using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var biggerNum = 0;
            var smallerNum = 0;
            var thirdNum = 0;
            var result = 0;
            
            if (firstNum>=secondNum)
            {
                biggerNum= firstNum;
                smallerNum = secondNum;
            }
            else
            {
                biggerNum = secondNum;
                smallerNum = firstNum;
            }

            do
            {
                result = smallerNum;
                thirdNum = biggerNum % smallerNum;
                biggerNum = smallerNum;
                smallerNum = thirdNum;
            }
            while (thirdNum != 0);
            Console.WriteLine(result);

        }
    }
}
