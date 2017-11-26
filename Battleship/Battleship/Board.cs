using System;

namespace Battleship
{
    public class Board
    {
        public int BoardSize { get; } = 10;

        private char[,] BattleField { get; }

        public Board(int boardSize = 10)
        {
            if (boardSize <= 10)
            {
                BattleField = new char[BoardSize, BoardSize];
            }
            else
            {
                BoardSize = boardSize;
                BattleField = new char[BoardSize, BoardSize];
            }            
        }

        public void PrintBoard()
        {
            Console.WriteLine($"  1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < BoardSize; i++)
            {
                Console.Write($"{(char)(65+i)}|");
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write($"{BattleField[i,j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
