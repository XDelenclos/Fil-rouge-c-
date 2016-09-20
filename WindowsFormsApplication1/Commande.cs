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
    public partial class Commande : Form
    {
        public Commande()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRechercheCli_Click(object sender, EventArgs e)
        {
            RechClient SearchCli = new RechClient();
            SearchCli.Show();
        }

        private void Commande_Load(object sender, EventArgs e)
        {

        }
    }
}
