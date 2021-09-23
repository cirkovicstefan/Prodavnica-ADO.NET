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
    public partial class KorisniciControl : UserControl
    {
        public KorisniciControl()
        {
            InitializeComponent();
            OsveziTabelu();
        }

        private void OsveziTabelu()
        {
            dataGridViewKorisnici.DataSource = KonekcijaSaServerom.Proxy.SviKorisnici().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodavajIzmeniKorisnika dodajKorisnika = new DodavajIzmeniKorisnika();
            dodajKorisnika.ShowDialog();
            OsveziTabelu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DONE : Izmena selektovanog korisnika
            //TO DO : Obezbediti da mora biti selektovan jedan red
            int red = dataGridViewKorisnici.SelectedRows[0].Index;

            string korisnickoIme = dataGridViewKorisnici[0, red].Value.ToString();
            string lozinka = dataGridViewKorisnici[1, red].Value.ToString();
            string imeIPrezime = dataGridViewKorisnici[2, red].Value.ToString();
            Uloga uloga = (Uloga)Enum.Parse(typeof(Uloga), dataGridViewKorisnici[3, red].Value.ToString());

            DodavajIzmeniKorisnika dodajKorisnika = new DodavajIzmeniKorisnika(korisnickoIme,lozinka,imeIPrezime,uloga);
            dodajKorisnika.ShowDialog();
            OsveziTabelu();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DONE : Brisanje selektovanog korisnika
            //TO DO : Obezbediti da mora biti selektovan jedan red 
            int red = dataGridViewKorisnici.SelectedRows[0].Index;
            KonekcijaSaServerom.Proxy.ObrisiKorisnika(dataGridViewKorisnici[0, red].Value.ToString());

            OsveziTabelu();
        }
    }
}
