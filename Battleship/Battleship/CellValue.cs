using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public enum CellValue
    {
        EMPTY = ' ', //tuscia cele
        WITH_SHIP = '#', //cele su nepataikytu laivu
        MISSED_SHOOT = 'O', //nepataikytas suvys
        HITTED_SHIP = 'X' //pataikytas suvis
    }
}
