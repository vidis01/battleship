using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Game
    {
        public Player HumanPlayer;
        public Player ComputerPlayer;

        public Move Move;

        public Game()
        {
            HumanPlayer = new Player();
            ComputerPlayer = new Player(/* computer*/);
            Move = new Move();
        }

        public void DarytiEjima()
        {
            Move.Shoot(HumanPlayer, ComputerPlayer);
        }

        //Čia turės būti sukuriami žaidėjai, daromi ėjimai
        //tikrinama ar pateikė ir t.t.
    }
}
