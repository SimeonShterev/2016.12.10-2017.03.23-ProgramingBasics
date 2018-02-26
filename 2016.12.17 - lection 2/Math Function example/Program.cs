using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Function_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            var result = first * second;
            Console.WriteLine(result);
            Console.WriteLine(Math.Floor(44.99)); //mathfloor, mathceeleng, mathtruncate
        }
    }
}
