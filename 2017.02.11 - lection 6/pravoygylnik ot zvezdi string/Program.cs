﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravoygylnik_ot_zvezdi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                string row = new string('*', 10);    //!!!!!!!!
                Console.WriteLine(row);
               // for (int j = 1; j <= 10; j++)
               // {
               //      Console.Write("*");
               // }
                Console.WriteLine();
            }

        }
    }
}
