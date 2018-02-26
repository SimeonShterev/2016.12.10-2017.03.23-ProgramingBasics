using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
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
                        result = qty * 0.50;
                        Console.WriteLine(result);
                        break;
                    case "water":
                        result = qty * 0.8;
                        Console.WriteLine(result);
                        break;
                    case "beer":
                        result = qty * 1.2;
                        Console.WriteLine(result);
                        break;
                    case "sweets":
                        result = qty * 1.45;
                            Console.WriteLine(result);
                        break; ;
                    case "peanuts":
                        result = qty * 1.6;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }

            else if (city == "Plovdiv")
            {
                switch(product)
                {
                    case "coffee":
                        result = qty * 0.40;
                        Console.WriteLine(result);
                        break;
                    case "water":
                        result = qty * 0.7;
                        Console.WriteLine(result);
                        break;
                    case "beer":
                        result = qty * 1.15;
                        Console.WriteLine(result);
                        break;
                    case "sweets":
                        result = qty * 1.3;
                        Console.WriteLine(result);
                        break;
                    case "peanuts":
                        result = qty * 1.5;
                        Console.WriteLine(result);
                        break;
                }
            } 

            else if (city=="Varna")
            {
                switch(product)
                {
                    case "coffee":
                        result = qty * 0.45;
                        Console.WriteLine(result);
                        break;
                    case "water":
                        result = qty * 0.7;
                        Console.WriteLine(result);
                        break;
                    case "beer":
                        result = qty * 1.1;
                        Console.WriteLine(result);
                        break;
                    case "sweets":
                        result = qty * 1.35;
                        Console.WriteLine(result);
                        break;
                    case "peanuts":
                        result = qty * 1.55;
                        Console.WriteLine(result);
                        break;
                } 
            }
        }
    }
}
