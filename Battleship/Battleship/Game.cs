using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Game
    {
        public Player Player;
        public Player ComputerPlayer;
        public Move Move;
        
        public void NewGame()
        {

            var player = new Player();
            var computerPlayer = new Player();
            var move = new Move();
            bool endgame = false;
            player.RandomLaivai();
           // player.PrintBoards();
           // Console.ReadKey();
            while (!endgame)
             {
                 player.PrintBoards();
                 if (move.Shoot(player, computerPlayer))
                 {
                     Console.WriteLine("Ivyko");
                     //Console.ReadKey();
                 }

             }

        }
    }
}
     /* public void DarytiEjima()
        {
            Move.Shoot(HumanPlayer, ComputerPlayer);
        }
        */
     //Čia turės būti sukuriami žaidėjai, daromi ėjimai
     //tikrinama ar pateikė ir t.t.