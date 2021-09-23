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
    public partial class IzvestajDatum : UserControl
    {
        DataGridView tabelaZaPrikaz;

        public IzvestajDatum(ref DataGridView dataGridView)
        {
            InitializeComponent();
            tabelaZaPrikaz = dataGridView;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // DONE : Upisati podatke u tabelaZaPrikaz na osnovu upisanih kriterijuma
            tabelaZaPrikaz.DataSource = KonekcijaSaServerom.Proxy.
                SviRacuniPoDatumu(dateTimePicker1.Value).ToList();

        }
    }
}
