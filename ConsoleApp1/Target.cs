using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Target
    {
        private readonly BoardLocation[] _target;

        public int Length => _target.Length;

        public Target(BoardLocation[] target)
        {
            _target = target;
        }

        public BoardLocation GetLocationAt(int targetStep)
        {
            return (pathStep < _target.Length) ? _target[targetStep] : null;
        }
    }
}
