using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int smallestNum = int.MaxValue;

            for (int i=1; i<=n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num<smallestNum)
                {
                    smallestNum = num;
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
