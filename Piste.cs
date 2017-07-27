using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintaHarjoitus
{
    public class Piste
    {
        private int _x;
        private int _y;

        public Piste(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public override string ToString()
        {
            return "(" + _x + ", " + _y + ")";
        }
    }
}
