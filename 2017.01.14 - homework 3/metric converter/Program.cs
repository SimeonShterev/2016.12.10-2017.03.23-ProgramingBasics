using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metric_converter
{
    class Program
    {
        static void Main(string[] args) 
        {
            double vhodqshtaStoinost = double.Parse(Console.ReadLine());
            string vhodnaMernaEdinica = (Console.ReadLine());
            string izhodnaMernaEdinica = (Console.ReadLine());

            double uniMernaEdinica;
            double result;


            if (vhodnaMernaEdinica == "mm")
                uniMernaEdinica = vhodqshtaStoinost / 1000;

            else if (vhodnaMernaEdinica == "cm")
                uniMernaEdinica = vhodqshtaStoinost / 100;

            else if (vhodnaMernaEdinica == "mi")
                uniMernaEdinica = vhodqshtaStoinost / 0.000621371192;

            else if (vhodnaMernaEdinica == "in")
                uniMernaEdinica = vhodqshtaStoinost / 39.3700787;

            else if (vhodnaMernaEdinica == "km")
                uniMernaEdinica = vhodqshtaStoinost / 0.001;

            else if (vhodnaMernaEdinica == "ft")
                uniMernaEdinica = vhodqshtaStoinost / 3.2808399;

            else if (vhodnaMernaEdinica == "yd")
                uniMernaEdinica = vhodqshtaStoinost / 1.0936133;

            else
                uniMernaEdinica = vhodqshtaStoinost;

            //------------------------------------------------------

            if (izhodnaMernaEdinica == "mm")
                result = uniMernaEdinica * 1000;

            else if (izhodnaMernaEdinica == "cm")
                result = uniMernaEdinica * 100;

            else if (izhodnaMernaEdinica == "mi")
                result = uniMernaEdinica * 0.000621371192;

            else if (izhodnaMernaEdinica == "in")
                result = uniMernaEdinica * 39.3700787;

            else if (izhodnaMernaEdinica == "km")
                result = uniMernaEdinica * 0.001;

            else if (izhodnaMernaEdinica == "ft")
                result = uniMernaEdinica * 3.2808399;
       
            else if (izhodnaMernaEdinica == "yd")
                result = uniMernaEdinica * 1.0936133;

            else
                result = uniMernaEdinica;

            //===================================================

            Console.WriteLine(result+ " " +izhodnaMernaEdinica);
        }
    }
}
