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

        public Dictionary<ShipType, Ship> Ships { get; set; }

        public Player()
        {
            MyBoard = new Board();
            OpponentBoard = new Board();
            OpponentBoardWithShips = new Board();

            Ships = new Dictionary<ShipType, Ship>();

            Ships.Add(ShipType.FOUR_SEATS, new Ship(4));
            Ships.Add(ShipType.THREE_SEATS_1, new Ship(3));
            Ships.Add(ShipType.THREE_SEATS_2, new Ship(3));
            Ships.Add(ShipType.TWO_SEATS_1, new Ship(2));
            Ships.Add(ShipType.TWO_SEATS_2, new Ship(2));
            Ships.Add(ShipType.TWO_SEATS_3, new Ship(2));
            Ships.Add(ShipType.ONE_SEAT_1, new Ship(1));
            Ships.Add(ShipType.ONE_SEAT_2, new Ship(1));
            Ships.Add(ShipType.ONE_SEAT_3, new Ship(1));
            Ships.Add(ShipType.ONE_SEAT_4, new Ship(1));
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
                    Console.Write($"{(char)MyBoard.BattleField[i, j].CellValue}|");

                }

                Console.Write($"        {(char)(65 + i)}|");

                for (int j = 0; j < OpponentBoard.BoardSize; j++)
                {
                    Console.Write($"{(char)OpponentBoard.BattleField[i, j].CellValue}|");

                }

                Console.WriteLine();
            }

        }

        public void RandomLaivai() //Kuria laivus, bet reikia koda tvarkyt dar ir padaryt visiems generavima //ideti var kad znot kieno laivus sukurt
        {
            
   
            int x = 0, y = 0, tokiuLaivuYra = 1, kelinvietis = 4;
            int maximum = 0, minimum = 0;
            // 1- keturvietis, 2 - trivieciai, 3 - dvivieciai, 4 - vienvieciai
            for (/*int kelinvietis = 4*/ ; kelinvietis > 0; kelinvietis--)
            {
                tokiuLaivuYra = 5 - kelinvietis;

                while (tokiuLaivuYra > 0)
 
                {
                    // x = int.Parse(Console.ReadLine()); //
                    // y = int.Parse(Console.ReadLine()); //
                    Random rand = new Random();
                    x = rand.Next(1, 11);
                    y = rand.Next(1, 11);
                    // 
                    Random puse = new Random();
                    int desinenArZemyn = puse.Next(1, 3); //1 desinen; 2 zemyn
                    bool flag = true;

                    if (desinenArZemyn == 1)
                    {
                        if ((x + kelinvietis > MyBoard.BoardSize) || (y + kelinvietis > MyBoard.BoardSize))
                        {
                            flag = false;
                            //break;
                        }
                        else
                        {
                            for (int h = -1; h < kelinvietis + 1; h++)
                            {
                                maximum = x + h;
                                if (maximum > 10) maximum = 10;
                                if (maximum < 1) maximum = 1; 
                                if (MyBoard.BattleField[y-1, maximum-1].CellValue == CellValue.WITH_SHIP)
                                {
                                    flag = false;
                                   // break;
                                }
                            }
                            for (int v = -1, vx = y; v < 5; v++)
                            {
                                maximum = x + v;
                                if (maximum > 10) maximum = 10;
                                if (maximum < 1) maximum = 1;
                                minimum = vx - 1;
                                if (minimum < 1) minimum = 1;
                                if (MyBoard.BattleField[minimum-1, maximum-1].CellValue == CellValue.WITH_SHIP)
                                {
                                    flag = false;
                                    //break;
                                }
                            }
                            for (int v = -1, vx = y; v < 5; v++)
                            {
                                maximum = x + v;
                                if (maximum > 10) maximum = 10;
                                if (maximum < 1) maximum = 1;
                                minimum = vx + 1;
                                if (minimum < 1) minimum = 1;
                                if (MyBoard.BattleField[minimum-1, maximum-1].CellValue == CellValue.WITH_SHIP)
                                {
                                    flag = false;
                                   // break;
                                }
                            }
                            
                        }

                        if (flag)
                        {
                            // x--; y--;
                            for (int i = 1; i < kelinvietis + 1; i++)
                            {
                                MyBoard.BattleField[y - 1, x++ - 1].CellValue = CellValue.WITH_SHIP;
                                Console.WriteLine("Generuojami laivai....");
                            }

                            tokiuLaivuYra--;
                        }
                    }
                    else
                    {
                        if ((x + kelinvietis > MyBoard.BoardSize) || (y + kelinvietis > MyBoard.BoardSize))
                        {
                            flag = false;
                            //break;
                        }
                        for (int v = -1; v < kelinvietis + 1; v++)
                        {
                            maximum = y + v;
                            if (maximum > 10) maximum = 10;
                            if (maximum < 1) maximum = 1;
                            if (MyBoard.BattleField[maximum - 1, x-1].CellValue == CellValue.WITH_SHIP)
                            {
                                flag = false;
                                // break;
                            }
                        }
                        for (int v = -1, vx = x; v < kelinvietis + 1; v++)
                        {
                            maximum = y + v;
                            if (maximum > 10) maximum = 10;
                            if (maximum < 1) maximum = 1;
                            minimum = vx - 1;
                            if (minimum < 1) minimum = 1;
                            if (MyBoard.BattleField[maximum - 1, minimum - 1].CellValue == CellValue.WITH_SHIP)
                            {
                                flag = false;
                                //break;
                            }
                        }
                        for (int v = -1, vx = x; v < kelinvietis + 1; v++)
                        {
                            maximum = y + v;
                            if (maximum > 10) maximum = 10;
                            if (maximum < 1) maximum = 1;
                            minimum = vx + 1;
                            if (minimum < 1) minimum = 1;
                            if (minimum > 10) minimum = 10;
                            if (MyBoard.BattleField[maximum - 1, minimum - 1].CellValue == CellValue.WITH_SHIP)
                            {
                                flag = false;
                                // break;
                            }
                        }

                        //---
                        if(flag)
                        {
                            // x--; y--;
                            for (int i = 1; i < kelinvietis + 1; i++)
                            {
                                MyBoard.BattleField[y++ - 1, x - 1].CellValue = CellValue.WITH_SHIP;
                                Console.WriteLine("Generuojami laivai....");
                            }

                            tokiuLaivuYra--;
                        }
                    }                
                 
            
                }

            }
        }

    }
}
