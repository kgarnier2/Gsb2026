namespace Interface
{
    partial class FrmVisiteAjout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteAjout));
            panelDroit = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            cbxPraticien = new ComboBox();
            btnAjouter = new Button();
            cbxMotif = new ComboBox();
            dtpDate = new DateTimePicker();
            panelGauche = new Panel();
            dgvVisites = new DataGridView();
            label2 = new Label();
            panelDroit.SuspendLayout();
            panel2.SuspendLayout();
            panelGauche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 74);
            // 
            // panelDroit
            // 
            panelDroit.Controls.Add(panel2);
            panelDroit.Dock = DockStyle.Right;
            panelDroit.Location = new Point(454, 98);
            panelDroit.Name = "panelDroit";
            panelDroit.Padding = new Padding(10);
            panelDroit.Size = new Size(346, 307);
            panelDroit.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(cbxPraticien);
            panel2.Controls.Add(btnAjouter);
            panel2.Controls.Add(cbxMotif);
            panel2.Controls.Add(dtpDate);
            panel2.Location = new Point(19, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 284);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 183);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 7;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 141);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Motif";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 97);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "Praticien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 38);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "Nouveau rendez-vous";
            // 
            // cbxPraticien
            // 
            cbxPraticien.FormattingEnabled = true;
            cbxPraticien.Location = new Point(67, 97);
            cbxPraticien.Name = "cbxPraticien";
            cbxPraticien.Size = new Size(220, 23);
            cbxPraticien.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Crimson;
            btnAjouter.Location = new Point(120, 226);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(104, 34);
            btnAjouter.TabIndex = 3;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cbxMotif
            // 
            cbxMotif.FormattingEnabled = true;
            cbxMotif.Location = new Point(67, 141);
            cbxMotif.Name = "cbxMotif";
            cbxMotif.Size = new Size(220, 23);
            cbxMotif.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(67, 183);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(220, 23);
            dtpDate.TabIndex = 2;
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Controls.Add(label2);
            panelGauche.Dock = DockStyle.Fill;
            panelGauche.Location = new Point(0, 98);
            panelGauche.Name = "panelGauche";
            panelGauche.Padding = new Padding(10);
            panelGauche.Size = new Size(454, 307);
            panelGauche.TabIndex = 14;
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(10, 25);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(434, 272);
            dgvVisites.TabIndex = 1;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(434, 15);
            label2.TabIndex = 0;
            label2.Text = "Liste des rendez-vous déjà programmés";
            // 
            // FrmVisiteAjout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGauche);
            Controls.Add(panelDroit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmVisiteAjout";
            Text = "FrmVisiteAjout";
            Load += FrmVisiteAjout_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroit, 0);
            Controls.SetChildIndex(panelGauche, 0);
            panelDroit.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGauche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDroit;
        private Panel panelGauche;
        private Label label2;
        private DateTimePicker dtpDate;
        private ComboBox cbxMotif;
        private ComboBox cbxPraticien;
        private Panel panel2;
        private Button btnAjouter;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dgvVisites;
    }
}