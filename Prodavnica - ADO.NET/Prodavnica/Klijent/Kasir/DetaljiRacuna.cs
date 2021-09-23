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
    public partial class DetaljiRacuna : Form
    {
        public DetaljiRacuna(FiskalniRacun racun)
        {
            InitializeComponent();
            txtIDRacuna.Text = racun.IdRacuna.ToString();
            txtImeIPrezime.Text = racun.ImeiPrezime;
            txtDatum.Text = racun.DatumiVreme.ToString();
            txtIznosRacuna.Text = racun.IznosRacuna.ToString();
            dataGridViewStavkeRacuna.DataSource = racun.ListaStavki;
        }

        
    }
}
