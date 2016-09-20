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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Village_Green.mdiobj.fichierToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.deconnexionToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.clientToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.commandeToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.fournisseurToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.catalogueToolStripMenuItem.Enabled = true;
            PL.Village_Green.mdiobj.connexionToolStripMenuItem.Enabled = false;
            this.Close();
        }
    }
}
