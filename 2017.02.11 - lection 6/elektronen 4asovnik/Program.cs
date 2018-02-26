using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elektronen_4asovnik
{
    class Program
    {
        static void Main(string[] args)
        {
            for ( int hh = 0; hh<=23; hh++)
            {
                for ( int mm= 0; mm<=59; mm++)
                {
                    Console.WriteLine("{0:00} : {1:00}",hh,mm);
                }
            }

        }
    }
}
