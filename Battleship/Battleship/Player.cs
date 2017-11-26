using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        public Board MyBoard { get; }

        public Board OponentBoard { get; }

        public Player()
        {
            MyBoard = new Board();
            OponentBoard = new Board();
        }
    }
}
