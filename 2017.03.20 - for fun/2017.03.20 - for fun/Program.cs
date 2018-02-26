using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017._03._20___for_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++) 
            {
                var iCopy = i;
                Console.Write(new string('.', n / 2 - i - 1) + "/");
                if (i != 0)
                {
                    Console.Write(" ");
                }

                while (iCopy % 2 == 0 && iCopy != 0)
                {
                    iCopy -= 2;
                    Console.Write("/");
                    if (i != 2)
                    {
                        Console.Write(" ");
                    }

                    if (i != 2)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");
                }

                if (i != 0)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\" + new string('.', n / 2 - i - 1));
            }
        }
    }
}
