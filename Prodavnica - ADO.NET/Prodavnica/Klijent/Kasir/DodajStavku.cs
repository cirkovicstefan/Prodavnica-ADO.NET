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
    public partial class DodajStavku : Form
    {
        DataGridView tabelaZaPrikaz;
        public DodajStavku(ref DataGridView dataGridView)
        {
            InitializeComponent();
            tabelaZaPrikaz = dataGridView;
            CenterToParent();
            //DONE : ucitati sve artikle iz baze i smestiti u listu stavku
            List<Artikal> artikli = KonekcijaSaServerom.Proxy.SviArtikli();
            dataGridViewArtikli.DataSource = artikli.ToList();
            dataGridViewArtikli.Columns[2].Visible = false; 
            // ne zelimo da prikazujemo kolicinu u magacinu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DONE : Izabranu stavku dodati u tabelaZaPrikaz u kojoj se nalaze sve stavke racuna
            //TO DO : Obezbediti da mora biti selektovan jedan red 

            int red = dataGridViewArtikli.SelectedRows[0].Index;
            string id = dataGridViewArtikli[0, red].Value.ToString();
            string naziv = dataGridViewArtikli[1, red].Value.ToString();
            double cena = double.Parse(dataGridViewArtikli[3, red].Value.ToString());
            double kolicina = double.Parse(txtKolicina.Text);
            double iznos = cena * kolicina;
            tabelaZaPrikaz.Rows.Add(id,naziv,cena,kolicina,iznos);
            this.Close();
        }
    }
}
