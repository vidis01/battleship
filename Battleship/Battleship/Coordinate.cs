using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Coordinate
    {
        public Row Row { get; } // A, B, ... J

        public int Column { get; } // 1, 2, ... 10

        public Coordinate(Row row, int column)
        {
            Row = row;

            if (column<1 || column>10)
            {
                new ArgumentException($"{nameof(Column)} not in range 1 <= value <= 10. ");
            }
            Column = column;
        }
    }
}
