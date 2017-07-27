using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerintaHarjoitus
{
    public class Pixel:PiirtoElementti
    {
        public Pixel(Piste sijainti, System.Drawing.Color vari):base(sijainti, vari)
        {

        }

        public override string ToString()
        {
            return "Pixel, sijainti: " + Sijainti.ToString() + " Väri: " + Vari.Name;
        }

        public override void Piirra(Graphics g)
        {
            System.Drawing.Pen p = new System.Drawing.Pen(Vari);
            g.DrawRectangle(p, Sijainti.X - 1, Sijainti.Y - 1, 2, 2);
        }
    }

    public class PaksuPixel : Pixel
    {
        public PaksuPixel(Piste sijainti, System.Drawing.Color vari) : base (sijainti, vari)
        {

        }

        public override void Piirra(Graphics g)
        {
            System.Drawing.Pen p = new System.Drawing.Pen(Vari, 20.0f);
            g.DrawRectangle(p, Sijainti.X - 1, Sijainti.Y - 1, 2, 2);
        }
    }
}
