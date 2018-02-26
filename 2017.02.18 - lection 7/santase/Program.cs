using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santase
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Points = 0;
            int player2Points = 0;

            while (true)
            {
                if (player1Points >= 48 || player2Points >= 48)
                {
                    break;
                }

                player1Points += 12;
                player2Points += 3;

            }
        }
    }
}
