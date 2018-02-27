using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lice_na_triagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h=");
            var h = double.Parse(Console.ReadLine());
            double S;
            S = a * h / 2;
            Console.WriteLine(S);
        }
    }
}
