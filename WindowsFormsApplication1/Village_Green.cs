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
    public partial class Village_Green : Form
    {
        public static Village_Green mdiobj;
        public Village_Green()
        {
            InitializeComponent();
        }
        public void ParamFenetre(Form Maform)
        {
            Maform.MdiParent = this;
            Maform.Show();
        }
        private void Village_Green_Load(object sender, EventArgs e)
        {
            deconnexionToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            commandeToolStripMenuItem.Enabled = false;
            fournisseurToolStripMenuItem.Enabled = false;
            catalogueToolStripMenuItem.Enabled = false;
            PL.Authentification connexion = new PL.Authentification();
            connexion.Show();
            ParamFenetre(connexion);
            mdiobj = this;
            Global.Modification = false;
            Global.Recherche = false;
            Global.Supprime = false;
        }
        private void modifierUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Authentification Accueil = new PL.Authentification();
            Accueil.Show();
        }
        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fichierToolStripMenuItem.Enabled = false;
            deconnexionToolStripMenuItem.Enabled = false;
            clientToolStripMenuItem.Enabled = false;
            commandeToolStripMenuItem.Enabled = false;
            fournisseurToolStripMenuItem.Enabled = false;
            catalogueToolStripMenuItem.Enabled = false;
            PL.Authentification connexion = new PL.Authentification();
            connexion.Show();
            ParamFenetre(connexion);
            mdiobj = this;
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.CreaNewClient NewClient = new PL.CreaNewClient();
            NewClient.Show();
            ParamFenetre(NewClient);
            mdiobj = this;
        }

        private void modifierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.Recherche = false;
            Global.Modification = true;
            Global.Supprime = false;
            PL.RechClient RechClient = new PL.RechClient();
            RechClient.Show();
            ParamFenetre(RechClient);
            mdiobj = this;
        }

        private void rechercherClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.Recherche = true;
            Global.Modification = false;
            Global.Supprime = false;
            PL.RechClient RechClient = new PL.RechClient();
            RechClient.Show();
            ParamFenetre(RechClient);
            mdiobj = this;
        }
        private void NewCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            PL.Commande NewCom = new PL.Commande();
            NewCom.Show();
            ParamFenetre(NewCom);
            mdiobj = this;
        }

        private void RechUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.ListComClient RechComClient = new PL.ListComClient();
            RechComClient.Show();
            ParamFenetre(RechComClient);
            mdiobj = this;
        }

        private void editerUneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void génréralToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void particulierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void professionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Form3 CAPro = new PL.Form3();
            CAPro.Show();
            ParamFenetre(CAPro);
            mdiobj = this;
        }

        private void supprimerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.Modification = false;
            Global.Recherche = false;
            Global.Supprime = true;
            PL.RechClient RechClient = new PL.RechClient();
            RechClient.Show();
            ParamFenetre(RechClient);
            mdiobj = this;
        }
    }
}
