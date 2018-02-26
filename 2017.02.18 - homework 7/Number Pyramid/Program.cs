using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var subject = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    subject += 1;
                    Console.Write(subject + " ");

                    if (subject == number)
                    {
                        break;
                    }
                }
                Console.WriteLine();

                if (subject == number)
                    {
                        break;
                    }
                }
            }
        }
    }
 