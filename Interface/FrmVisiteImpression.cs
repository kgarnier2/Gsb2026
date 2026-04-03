using Donnee;
using Metier;
using System.Drawing.Printing;

namespace Interface
{
    public partial class FrmVisiteImpression : FrmBase
    {
        // ── attributs ─────────────────────────────────────────────
        private List<Visite> lesVisites = new();
        private List<Visite> lesVisitesFiltrees = new();

        public FrmVisiteImpression(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region procédures événementielles

        private void FrmVisiteImpression_Load(object sender, EventArgs e)
        {
            parametrerComposant();

            // Visites à venir (date >= aujourd'hui)
            lesVisites = session.MesVisites
                .FindAll(v => v.DateEtHeure >= DateTime.Now);

            if (lesVisites.Count == 0)
            {
                message.Text = "Aucun rendez-vous planifié pour le moment.";
                panelSaisie.Visible = false;
            }

            centrerFormulaire();
        }

        private void FrmVisiteImpression_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {
            messageIntervale.Text = "";
            dtpFin.MinDate = dtpDebut.Value.AddDays(7);
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            messageIntervale.Text = "";
        }

        private void imgApercu_Click(object sender, EventArgs e)
        {
            if (!verifierIntervalle()) return;

            printRendezVous.PrintController = new PreviewPrintController();
            printRendezVous.DocumentName = "Rendez-vous";
            apercuRendezVous.Document = printRendezVous;
            apercuRendezVous.ShowDialog();

            // Remettre le controller standard après l'aperçu
            printRendezVous.PrintController = new StandardPrintController();
        }

        private void imgImprimer_Click(object sender, EventArgs e)
        {
            if (!verifierIntervalle()) return;

            printRendezVous.PrintController = new StandardPrintController();
            printRendezVous.DocumentName = "Rendez-vous";
            choixImprimante.Document = printRendezVous;
            DialogResult result = choixImprimante.ShowDialog();
            if (result == DialogResult.OK)
            {
                printRendezVous.Print();
            }
        }

        private void printRendezVous_PrintPage(object sender, PrintPageEventArgs e)
        {
            // ── Paramètres de mise en page ────────────────────────
            int margeGauche = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            int largeurDisponible = e.MarginBounds.Width;

            // Polices et styles
            Font police = new Font("Segoe UI", 9);
            Font policeTitre = new Font("Segoe UI", 14, FontStyle.Bold);
            Font policeEntete = new Font("Segoe UI", 9, FontStyle.Bold);

            SolidBrush brush = new SolidBrush(Color.Black);
            SolidBrush brushEntete = new SolidBrush(Color.White);
            SolidBrush fondEntete = new SolidBrush(Color.DimGray);
            Pen penGris = new Pen(Color.LightGray, 1);

            // ── Définition des colonnes (Total = 650 à 700 pour A4) ──
            var colonnes = new[]
            {
        new { Titre = "Date",      Largeur = 100, Align = StringAlignment.Near },
        new { Titre = "Heure",     Largeur = 50,  Align = StringAlignment.Center },
        new { Titre = "Praticien", Largeur = 120, Align = StringAlignment.Near },
        new { Titre = "Téléphone", Largeur = 90,  Align = StringAlignment.Near },
        new { Titre = "Lieu",      Largeur = 160, Align = StringAlignment.Near }, // Rue + Ville
        new { Titre = "Motif",     Largeur = 130, Align = StringAlignment.Near }
    };

            int largeurTotale = colonnes.Sum(c => c.Largeur);

            // ── 1. Dessin du Titre ────────────────────────────────
            string titre = "MES RENDEZ-VOUS";
            string periode = $"Période du {dtpDebut.Value:dd/MM/yyyy} au {dtpFin.Value:dd/MM/yyyy}";

            e.Graphics.DrawString(titre, policeTitre, brush, margeGauche, y);
            y += 30;
            e.Graphics.DrawString(periode, police, brush, margeGauche, y);
            y += 40;

            // ── 2. Dessin de l'Entête (Fond gris) ─────────────────
            int xEntete = margeGauche;
            e.Graphics.FillRectangle(fondEntete, xEntete, y, largeurTotale, 25);

            foreach (var col in colonnes)
            {
                RectangleF rect = new RectangleF(xEntete, y, col.Largeur, 25);
                StringFormat sf = new StringFormat
                {
                    Alignment = col.Align,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(col.Titre, policeEntete, brushEntete, rect, sf);
                xEntete += col.Largeur;
            }
            y += 25;

            // ── 3. Dessin des Données (Boucle avec hauteur dynamique) ──
            foreach (Visite v in lesVisitesFiltrees)
            {
                // On prépare les chaînes de caractères
                string txtDate = v.DateEtHeure.ToString("dd/MM/yyyy");
                string txtHeure = v.DateEtHeure.ToString("HH:mm");
                string txtNom = v.LePraticien.NomPrenom;
                string txtTel = v.LePraticien.Telephone;
                string txtLieu = $"{v.LePraticien.Rue}, {v.LePraticien.Ville}";
                string txtMotif = v.LeMotif.Libelle;

                string[] tabTextes = { txtDate, txtHeure, txtNom, txtTel, txtLieu, txtMotif };

                // CALCUL DE LA HAUTEUR : On cherche la cellule qui demande le plus de hauteur
                float hauteurLigneRequise = 25; // Hauteur minimum
                for (int i = 0; i < tabTextes.Length; i++)
                {
                    // MeasureString avec contrainte de largeur pour simuler le Wrap
                    SizeF tailleMesuree = e.Graphics.MeasureString(tabTextes[i], police, colonnes[i].Largeur);
                    if (tailleMesuree.Height > hauteurLigneRequise)
                    {
                        hauteurLigneRequise = tailleMesuree.Height;
                    }
                }

                // Ajout d'une petite marge de confort (padding)
                hauteurLigneRequise += 8;

                // VERIFICATION SAUT DE PAGE
                if (y + hauteurLigneRequise > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return; // Arrête cette page et Windows appellera la fonction pour la suivante
                }

                // DESSIN DES CELLULES
                int xCourant = margeGauche;
                for (int i = 0; i < tabTextes.Length; i++)
                {
                    RectangleF rectCellule = new RectangleF(xCourant, y, colonnes[i].Largeur, hauteurLigneRequise);

                    StringFormat sf = new StringFormat
                    {
                        Alignment = colonnes[i].Align,
                        LineAlignment = StringAlignment.Near, // Aligné en haut pour les textes longs
                        Trimming = StringTrimming.Word // Coupe proprement aux espaces
                    };

                    // Dessin du texte
                    e.Graphics.DrawString(tabTextes[i], police, brush, rectCellule, sf);

                    xCourant += colonnes[i].Largeur;
                }

                // Ligne de séparation sous chaque rendez-vous
                y += (int)hauteurLigneRequise;
                e.Graphics.DrawLine(penGris, margeGauche, y, margeGauche + largeurTotale, y);
            }

            // ── 4. Nettoyage des ressources ───────────────────────
            police.Dispose();
            policeTitre.Dispose();
            policeEntete.Dispose();
            brush.Dispose();
            brushEntete.Dispose();
            fondEntete.Dispose();
            penGris.Dispose();
        }

        #endregion

        #region procédures

        private void parametrerComposant()
        {
            lblTitre.Text = "Impression des rendez-vous sur une période";

            // dtpDebut : aujourd'hui à aujourd'hui + 53 jours
            dtpDebut.MinDate = DateTime.Today;
            dtpDebut.MaxDate = DateTime.Today.AddDays(53);
            dtpDebut.Value = DateTime.Today;
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dddd d MMMM yyyy";

            // dtpFin : aujourd'hui + 7 à aujourd'hui + 60 jours
            dtpFin.MinDate = DateTime.Today.AddDays(7);
            dtpFin.MaxDate = DateTime.Today.AddDays(60);
            dtpFin.Value = DateTime.Today.AddDays(7);
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dddd d MMMM yyyy";

            message.Text = "";
            messageIntervale.Text = "";
        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private bool verifierIntervalle()
        {
            lesVisitesFiltrees = lesVisites
                .Where(v => v.DateEtHeure.Date >= dtpDebut.Value.Date
                         && v.DateEtHeure.Date <= dtpFin.Value.Date)
                .OrderBy(v => v.DateEtHeure)
                .ToList();

            if (lesVisitesFiltrees.Count == 0)
            {
                messageIntervale.Text = "Aucun rendez-vous planifié sur cette période.";
                messageIntervale.ForeColor = Color.Red;
                return false;
            }

            messageIntervale.Text = "";
            return true;
        }

        #endregion
    }
}