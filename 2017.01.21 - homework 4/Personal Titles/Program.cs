using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender =char.Parse(Console.ReadLine()); // <-- important

            if (gender == 'm' && age<16)
                Console.WriteLine("Master");

            else if (gender == 'm' && age>=16)
                Console.WriteLine("Mr.");

            else if (gender == 'f' && age < 16)
                Console.WriteLine("Miss");

            else if (gender == 'f' && age >= 16)
                Console.WriteLine("Ms.");

        }
    }
}




