using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object c = a + " " + b;
            string abc = c.ToString();
            Console.WriteLine(abc);

            int firstNumber = 5;
            int secondNumber = 9;
            double result = 0;

            result = (double)secondNumber / firstNumber;
            Console.WriteLine(result);
        }
    }
}
