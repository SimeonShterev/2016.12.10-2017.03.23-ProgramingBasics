using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace въвеждане_на_число
{
    class Program
    {
        static void Main(string[] args)
        {

            // въвеждай нещо си, докато то е различно от дванайсет

            string input;
            do
            {
                Console.WriteLine("vavedete...");
                input = Console.ReadLine();
                Console.WriteLine(input);
            }
            while (input != "12");
        }
    }
}
