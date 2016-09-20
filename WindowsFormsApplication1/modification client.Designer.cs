namespace PL
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBoxCP = new System.Windows.Forms.TextBox();
            this.TxtBoxFactVille = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBoxFactAdr = new System.Windows.Forms.TextBox();
            this.TxtBoxFactCompAdr = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBoxLivCP = new System.Windows.Forms.TextBox();
            this.TxtBoxLivVille = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtBoxLivAdr = new System.Windows.Forms.TextBox();
            this.TxtBoxLivCompAdr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtBoxSiret = new System.Windows.Forms.TextBox();
            this.TxtBoxEnseigne = new System.Windows.Forms.TextBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.LblRecherche = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxMail = new System.Windows.Forms.TextBox();
            this.TxtBoxFax = new System.Windows.Forms.TextBox();
            this.TxtBoxPrenom = new System.Windows.Forms.TextBox();
            this.TxtBoxTel = new System.Windows.Forms.TextBox();
            this.TxtBoxPort = new System.Windows.Forms.TextBox();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSaveModif = new System.Windows.Forms.Button();
            this.LabelRefCli = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.TxtBoxCoef = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.LblEtat = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Lblinactif = new System.Windows.Forms.Label();
            this.LblActif = new System.Windows.Forms.Label();
            this.LblModif = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(442, 267);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 198);
            this.tabControl1.TabIndex = 52;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.TxtBoxCP);
            this.tabPage1.Controls.Add(this.TxtBoxFactVille);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TxtBoxFactAdr);
            this.tabPage1.Controls.Add(this.TxtBoxFactCompAdr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 172);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adresse de Facturation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Ville :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Code Postal :";
            // 
            // TxtBoxCP
            // 
            this.TxtBoxCP.Location = new System.Drawing.Point(154, 92);
            this.TxtBoxCP.Name = "TxtBoxCP";
            this.TxtBoxCP.Size = new System.Drawing.Size(91, 20);
            this.TxtBoxCP.TabIndex = 27;
            // 
            // TxtBoxFactVille
            // 
            this.TxtBoxFactVille.Location = new System.Drawing.Point(152, 130);
            this.TxtBoxFactVille.Name = "TxtBoxFactVille";
            this.TxtBoxFactVille.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxFactVille.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Complément d\'adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adresse :";
            // 
            // TxtBoxFactAdr
            // 
            this.TxtBoxFactAdr.Location = new System.Drawing.Point(154, 26);
            this.TxtBoxFactAdr.Name = "TxtBoxFactAdr";
            this.TxtBoxFactAdr.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxFactAdr.TabIndex = 23;
            // 
            // TxtBoxFactCompAdr
            // 
            this.TxtBoxFactCompAdr.Location = new System.Drawing.Point(154, 57);
            this.TxtBoxFactCompAdr.Name = "TxtBoxFactCompAdr";
            this.TxtBoxFactCompAdr.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxFactCompAdr.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtBoxLivCP);
            this.tabPage2.Controls.Add(this.TxtBoxLivVille);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.TxtBoxLivAdr);
            this.tabPage2.Controls.Add(this.TxtBoxLivCompAdr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adresse de Livraison";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Ville :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(77, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Code Postal :";
            // 
            // TxtBoxLivCP
            // 
            this.TxtBoxLivCP.Location = new System.Drawing.Point(154, 92);
            this.TxtBoxLivCP.Name = "TxtBoxLivCP";
            this.TxtBoxLivCP.Size = new System.Drawing.Size(91, 20);
            this.TxtBoxLivCP.TabIndex = 35;
            // 
            // TxtBoxLivVille
            // 
            this.TxtBoxLivVille.Location = new System.Drawing.Point(152, 130);
            this.TxtBoxLivVille.Name = "TxtBoxLivVille";
            this.TxtBoxLivVille.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxLivVille.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Complément d\'adresse :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(97, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Adresse :";
            // 
            // TxtBoxLivAdr
            // 
            this.TxtBoxLivAdr.Location = new System.Drawing.Point(154, 26);
            this.TxtBoxLivAdr.Name = "TxtBoxLivAdr";
            this.TxtBoxLivAdr.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxLivAdr.TabIndex = 31;
            // 
            // TxtBoxLivCompAdr
            // 
            this.TxtBoxLivCompAdr.Location = new System.Drawing.Point(154, 57);
            this.TxtBoxLivCompAdr.Name = "TxtBoxLivCompAdr";
            this.TxtBoxLivCompAdr.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxLivCompAdr.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtBoxSiret);
            this.groupBox1.Controls.Add(this.TxtBoxEnseigne);
            this.groupBox1.Location = new System.Drawing.Point(106, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 67);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professionnel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Numéro de SIRET :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Enseigne :";
            // 
            // TxtBoxSiret
            // 
            this.TxtBoxSiret.Location = new System.Drawing.Point(494, 21);
            this.TxtBoxSiret.Name = "TxtBoxSiret";
            this.TxtBoxSiret.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxSiret.TabIndex = 26;
            // 
            // TxtBoxEnseigne
            // 
            this.TxtBoxEnseigne.Location = new System.Drawing.Point(87, 21);
            this.TxtBoxEnseigne.Name = "TxtBoxEnseigne";
            this.TxtBoxEnseigne.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxEnseigne.TabIndex = 23;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(21, 659);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(82, 34);
            this.BtnAnnuler.TabIndex = 50;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.Location = new System.Drawing.Point(863, 659);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(86, 34);
            this.BtnValider.TabIndex = 49;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // LblRecherche
            // 
            this.LblRecherche.AutoSize = true;
            this.LblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecherche.Location = new System.Drawing.Point(438, 208);
            this.LblRecherche.Name = "LblRecherche";
            this.LblRecherche.Size = new System.Drawing.Size(104, 20);
            this.LblRecherche.TabIndex = 48;
            this.LblRecherche.Text = "Fiche Client";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "E-mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fax :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Portable :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Téléphone :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nom :";
            // 
            // TxtBoxMail
            // 
            this.TxtBoxMail.Location = new System.Drawing.Point(600, 471);
            this.TxtBoxMail.Name = "TxtBoxMail";
            this.TxtBoxMail.Size = new System.Drawing.Size(260, 20);
            this.TxtBoxMail.TabIndex = 41;
            this.TxtBoxMail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxMail_Validating);
            // 
            // TxtBoxFax
            // 
            this.TxtBoxFax.Location = new System.Drawing.Point(181, 453);
            this.TxtBoxFax.Name = "TxtBoxFax";
            this.TxtBoxFax.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxFax.TabIndex = 40;
            // 
            // TxtBoxPrenom
            // 
            this.TxtBoxPrenom.Location = new System.Drawing.Point(181, 342);
            this.TxtBoxPrenom.Name = "TxtBoxPrenom";
            this.TxtBoxPrenom.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxPrenom.TabIndex = 39;
            this.TxtBoxPrenom.Validated += new System.EventHandler(this.TxtBoxPrenom_Validated);
            // 
            // TxtBoxTel
            // 
            this.TxtBoxTel.Location = new System.Drawing.Point(181, 378);
            this.TxtBoxTel.Name = "TxtBoxTel";
            this.TxtBoxTel.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxTel.TabIndex = 38;
            this.TxtBoxTel.Validated += new System.EventHandler(this.TxtBoxTel_Validated);
            // 
            // TxtBoxPort
            // 
            this.TxtBoxPort.Location = new System.Drawing.Point(181, 414);
            this.TxtBoxPort.Name = "TxtBoxPort";
            this.TxtBoxPort.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxPort.TabIndex = 37;
            this.TxtBoxPort.TextChanged += new System.EventHandler(this.TxtBoxPort_TextChanged);
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(181, 300);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(189, 20);
            this.TxtBoxNom.TabIndex = 36;
            this.TxtBoxNom.Validated += new System.EventHandler(this.TxtBoxNom_Validated);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(106, 519);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "Professionnel";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(221, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSaveModif
            // 
            this.BtnSaveModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveModif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSaveModif.Location = new System.Drawing.Point(764, 659);
            this.BtnSaveModif.Name = "BtnSaveModif";
            this.BtnSaveModif.Size = new System.Drawing.Size(185, 38);
            this.BtnSaveModif.TabIndex = 53;
            this.BtnSaveModif.Text = "Enregistrer modification";
            this.BtnSaveModif.UseVisualStyleBackColor = true;
            this.BtnSaveModif.Click += new System.EventHandler(this.BtnSaveModif_Click);
            // 
            // LabelRefCli
            // 
            this.LabelRefCli.AutoSize = true;
            this.LabelRefCli.Location = new System.Drawing.Point(190, 233);
            this.LabelRefCli.Name = "LabelRefCli";
            this.LabelRefCli.Size = new System.Drawing.Size(0, 13);
            this.LabelRefCli.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(98, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "Référence Client :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(132, 276);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Civilité :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(280, 274);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 57;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monsieur";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(208, 274);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 58;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Madame";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // TxtBoxCoef
            // 
            this.TxtBoxCoef.Location = new System.Drawing.Point(600, 510);
            this.TxtBoxCoef.Name = "TxtBoxCoef";
            this.TxtBoxCoef.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxCoef.TabIndex = 59;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(529, 513);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 13);
            this.label20.TabIndex = 60;
            this.label20.Text = "Coefficient :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(761, 215);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 13);
            this.label21.TabIndex = 61;
            this.label21.Text = "Etat :";
            // 
            // LblEtat
            // 
            this.LblEtat.AutoSize = true;
            this.LblEtat.Location = new System.Drawing.Point(800, 215);
            this.LblEtat.Name = "LblEtat";
            this.LblEtat.Size = new System.Drawing.Size(0, 13);
            this.LblEtat.TabIndex = 62;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(803, 233);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(50, 45);
            this.trackBar1.TabIndex = 63;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Lblinactif
            // 
            this.Lblinactif.AutoSize = true;
            this.Lblinactif.Location = new System.Drawing.Point(761, 249);
            this.Lblinactif.Name = "Lblinactif";
            this.Lblinactif.Size = new System.Drawing.Size(36, 13);
            this.Lblinactif.TabIndex = 64;
            this.Lblinactif.Text = "Inactif";
            // 
            // LblActif
            // 
            this.LblActif.AutoSize = true;
            this.LblActif.Location = new System.Drawing.Point(860, 249);
            this.LblActif.Name = "LblActif";
            this.LblActif.Size = new System.Drawing.Size(28, 13);
            this.LblActif.TabIndex = 65;
            this.LblActif.Text = "Actif";
            // 
            // LblModif
            // 
            this.LblModif.AutoSize = true;
            this.LblModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModif.Location = new System.Drawing.Point(388, 210);
            this.LblModif.Name = "LblModif";
            this.LblModif.Size = new System.Drawing.Size(206, 20);
            this.LblModif.TabIndex = 66;
            this.LblModif.Text = "Modification Fiche Client";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 709);
            this.Controls.Add(this.LblModif);
            this.Controls.Add(this.LblActif);
            this.Controls.Add(this.Lblinactif);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.LblEtat);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtBoxCoef);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LabelRefCli);
            this.Controls.Add(this.BtnSaveModif);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnValider);
            this.Controls.Add(this.LblRecherche);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxMail);
            this.Controls.Add(this.TxtBoxFax);
            this.Controls.Add(this.TxtBoxPrenom);
            this.Controls.Add(this.TxtBoxTel);
            this.Controls.Add(this.TxtBoxPort);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Fiche Client ";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Label LblRecherche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSaveModif;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TextBox TxtBoxCP;
        public System.Windows.Forms.TextBox TxtBoxFactVille;
        public System.Windows.Forms.TextBox TxtBoxFactAdr;
        public System.Windows.Forms.TextBox TxtBoxFactCompAdr;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtBoxSiret;
        public System.Windows.Forms.TextBox TxtBoxEnseigne;
        public System.Windows.Forms.TextBox TxtBoxMail;
        public System.Windows.Forms.TextBox TxtBoxFax;
        public System.Windows.Forms.TextBox TxtBoxPrenom;
        public System.Windows.Forms.TextBox TxtBoxTel;
        public System.Windows.Forms.TextBox TxtBoxPort;
        public System.Windows.Forms.TextBox TxtBoxNom;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TextBox TxtBoxLivCP;
        public System.Windows.Forms.TextBox TxtBoxLivVille;
        public System.Windows.Forms.TextBox TxtBoxLivAdr;
        public System.Windows.Forms.TextBox TxtBoxLivCompAdr;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LabelRefCli;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox TxtBoxCoef;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label LblEtat;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label Lblinactif;
        private System.Windows.Forms.Label LblActif;
        private System.Windows.Forms.Label LblModif;
    }
}