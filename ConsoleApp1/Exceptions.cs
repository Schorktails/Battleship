﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class BattleshipException : System.Exception
    {
        public BattleshipException()
        {
        }

        public BattleshipException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : BattleshipException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
