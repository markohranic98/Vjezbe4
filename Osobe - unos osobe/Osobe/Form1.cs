using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osobe
{
    public partial class uiOsobe : Form
    {
        private Osoba nova = null;

        public uiOsobe()
        {
            InitializeComponent();
            uiActionDodaj.Enabled = true;
            uiOutputOsobe.DataSource = Osoba.SveOsobe;
            
        }
        
        private void uiActionDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                nova = new Osoba();
                nova.Ime = uiInputIme.Text;
                nova.Prezime = uiInputPrezime.Text;
                nova.DatumRodenja = uiInputDatumRodenja.Value;
                Osoba.SveOsobe.Add(new Osoba(nova.Ime, nova.Prezime, nova.DatumRodenja));
            }
            catch (NotYetBornException ex)
            {

                MessageBox.Show(ex.Poruka);
            }
            
        }

        private void uiActionSvi_Click(object sender, EventArgs e)
        {
            uiOutputOsobe.DataSource = Osoba.SveOsobe;
        }

        private void uiActionPoDatumu_Click(object sender, EventArgs e)
        {
            uiOutputOsobe.DataSource = Osoba.OsobeNaDatum(uiInputFilter.Value);
        }
    }
}