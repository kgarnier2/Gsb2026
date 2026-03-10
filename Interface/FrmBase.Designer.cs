namespace Interface
{
    partial class FrmBase
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
            lblTitre = new Label();
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            programmerRendezVous = new ToolStripMenuItem();
            modifierRendezVous = new ToolStripMenuItem();
            imprimerRendezvous = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            enregistrerBilan = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            consulterVisite = new ToolStripMenuItem();
            medicamentToolStripMenuItem = new ToolStripMenuItem();
            ficheMédicament = new ToolStripMenuItem();
            visiteurToolStripMenuItem = new ToolStripMenuItem();
            listePraticien = new ToolStripMenuItem();
            nouveauPraticien = new ToolStripMenuItem();
            modifierPraticien = new ToolStripMenuItem();
            panel1 = new Panel();
            lblVisiteur = new Label();
            labelGsb = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Dock = DockStyle.Top;
            lblTitre.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(0, 24);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(626, 74);
            lblTitre.TabIndex = 9;
            lblTitre.Text = "Titre";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            lblTitre.Click += lblTitre_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, medicamentToolStripMenuItem, visiteurToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(626, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programmerRendezVous, modifierRendezVous, imprimerRendezvous, toolStripSeparator1, enregistrerBilan, toolStripSeparator2, consulterVisite });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(47, 20);
            fichierToolStripMenuItem.Text = "Visite";
            // 
            // programmerRendezVous
            // 
            programmerRendezVous.DisplayStyle = ToolStripItemDisplayStyle.Text;
            programmerRendezVous.Name = "programmerRendezVous";
            programmerRendezVous.ShortcutKeys = Keys.Alt | Keys.R;
            programmerRendezVous.ShowShortcutKeys = false;
            programmerRendezVous.Size = new Size(258, 22);
            programmerRendezVous.Text = "Nouveau &Rendez-vous";
            programmerRendezVous.Click += programmerRendezVous_Click;
            // 
            // modifierRendezVous
            // 
            modifierRendezVous.AccessibleRole = AccessibleRole.TitleBar;
            modifierRendezVous.Name = "modifierRendezVous";
            modifierRendezVous.ShortcutKeys = Keys.Alt | Keys.D;
            modifierRendezVous.ShowShortcutKeys = false;
            modifierRendezVous.Size = new Size(258, 22);
            modifierRendezVous.Text = "&Déplacer ou annuler un rendez-vous";
            modifierRendezVous.Click += modifierRendezVous_Click;
            // 
            // imprimerRendezvous
            // 
            imprimerRendezvous.Name = "imprimerRendezvous";
            imprimerRendezvous.ShortcutKeys = Keys.Alt | Keys.I;
            imprimerRendezvous.ShowShortcutKeys = false;
            imprimerRendezvous.Size = new Size(258, 22);
            imprimerRendezvous.Text = "&Imprimer les rendez-vous";
            imprimerRendezvous.Click += imprimerRendezvous_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(255, 6);
            // 
            // enregistrerBilan
            // 
            enregistrerBilan.Name = "enregistrerBilan";
            enregistrerBilan.ShortcutKeys = Keys.Alt | Keys.B;
            enregistrerBilan.ShowShortcutKeys = false;
            enregistrerBilan.Size = new Size(258, 22);
            enregistrerBilan.Text = "&Enregistrer un bilan";
            enregistrerBilan.Click += enregistrerBilan_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(255, 6);
            // 
            // consulterVisite
            // 
            consulterVisite.Name = "consulterVisite";
            consulterVisite.ShortcutKeys = Keys.Alt | Keys.V;
            consulterVisite.ShowShortcutKeys = false;
            consulterVisite.Size = new Size(258, 22);
            consulterVisite.Text = "&Liste des Visites";
            consulterVisite.Click += consulterVisite_Click;
            // 
            // medicamentToolStripMenuItem
            // 
            medicamentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ficheMédicament });
            medicamentToolStripMenuItem.Name = "medicamentToolStripMenuItem";
            medicamentToolStripMenuItem.Size = new Size(86, 20);
            medicamentToolStripMenuItem.Text = "Médicament";
            // 
            // ficheMédicament
            // 
            ficheMédicament.Name = "ficheMédicament";
            ficheMédicament.ShortcutKeys = Keys.Alt | Keys.M;
            ficheMédicament.ShowShortcutKeys = false;
            ficheMédicament.Size = new Size(165, 22);
            ficheMédicament.Text = "&Fiche médicament";
            ficheMédicament.Click += ficheMédicamentToolStripMenuItem_Click;
            // 
            // visiteurToolStripMenuItem
            // 
            visiteurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listePraticien, nouveauPraticien, modifierPraticien });
            visiteurToolStripMenuItem.Name = "visiteurToolStripMenuItem";
            visiteurToolStripMenuItem.Size = new Size(65, 20);
            visiteurToolStripMenuItem.Text = "Praticien";
            // 
            // listePraticien
            // 
            listePraticien.Name = "listePraticien";
            listePraticien.ShortcutKeys = Keys.Alt | Keys.P;
            listePraticien.ShowShortcutKeys = false;
            listePraticien.Size = new Size(135, 22);
            listePraticien.Text = "&Liste";
            listePraticien.Click += listePraticien_Click;
            // 
            // nouveauPraticien
            // 
            nouveauPraticien.Name = "nouveauPraticien";
            nouveauPraticien.ShortcutKeys = Keys.Alt | Keys.A;
            nouveauPraticien.ShowShortcutKeys = false;
            nouveauPraticien.Size = new Size(135, 22);
            nouveauPraticien.Text = "&Ajouter";
            nouveauPraticien.Click += nouveauPraticien_Click;
            // 
            // modifierPraticien
            // 
            modifierPraticien.Name = "modifierPraticien";
            modifierPraticien.ShortcutKeys = Keys.Alt | Keys.U;
            modifierPraticien.ShowShortcutKeys = false;
            modifierPraticien.Size = new Size(135, 22);
            modifierPraticien.Text = "&Mettre à jour";
            modifierPraticien.Click += modifierPraticien_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblVisiteur);
            panel1.Controls.Add(labelGsb);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 313);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 45);
            panel1.TabIndex = 12;
            // 
            // lblVisiteur
            // 
            lblVisiteur.BackColor = Color.Transparent;
            lblVisiteur.Dock = DockStyle.Left;
            lblVisiteur.Font = new Font("Georgia", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisiteur.Location = new Point(368, 0);
            lblVisiteur.Name = "lblVisiteur";
            lblVisiteur.Size = new Size(256, 45);
            lblVisiteur.TabIndex = 12;
            lblVisiteur.Text = "Visiteur";
            lblVisiteur.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelGsb
            // 
            labelGsb.BackColor = Color.Transparent;
            labelGsb.Dock = DockStyle.Left;
            labelGsb.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGsb.Location = new Point(0, 0);
            labelGsb.Name = "labelGsb";
            labelGsb.Size = new Size(368, 45);
            labelGsb.TabIndex = 9;
            labelGsb.Text = "GSB - Galaxy Swiss Bourdin - Visiteur connecté :";
            labelGsb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(626, 358);
            Controls.Add(panel1);
            Controls.Add(lblTitre);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBase";
            SizeGripStyle = SizeGripStyle.Hide;
            WindowState = FormWindowState.Maximized;
            FormClosed += FrmBase_FormClosed;
            Load += FrmBase_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterVisite;
        private System.Windows.Forms.ToolStripMenuItem programmerRendezVous;
        protected System.Windows.Forms.ToolStripMenuItem modifierRendezVous;
        private System.Windows.Forms.ToolStripMenuItem enregistrerBilan;
        private System.Windows.Forms.ToolStripMenuItem imprimerRendezvous;
        private System.Windows.Forms.ToolStripMenuItem medicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheMédicament;
        private System.Windows.Forms.ToolStripMenuItem visiteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauPraticien;
        private System.Windows.Forms.ToolStripMenuItem modifierPraticien;
        private System.Windows.Forms.ToolStripMenuItem listePraticien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.Label labelGsb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}