using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_or_veggi__switch_case_
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();

            switch(productName)
            {
                case "apple":
                    Console.WriteLine("fruit");
                    break;
                case "banana":
                    Console.WriteLine("fruit");
                    break;
                case "kiwi":
                    Console.WriteLine("fruit");
                    break;
                case "grapes":
                    Console.WriteLine("fruit");
                    break;
                case "mango":
                    Console.WriteLine("fruit");
                    break;


                case "tomato":
                    Console.WriteLine("veggi");
                    break;
                case "carrot":
                    Console.WriteLine("veggi");
                    break;
                case "pepper":
                    Console.WriteLine("veggi");
                    break;
                case "cucamber":
                    Console.WriteLine("veggi");
                    break;


                default:
                    Console.WriteLine("unknown");
                    break;



            }
        }
    }
}
