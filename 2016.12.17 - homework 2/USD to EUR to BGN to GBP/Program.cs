using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_EUR_to_BGN_to_GBP
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            var vhodnaValuta = Console.ReadLine();
            var izhodnaValuta = Console.ReadLine();

            double uniValuta;
            double result;

            if (vhodnaValuta == "USD")
            {
                uniValuta = sum * 1.79549;
            }
            else if (vhodnaValuta == "GBP")
            {
                uniValuta = sum * 2.53405;
            }
            else if (vhodnaValuta == "EUR")
            {
                uniValuta = sum * 1.95583;
            }
            else
            {
                uniValuta = sum;
            }

            //----------------------------------------

            if (izhodnaValuta == "USD")
            {
                result = uniValuta / 1.79549;
            }
            else if (izhodnaValuta == "GBP")
            {
                result = uniValuta / 2.53405;
            }
            else if (izhodnaValuta == "EUR")
            {
                result = uniValuta / 1.95583;
            }
            else
            {
                result = uniValuta;
            }
            Console.WriteLine(Math.Round(result,2));
        }
    }
}
