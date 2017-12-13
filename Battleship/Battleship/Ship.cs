using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Ship
    {
        public Board MyBoard { get; }

        public Board OpponentBoard { get; }

        public Player Player { get; }

       public void ShipPlacing()
        {
            var pl = new Player();

            //var player
        //Turėtų būt talpinama visa informacija apie laivą, jo išdėstymą, ar pataikė 
        //jau į jį ar ne ir t.t.
            pl.MyBoard.BattleField[3, 4] = 'u';
            Player.MyBoard.BattleField[3, 5] = 'u';
            Player.MyBoard.BattleField[3, 6] = 'u';

        }
    }
}
