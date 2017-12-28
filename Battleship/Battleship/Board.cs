using System;
using System.Linq;

namespace Battleship
{
    public class Board
    {
        public int BoardSize { get; } = 10;

        public Cell[,] BattleField { get; }

        public Board()
        {
            BattleField = new Cell[BoardSize, BoardSize];
            InitializeBoard();
        }

        public void PrintBoard()
        {
            Console.WriteLine("  1 2 3 4 5 6 7 8 9 10");
            for (int i = 0; i < BoardSize; i++)
            {
                Console.Write($"{(char)(65+i)}|");                
                for (int j = 0; j < BoardSize; j++)
                {
                    Console.Write($"{(char)BattleField[i,j].CellValue}|");
                }
                Console.WriteLine();
            }
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    BattleField[i, j] = new Cell();
                }
            }
        }
       
    }
}
