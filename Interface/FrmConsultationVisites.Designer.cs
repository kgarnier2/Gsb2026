namespace Interface
{
    partial class FrmConsultationVisites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultationVisites));
            panelCentral = new Panel();
            label1 = new Label();
            dgvVisites = new DataGridView();
            label2 = new Label();
            panelPraticien = new Panel();
            lblPraticien = new Label();
            lblRue = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblType = new Label();
            lblSpecialite = new Label();
            labelMotifTitre = new Label();
            lblMotif = new Label();
            labelBilanTitre = new Label();
            lblBilan = new Label();
            label3 = new Label();
            lstMedicament = new ListBox();
            label4 = new Label();
            dgvEchantillon = new DataGridView();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            panelPraticien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(1000, 74);
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(label1);
            panelCentral.Controls.Add(dgvVisites);
            panelCentral.Controls.Add(label2);
            panelCentral.Controls.Add(panelPraticien);
            panelCentral.Controls.Add(labelMotifTitre);
            panelCentral.Controls.Add(lblMotif);
            panelCentral.Controls.Add(labelBilanTitre);
            panelCentral.Controls.Add(lblBilan);
            panelCentral.Controls.Add(label3);
            panelCentral.Controls.Add(lstMedicament);
            panelCentral.Controls.Add(label4);
            panelCentral.Controls.Add(dgvEchantillon);
            panelCentral.Location = new Point(0, 98);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(980, 500);
            panelCentral.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 0;
            label1.Text = "Sélectionner la visite pour afficher le détail";
            // 
            // dgvVisites
            // 
            dgvVisites.Location = new Point(10, 25);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(452, 460);
            dgvVisites.TabIndex = 0;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label2.Location = new Point(480, 5);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Praticien";
            // 
            // panelPraticien
            // 
            panelPraticien.Controls.Add(lblPraticien);
            panelPraticien.Controls.Add(lblRue);
            panelPraticien.Controls.Add(lblTelephone);
            panelPraticien.Controls.Add(lblEmail);
            panelPraticien.Controls.Add(lblType);
            panelPraticien.Controls.Add(lblSpecialite);
            panelPraticien.Location = new Point(480, 25);
            panelPraticien.Name = "panelPraticien";
            panelPraticien.Size = new Size(490, 88);
            panelPraticien.TabIndex = 2;
            // 
            // lblPraticien
            // 
            lblPraticien.Location = new Point(0, 5);
            lblPraticien.Name = "lblPraticien";
            lblPraticien.Size = new Size(144, 23);
            lblPraticien.TabIndex = 0;
            lblPraticien.Text = "nom praticien";
            // 
            // lblRue
            // 
            lblRue.Location = new Point(0, 28);
            lblRue.Name = "lblRue";
            lblRue.Size = new Size(144, 37);
            lblRue.TabIndex = 1;
            lblRue.Text = "rue";
            // 
            // lblTelephone
            // 
            lblTelephone.Location = new Point(150, 5);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(166, 23);
            lblTelephone.TabIndex = 2;
            lblTelephone.Text = "tel";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(150, 28);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(175, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "email";
            // 
            // lblType
            // 
            lblType.Location = new Point(322, 5);
            lblType.Name = "lblType";
            lblType.Size = new Size(145, 23);
            lblType.TabIndex = 4;
            lblType.Text = "type";
            // 
            // lblSpecialite
            // 
            lblSpecialite.Location = new Point(322, 28);
            lblSpecialite.Name = "lblSpecialite";
            lblSpecialite.Size = new Size(168, 37);
            lblSpecialite.TabIndex = 5;
            lblSpecialite.Text = "specialite";
            // 
            // labelMotifTitre
            // 
            labelMotifTitre.AutoSize = true;
            labelMotifTitre.Font = new Font("Georgia", 10F, FontStyle.Bold);
            labelMotifTitre.Location = new Point(480, 128);
            labelMotifTitre.Name = "labelMotifTitre";
            labelMotifTitre.Size = new Size(48, 17);
            labelMotifTitre.TabIndex = 3;
            labelMotifTitre.Text = "Motif";
            // 
            // lblMotif
            // 
            lblMotif.Location = new Point(480, 145);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(490, 23);
            lblMotif.TabIndex = 4;
            lblMotif.Text = "motif";
            // 
            // labelBilanTitre
            // 
            labelBilanTitre.AutoSize = true;
            labelBilanTitre.Font = new Font("Georgia", 10F, FontStyle.Bold);
            labelBilanTitre.Location = new Point(480, 178);
            labelBilanTitre.Name = "labelBilanTitre";
            labelBilanTitre.Size = new Size(46, 17);
            labelBilanTitre.TabIndex = 5;
            labelBilanTitre.Text = "Bilan";
            // 
            // lblBilan
            // 
            lblBilan.Location = new Point(480, 205);
            lblBilan.Name = "lblBilan";
            lblBilan.Size = new Size(490, 40);
            lblBilan.TabIndex = 6;
            lblBilan.Text = "bilan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label3.Location = new Point(480, 245);
            label3.Name = "label3";
            label3.Size = new Size(180, 17);
            label3.TabIndex = 7;
            label3.Text = "Médicaments présentés";
            // 
            // lstMedicament
            // 
            lstMedicament.FormattingEnabled = true;
            lstMedicament.Location = new Point(480, 265);
            lstMedicament.Name = "lstMedicament";
            lstMedicament.Size = new Size(180, 49);
            lstMedicament.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 10F, FontStyle.Bold);
            label4.Location = new Point(480, 330);
            label4.Name = "label4";
            label4.Size = new Size(159, 17);
            label4.TabIndex = 8;
            label4.Text = "Échantillons fournis";
            // 
            // dgvEchantillon
            // 
            dgvEchantillon.Location = new Point(480, 350);
            dgvEchantillon.Name = "dgvEchantillon";
            dgvEchantillon.Size = new Size(302, 130);
            dgvEchantillon.TabIndex = 8;
            // 
            // FrmConsultationVisites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 620);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmConsultationVisites";
            Text = "Consultation des visites";
            Load += FrmConsultationVisites_Load;
            Resize += FrmConsultationVisites_Resize;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            panelPraticien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCentral;
        private DataGridView dgvVisites;
        private Label label1;
        private Label label2;
        private Label labelMotifTitre;
        private Label labelBilanTitre;
        private Panel panelPraticien;
        private Label lblSpecialite;
        private Label lblType;
        private Label lblEmail;
        private Label lblTelephone;
        private Label lblRue;
        private Label lblPraticien;
        private Label lblBilan;
        private Label lblMotif;
        private Label label3;
        private ListBox lstMedicament;
        private Label label4;
        private DataGridView dgvEchantillon;
    }
}
