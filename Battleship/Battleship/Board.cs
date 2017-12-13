﻿using System;

namespace Battleship
{
    public class Board
    {
        public int BoardSize { get; } = 10;

        public char[,] BattleField { get; }

        public Board(int boardSize = 10)
        {
//#warning Pagalvoti, gal galima supaprastinti sąlygą? Gal Vytas pataisys.
            if (boardSize >= 26)
            {
                BoardSize = 26;
            }
            else
            {
                if (boardSize < 10)
                {
                    BoardSize = 10;
                }
                else
                {
                    BoardSize = boardSize;
                }
            }

            BattleField = new char[BoardSize, BoardSize];
        }

        public void PrintBoard()
        {
            // Console.WriteLine("  1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20");
            for (int a = 1; a <= BoardSize; a++)
            {
                if (a == 1)
                {
                    Console.Write(" ");
                }
                Console.Write(" " + a);

            }
            Console.WriteLine();
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
