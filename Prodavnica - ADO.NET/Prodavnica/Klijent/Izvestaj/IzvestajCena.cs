using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class IzvestajCena : UserControl
    {
        DataGridView tabelaZaPrikaz;
        public IzvestajCena(ref DataGridView dataGridView)
        {
            InitializeComponent();
            tabelaZaPrikaz = dataGridView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DONE : Upisati podatke u tabelaZaPrikaz na osnovu upisanih kriterijuma
            tabelaZaPrikaz.DataSource = KonekcijaSaServerom.Proxy.ArtikliPoOpseguCene
                (double.Parse(txtCenaOd.Text),double.Parse(txtCenaDo.Text)).ToList();
        }
    }
}
