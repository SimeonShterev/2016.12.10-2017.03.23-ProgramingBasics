using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ракла
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <100; i++)
            {
                Console.Write("Cloth colour: ");
                string color = Console.ReadLine();

                // ako e chervena - preskochi i prodalji
                if (color == "red")
                    continue;
                Console.WriteLine(color);
            }

        }
    }
}
