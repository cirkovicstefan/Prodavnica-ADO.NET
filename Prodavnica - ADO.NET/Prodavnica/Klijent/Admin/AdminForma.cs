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
    public partial class AdminForma : Form
    {
        public AdminForma()
        {
            InitializeComponent();
            comboBoxTabela.SelectedIndex = 0;
            CenterToParent();
        }
        
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTabela.SelectedItem.ToString().Equals("Korisnici"))
            {
                KorisniciControl control = new KorisniciControl();
                control.Dock = DockStyle.Fill;
                panel.Controls.Clear();
                panel.Controls.Add(control);
            }
            else
            {
                ArtikliControl control = new ArtikliControl();
                control.Dock = DockStyle.Fill;
                panel.Controls.Clear();
                panel.Controls.Add(control);
            }

        }

        private void racuniPoRadnikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.radnik);
            izvestajDialog.ShowDialog();
        }

        private void racuniPoDatumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.datum);
            izvestajDialog.ShowDialog();
        }

        private void artikliPoOpseguCeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvestaji izvestajDialog = new Izvestaji(Izvestaji.TipIzvestaja.cena);
            izvestajDialog.ShowDialog();
        }
    }
}
