using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool parseSuccess = int.TryParse(Console.ReadLine(), out number);
            Console.WriteLine(parseSuccess);//tova 6te se pogrivi za va6iq nevaliden whod
        }
    }
}
