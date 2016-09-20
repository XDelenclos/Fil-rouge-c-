using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Démarrage : Form
    {
        public Démarrage()
        {
            InitializeComponent();
        }

       

        private void Démarrage_Load(object sender, EventArgs e)
        {

        }

        private void BtnNouvCom_Click(object sender, EventArgs e)
        {
            Commande commande = new Commande();
            commande.Show();
            this.Hide();
        }

        private void BtnEditerCom_Click(object sender, EventArgs e)
        {
            ListComClient ListeCommande = new ListComClient();
            this.Hide();
            ListeCommande.ShowDialog();
            Show();
            
        }

        private void BtnNewClient_Click(object sender, EventArgs e)
        {
            CreaNewClient NewClient = new CreaNewClient();
            NewClient.Show();
            this.Hide();
        }

        private void BtnRechClient_Click(object sender, EventArgs e)
        {
            RechClient SearchCli = new RechClient();
            this.Hide();
            SearchCli.ShowDialog();
            Show();
        }
    }
}
