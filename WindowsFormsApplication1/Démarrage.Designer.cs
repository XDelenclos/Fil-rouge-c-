namespace PL
{
    partial class Démarrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Démarrage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCatalogue = new System.Windows.Forms.Button();
            this.BtnNouvCom = new System.Windows.Forms.Button();
            this.BtnDeconnexion = new System.Windows.Forms.Button();
            this.BtnEditerCom = new System.Windows.Forms.Button();
            this.GBoxCommande = new System.Windows.Forms.GroupBox();
            this.GBoxClient = new System.Windows.Forms.GroupBox();
            this.BtnRechClient = new System.Windows.Forms.Button();
            this.BtnNewClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxCommande.SuspendLayout();
            this.GBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCatalogue
            // 
            this.BtnCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCatalogue.Location = new System.Drawing.Point(251, 213);
            this.BtnCatalogue.Name = "BtnCatalogue";
            this.BtnCatalogue.Size = new System.Drawing.Size(219, 81);
            this.BtnCatalogue.TabIndex = 4;
            this.BtnCatalogue.Text = "Catalogue";
            this.BtnCatalogue.UseVisualStyleBackColor = true;
            // 
            // BtnNouvCom
            // 
            this.BtnNouvCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouvCom.Location = new System.Drawing.Point(34, 29);
            this.BtnNouvCom.Name = "BtnNouvCom";
            this.BtnNouvCom.Size = new System.Drawing.Size(219, 81);
            this.BtnNouvCom.TabIndex = 5;
            this.BtnNouvCom.Text = "Nouvelle Commande";
            this.BtnNouvCom.UseVisualStyleBackColor = true;
            this.BtnNouvCom.Click += new System.EventHandler(this.BtnNouvCom_Click);
            // 
            // BtnDeconnexion
            // 
            this.BtnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeconnexion.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnDeconnexion.Location = new System.Drawing.Point(596, 599);
            this.BtnDeconnexion.Name = "BtnDeconnexion";
            this.BtnDeconnexion.Size = new System.Drawing.Size(120, 38);
            this.BtnDeconnexion.TabIndex = 6;
            this.BtnDeconnexion.Text = "Déconnexion →";
            this.BtnDeconnexion.UseVisualStyleBackColor = true;
            // 
            // BtnEditerCom
            // 
            this.BtnEditerCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditerCom.Location = new System.Drawing.Point(34, 161);
            this.BtnEditerCom.Name = "BtnEditerCom";
            this.BtnEditerCom.Size = new System.Drawing.Size(219, 81);
            this.BtnEditerCom.TabIndex = 7;
            this.BtnEditerCom.Text = "Rechercher une Commande";
            this.BtnEditerCom.UseVisualStyleBackColor = true;
            this.BtnEditerCom.Click += new System.EventHandler(this.BtnEditerCom_Click);
            // 
            // GBoxCommande
            // 
            this.GBoxCommande.Controls.Add(this.BtnEditerCom);
            this.GBoxCommande.Controls.Add(this.BtnNouvCom);
            this.GBoxCommande.Location = new System.Drawing.Point(36, 311);
            this.GBoxCommande.Name = "GBoxCommande";
            this.GBoxCommande.Size = new System.Drawing.Size(288, 270);
            this.GBoxCommande.TabIndex = 10;
            this.GBoxCommande.TabStop = false;
            // 
            // GBoxClient
            // 
            this.GBoxClient.Controls.Add(this.BtnRechClient);
            this.GBoxClient.Controls.Add(this.BtnNewClient);
            this.GBoxClient.Location = new System.Drawing.Point(396, 311);
            this.GBoxClient.Name = "GBoxClient";
            this.GBoxClient.Size = new System.Drawing.Size(288, 270);
            this.GBoxClient.TabIndex = 11;
            this.GBoxClient.TabStop = false;
            // 
            // BtnRechClient
            // 
            this.BtnRechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechClient.Location = new System.Drawing.Point(34, 161);
            this.BtnRechClient.Name = "BtnRechClient";
            this.BtnRechClient.Size = new System.Drawing.Size(219, 81);
            this.BtnRechClient.TabIndex = 7;
            this.BtnRechClient.Text = "Rechercher un Client";
            this.BtnRechClient.UseVisualStyleBackColor = true;
            this.BtnRechClient.Click += new System.EventHandler(this.BtnRechClient_Click);
            // 
            // BtnNewClient
            // 
            this.BtnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewClient.Location = new System.Drawing.Point(34, 29);
            this.BtnNewClient.Name = "BtnNewClient";
            this.BtnNewClient.Size = new System.Drawing.Size(219, 81);
            this.BtnNewClient.TabIndex = 5;
            this.BtnNewClient.Text = "Nouveau Client";
            this.BtnNewClient.UseVisualStyleBackColor = true;
            this.BtnNewClient.Click += new System.EventHandler(this.BtnNewClient_Click);
            // 
            // Démarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 649);
            this.Controls.Add(this.GBoxClient);
            this.Controls.Add(this.GBoxCommande);
            this.Controls.Add(this.BtnDeconnexion);
            this.Controls.Add(this.BtnCatalogue);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Démarrage";
            this.Text = "Démarrage";
            this.Load += new System.EventHandler(this.Démarrage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxCommande.ResumeLayout(false);
            this.GBoxClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCatalogue;
        private System.Windows.Forms.Button BtnNouvCom;
        private System.Windows.Forms.Button BtnDeconnexion;
        private System.Windows.Forms.Button BtnEditerCom;
        private System.Windows.Forms.GroupBox GBoxCommande;
        private System.Windows.Forms.GroupBox GBoxClient;
        private System.Windows.Forms.Button BtnRechClient;
        private System.Windows.Forms.Button BtnNewClient;
    }
}