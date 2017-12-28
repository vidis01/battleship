using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Cell
    {
        public CellValue CellValue { get; set; }

        public Ship Ship { get; set; } = null;

        public Cell()
        {
            CellValue = CellValue.EMPTY;
        }
    }
}
