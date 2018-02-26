using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            while(n%2==0)
            {
                var m = int.Parse(Console.ReadLine());
                n = m;
            }

            var topPart = n;
            var bottomPart = n;
            var midPart = n;
            var one = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i) + "\\");
                Console.Write(new string('-', 2 * topPart - 1) + "/");
                Console.WriteLine(new string('*', i));
                topPart--;
            }


            for (int i = 1; i <= n/3; i++)
            {
                Console.Write("|" + new string('*', (n - 3) / 2));
                Console.Write(new string('*', one) + "\\");
                Console.Write(new string('*', midPart) + "/");                
                Console.Write(new string('*', one));
                Console.WriteLine(new string('*', (n - 3) / 2) + "|");
                midPart -= 2;
                one++;
            }   


                for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i) + "\\");
                Console.Write(new string('*', 2 * bottomPart - 1) + "/");
                Console.WriteLine(new string('-', i));
                bottomPart--;
            }
        }
    }
}
