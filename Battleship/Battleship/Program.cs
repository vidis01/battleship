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
            var board = new Board();

            board.PrintBoard();

            Console.ReadKey();
        }
    }
}
