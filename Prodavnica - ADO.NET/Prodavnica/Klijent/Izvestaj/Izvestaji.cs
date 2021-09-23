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
    public partial class Izvestaji : Form
    {
        public enum TipIzvestaja { datum, radnik, cena}
        public Izvestaji(TipIzvestaja tipIzvestaja)
        {
            InitializeComponent();
            CenterToParent();

            if (tipIzvestaja.Equals(TipIzvestaja.datum))
            {
                IzvestajDatum control = new IzvestajDatum(ref dataGridView1);
                control.Dock = DockStyle.Left;
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(control);

            }
            else if (tipIzvestaja.Equals(TipIzvestaja.radnik))
            {
                IzvestajRadnik control = new IzvestajRadnik(ref dataGridView1);
                control.Dock = DockStyle.Left;
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(control);
            }
            else if (tipIzvestaja.Equals(TipIzvestaja.cena))
            {
                IzvestajCena control = new IzvestajCena(ref dataGridView1);
                control.Dock = DockStyle.Left;
                splitContainer1.Panel1.Controls.Clear();
                splitContainer1.Panel1.Controls.Add(control);
            }
        }


      
    }
}
