using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()); // I'm proud of solving this one.
            var secondVar = 0;                          //The first "real hard" problem I have solved.

            for (int i = 0; i < number; i++)
            {
                for (int j = 1; j <=number; j++)
                {
                    secondVar = i + j;
                    Console.Write(secondVar);

                    if (secondVar==number)
                    {
                        for (int k = number; k > (number-i); k--)
                        {
                            Console.Write(k-1);
                        }
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
