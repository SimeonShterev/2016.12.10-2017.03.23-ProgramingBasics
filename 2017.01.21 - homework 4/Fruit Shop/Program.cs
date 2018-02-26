using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            double qty = double.Parse(Console.ReadLine());
            double price;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" ||
                dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                switch (fruit)
                {
                    case ("banana"):
                        price = qty * 2.5;
                        Console.WriteLine(price);
                        break;
                    case ("apple"):
                        price = qty * 1.2;
                        Console.WriteLine(price);
                        break;
                    case ("orange"):
                        price = qty * 0.85;
                        Console.WriteLine(price);
                        break;
                    case ("grapefruit"):
                        price = qty * 1.45;
                        Console.WriteLine(price);
                        break;
                    case ("kiwi"):
                        price = qty * 2.7;
                        Console.WriteLine(price);
                        break;
                    case ("pineapple"):
                        price = qty * 5.5;
                        Console.WriteLine(price);
                        break;
                    case ("grapes"):
                        price = qty * 3.85;
                        Console.WriteLine(price);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
                Console.WriteLine("error");

            //-----------------------------------------

            if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                switch (fruit)
                {
                    case ("banana"):
                        price = qty * 2.7;
                        Console.WriteLine(price);
                        break;
                    case ("apple"):
                        price = qty * 1.25;
                        Console.WriteLine(price);
                        break;
                    case ("orange"):
                        price = qty * 0.9;
                        Console.WriteLine(price);
                        break;
                    case ("grapefruit"):
                        price = qty * 1.6;
                        Console.WriteLine(price);
                        break;
                    case ("kiwi"):
                        price = qty * 3;
                        Console.WriteLine(price);
                        break;
                    case ("pineapple"):
                        price = qty * 5.6;
                        Console.WriteLine(price);
                        break;
                    case ("grapes"):
                        price = qty * 4.2;
                        Console.WriteLine(price);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
                Console.WriteLine("error");

        }
    }
}
