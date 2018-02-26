using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyteshestwie
{
    class Program
    {
        static void Main(string[] args)
        {
            //ako gorivoto ne mi stigne, shte zaredq. 
            string startTown = Console.ReadLine();
            string endTown = Console.ReadLine();
            double rezervoarPercent = double.Parse(Console.ReadLine());

            Console.WriteLine("trygnah ot {0}", startTown);
            bool isFuelNotEnough = rezervoarPercent != 1;
            if (isFuelNotEnough);
            Console.WriteLine("spiram da zaredq");

            Console.WriteLine("pristignah v {0}", endTown);



        }
    }
}
