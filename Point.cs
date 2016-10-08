using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    class Point
    {
        public int row { get; set; }
        public int col { get; set; }
        public bool visited = false;

        public Point(int x, int y)
        {
            this.row = x;
            this.col = y;
        }
    }
}
