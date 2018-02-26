using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for ( int i=1; i<=n; i++)
            {
                string row = new string(' ', n - i);
                Console.Write(row);

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();          // i did not solve that part alone
            }

            for (int i=n-1; i>=1; i--)
            {
                string row = new string(' ', n - i);
                Console.Write(row);
                for (int j=1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
