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
    public partial class RechClient : Form
    {
        bool flagNom = false;
        bool flagPrenom = false;
        bool flagEnseigne = false; 
        bool flagRefCli = false;
        ClientDAO repo = new ClientDAO();
        string PatternNomPrenom = @"^[a-zA-ZÀ-ÿ\s\’-]{1-80}";
        string PatternNum = "^[0-9]+$";
        
        public RechClient()
        {
            InitializeComponent();
        }

        private void Annuler(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void RechClient_Load(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void BtnRechercheCli_Click(object sender, EventArgs e)
        {
            if (flagNom == true && flagPrenom==true)
            {
                PL.Form5 RechClient = new PL.Form5();
                Client c = repo.findnom(TxtBoxNom.Text, TxtBoxPrenom.Text, Global.Choix);
                Global.ID = c.Numero_client;
                RechClient.Show();
            }
            else if (flagEnseigne ==true)
            {
                PL.Form5 RechClient = new PL.Form5();
                Client c = repo.findEnseigne(TxtBoxEnseigne.Text, Global.Choix);
                Global.ID = c.Numero_client;
                RechClient.Show();
            }
            else if (flagRefCli==true)
            {
                PL.Form5 RechClient = new PL.Form5();
                Client c = repo.find(Convert.ToInt32(TxtBoxRefCli.Text), Global.Choix);
                Global.ID = c.Numero_client;
                RechClient.Show();
            }
           

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void TxtBoxRefCli_Validating(object sender, CancelEventArgs e)
        {
            if (TxtBoxRefCli.Text != "")
            {
                flagRefCli = true;
            }
        }

        private void TxtBoxNom_Validating(object sender, CancelEventArgs e)
        {
            if (TxtBoxNom.Text != "")
            {
                flagNom = true;
            }
        }

        private void TxtBoxPrenom_Validating(object sender, CancelEventArgs e)
        {
            if (TxtBoxPrenom.Text != "")
            {
                flagPrenom = true;
            }
        }

        private void TxtBoxEnseigne_Validating(object sender, CancelEventArgs e)
        {
            if (TxtBoxEnseigne.Text != "")
            {
                flagEnseigne = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Global.Choix = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Choix = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Choix = 1;
        }
    }
}
