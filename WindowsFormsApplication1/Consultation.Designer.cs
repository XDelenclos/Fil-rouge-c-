namespace WindowsFormsApplication1
{
    partial class Consultation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultation));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiffreDaffaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsCOmmandésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.répartitionDuCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.particulierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.génréralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiffreDaffaireToolStripMenuItem,
            this.produitsCOmmandésToolStripMenuItem,
            this.listeDesCommandesToolStripMenuItem,
            this.répartitionDuCAToolStripMenuItem,
            this.commandesEnCoursToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fichierToolStripMenuItem.Text = "Consulter";
            // 
            // chiffreDaffaireToolStripMenuItem
            // 
            this.chiffreDaffaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.génréralToolStripMenuItem,
            this.ournisseursToolStripMenuItem});
            this.chiffreDaffaireToolStripMenuItem.Name = "chiffreDaffaireToolStripMenuItem";
            this.chiffreDaffaireToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.chiffreDaffaireToolStripMenuItem.Text = "Chiffre d\'affaire";
            // 
            // produitsCOmmandésToolStripMenuItem
            // 
            this.produitsCOmmandésToolStripMenuItem.Name = "produitsCOmmandésToolStripMenuItem";
            this.produitsCOmmandésToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.produitsCOmmandésToolStripMenuItem.Text = "Produits Commandés";
            // 
            // listeDesCommandesToolStripMenuItem
            // 
            this.listeDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.particulierToolStripMenuItem,
            this.professionnelToolStripMenuItem});
            this.listeDesCommandesToolStripMenuItem.Name = "listeDesCommandesToolStripMenuItem";
            this.listeDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.listeDesCommandesToolStripMenuItem.Text = "Répartiton CA";
            this.listeDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeDesCommandesToolStripMenuItem_Click);
            // 
            // répartitionDuCAToolStripMenuItem
            // 
            this.répartitionDuCAToolStripMenuItem.Name = "répartitionDuCAToolStripMenuItem";
            this.répartitionDuCAToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.répartitionDuCAToolStripMenuItem.Text = "Liste des Commandes";
            // 
            // commandesEnCoursToolStripMenuItem
            // 
            this.commandesEnCoursToolStripMenuItem.Name = "commandesEnCoursToolStripMenuItem";
            this.commandesEnCoursToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.commandesEnCoursToolStripMenuItem.Text = "Commandes en cours";
            // 
            // particulierToolStripMenuItem
            // 
            this.particulierToolStripMenuItem.Name = "particulierToolStripMenuItem";
            this.particulierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.particulierToolStripMenuItem.Text = "Particulier";
            // 
            // professionnelToolStripMenuItem
            // 
            this.professionnelToolStripMenuItem.Name = "professionnelToolStripMenuItem";
            this.professionnelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.professionnelToolStripMenuItem.Text = "Professionnel";
            // 
            // génréralToolStripMenuItem
            // 
            this.génréralToolStripMenuItem.Name = "génréralToolStripMenuItem";
            this.génréralToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.génréralToolStripMenuItem.Text = "Général";
            // 
            // ournisseursToolStripMenuItem
            // 
            this.ournisseursToolStripMenuItem.Name = "ournisseursToolStripMenuItem";
            this.ournisseursToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ournisseursToolStripMenuItem.Text = "Par Fournisseur";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiffreDaffaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsCOmmandésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem répartitionDuCAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandesEnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem génréralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem particulierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionnelToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}