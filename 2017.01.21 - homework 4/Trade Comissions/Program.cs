using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commision;


            if (sales>=0 && sales<=500)
            {
                switch(city)
                {
                    case ("sofia"):
                        commision = sales * 0.05;
                        Console.WriteLine(commision);
                        break;
                    case ("varna"):
                        commision = sales * 0.045;
                        Console.WriteLine(commision);
                        break;
                    case ("plovdiv"):
                        commision = sales * 0.055;
                        Console.WriteLine(commision);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (sales >500 && sales <= 1000)
            {
                switch (city)
                {
                    case ("sofia"):
                        commision = sales * 0.07;
                        Console.WriteLine(commision);
                        break;
                    case ("varna"):
                        commision = sales * 0.075;
                        Console.WriteLine(commision);
                        break;
                    case ("plovdiv"):
                        commision = sales * 0.08;
                        Console.WriteLine(commision);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if(sales >1000 && sales <= 10000)
            {
                switch (city)
                {
                    case ("sofia"):
                        commision = sales * 0.08;
                        Console.WriteLine(commision);
                        break;
                    case ("varna"):
                        commision = sales * 0.1;
                        Console.WriteLine(commision);
                        break;
                    case ("plovdiv"):
                        commision = sales * 0.12;
                        Console.WriteLine(commision);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (sales >10000)
            {
                switch (city)
                {
                    case ("sofia"):
                        commision = sales * 0.12;
                        Console.WriteLine(commision);
                        break;
                    case ("varna"):
                        commision = sales * 0.13;
                        Console.WriteLine(commision);
                        break;
                    case ("plovdiv"):
                        commision = sales * 0.145;
                        Console.WriteLine(commision);
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
