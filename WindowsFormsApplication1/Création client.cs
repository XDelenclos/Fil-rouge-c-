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
    public partial class CreaNewClient : Form
    {
        ClientDAO repo = new ClientDAO();
        Global G = new Global();
        public CreaNewClient()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void CreaNewClient_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            DialogResult Resultat = MessageBox.Show("Souhaitez vous valider la saisie ?", "Validation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (Resultat == DialogResult.Yes)
            {
                Client c = new Client();
                if (radioButton1.Checked == true)
                {
                    c.Civilite = true;
                }
                else
                    c.Civilite = false;

                c.Nom = TxtBoxNom.Text;
                c.Prenom = TxtBoxPrenom.Text;
                c.Téléphone = TxtBoxTel.Text;
                c.TelPortable = TxtBoxPort.Text;
                if (CheckBoxPRo.Checked == true)
                { c.Siret = Convert.ToDouble(TxtBoxSiret.Text); }
                else
                { }

                c.email = TxtBoxMail.Text;
                c.VilleLiv = TxtBoxLivVille.Text;
                c.CPLivraison = TxtBoxLivCP.Text;
                c.CompAdressLiv = TxtBoxLivCompAdr.Text;
                c.AdrLivraison = TxtBoxLivAdr.Text;
                c.Fax = TxtBoxFax.Text;
                c.VilleFact = TxtBoxFactVille.Text;
                c.AdrFacturation = TxtBoxFactAdr.Text;
                c.CompAdressFact = TxtBoxFactCompAdr.Text;
                c.CPFacturation = TxtBoxCPFact.Text;
                c.Enseigne = TxtBoxEnseigne.Text;
                c.CPFacturation = TxtBoxCPFact.Text;
                c.Coefficient = Convert.ToInt32(TxtBoxCoef.Text);
                if (CheckBoxPRo.Checked == true)
                {
                    c.Statut = true;
                }
                else
                { c.Statut = false; }
                /*c.Activite = " Actif";*/
                ClientDAO database = new ClientDAO();
                try
                {
                    database.insert(c);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Resultat == DialogResult.Cancel)
            {

            }
            else if (Resultat == DialogResult.No)
            {
                this.Close();
            }

        }

        private void CheckBoxPRo_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPRo.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
                groupBox1.Enabled = false;
        }

        private void TxtBoxFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreaNewClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult R = MessageBox.Show(G.Interro(1), "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (R == DialogResult.Yes)
            { }
            else
                e.Cancel= true;
        }
    }
}
