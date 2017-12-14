using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Move
    {
        int x = 0, y = 0, ejimas = 1;
      
        public bool Shoot(Player player, Player computerPlayer)
        {
                bool gerai = false;
                while (!gerai)
                {
                    Console.WriteLine("ejimas " + ejimas);
                    Console.WriteLine("Pasirinkite ejima x, po to y: ");  //kadangi nemoku nuskaityt 2 iskart 
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    if ( (y > player.MyBoard.BoardSize) || (x > player.MyBoard.BoardSize) ) //dar reikia tikrinti 0, minusa
                        Console.WriteLine("Per dideli skaiciai.");
                    else if ( (player.OpponentBoard.BattleField[--y, --x] == 'o') || (player.OpponentBoard.BattleField[y, x] == 'x') )
                    {
                        Console.WriteLine("Cia jau buvo sauta. Rinkis kitas koordinates.");
                    }
                    else if (player.MyBoard.BattleField[y, x] =='U')
                    {
                        Console.WriteLine("PATAIKEI!!!!!!");

                    }
                    else
                    {
                        player.OpponentBoard.BattleField[y, x] = 'o';  //pazymim vieta i kur sauta
                        ejimas++;
                        gerai = true;
                       
                    }
                }
                Console.Clear();
                return true;
        }


    }

}
        //Turėtų būti atliekami visi veiksmai susiję su ėjimais.
        //o simboliu žymimas šūvis
        //X žymima, kai pataikoma
 