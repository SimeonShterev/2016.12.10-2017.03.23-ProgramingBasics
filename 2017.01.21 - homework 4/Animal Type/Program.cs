using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animalType = Console.ReadLine().ToLower();

            if (animalType=="crocodile" || animalType=="tortoise" || animalType=="snake")
                Console.WriteLine("reptile");
            else if (animalType=="dog")
                Console.WriteLine("mammal");
            else
                Console.WriteLine("unknown");
        }
    }
}
