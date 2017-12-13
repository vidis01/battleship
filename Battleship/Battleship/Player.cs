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

        public Board OpponentBoard { get; } //vieta, kur player saudo, opponent laivai nematomi
        public Board OpponentBoardWithShips { get; } // opponent laivai nematomi

        public Player()
        {
            MyBoard = new Board();
            OpponentBoard = new Board();
            OpponentBoardWithShips = new Board();
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

                for (int j = 0; j < OpponentBoard.BoardSize; j++)
                {
                    Console.Write($"{OpponentBoard.BattleField[i, j]}|");

                }

                Console.WriteLine();
            }

        }
        public void RandomLaivai() //tik pradejau, kolkas stato keturvieti gulsciai, tesiu kai laiko turesiu
        {
            Random rand = new Random();
            int r = rand.Next(1, 11);
            // int puse = rand.Next(1, 3);
            int puse = 1;
            // 1- keturvietis, 2 - trivieciai, 3 - dvivieciai, 4 - vienvieciai
            Console.WriteLine("Ivesk pradines laivo koordinates");
            int x = int.Parse(Console.ReadLine()); x--;
            int y = int.Parse(Console.ReadLine()); y--;
            if (puse == 1)
            {
                for (int h = -1; h < 5; h++)
                {
                    if (MyBoard.BattleField[y, x + h] != ' ')
                    {
                        break;
                    }
                }
                for (int v = -1, vx = y; v < 5; v++)
                {
                    if (MyBoard.BattleField[vx-1, x+v] != ' ')
                    {
                        break;
                    }
                }
                for (int v = -1, vx = y; v < 5; v++)
                {
                    if (MyBoard.BattleField[vx + 1, x + v] != ' ')
                    {
                        break;
                    }
                }
                for (int i = 1; i < 5; i++)
                {
                    MyBoard.BattleField[y, x++] = 'U';
                }

            }

        }

    }
}
