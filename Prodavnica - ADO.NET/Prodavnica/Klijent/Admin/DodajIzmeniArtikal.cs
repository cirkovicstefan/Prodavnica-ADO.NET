using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Klijent
{
    public partial class DodajIzmeniArtikal : Form
    {
        bool dodavanje = true;
        public DodajIzmeniArtikal()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(JedinicaMere));
            button1.Text = "Dodaj";
            CenterToParent();
        }

        public DodajIzmeniArtikal(string id, string naziv, double kolicina, double cena, JedinicaMere jedinicaMere)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(JedinicaMere));
            comboBox1.SelectedIndex = (int) jedinicaMere;
            txtID.Text = id;
            txtID.ReadOnly = true; // necemo da dozvolimo menjanje ID-ja
            txtNaziv.Text = naziv;
            txtCena.Text = cena.ToString();
            txtKolicina.Text = kolicina.ToString();
            button1.Text = "Izmeni";
            dodavanje = false;
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DONE : Izvrsiti dodavanje podataka ili izmenu u zavisnosti sta je pozvano
            // TO DO : Proveriti da li su sve vrednosti dobro unete

            JedinicaMere mera = (JedinicaMere) Enum.ToObject(typeof(JedinicaMere), comboBox1.SelectedIndex);
            string id = txtID.Text; 
            string naziv = txtNaziv.Text;
            double cena = double.Parse(txtCena.Text);
            double kolicina = double.Parse(txtKolicina.Text);

            Artikal a = new Artikal(id, naziv, kolicina, cena, mera);
            if (dodavanje)
            {
                KonekcijaSaServerom.Proxy.DodajArtikal(a);
            }
            else
            {
                KonekcijaSaServerom.Proxy.IzmeniArtikal(a);
            }

            this.Close();
        }

        


    }
}
