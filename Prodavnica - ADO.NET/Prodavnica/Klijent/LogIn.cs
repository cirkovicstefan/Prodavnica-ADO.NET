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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DONE: provera korisnickog imena i lozinke

            string korisnickoIme = txbKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            Uloga uloga = KonekcijaSaServerom.Proxy.LogIn(korisnickoIme, lozinka);

            if (uloga.Equals(Uloga.Administrator))
            {
                lblGreska.Text = "";
                txbKorisnickoIme.Text = "";
                txtLozinka.Text = "";
                AdminForma admin = new AdminForma();
                admin.ShowDialog();

            }
            else if (uloga.Equals(Uloga.Kasir))
            {
                lblGreska.Text = "";
                txbKorisnickoIme.Text = "";
                txtLozinka.Text = "";
                KasirForma kasir = new KasirForma(KonekcijaSaServerom.Proxy.ImeIPrezime(korisnickoIme));
                kasir.ShowDialog();
            }
            else if (uloga.Equals(Uloga.None))
            {
                lblGreska.Text = "Niste pravilno uneli podatke.";
            }
        }
    }
    }
