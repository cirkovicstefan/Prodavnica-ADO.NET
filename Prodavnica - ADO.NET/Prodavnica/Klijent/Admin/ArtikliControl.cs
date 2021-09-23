using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class ArtikliControl : UserControl
    {
        public ArtikliControl()
        {
            InitializeComponent();
            OsveziTabelu();
        }

        private void OsveziTabelu()
        {
            dataGridViewArtikli.DataSource = KonekcijaSaServerom.Proxy.SviArtikli().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajIzmeniArtikal dodajArtikal = new DodajIzmeniArtikal();
            dodajArtikal.ShowDialog();

            OsveziTabelu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DONE : Izmena selektovanog artikla
            // TO DO : Obezbediti da mora biti selektovan jedan red 
            int red = dataGridViewArtikli.SelectedRows[0].Index;

            string id = dataGridViewArtikli[0, red].Value.ToString();
            string naziv = dataGridViewArtikli[1, red].Value.ToString();
            double kolicina = (double) dataGridViewArtikli[2, red].Value;
            double cena = (double)dataGridViewArtikli[3, red].Value;
            JedinicaMere mera = (JedinicaMere) Enum.Parse(typeof(JedinicaMere), dataGridViewArtikli[4, red].Value.ToString());

            DodajIzmeniArtikal dodajArtikal = new DodajIzmeniArtikal(id, naziv, kolicina, cena, mera);
            dodajArtikal.ShowDialog();

            OsveziTabelu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // DONE : Brisanje selektovanog artikla
            // TO DO : Obezbediti da mora biti selektovan jedan red 
            int red = dataGridViewArtikli.SelectedRows[0].Index;
            KonekcijaSaServerom.Proxy.ObrisiArtikal(dataGridViewArtikli[0, red].Value.ToString());

            OsveziTabelu();
        }
    }
}
