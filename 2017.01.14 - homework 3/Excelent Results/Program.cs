using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excelent_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            double ocenka = double.Parse(Console.ReadLine());
            if (ocenka >=5.5)
                Console.WriteLine("Excellent!");
        }
    }
}
