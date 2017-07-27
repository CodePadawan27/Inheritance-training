using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintaHarjoitus
{
    public class PiirtoElementti
    {
        private Piste _sijainti;
        private System.Drawing.Color _vari;

        public PiirtoElementti(Piste sijainti, System.Drawing.Color vari)
        {
            _sijainti = sijainti;
            _vari = vari;
        }

        public Piste Sijainti
        {
            get { return _sijainti; }
            set { _sijainti = value; }
        }

        public System.Drawing.Color Vari
        {
            get { return _vari; }
            set { _vari = value; }
        }

        public override string ToString()
        {
            return "Grafiikan kantaluokka, sijanti:" + _sijainti.ToString() + " Väri: " + _vari.Name;
        }

        public virtual void Piirra(System.Drawing.Graphics g)
        {
            System.Drawing.Font f = new System.Drawing.Font("Arial", 10.0f);
        System.Drawing.Brush b = new System.Drawing.SolidBrush(Vari);
        g.DrawString("en osaa piirtää", f, b, _sijainti.X, _sijainti.Y);
        }
}
}
