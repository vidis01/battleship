using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Ship
    {
        public int Seats { get; } //keliu vietu 1..4

        public Orientation? Orientation { get; set; } = null; //horizontalus ar vertikalus

        public Coordinate [] Coordinates { get; } 

        public bool IsDead { get; set; } = false; //kai pilnai nusauna nustatyti => true

        public Ship(int seats)
        {
            Seats = seats;
            Coordinates = new Coordinate[seats];
        }         
    }
}
