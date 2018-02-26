using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_and_Time.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2016, 12, 18);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
