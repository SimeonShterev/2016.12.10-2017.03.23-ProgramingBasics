using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            double result;

            if (typeOfFigure == "square")
            {
                double stranaNaKvadrat = double.Parse(Console.ReadLine());
                result = stranaNaKvadrat * stranaNaKvadrat;
            }

            else if (typeOfFigure == "rectangle")
            {
                double stranaA = double.Parse(Console.ReadLine());
                double stranaB = double.Parse(Console.ReadLine());
                result = stranaA * stranaB;
            }

            else if (typeOfFigure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = radius * radius * Math.PI;
            }

            else
            {
                double hipotenuza = double.Parse(Console.ReadLine());
                double visochina = double.Parse(Console.ReadLine());
                result = hipotenuza * visochina / 2;
            }

            Console.WriteLine(Math.Round(result,3));
        }
    }
}
