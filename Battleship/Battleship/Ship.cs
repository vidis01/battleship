using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Ship
    {
        public int Seats { get; }

        public int [] Coordinates { get; }

        public bool IsDead { get; set; } = false;

        public Ship(int seats)
        {
            Seats = seats;
            Coordinates = new int[seats];
        }
        //Turėtų būt talpinama visa informacija apie laivą, jo išdėstymą, ar pataikė 
        //jau į jį ar ne ir t.t.
         
    }
}
