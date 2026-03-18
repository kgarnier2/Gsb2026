namespace Interface
{
    partial class FrmVisiteModification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteModification));
            panelDroit = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            lblDate = new Label();
            label2 = new Label();
            lblNom = new Label();
            label1 = new Label();
            panelGauche = new Panel();
            dgvVisites = new DataGridView();
            label4 = new Label();
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
            panelDroit.Location = new Point(478, 98);
            panelDroit.Name = "panelDroit";
            panelDroit.Size = new Size(322, 307);
            panelDroit.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dtpDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblDate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblNom);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(6, 13);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(304, 287);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(115, 148);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 6;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(87, 80);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 86);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 4;
            label3.Text = "est remi au :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(142, 53);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(114, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Date et heure du rdv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 53);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "prévu initialement le :";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(142, 25);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(100, 15);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom du praticien";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Le rendez-vous chez :";
            // 
            // panelGauche
            // 
            panelGauche.Controls.Add(dgvVisites);
            panelGauche.Controls.Add(label4);
            panelGauche.Dock = DockStyle.Fill;
            panelGauche.Location = new Point(0, 98);
            panelGauche.Name = "panelGauche";
            panelGauche.Size = new Size(478, 307);
            panelGauche.TabIndex = 14;
            // 
            // dgvVisites
            // 
            dgvVisites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVisites.Dock = DockStyle.Fill;
            dgvVisites.Location = new Point(0, 15);
            dgvVisites.Name = "dgvVisites";
            dgvVisites.Size = new Size(478, 292);
            dgvVisites.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(322, 15);
            label4.TabIndex = 0;
            label4.Text = "Selectionner la visite afin de modifier la date du rendez vous";
            // 
            // FrmVisiteModification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGauche);
            Controls.Add(panelDroit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmVisiteModification";
            Text = "FrmVisiteModification";
            Load += FrmVisiteModification_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelDroit, 0);
            Controls.SetChildIndex(panelGauche, 0);
            panelDroit.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGauche.ResumeLayout(false);
            panelGauche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVisites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDroit;
        private Panel panelGauche;
        private Panel panel2;
        private Label label1;
        private Label lblNom;
        private DateTimePicker dtpDate;
        private Label label3;
        private Label lblDate;
        private Label label2;
        private Button button1;
        private DataGridView dgvVisites;
        private Label label4;
    }
}