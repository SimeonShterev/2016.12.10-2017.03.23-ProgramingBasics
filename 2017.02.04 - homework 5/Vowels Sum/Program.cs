using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int vowelSum = 0;
            
            for (int s = 0; s < text.Length; s++)
            {
                switch (text[s])
                {
                    case 'a':
                        vowelSum += 1;
                        break;
                    case 'e':
                        vowelSum += 2;
                        break;
                    case 'i':
                        vowelSum += 3;
                        break;
                    case 'o':
                        vowelSum += 4;
                        break;
                    case 'u':
                        vowelSum += 5;
                        break;        
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}
