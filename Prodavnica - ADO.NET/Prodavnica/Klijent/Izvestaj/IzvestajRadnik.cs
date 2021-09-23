using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Klijent
{
    public partial class IzvestajRadnik : UserControl
    {
        DataGridView tabelaZaPrikaz;
        public IzvestajRadnik(ref DataGridView dataGridView)
        {
            InitializeComponent();
            tabelaZaPrikaz = dataGridView;
            //DONE iscitati sve radnike iz baze i ucitati u comboBox
            List<Korisnik> korisnici = KonekcijaSaServerom.Proxy.SviKorisnici();
            foreach (Korisnik k in korisnici)
            {
                comboBox1.Items.Add(k.ImeIPrezime);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DONE : Upisati podatke u tabelaZaPrikaz na osnovu upisanih kriterijuma
            string selektovanoIme = comboBox1.SelectedItem.ToString();
            tabelaZaPrikaz.DataSource = KonekcijaSaServerom.Proxy.SviRacuniKorisnika(selektovanoIme).ToList();
        }
    }
}
