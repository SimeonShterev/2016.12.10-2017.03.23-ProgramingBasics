using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlojeni_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j=0; j<2; j++)
            {
                Console.WriteLine(new string('R', 20)); //ако искаме да принтираме 'R '(R място)
                                                        //използваме вложени цикли
            }
        }
    }
}
