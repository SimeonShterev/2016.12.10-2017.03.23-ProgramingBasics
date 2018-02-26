using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());
            double result;

            if (city == "Sofia")
            {
                switch (product)
                {
                    case "coffee":
                    case "water":
                    case "beer":
                    case "sweets":
                    case "peanuts":
                        result = qty * 1.6;
                        Console.WriteLine(result);
                        break;
                }
            }
        }
    }
}
