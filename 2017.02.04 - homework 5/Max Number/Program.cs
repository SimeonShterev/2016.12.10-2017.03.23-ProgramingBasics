﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int biggestNum=int.MinValue;    // minValue представлява най -малката стойност
                                            // на съответния тип променлива(int, double, short....)
            for (int i=1; i<=n; i++)
            { 
                int num = int.Parse(Console.ReadLine());
                if (num>biggestNum)
                {
                    biggestNum = num;
                }
            }
            Console.WriteLine(biggestNum);

        }
    }
}
