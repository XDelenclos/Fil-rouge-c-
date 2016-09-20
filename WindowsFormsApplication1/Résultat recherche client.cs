using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace PL
{
    public partial class Form5 : Form
    {

        public void ParamDataGrid(DataGridView DtGdView)
        {
            DtGdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtGdView.RowHeadersVisible = false;
            DtGdView.MultiSelect = false;
            try {
                DtGdView.Rows[0].Selected = true; }
            catch
            { MessageBox.Show("Il n'y a pas de résultats à votre recherche", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }
        public Form5()
        {
            InitializeComponent();
        }

      

        private void Form5_Load(object sender, EventArgs e)
        {

            if (Global.Modification == true)
            {
                BtnModifClient.Visible = true;
                BtnSupClient.Visible = false;
                BtnValider.Visible = false;
            }

            if (Global.Supprime == true)
            {
                BtnModifClient.Visible = false;
                BtnSupClient.Visible = true;
                BtnValider.Visible = false;
            }
            else if (Global.Recherche== true)
            {
                BtnSupClient.Visible = false;
                BtnModifClient.Visible = false;
                BtnValider.Visible = true;
            }

            ClientDAO repo2 = new ClientDAO();
            dataGridView1.DataSource = repo2.ListClientNum(Global.ID);
            for (int i = 4; i < 21; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            ParamDataGrid(dataGridView1);
            dataGridView1.Columns[13].Visible = true;
            dataGridView1.Columns[0].HeaderText = "Référence Client";
        }

        private void BtnSupClient_Click(object sender, EventArgs e)
        {
            DialogResult suppression = MessageBox.Show("Souhaitez vous vraiment supprimer la fiche client ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (suppression == DialogResult.Yes)
            {
                ClientDAO database = new ClientDAO();
                Client d = new Client();
                d.Numero_client = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                try
                {
                    database.Delete_Complet(d);
                    MessageBox.Show("Suppression Effectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            { }
        }

        private void BtnModifClient_Click(object sender, EventArgs e)
        {
            Global.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            PL.Form4 FicheClient = new Form4();
            FicheClient.Show();
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            try
            {
                Global.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                PL.Form4 FicheClient = new Form4();
                FicheClient.Show();
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
