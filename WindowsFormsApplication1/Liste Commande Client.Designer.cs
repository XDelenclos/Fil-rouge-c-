namespace PL
{
    partial class ListComClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRechercher = new System.Windows.Forms.Button();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtBoxEnseigne = new System.Windows.Forms.TextBox();
            this.TxtBoxNumClient = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrboxClient = new System.Windows.Forms.GroupBox();
            this.DataGViewResultat = new System.Windows.Forms.DataGridView();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnModifCom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnValidSearch = new System.Windows.Forms.Button();
            this.BtnModifClient = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsultCom = new System.Windows.Forms.Button();
            this.GrboxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGViewResultat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRechercher
            // 
            this.BtnRechercher.Location = new System.Drawing.Point(448, 37);
            this.BtnRechercher.Name = "BtnRechercher";
            this.BtnRechercher.Size = new System.Drawing.Size(102, 34);
            this.BtnRechercher.TabIndex = 0;
            this.BtnRechercher.Text = "Recherche Client";
            this.BtnRechercher.UseVisualStyleBackColor = true;
            this.BtnRechercher.Click += new System.EventHandler(this.BtnRechercher_Click);
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(30, 45);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(82, 20);
            this.TxtBoxNom.TabIndex = 1;
            this.TxtBoxNom.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxNom_Validating);
            // 
            // TxtBoxEnseigne
            // 
            this.TxtBoxEnseigne.Location = new System.Drawing.Point(139, 45);
            this.TxtBoxEnseigne.Name = "TxtBoxEnseigne";
            this.TxtBoxEnseigne.Size = new System.Drawing.Size(145, 20);
            this.TxtBoxEnseigne.TabIndex = 3;
            this.TxtBoxEnseigne.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxEnseigne_Validating);
            // 
            // TxtBoxNumClient
            // 
            this.TxtBoxNumClient.Location = new System.Drawing.Point(290, 45);
            this.TxtBoxNumClient.Name = "TxtBoxNumClient";
            this.TxtBoxNumClient.Size = new System.Drawing.Size(142, 20);
            this.TxtBoxNumClient.TabIndex = 7;
            this.TxtBoxNumClient.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxNumClient_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Nom :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Enseigne :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Numéro Client :";
            // 
            // GrboxClient
            // 
            this.GrboxClient.Controls.Add(this.label7);
            this.GrboxClient.Controls.Add(this.label13);
            this.GrboxClient.Controls.Add(this.label15);
            this.GrboxClient.Controls.Add(this.TxtBoxNumClient);
            this.GrboxClient.Controls.Add(this.TxtBoxEnseigne);
            this.GrboxClient.Controls.Add(this.TxtBoxNom);
            this.GrboxClient.Controls.Add(this.BtnRechercher);
            this.GrboxClient.Location = new System.Drawing.Point(12, 12);
            this.GrboxClient.Name = "GrboxClient";
            this.GrboxClient.Size = new System.Drawing.Size(560, 89);
            this.GrboxClient.TabIndex = 29;
            this.GrboxClient.TabStop = false;
            this.GrboxClient.Text = "Client";
            // 
            // DataGViewResultat
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGViewResultat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGViewResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGViewResultat.Location = new System.Drawing.Point(113, 125);
            this.DataGViewResultat.Name = "DataGViewResultat";
            this.DataGViewResultat.Size = new System.Drawing.Size(347, 179);
            this.DataGViewResultat.TabIndex = 30;
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(518, 338);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(75, 23);
            this.BtnValider.TabIndex = 31;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(12, 338);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.BtnAnnuler.TabIndex = 32;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnModifCom
            // 
            this.BtnModifCom.Location = new System.Drawing.Point(113, 310);
            this.BtnModifCom.Name = "BtnModifCom";
            this.BtnModifCom.Size = new System.Drawing.Size(152, 23);
            this.BtnModifCom.TabIndex = 33;
            this.BtnModifCom.Text = "Modifier la commande";
            this.BtnModifCom.UseVisualStyleBackColor = true;
            this.BtnModifCom.Click += new System.EventHandler(this.BtnModifCom_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 328);
            this.dataGridView1.TabIndex = 34;
            // 
            // BtnValidSearch
            // 
            this.BtnValidSearch.Location = new System.Drawing.Point(358, 20);
            this.BtnValidSearch.Name = "BtnValidSearch";
            this.BtnValidSearch.Size = new System.Drawing.Size(75, 41);
            this.BtnValidSearch.TabIndex = 35;
            this.BtnValidSearch.Text = "Ajouter Sélection";
            this.BtnValidSearch.UseVisualStyleBackColor = true;
            this.BtnValidSearch.Click += new System.EventHandler(this.BtnValidSearch_Click);
            // 
            // BtnModifClient
            // 
            this.BtnModifClient.Location = new System.Drawing.Point(358, 67);
            this.BtnModifClient.Name = "BtnModifClient";
            this.BtnModifClient.Size = new System.Drawing.Size(75, 42);
            this.BtnModifClient.TabIndex = 36;
            this.BtnModifClient.Text = "Modifier client";
            this.BtnModifClient.UseVisualStyleBackColor = true;
            this.BtnModifClient.Click += new System.EventHandler(this.BtnModifClient_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.BtnModifClient);
            this.groupBox1.Controls.Add(this.BtnValidSearch);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(616, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 356);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche client";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnConsultCom
            // 
            this.BtnConsultCom.Location = new System.Drawing.Point(308, 310);
            this.BtnConsultCom.Name = "BtnConsultCom";
            this.BtnConsultCom.Size = new System.Drawing.Size(152, 23);
            this.BtnConsultCom.TabIndex = 39;
            this.BtnConsultCom.Text = "Consulter la commande";
            this.BtnConsultCom.UseVisualStyleBackColor = true;
            this.BtnConsultCom.Click += new System.EventHandler(this.BtnConsultCom_Click);
            // 
            // ListComClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 373);
            this.Controls.Add(this.BtnConsultCom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnModifCom);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.DataGViewResultat);
            this.Controls.Add(this.GrboxClient);
            this.Name = "ListComClient";
            this.Text = "Liste des Commandes Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListComClient_FormClosing);
            this.Load += new System.EventHandler(this.ListComClient_Load);
            this.GrboxClient.ResumeLayout(false);
            this.GrboxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGViewResultat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GrboxClient;
        private System.Windows.Forms.DataGridView DataGViewResultat;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnModifCom;
        public System.Windows.Forms.TextBox TxtBoxNom;
        public System.Windows.Forms.TextBox TxtBoxEnseigne;
        public System.Windows.Forms.TextBox TxtBoxNumClient;
        public System.Windows.Forms.Button BtnRechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnValidSearch;
        private System.Windows.Forms.Button BtnModifClient;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsultCom;
    }
}