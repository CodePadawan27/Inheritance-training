using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerintaHarjoitus
{
    public partial class Paaikkuna : Form
    {

        private ArrayList elementit = new ArrayList();
        public Paaikkuna()
        {
            InitializeComponent();

            variComboBox.DataSource = Enum.GetNames(typeof(System.Drawing.KnownColor));
            variComboBox.SelectedIndex = 0;
        }

        private void virkistaLista()
        {
            piirtoElementitListBox.DataSource = elementit.ToArray();
        }

        private void uusiPiirtoNappi_Click(object sender, EventArgs e)
        {
            Piste keskipiste = new Piste(int.Parse(xTextBox.Text), int.Parse(yTextBox.Text));
            System.Drawing.Color c = System.Drawing.Color.FromName(variComboBox.Text);
            PiirtoElementti pe = new PiirtoElementti(keskipiste, c);
            elementit.Add(pe);
            virkistaLista();
        }

        private void pixelNappi_Click(object sender, EventArgs e)
        {
            Piste p = new Piste(int.Parse(xTextBox.Text), int.Parse(yTextBox.Text));
            Pixel px = new PaksuPixel(p, System.Drawing.Color.FromName(variComboBox.Text));
            elementit.Add(px);
            virkistaLista();
        }

        private void ympyraNappi_Click(object sender, EventArgs e)
        {
            Ympyra y = new Ympyra(new Piste(int.Parse(xTextBox.Text), int.Parse(yTextBox.Text)), int.Parse(sadesarmaTextBox.Text), System.Drawing.Color.FromName(variComboBox.Text));
           
            elementit.Add(y);
            virkistaLista();
        }

        private void nelioNappi_Click(object sender, EventArgs e)
        {
            elementit.Add(new Nelio(new Piste(int.Parse(xTextBox.Text), int.Parse(yTextBox.Text)), int.Parse(sadesarmaTextBox.Text), System.Drawing.Color.FromName(variComboBox.Text)));
            virkistaLista();
        }

        private void piirtoNappi_Click(object sender, EventArgs e)
        {
            Graphics g = piirtoalustaPictureBox.CreateGraphics();
            PiirtoElementti pe;
            int indeksi = piirtoElementitListBox.SelectedIndex;



            if (indeksi >= 0)
            {
                pe = (PiirtoElementti)elementit[indeksi];
                pe.Piirra(g);
            }
        }

        private void tyhjennaNappi_Click(object sender, EventArgs e)
        {
            piirtoalustaPictureBox.Refresh();
        }

        private void tyhjennaListaNappi_Click(object sender, EventArgs e)
        {
            elementit.Clear();
            virkistaLista();
        }
    }
    }

