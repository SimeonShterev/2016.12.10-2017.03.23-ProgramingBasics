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

            var zLeftSide = 0;
            var zRightSide = 0;


            for (int i = 0; i <= (n / 2 - 1); i++)
            {
                zLeftSide = i;
                zRightSide = i;
                Console.Write(new string('.', (n / 2) - 1 - i));
                if (i == 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write("/ ");
                }

                while (zLeftSide >= 2)
                {
                    if (zLeftSide == 2)
                    {
                        Console.Write("/");
                    }
                    else
                    {
                        Console.Write("/ ");
                    }
                    zLeftSide -= 2;
                }

                while (zRightSide >= 2)
                {
                    if (zRightSide == i && zRightSide%2==0)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" \\");
                    }
                    zRightSide -= 2;
                }

                if (i == 0)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(" \\");
                }

                Console.Write(new string('.', (n / 2) - 1 - i));
                Console.WriteLine();
            }
        }
    }
}
