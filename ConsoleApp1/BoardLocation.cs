using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class BoardLocation
    {
        public BoardLocation(int x, int y, Board board) : base(x, y)
        {
            if (!board.OnBoard(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(BoardLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
