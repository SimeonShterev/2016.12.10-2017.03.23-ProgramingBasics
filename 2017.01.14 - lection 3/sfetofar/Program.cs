using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfetofar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cherveno = bool.Parse(Console.ReadLine());
            bool jylto = bool.Parse(Console.ReadLine());
            bool zeleno = bool.Parse(Console.ReadLine());

            if (cherveno)
                Console.WriteLine("Stoq");
            else if (jylto)
                Console.WriteLine("Prigotvqm se");
            else
                Console.WriteLine("Trygvam");


        }
    }
}
