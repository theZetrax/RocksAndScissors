using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocksAndScissors
{
    class GameResult
    {
        private int? GameResultValue { get; set; }
        public string annotation { get; set; }
        public GameResult(int? val, string str)
        {
            GameResultValue = val;
            annotation = str;
        }

        override public string ToString()
        {
            return annotation;
        }
    }
}
