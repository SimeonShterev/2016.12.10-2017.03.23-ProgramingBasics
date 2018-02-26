﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool horizontalBorder = ((x1 <= x && x <= x2) && (y == y1 || y == y2));
            bool verticalBorder = ((y1 <= y && y2 >= y) && (x == x1 || x == x2));
            
            if (horizontalBorder==true || verticalBorder==true)
                Console.WriteLine("Border");
            else
                Console.WriteLine("Inside / Outside"); // probvai bez intervali inside/outside
                
          }
    }
}
