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
    public partial class DodavajIzmeniKorisnika : Form
    {
        bool dodavanje = true;

        public DodavajIzmeniKorisnika()
        {
            InitializeComponent();
            cbUloga.DataSource = Enum.GetValues(typeof(Uloga));
            button1.Text = "Dodaj";
            CenterToParent();
        }

        public DodavajIzmeniKorisnika(string korisnickoIme, string lozinka, string imeIPrezime, Uloga uloga)
        {
            InitializeComponent();
            cbUloga.DataSource = Enum.GetValues(typeof(Uloga));
            cbUloga.SelectedIndex = (int)uloga;
            txtKorisnickoIme.Text = korisnickoIme;
            txtKorisnickoIme.ReadOnly = true; // korisnicko ime ne moze da se promeni
            txtLozinka.Text = lozinka;
            txtImeiPrezime.Text = imeIPrezime;
            button1.Text = "Izmeni";
            dodavanje = false;
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DONE : Izvrsiti dodavanje podataka ili izmenu u zavisnosti sta je pozvano
            // TO DO : Proveriti da li su svi podaci pravilno uneti

            Uloga uloga = (Uloga)Enum.ToObject(typeof(Uloga), cbUloga.SelectedIndex);
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;
            string imeIPrezime = txtImeiPrezime.Text;

            Korisnik k = new Korisnik(korisnickoIme,lozinka,imeIPrezime,uloga);
            if (dodavanje)
            {
                KonekcijaSaServerom.Proxy.DodajKorisnika(k);
            }
            else
            {
                KonekcijaSaServerom.Proxy.IzmeniKorisnika(k);            }

            this.Close();
        }
    }
}
