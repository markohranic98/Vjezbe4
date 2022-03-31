﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vozila;

namespace Vozila_Forms_DllRef
{
    public partial class FrmGlavna : Form
    {
        List<Vozilo> vozila = new List<Vozilo>();

        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        private void PrikaziVozila()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = vozila;
            dgvVozila.DataSource = null;
            dgvVozila.DataSource = bs;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmPodaci podaci = new FrmPodaci(vozila);
            podaci.ShowDialog();
            PrikaziVozila();
        }

        private void btnPromijeni_Click(object sender, EventArgs e)
        {
            if (dgvVozila.CurrentRow != null)
            {
                Vozilo odabrano = dgvVozila.CurrentRow.DataBoundItem as Vozilo;            
                FrmPodaci podaci = new FrmPodaci(odabrano);
                podaci.ShowDialog();
                PrikaziVozila();
                
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVozila.CurrentRow != null)
            {
                
                Vozilo odabrano = dgvVozila.CurrentRow.DataBoundItem as Vozilo;
                vozila.Remove(odabrano);
                PrikaziVozila();
            }
        }
    }
}
