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

        public void PrintBoards()
        {
            Console.WriteLine("       My Board                      Computer");
            Console.WriteLine($"  1 2 3 4 5 6 7 8 9 10          1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < MyBoard.BoardSize; i++)
            {
                Console.Write($"{(char)(65 + i)}|");
                for (int j = 0; j < MyBoard.BoardSize; j++)
                {
                    Console.Write($"{MyBoard.BattleField[i, j]}|");

                }

                Console.Write($"        {(char)(65 + i)}|");
                for (int j = 0; j < OponentBoard.BoardSize; j++)
                {
                    Console.Write($"{OponentBoard.BattleField[i, j]}|");

                }

                Console.WriteLine();
            }
        }
    }
}
