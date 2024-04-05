﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vue;

namespace EXample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ucClient frmclient = new ucClient();
            this.panel1.Controls.Add(frmclient);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void technicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ucTechnicien frmtechn = new ucTechnicien();
            this.panel1.Controls.Add(frmtechn);
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ucMateriel frmmateriel = new ucMateriel();
            this.panel1.Controls.Add(frmmateriel);
        }

        private void reparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ucReparation frmReparation = new ucReparation();
            this.panel1.Controls.Add(frmReparation);
        }
    }
}
