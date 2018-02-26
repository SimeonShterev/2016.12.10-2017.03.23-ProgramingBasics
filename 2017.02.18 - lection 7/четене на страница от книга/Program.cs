using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace четене_на_страница_от_книга
{
    class Program
    {
        static void Main(string[] args)
        {
            //Докато имам следващ ред, 
            //процхитам го
            int numberOfWords = int.Parse(Console.ReadLine());
            
            while (numberOfWords>0)
            {
                //cheta si reda
                Console.WriteLine("Prochitam reda");

                numberOfWords = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Prochitoh stranicata");
        }
    }
}
                    String simo = "simo"//lampi4kata v lqvo