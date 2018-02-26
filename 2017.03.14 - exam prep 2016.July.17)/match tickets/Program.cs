using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            var numberOfPeople = int.Parse(Console.ReadLine());
            var priceOfTicket = 0.0;
            var moneyNeededForTickets = 0.0;
            var moneyLeftForTickets = 0.0;

            int percentageOfAllMoney = 0;

            if (numberOfPeople > 0 && numberOfPeople < 5)
            {
                percentageOfAllMoney = 75;
            }
            else if (numberOfPeople > 4 && numberOfPeople < 10)
            {
                percentageOfAllMoney = 60;
            }
            else if (numberOfPeople > 9 && numberOfPeople < 25)
            {
                percentageOfAllMoney = 50;
            }
            else if (numberOfPeople > 24 && numberOfPeople < 50)
            {
                percentageOfAllMoney = 40;
            }
            else if (numberOfPeople > 49)
            {
                percentageOfAllMoney = 25;
            }

            if (category == "normal")
            {
                priceOfTicket = 249.99;
            }
            else if (category=="vip")
            {
                priceOfTicket = 499.99;
            }

            moneyLeftForTickets = budget - ((double)percentageOfAllMoney / 100 * budget);
            moneyNeededForTickets = priceOfTicket * numberOfPeople;

            if (moneyNeededForTickets<moneyLeftForTickets)
            {
                Console.WriteLine("Yes! You have {0:f} leva left.", (moneyLeftForTickets-moneyNeededForTickets));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", (moneyNeededForTickets-moneyLeftForTickets));
            }

        }
    }
}
