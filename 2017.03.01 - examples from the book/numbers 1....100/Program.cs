using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_1._._._._100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number between 1 and 100");

            var number = int.Parse(Console.ReadLine());
            int secondDigit = 0;

            switch(number)
            {
                case (1):
                    Console.WriteLine("one");
                    break;
                case (2):
                    Console.WriteLine("two");
                    break;
                case (3):
                    Console.WriteLine("three");
                    break;
                case (4):
                    Console.WriteLine("four");
                    break;
                case (5):
                    Console.WriteLine("five");
                    break;
                case (6):
                    Console.WriteLine("six");
                    break;
                case (7):
                    Console.WriteLine("seven");
                    break;
                case (8):
                    Console.WriteLine("eight");
                    break;
                case (9):
                    Console.WriteLine("nine");
                    break;
                case (10):
                    Console.WriteLine("ten");
                    break;
                case (11):
                    Console.WriteLine("one");
                    break;
                case (12):
                    Console.WriteLine("two");
                    break;
                case (13):
                    Console.WriteLine("one");
                    break;
                case (14):
                    Console.WriteLine("two");
                    break;
                case (15):
                    Console.WriteLine("one");
                    break;
                case (16):
                    Console.WriteLine("two");
                    break;
                case (17):
                    Console.WriteLine("one");
                    break;
                case (18):
                    Console.WriteLine("two");
                    break;
                case (19):
                    Console.WriteLine("nineteen");
                    break;
                default:
                    {

                        if (number > 19 && number < 30)
                        {
                            Console.Write("twenty ");
                            secondDigit = number % 10;

                            switch (secondDigit)
                            {
                                case (1):
                                    Console.WriteLine("one");
                                    break;
                                case (2):
                                    Console.WriteLine("two");
                                    break;
                                case (3):
                                    Console.WriteLine("three");
                                    break;
                                case (4):
                                    Console.WriteLine("four");
                                    break;
                                case (5):
                                    Console.WriteLine("five");
                                    break;
                                case (6):
                                    Console.WriteLine("six");
                                    break;
                                case (7):
                                    Console.WriteLine("seven");
                                    break;
                                case (8):
                                    Console.WriteLine("eight");
                                    break;
                                case (9):
                                    Console.WriteLine("nine");
                                    break;
                                default:
                                    Console.WriteLine(" ");
                                    break;
                            }
                        }
                        else if (number > 29 && number < 40)
                        {
                            Console.Write("thirty ");
                            secondDigit = number % 10;

                            switch (secondDigit)
                            {
                                case (1):
                                    Console.WriteLine("one");
                                    break;
                                case (2):
                                    Console.WriteLine("two");
                                    break;
                                case (3):
                                    Console.WriteLine("three");
                                    break;
                                case (4):
                                    Console.WriteLine("four");
                                    break;
                                case (5):
                                    Console.WriteLine("five");
                                    break;
                                case (6):
                                    Console.WriteLine("six");
                                    break;
                                case (7):
                                    Console.WriteLine("seven");
                                    break;
                                case (8):
                                    Console.WriteLine("eight");
                                    break;
                                case (9):
                                    Console.WriteLine("nine");
                                    break;
                                default:
                                    Console.WriteLine(" ");
                                    break;
                            }

                        }
                    }
                    break;
            }
        }
    }
}
