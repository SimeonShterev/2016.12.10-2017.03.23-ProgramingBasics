using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace true__false
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuestions = int.Parse(Console.ReadLine());

            bool moveForward = numberOfQuestions == 0;

            Console.WriteLine(moveForward);
        }
    }
}
