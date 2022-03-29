using BankaLib;
using KorisniciLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAdvanced
{
    public partial class FrmTransakcije : Form
    {
        private IRacun racun;
        public IRacun Racun { get => racun; set => racun = value; }

        public FrmTransakcije()
        {
            InitializeComponent();
            transakcijeDataGridView.SelectionChanged += (s, a) => btnNovaTransakcija.Visible = true;
        }

        public FrmTransakcije(IRacun odabraniRacun)
        {
            InitializeComponent();
            transakcijeDataGridView.SelectionChanged += (s,a)=> btnNovaTransakcija.Visible = true;
            Racun = odabraniRacun;
        }

        private void FrmTransakcije_Load(object sender, EventArgs e)
        {
            if (Racun != null)
            {
                PrikaziTransakcijeRacuna();
                btnNovaTransakcija.Visible = true;
            }
            else
            {
                PrikaziSveTransakcije();
                btnNovaTransakcija.Visible = false;
            }
        }

        private void PrikaziSveTransakcije()
        {
            var sveTransakcije = KorisniciDB.VratiSveTransakcije();
            transakcijeDataGridView.DataSource = sveTransakcije;
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaTransakcija_Click(object sender, EventArgs e)
        {
            var form = new FrmNovaTransakcija();
            form.ShowDialog();
            PrikaziSveTransakcije();
        }

        private void PrikaziTransakcijeRacuna()
        {
            List<Transakcija> transakcijeRacuna = Racun.VratiSveTransakcije().ToList();
            transakcijeDataGridView.DataSource = transakcijeRacuna;
        }
    }
}
