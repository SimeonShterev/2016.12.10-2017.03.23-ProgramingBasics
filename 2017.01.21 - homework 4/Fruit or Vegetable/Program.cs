using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_veggi__switch_case_
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            switch (productName)
            {
                case "apple":
                case "banana":
                case "kiwi":
                case "grapes":
                case "cherry":
                case "lemon":
                    Console.WriteLine("fruit");
                    break;
                case "tomato":
                case "carrot":
                case "cucumber":
                case "pepper":
                    Console.WriteLine("vegetable");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
