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
            comboBox3 = new ComboBox();
            label1 = new Label();
            panelGauche = new Panel();
            button1 = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panelHaut = new Panel();
            panelCentral.SuspendLayout();
            panelDroit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEchantillon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cptQuantite).BeginInit();
            panelGauche.SuspendLayout();
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
            panelDroit.Controls.Add(comboBox3);
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
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(157, 23);
            comboBox3.TabIndex = 1;
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
            panelGauche.Controls.Add(button1);
            panelGauche.Controls.Add(label7);
            panelGauche.Controls.Add(textBox1);
            panelGauche.Controls.Add(label3);
            panelGauche.Controls.Add(label2);
            panelGauche.Controls.Add(comboBox2);
            panelGauche.Controls.Add(comboBox1);
            panelGauche.Location = new Point(15, 81);
            panelGauche.Name = "panelGauche";
            panelGauche.Size = new Size(350, 216);
            panelGauche.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(150, 190);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 6;
            button1.Text = "Enregistrer la fiche visite";
            button1.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.Location = new Point(17, 97);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(306, 87);
            textBox1.TabIndex = 4;
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
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(181, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(181, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 0;
            // 
            // panelHaut
            // 
            panelHaut.Location = new Point(18, 14);
            panelHaut.Name = "panelHaut";
            panelHaut.Size = new Size(728, 61);
            panelHaut.TabIndex = 0;
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnAjouter;
        private Label label5;
        private NumericUpDown cptQuantite;
        private Label label4;
        private ComboBox comboBox3;
        private Label label6;
        private DataGridView dgvEchantillon;
        private TextBox textBox1;
        private Label label7;
        private Button button1;
    }
}