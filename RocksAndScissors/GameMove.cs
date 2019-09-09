using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocksAndScissors
{
    class GameMove
    {
        private int MoveValue { get; set; }
        public GameMove(int val)
        {
            MoveValue = val;
        }
    }
}
