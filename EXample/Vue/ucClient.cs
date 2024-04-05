using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Modele;
using Controlleur;



namespace Vue
{
    public partial class ucClient : UserControl
    {
        

        public ucClient()
        {
            InitializeComponent();
        }

        private void ucClient_Load(object sender, EventArgs e)
        {

        }

        private void tbxClient_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void radHomme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radFemme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbxTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string matricule = tbxClient.Text;
            string nom = tbxNom.Text;
            string genre = "";
            string telephone = tbxTelephone.Text;
            string email = tbxEmail.Text;
            string nationalite = tbxNationalite.Text;

            foreach (Control ctrl in groupBox1.Controls)
            {
                if (((RadioButton)ctrl).Checked)
                {
                    genre = ((RadioButton)ctrl).Text;
                    break;
                }
            }

            Client Cl2 = new Client(matricule,nom,nationalite,telephone,email,genre);

            Factory.addClients(Cl2);
            dataGridView1.DataSource = Factory.getAllClients();
            reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Factory.getAllClients();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        void reset()
        {
            tbxClient.Text = "";
            tbxNom.Text = "";
            tbxTelephone.Text = "";
            tbxEmail.Text = "";
            tbxNationalite.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
