using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {

            bool Endgame = false; 
            var player = new Player();
           
            int x = 0, y = 0, ejimas = 1;

            
            while (!Endgame)        //kolkas tik suka, nera Meniu
            {
               
                player.PrintBoards();
                bool gerai = false;
                while (!gerai)
                {
                    Console.WriteLine("ejimas " + ejimas);
                    Console.WriteLine("Pasirinkite ejima x, po to y: ");  //kadangi nemoku nuskaityt 2 iskart 
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                    if ((y > player.MyBoard.BoardSize) || (x > player.MyBoard.BoardSize)) //dar reikia tikrinti 0, minusa
                        Console.WriteLine("Per dideli skaiciai.");
                    else if (player.MyBoard.BattleField[--y, --x] == 'o')
                    {
                        Console.WriteLine("Uzimta. Rinkis kitas koordinates.");
                    }
                        else
                        {
                            ejimas++;
                            player.MyBoard.BattleField[y, x] = 'o';
                            gerai = true;
                        }
                   //cia galimai aprasyti antro zaidejo ejima
                }
                Console.Clear();
            }
        }
    }
}
