using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var CNY = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());
            
            var BTCtoBGN = 1168;
            var CNYtoUSD = 0.15;
            var USDtoBGN = 1.76;
            var EURtoBGN = 1.95;

            var bitcoinInEUR = bitcoins * BTCtoBGN / EURtoBGN;
            var CNYinEUR = CNY * CNYtoUSD * USDtoBGN / EURtoBGN;

            var result = (bitcoinInEUR + CNYinEUR) * (100 - commission) / 100;

            Console.WriteLine(result);
        }
    }
}
