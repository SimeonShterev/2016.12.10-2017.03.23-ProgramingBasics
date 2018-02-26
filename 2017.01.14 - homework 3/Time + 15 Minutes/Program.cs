using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + 15;
            int newMinutes;
            int newHours;

            if (hours == 23 && minutes > 59)
            {
                newHours = 0;
                newMinutes = minutes - 60;
                Console.WriteLine("{0}:{1:00}", newHours, newMinutes);
            }
            else if (minutes < 60)
            {
                Console.WriteLine("{0}:{1:00}", hours, minutes);
            }
            else
            {
                newMinutes = minutes - 60;
                newHours = hours + 1;
                Console.WriteLine("{0}:{1:00}", newHours, newMinutes);
            }
        }
    }
}
