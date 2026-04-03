namespace Interface
{
    partial class FrmVisiteBilan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteBilan));
            panelCentral = new Panel();
            panelDroit = new Panel();
            label6 = new Label();
            dgvEchantillon = new DataGridView();
            btnAjouter = new Button();
            label5 = new Label();
            cptQuantite = new NumericUpDown();
            label4 = new Label();
            cbxEchantillon = new ComboBox();
            label1 = new Label();
            panelGauche = new Panel();
            msgBilan = new Label();
            msgSecondMedicament = new Label();
            msgPremierMedicament = new Label();
            btnEnregistrer = new Button();
            label7 = new Label();
            txtBilan = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbxSecondMedicament = new ComboBox();
            cbxPremierMedicament = new ComboBox();
            panelHaut = new Panel();
            label9 = new Label();
            label8 = new Label();
            lblMessage = new Label();
            lblNom = new Label();
            lblDate = new Label();
            btnSuivant = new Button();
            btnPrecedent = new Button();
            panelCentral.SuspendLayout();
            panelDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cptQuantite).BeginInit();
            panelGauche.SuspendLayout();
            panelHaut.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panelDroit);
            panelCentral.Controls.Add(panelGauche);
            panelCentral.Controls.Add(panelHaut);
            panelCentral.Location = new Point(24, 101);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(749, 301);
            panelCentral.TabIndex = 13;
            // 
            // panelDroit
            // 
            panelDroit.Controls.Add(label6);
            panelDroit.Controls.Add(dgvEchantillon);
            panelDroit.Controls.Add(btnAjouter);
            panelDroit.Controls.Add(label5);
            panelDroit.Controls.Add(cptQuantite);
            panelDroit.Controls.Add(label4);
            panelDroit.Controls.Add(cbxEchantillon);
            panelDroit.Controls.Add(label1);
            panelDroit.Location = new Point(371, 81);
            panelDroit.Name = "panelDroit";
            panelDroit.Size = new Size(375, 216);
            panelDroit.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 79);
            label6.Name = "label6";
            label6.Size = new Size(176, 15);
            label6.TabIndex = 7;
            label6.Text = "Liste des médicament distribués";
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEchantillon.Location = new Point(12, 97);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.Size = new Size(348, 116);
            dgvEchantillon.TabIndex = 6;
            dgvEchantillon.CellClick += dgvEchantillon_CellClick;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.White;
            btnAjouter.Location = new Point(254, 49);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(95, 23);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 31);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Quantité";
            // 
            // cptQuantite
            // 
            cptQuantite.Location = new Point(195, 49);
            cptQuantite.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            cptQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cptQuantite.Name = "cptQuantite";
            cptQuantite.Size = new Size(44, 23);
            cptQuantite.TabIndex = 3;
            cptQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 30);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 2;
            label4.Text = "Médicament";
            // 
            // cbxEchantillon
            // 
            cbxEchantillon.FormattingEnabled = true;
            cbxEchantillon.Location = new Point(12, 48);
            cbxEchantillon.Name = "cbxEchantillon";
            cbxEchantillon.Size = new Size(157, 23);
            cbxEchantillon.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Echantillon distribués";
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(msgBilan);
            panelGauche.Controls.Add(msgSecondMedicament);
            panelGauche.Controls.Add(msgPremierMedicament);
            panelGauche.Controls.Add(btnEnregistrer);
            panelGauche.Controls.Add(label7);
            panelGauche.Controls.Add(txtBilan);
            panelGauche.Controls.Add(label3);
            panelGauche.Controls.Add(label2);
            panelGauche.Controls.Add(cbxSecondMedicament);
            panelGauche.Controls.Add(cbxPremierMedicament);
            panelGauche.Location = new Point(15, 81);
            panelGauche.Name = "panelGauche";
            panelGauche.Size = new Size(350, 216);
            panelGauche.TabIndex = 1;
            // 
            // msgBilan
            // 
            msgBilan.AutoSize = true;
            msgBilan.ForeColor = Color.Red;
            msgBilan.Location = new Point(17, 194);
            msgBilan.Name = "msgBilan";
            msgBilan.Size = new Size(44, 15);
            msgBilan.TabIndex = 9;
            msgBilan.Text = "label10";
            // 
            // msgSecondMedicament
            // 
            msgSecondMedicament.AutoSize = true;
            msgSecondMedicament.ForeColor = Color.Red;
            msgSecondMedicament.Location = new Point(3, 64);
            msgSecondMedicament.Name = "msgSecondMedicament";
            msgSecondMedicament.Size = new Size(44, 15);
            msgSecondMedicament.TabIndex = 8;
            msgSecondMedicament.Text = "label10";
            // 
            // msgPremierMedicament
            // 
            msgPremierMedicament.AutoSize = true;
            msgPremierMedicament.ForeColor = Color.Red;
            msgPremierMedicament.Location = new Point(3, 30);
            msgPremierMedicament.Name = "msgPremierMedicament";
            msgPremierMedicament.Size = new Size(44, 15);
            msgPremierMedicament.TabIndex = 7;
            msgPremierMedicament.Text = "label10";
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.Red;
            btnEnregistrer.Location = new Point(150, 190);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(173, 23);
            btnEnregistrer.TabIndex = 6;
            btnEnregistrer.Text = "Enregistrer la fiche visite";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 79);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 5;
            label7.Text = "Bilan de la visite";
            // 
            // txtBilan
            // 
            txtBilan.Location = new Point(17, 97);
            txtBilan.Multiline = true;
            txtBilan.Name = "txtBilan";
            txtBilan.Size = new Size(306, 87);
            txtBilan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 3;
            label3.Text = "Second médicament proposé :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 2;
            label2.Text = "Premier médicament présenté :";
            // 
            // cbxSecondMedicament
            // 
            cbxSecondMedicament.FormattingEnabled = true;
            cbxSecondMedicament.Location = new Point(181, 48);
            cbxSecondMedicament.Name = "cbxSecondMedicament";
            cbxSecondMedicament.Size = new Size(142, 23);
            cbxSecondMedicament.TabIndex = 1;
            // 
            // cbxPremierMedicament
            // 
            cbxPremierMedicament.FormattingEnabled = true;
            cbxPremierMedicament.Location = new Point(181, 9);
            cbxPremierMedicament.Name = "cbxPremierMedicament";
            cbxPremierMedicament.Size = new Size(142, 23);
            cbxPremierMedicament.TabIndex = 0;
            // 
            // panelHaut
            // 
            panelHaut.Controls.Add(label9);
            panelHaut.Controls.Add(label8);
            panelHaut.Controls.Add(lblMessage);
            panelHaut.Controls.Add(lblNom);
            panelHaut.Controls.Add(lblDate);
            panelHaut.Controls.Add(btnSuivant);
            panelHaut.Controls.Add(btnPrecedent);
            panelHaut.Location = new Point(18, 14);
            panelHaut.Name = "panelHaut";
            panelHaut.Size = new Size(728, 61);
            panelHaut.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 36);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 8;
            label9.Text = "Chez";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 7);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 7;
            label8.Text = "Le";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(61, 46);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(44, 15);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "label10";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(249, 36);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(98, 15);
            lblNom.TabIndex = 5;
            lblNom.Text = "nom du praticien";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(230, 7);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(96, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "date et heure rdv";
            // 
            // btnSuivant
            // 
            btnSuivant.BackColor = Color.Lime;
            btnSuivant.Location = new Point(96, 3);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Size = new Size(54, 23);
            btnSuivant.TabIndex = 1;
            btnSuivant.Text = ">";
            btnSuivant.UseVisualStyleBackColor = false;
            btnSuivant.Click += btnSuivant_Click;
            // 
            // btnPrecedent
            // 
            btnPrecedent.BackColor = Color.Lime;
            btnPrecedent.Location = new Point(31, 3);
            btnPrecedent.Name = "btnPrecedent";
            btnPrecedent.Size = new Size(39, 23);
            btnPrecedent.TabIndex = 0;
            btnPrecedent.Text = "<";
            btnPrecedent.UseVisualStyleBackColor = false;
            btnPrecedent.Click += btnPrecedent_Click;
            // 
            // FrmVisiteBilan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmVisiteBilan";
            Text = "FrmVisiteBilan";
            Load += FrmVisiteBilan_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelDroit.ResumeLayout(false);
            panelDroit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ((System.ComponentModel.ISupportInitialize)cptQuantite).EndInit();
            panelGauche.ResumeLayout(false);
            panelGauche.PerformLayout();
            panelHaut.ResumeLayout(false);
            panelHaut.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private Panel panelHaut;
        private Panel panelDroit;
        private Label label1;
        private Panel panelGauche;
        private Label label3;
        private Label label2;
        private ComboBox cbxSecondMedicament;
        private ComboBox cbxPremierMedicament;
        private Button btnAjouter;
        private Label label5;
        private NumericUpDown cptQuantite;
        private Label label4;
        private ComboBox cbxEchantillon;
        private Label label6;
        private DataGridView dgvEchantillon;
        private TextBox txtBilan;
        private Label label7;
        private Button btnEnregistrer;
        private Button btnSuivant;
        private Button btnPrecedent;
        private Label lblDate;
        private Label lblNom;
        private Label msgSecondMedicament;
        private Label msgPremierMedicament;
        private Label msgBilan;
        private Label lblMessage;
        private Label label9;
        private Label label8;
    }
}