using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintaHarjoitus
{
    public class Nelio :PiirtoElementti
    {
        int _sarma;

        public int Sarma
        {
            get { return _sarma; }
            set { _sarma = value; }
        }
        public Nelio(Piste vasenYlakulma, int sarma, System.Drawing.Color vari) : base (vasenYlakulma, vari)

        {
            _sarma = sarma;
        }

        public override string ToString()
        {
            return "Neliö, vasen yläkulma: " + Sijainti.ToString() + " särmä: " + _sarma + " Väri: " + Vari.Name;
        }

        public override void Piirra(Graphics g)
        {
            System.Drawing.Pen p = new System.Drawing.Pen(Vari);
            g.DrawRectangle(p, Sijainti.X, Sijainti.Y, Sarma, Sarma);
        }
    }
}
