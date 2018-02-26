using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battle
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstoPlayerPokemons = int.Parse(Console.ReadLine());
            var secondPlayerPokemons = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());
            var currentBattle = 0;

            for (int i = 1; i <= firstoPlayerPokemons; i++) 
            {
                for (int j = 1; j <= secondPlayerPokemons; j++) 
                {
                    currentBattle++;
                    if (currentBattle == maxBattles + 1)
                    {
                        break;
                    }
                    Console.Write("(" + i + " <-> " + j + ") ");
                }
                if (currentBattle == maxBattles + 1)
                {
                    break;
                }
            }
        }
    }
}
