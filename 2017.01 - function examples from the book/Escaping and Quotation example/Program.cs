using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaping_and_Quotation_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotedString = @"The ""use"" of quotations causes difficulties //\\";
            //Цитираните низове се използват често пъти за задаване на имена на пътища в системата!
            Console.WriteLine(quotedString);
            string unquotedString = "The \"use\" of quotations causes difficulties";
            Console.WriteLine(unquotedString);
        }
    }
}
