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
using System.Text.RegularExpressions;

namespace PL
{
    public partial class ListComClient : Form
    {
        bool flagNom = false;
        bool flagEnseigne = false;
        bool flagNum = false;
        Global G = new Global();
        //private WindowsFormsApplication1.Form4 Modifcli = new WindowsFormsApplication1.Form4();

        public ListComClient()
        {
            InitializeComponent();

        }
       
        public void Affichagecolonne()
        {
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
        }
        public void ParamDataGrid(DataGridView DtGdView)
        {
            DtGdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtGdView.RowHeadersVisible = false;
            DtGdView.MultiSelect = false;
            //DtGdView.Rows[0].Selected = true;
        }
        private void BtnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagNom == true)
                {
                    Width = 1100;
                    groupBox1.Enabled = true;
                    ClientDAO repo = new ClientDAO();
                    dataGridView1.DataSource = repo.ListClient(TxtBoxNom.Text);
                    Affichagecolonne();
                    ParamDataGrid(dataGridView1);
                }
                if (flagEnseigne == true)
                {
                    Width = 1100;
                    groupBox1.Enabled = true;
                    ClientDAO repo = new ClientDAO();
                    dataGridView1.DataSource = repo.ListClientEnseigne(TxtBoxEnseigne.Text);
                    Affichagecolonne();
                    ParamDataGrid(dataGridView1);
                }
                if (flagNum == true)
                {
                    Width = 1100;
                    groupBox1.Enabled = true;
                    ClientDAO repo = new ClientDAO();
                    dataGridView1.DataSource = repo.ListClientNum(Convert.ToInt32(TxtBoxNumClient.Text));
                    Affichagecolonne();
                    ParamDataGrid(dataGridView1);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nom incorrect ou mal orthographié");

            }

        }
        private void ListComClient_Load(object sender, EventArgs e)
        {
            Width = 620;
            groupBox1.Enabled = false;
        }
        private void BtnValidSearch_Click(object sender, EventArgs e)
        {
            if (flagNom==true)
            {
                Width = 620;
                groupBox1.Enabled = false;
                CommandeDAO repo = new CommandeDAO();
                DataGViewResultat.DataSource = repo.ListComNom(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                DataGViewResultat.Columns[1].Visible = false;
                DataGViewResultat.Columns[2].Visible = false;
                DataGViewResultat.Columns[3].Visible = false;
                DataGViewResultat.Columns[5].Visible = false;
                DataGViewResultat.Columns[6].Visible = false;
                DataGViewResultat.Columns[7].Visible = false;
                ParamDataGrid(DataGViewResultat);
               
            }
            if (flagEnseigne == true)
            {
                Width = 620;
                groupBox1.Enabled = false;
                CommandeDAO repo1 = new CommandeDAO();
                DataGViewResultat.DataSource = repo1.ListComEnseigne(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                DataGViewResultat.Columns[1].Visible = false;
                DataGViewResultat.Columns[2].Visible = false;
                DataGViewResultat.Columns[3].Visible = false;
                DataGViewResultat.Columns[5].Visible = false;
                DataGViewResultat.Columns[6].Visible = false;
                DataGViewResultat.Columns[7].Visible = false;
                ParamDataGrid(DataGViewResultat);
                
            }
            if (flagNum == true)
            {
                Width = 620;
                groupBox1.Enabled = false;
                CommandeDAO repo2 = new CommandeDAO();
                DataGViewResultat.DataSource = repo2.ListComNum(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                DataGViewResultat.Columns[1].Visible = false;
                DataGViewResultat.Columns[2].Visible = false;
                DataGViewResultat.Columns[3].Visible = false;
                DataGViewResultat.Columns[5].Visible = false;
                DataGViewResultat.Columns[6].Visible = false;
                DataGViewResultat.Columns[7].Visible = false;
                ParamDataGrid(DataGViewResultat);
              
               
            }
        }

        private void TxtBoxNom_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[A-Za-z]+$";
            if (Regex.IsMatch(TxtBoxNom.Text, pattern))
            {
                flagNom = true;
            }
            else
            { flagNom = false; }

        }
        private void TxtBoxEnseigne_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[A-Za-z0-9]+$";
            if (Regex.IsMatch(TxtBoxEnseigne.Text, pattern))
            {
                flagEnseigne = true;
            }
            else
            { flagEnseigne = false; }
        }
        private void TxtBoxNumClient_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[0-9]+$";
            if (Regex.IsMatch(TxtBoxNumClient.Text, pattern))
            {
                flagNum = true;
            }
            else
            { flagNum = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Width = 620;
            groupBox1.Enabled = true;
            TxtBoxNom.Clear();
        }

        private void BtnModifClient_Click(object sender, EventArgs e)
        {
            PL.Form4 ModifClient = new PL.Form4();
            Global.ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            ModifClient.Show();
        }

        private void BtnModifCom_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultCom_Click(object sender, EventArgs e)
        {
            PL.ConsulterCommande Consulter = new PL.ConsulterCommande();
            Consulter.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListComClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show(G.Interro(3), "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            { }
            else
                e.Cancel = true;
        }
    }
}
