namespace Interface
{
    partial class FrmVisiteImpression
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteImpression));
            printRendezVous = new System.Drawing.Printing.PrintDocument();
            choixImprimante = new PrintDialog();
            apercuRendezVous = new PrintPreviewDialog();
            panelCentral = new Panel();
            message = new Label();
            imgGsb = new PictureBox();
            panelSaisie = new Panel();
            messageIntervale = new Label();
            dtpFin = new DateTimePicker();
            dtpDebut = new DateTimePicker();
            label02 = new Label();
            label01 = new Label();
            imgImprimer = new PictureBox();
            imgApercu = new PictureBox();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgGsb).BeginInit();
            panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).BeginInit();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Size = new Size(800, 71);
            // 
            // printRendezVous
            // 
            printRendezVous.PrintPage += printRendezVous_PrintPage;
            // 
            // choixImprimante
            // 
            choixImprimante.UseEXDialog = true;
            // 
            // apercuRendezVous
            // 
            apercuRendezVous.AutoScrollMargin = new Size(0, 0);
            apercuRendezVous.AutoScrollMinSize = new Size(0, 0);
            apercuRendezVous.ClientSize = new Size(400, 300);
            apercuRendezVous.Enabled = true;
            apercuRendezVous.Icon = (Icon)resources.GetObject("apercuRendezVous.Icon");
            apercuRendezVous.Name = "apercuRendezVous";
            apercuRendezVous.Visible = false;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(message);
            panelCentral.Controls.Add(imgGsb);
            panelCentral.Controls.Add(panelSaisie);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 95);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(800, 310);
            panelCentral.TabIndex = 13;
            // 
            // message
            // 
            message.AutoSize = true;
            message.ForeColor = Color.Red;
            message.Location = new Point(25, 11);
            message.Name = "message";
            message.Size = new Size(30, 15);
            message.TabIndex = 2;
            message.Text = "msg";
            // 
            // imgGsb
            // 
            imgGsb.Image = Properties.Resources.logoGSB;
            imgGsb.Location = new Point(25, 39);
            imgGsb.Name = "imgGsb";
            imgGsb.Size = new Size(249, 253);
            imgGsb.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGsb.TabIndex = 1;
            imgGsb.TabStop = false;
            // 
            // panelSaisie
            // 
            panelSaisie.Controls.Add(messageIntervale);
            panelSaisie.Controls.Add(dtpFin);
            panelSaisie.Controls.Add(dtpDebut);
            panelSaisie.Controls.Add(label02);
            panelSaisie.Controls.Add(label01);
            panelSaisie.Controls.Add(imgImprimer);
            panelSaisie.Controls.Add(imgApercu);
            panelSaisie.Location = new Point(361, 21);
            panelSaisie.Name = "panelSaisie";
            panelSaisie.Size = new Size(427, 279);
            panelSaisie.TabIndex = 0;
            // 
            // messageIntervale
            // 
            messageIntervale.AutoSize = true;
            messageIntervale.ForeColor = Color.Red;
            messageIntervale.Location = new Point(25, 119);
            messageIntervale.Name = "messageIntervale";
            messageIntervale.Size = new Size(30, 15);
            messageIntervale.TabIndex = 6;
            messageIntervale.Text = "msg";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(107, 69);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 5;
            // 
            // dtpDebut
            // 
            dtpDebut.Location = new Point(107, 18);
            dtpDebut.Name = "dtpDebut";
            dtpDebut.Size = new Size(200, 23);
            dtpDebut.TabIndex = 4;
            // 
            // label02
            // 
            label02.AutoSize = true;
            label02.Location = new Point(25, 75);
            label02.Name = "label02";
            label02.Size = new Size(22, 15);
            label02.TabIndex = 3;
            label02.Text = "Au";
            // 
            // label01
            // 
            label01.AutoSize = true;
            label01.Location = new Point(25, 24);
            label01.Name = "label01";
            label01.Size = new Size(22, 15);
            label01.TabIndex = 2;
            label01.Text = "Du";
            // 
            // imgImprimer
            // 
            imgImprimer.Image = Properties.Resources.imprimer;
            imgImprimer.Location = new Point(244, 160);
            imgImprimer.Name = "imgImprimer";
            imgImprimer.Size = new Size(100, 93);
            imgImprimer.SizeMode = PictureBoxSizeMode.StretchImage;
            imgImprimer.TabIndex = 1;
            imgImprimer.TabStop = false;
            imgImprimer.Click += imgImprimer_Click;
            // 
            // imgApercu
            // 
            imgApercu.Image = Properties.Resources.apercu;
            imgApercu.Location = new Point(69, 160);
            imgApercu.Margin = new Padding(2);
            imgApercu.Name = "imgApercu";
            imgApercu.Size = new Size(74, 103);
            imgApercu.SizeMode = PictureBoxSizeMode.StretchImage;
            imgApercu.TabIndex = 0;
            imgApercu.TabStop = false;
            imgApercu.Click += imgApercu_Click;
            // 
            // FrmVisiteImpression
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCentral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmVisiteImpression";
            Text = "FrmVisiteImpression";
            Load += FrmVisiteImpression_Load;
            Controls.SetChildIndex(lblTitre, 0);
            Controls.SetChildIndex(panelCentral, 0);
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgGsb).EndInit();
            panelSaisie.ResumeLayout(false);
            panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgImprimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgApercu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printRendezVous;
        private PrintDialog choixImprimante;
        private PrintPreviewDialog apercuRendezVous;
        private Panel panelCentral;
        private Panel panelSaisie;
        private PictureBox imgGsb;
        private Label label02;
        private Label label01;
        private PictureBox imgImprimer;
        private PictureBox imgApercu;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpDebut;
        private Label messageIntervale;
        private Label message;
    }
}