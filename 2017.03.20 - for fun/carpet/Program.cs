using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var z = 0;
            var zInner = 0;

            for (int i = 0; i <= (n / 2 - 1); i++)
            {
                z = i;
                Console.Write(new string('.', (n / 2) - 1 - i));
                if (i == 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("/ ");
                }
                while (z >= 2)
                {
                    zInner = z;
                    if (z == 2)
                    {
                        Console.Write("/");                       
                    }
                    else
                    {
                        Console.Write("/ ");
                   
                    }
                    while (zInner >= 2)
                    {
                        if (zInner == 2)
                        {
                            Console.Write("\\");
                        }
                        else
                        {
                            Console.Write(" \\");

                        }
                        zInner -= 2;
                    }
                    z -= 2;
                }
                Console.WriteLine();
            }
        }
    }
}
