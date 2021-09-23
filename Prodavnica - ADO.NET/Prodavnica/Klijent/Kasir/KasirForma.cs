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
    public partial class KasirForma : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public KasirForma(string imeiPrezimeKasira)
        {
            InitializeComponent();
            toolStripStatusLabelKorisnickoIme.Text = imeiPrezimeKasira;
            CenterToParent();
            dataGridViewRacuni.DataSource = bindingSource;
            OsveziTabelu();
        }

        private void OsveziTabelu()
        {
            bindingSource.DataSource =  KonekcijaSaServerom.Proxy.SviRacuni();
        }

        private void racuniPoDatumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.datum);
            izvestajDialog.ShowDialog();
        }

        private void racuniPoRadnikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.radnik);
            izvestajDialog.ShowDialog();
        }

        private void artikliPoOpseguCeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.cena);
            izvestajDialog.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodavanjeRacuna dodavanjeRacuna = new DodavanjeRacuna(toolStripStatusLabelKorisnickoIme.Text);
            dodavanjeRacuna.ShowDialog();
            OsveziTabelu();
        }

        private void btbDetaljiRacuna_Click(object sender, EventArgs e)
        {
            int red = dataGridViewRacuni.SelectedRows[0].Index;
            FiskalniRacun selected = (FiskalniRacun) bindingSource[red];
            DetaljiRacuna detaljiRacunaDIalog = new DetaljiRacuna(selected);
            detaljiRacunaDIalog.ShowDialog();
        }
    }
}
