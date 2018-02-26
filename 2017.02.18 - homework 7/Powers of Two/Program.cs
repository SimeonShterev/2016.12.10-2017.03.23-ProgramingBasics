using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int i=0; i<=number; i++)
            {
                double num = 2;
                num = Math.Pow(num, i);
                Console.WriteLine(num);
            }
        }
    }
}
