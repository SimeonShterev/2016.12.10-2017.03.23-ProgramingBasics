using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var grade = 0.0;
            var countGrades = 0;
            var top = 0.0;
            var between4and5 = 0.0;
            var between3and4 = 0.0;
            var fail = 0.0;
            var average = 0.0;

            do
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    top++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    between4and5++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    between3and4++;
                }
                else if (grade < 3.00)
                {
                    fail++;
                }
                average += grade;
                countGrades++;
            }
            while (countGrades != students);

            top = top / students * 100;
            Console.WriteLine("Top students: {0:f2}%", top);

            between4and5 = between4and5 / students * 100;
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", between4and5);

            between3and4 = between3and4 / students * 100;
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", between3and4);

            fail = fail / students * 100;
            Console.WriteLine("Fail: {0:f2}%", fail);

            average = average / students;
            Console.WriteLine("Average: {0:f2}", average);
        }
    }
}
