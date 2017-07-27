using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintaHarjoitus
{
    public class Ympyra :PiirtoElementti
    {
        private int _sade;
        public int Sade
        {
            get { return _sade; }
            set { _sade = value; }
        }

        public Ympyra(Piste keskipiste, int sade, System.Drawing.Color vari):base(keskipiste,vari)
        {
            _sade = sade;
        }

        public override string ToString()
        {
            return "Ympyrä, kp: " + Sijainti.ToString() + " säde:" + _sade + " Väri: " + Vari.Name;
        }

        public override void Piirra(Graphics g)
        {
            System.Drawing.Pen p = new System.Drawing.Pen(Vari);
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(Sijainti.X - Sade, Sijainti.Y - Sade, 2 * Sade, 2 * Sade);
            g.DrawEllipse(p, r);
        }
    }
}
