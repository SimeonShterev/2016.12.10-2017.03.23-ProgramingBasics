using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var sesson = Console.ReadLine().ToLower();
            string housing;
            string location;
            var price = 0.0;

            if (budget < 1000 && sesson=="summer")
            {
                housing = "Camp";
                location = "Alaska";
                price = budget * 0.65;
            }
            else if (budget<1000 && sesson=="winter")
            {
                housing = "Camp";
                location = "Marocco";
                price = budget * 0.45;
            }

            if (budget > 1000 && budget < 3000 && sesson == "summer")
            {
                housing = "Hut";
                location = "Alaska";
                price = budget * 0.80;
            }
            else if (budget > 1000 && budget < 3000 && sesson == "winter")
            {
                housing = "Hut";
                location = "Marocco";
                price = budget * 0.60;
            }

            if (budget > 3000 && sesson == "summer")
            {
                housing = "Hotel";
                location = "Alaska";
                price = budget * 0.9;
            }
            else if (budget > 3000 && sesson == "winter")
            {
                housing = "Hotel";
                location = "Marocco";
                price = budget * 0.9;
            }

            Console.WriteLine("{0} - {1} - {2:f2}", location, housing, price);
        }
    }
}
