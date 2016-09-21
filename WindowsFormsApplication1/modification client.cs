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
    public partial class Form4 : Form
    {
        ClientDAO repo = new ClientDAO();
        Global G = new Global();
        public Form4()
        {
            InitializeComponent();
        }

        public void Form4_Load(object sender, EventArgs e)
        {
            if (Global.Modification == true)
            {
                LblActif.Visible = true;
                Lblinactif.Visible = true;
                trackBar1.Visible = true;
                BtnSaveModif.Visible = true;
                BtnValider.Visible = false;
                LblModif.Visible = true;
                LblRecherche.Visible = false;

            }
            else if (Global.Recherche == true)
            {
                BtnSaveModif.Visible = false;
                BtnValider.Visible = true;
                LblActif.Visible = false;
                Lblinactif.Visible = false;
                trackBar1.Visible = false;
                LblModif.Visible = false;
                LblRecherche.Visible = true;
                checkBox1.Enabled = false;
                TxtBoxNom.Enabled = false;
                TxtBoxPrenom.Enabled = false;
                TxtBoxTel.Enabled = false;
                TxtBoxSiret.Enabled = false;
                TxtBoxMail.Enabled = false;
                TxtBoxLivVille.Enabled = false;
                TxtBoxLivCP.Enabled = false;
                TxtBoxLivCompAdr.Enabled = false;
                TxtBoxLivAdr.Enabled = false; ;
                TxtBoxFax.Enabled = false;
                TxtBoxFactVille.Enabled = false;
                TxtBoxFactAdr.Enabled = false;
                TxtBoxFactCompAdr.Enabled = false;
                TxtBoxEnseigne.Enabled = false;
                TxtBoxCP.Enabled = false;
                TxtBoxPort.Enabled = false;
                TxtBoxCoef.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
            }


            Client c = repo.find(Global.ID, 3);
            LabelRefCli.Text = Convert.ToString(c.Numero_client);
            TxtBoxNom.Text = c.Nom;
            TxtBoxPrenom.Text = c.Prenom;
            TxtBoxTel.Text = c.Téléphone;
            TxtBoxPort.Text = c.TelPortable;
            if (c.Siret == 0)
            { TxtBoxSiret.Text = ""; }
            else
            { TxtBoxSiret.Text = Convert.ToString(c.Siret); }
            TxtBoxMail.Text = c.email;
            TxtBoxLivVille.Text = c.VilleLiv;
            TxtBoxLivCP.Text = c.CPLivraison;
            TxtBoxLivCompAdr.Text = c.CompAdressLiv;
            TxtBoxFactCompAdr.Text = c.CompAdressFact;
            TxtBoxLivAdr.Text = c.AdrLivraison;
            TxtBoxFax.Text = c.Fax;
            TxtBoxFactVille.Text = c.VilleFact;
            TxtBoxFactAdr.Text = c.AdrFacturation;
            TxtBoxEnseigne.Text = c.Enseigne;
            TxtBoxCP.Text = c.CPFacturation;
            TxtBoxCoef.Text = c.Coefficient.ToString();
            if (c.Activite == "Actif     ")
            {
                LblEtat.ForeColor = Color.Green;
                LblEtat.Text = c.Activite;
            }
            else if (c.Activite == "Inactif   ")
            {
                LblEtat.ForeColor = Color.Red;
                LblEtat.Text = c.Activite;
            }
            if (c.Statut == true)
            {
                checkBox1.Checked = true;
                groupBox1.Enabled = true;
            }
            else
            { groupBox1.Enabled = false; }
            if (c.Civilite == true)
            {
                radioButton1.Checked = true;
            }
            else if (c.Civilite == false)
            { radioButton2.Checked = true; }


            if (c.AdrFacturation == "")
            {
                tabControl1.SelectedTab = tabControl1.TabPages[1];
            }
            else
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            if (c.Activite == "Actif     ")
            { trackBar1.Value = 1; }
            else
                trackBar1.Value = 0;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            { groupBox1.Enabled = false; }
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {



        }

        private void BtnSaveModif_Click(object sender, EventArgs e)
        {
            Client d = new Client();
            d.Nom = TxtBoxNom.Text;
            d.Prenom = TxtBoxPrenom.Text;
            d.Enseigne = TxtBoxEnseigne.Text;
            if (TxtBoxSiret.Text == "")
            { d.Siret = null; }
            else
            { d.Siret = Convert.ToInt32(TxtBoxSiret.Text); }

            d.AdrFacturation = TxtBoxFactAdr.Text;
            d.AdrFacturation = TxtBoxFactAdr.Text;
            d.CompAdressFact = TxtBoxFactCompAdr.Text;
            d.VilleFact = TxtBoxFactVille.Text;
            d.CPFacturation = TxtBoxCP.Text;
            d.AdrLivraison = TxtBoxLivAdr.Text;
            d.CompAdressLiv = TxtBoxLivCompAdr.Text;
            d.VilleLiv = TxtBoxLivVille.Text;
            d.CPLivraison = TxtBoxLivCP.Text;
            d.Téléphone = TxtBoxTel.Text;
            d.TelPortable = TxtBoxPort.Text;
            if (checkBox1.Checked == true)
            {
                d.Statut = true;
            }
            else
            { d.Statut = false; }
            if (radioButton1.Checked == true)
            {
                d.Civilite = true;
            }
            else
            {
                d.Civilite = false;
            }
            d.Fax = TxtBoxFax.Text;
            d.email = TxtBoxMail.Text;
            if (TxtBoxCoef.Text == "")
            { d.Coefficient = null; }
            else
            { d.Coefficient = Convert.ToInt32(TxtBoxCoef.Text); }

            DialogResult Modif = MessageBox.Show(G.Interro(2), "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Modif == DialogResult.Yes)
            {
                ClientDAO database = new ClientDAO();
                d.Numero_client = Global.ID;
                try
                {
                    database.Update(d, Global.Activite);
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

        private void BtnAnnuler_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Global.Activite = trackBar1.Value;
            if (Global.Activite == 0)
            {
                LblEtat.ForeColor = Color.Red;
                LblEtat.Text = "Inactif";
            }
            else
            {
                LblEtat.ForeColor = Color.Green;
                LblEtat.Text = "Actif";
            }
        }

        private void TxtBoxNom_Validated(object sender, EventArgs e)
        {

        }

        private void TxtBoxPrenom_Validated(object sender, EventArgs e)
        {

        }

        private void TxtBoxTel_Validated(object sender, EventArgs e)
        {

        }

        private void TxtBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxMail_Validating(object sender, CancelEventArgs e)
        {
            ClientDAO test = new ClientDAO();
            if (test.TestMail(TxtBoxMail.Text)!="")
            MessageBox.Show("Une erreur a été détectée : "+test.TestMail(TxtBoxMail.Text),"Erreur adresse E-mail",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            { }

        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.Modification == true)
            {
                DialogResult R = MessageBox.Show(G.Interro(1), "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                { }
                else
                { e.Cancel = true; }
            }
            else
                this.Close();
        }
    }
}
