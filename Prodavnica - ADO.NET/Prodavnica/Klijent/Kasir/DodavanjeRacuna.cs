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
    public partial class DodavanjeRacuna : Form
    {
        string imeIPrezimeKasira = "";
        public DodavanjeRacuna(string imeIPrezimeKasira)
        {
            InitializeComponent();
            CenterToParent();
            this.imeIPrezimeKasira = imeIPrezimeKasira;

            dataGridViewStavkeRacuna.Columns.Add("idArtikla", "Id artikla");
            dataGridViewStavkeRacuna.Columns.Add("nazivArtikla", "nazivArtikla");
            dataGridViewStavkeRacuna.Columns.Add("cena", "cena");
            dataGridViewStavkeRacuna.Columns.Add("kolicina", "kolicina");
            dataGridViewStavkeRacuna.Columns.Add("iznos", "iznos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavku dodajStavku = new DodajStavku(ref dataGridViewStavkeRacuna);
            dodajStavku.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DONE : Obrisati selektovanu stavku 
            // TO DO : Obezbediti da mora biti selektovan jedan red 
            int red = dataGridViewStavkeRacuna.SelectedRows[0].Index;

            //pre brisanja moramo da umanjimo ukupan iznos
            double iznosZaUmanjenje = double.Parse(dataGridViewStavkeRacuna[4, red].Value.ToString());
            double iznos = double.Parse(txtUkupno.Text);
            iznos -= iznosZaUmanjenje;
            txtUkupno.Text = iznos.ToString();

            dataGridViewStavkeRacuna.Rows.RemoveAt(red);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DONE : tek kada se klikne zavrsetak racuna  vrsi se upis svih podataka u bazu
            List<StavkaFiskalnogRacuna> list = new List<StavkaFiskalnogRacuna>();
            //prolazimo kroz sve stavke iz tabele i dodajemo ih u listu

            int countIndex = dataGridViewStavkeRacuna.Rows.Count - 2;
            for (int i = 0; i <= countIndex; i++)
            {
                StavkaFiskalnogRacuna stavka = new StavkaFiskalnogRacuna();
                stavka.IdArtikla = dataGridViewStavkeRacuna[0, i].Value.ToString();
                stavka.Kolicina = double.Parse(dataGridViewStavkeRacuna[3, i].Value.ToString());
                list.Add(stavka);
            }

            FiskalniRacun racun = new FiskalniRacun();
            racun.ListaStavki = list;
            racun.IznosRacuna = double.Parse(txtUkupno.Text);
            racun.DatumiVreme = DateTime.Now;
            racun.ImeiPrezime = imeIPrezimeKasira;
            KonekcijaSaServerom.Proxy.DodajRacun(racun);

            this.Close();
        }

        private void dataGridViewStavkeRacuna_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // DONE : Nakon dodavanja nove stavke osveziti ukupnu cenu
            int indexPoslednjegReda = dataGridViewStavkeRacuna.Rows.Count - 2; 
            if (indexPoslednjegReda >= 0)
            {
                double iznos = double.Parse(txtUkupno.Text);
                iznos += double.Parse(dataGridViewStavkeRacuna[4, indexPoslednjegReda].Value.ToString());
                txtUkupno.Text = iznos.ToString();
            }
            else
                txtUkupno.Text = "0";
        }


    }
}
