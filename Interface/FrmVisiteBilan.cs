using Donnee;
using Metier;
using System.Data;

namespace Interface
{
    public partial class FrmVisiteBilan : FrmBase
    {
        // ── attributs ─────────────────────────────────────────────
        private List<Visite> lesVisitesNonCompletees = new();
        private int indexVisiteCourante = 0;

        public FrmVisiteBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region procédures événementielles

        private void FrmVisiteBilan_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            chargerLesVisites();
            centrerFormulaire();
        }

        private void FrmVisiteBilan_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            changerVisite(-1);
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            changerVisite(1);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ajouterEchantillon();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            enregistrer();
        }

        private void dgvEchantillon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Visite visite = lesVisitesNonCompletees[indexVisiteCourante];
            Medicament med = (Medicament)dgvEchantillon.Rows[e.RowIndex].Cells["Medicament"].Value;

            // bouton + : augmenter la quantité
            if (e.ColumnIndex == 3)
            {
                int qte = visite.getQuantite(med);
                if (qte < 10)
                {
                    visite.supprimerEchantillon(med);
                    visite.ajouterEchantillon(med, qte + 1);
                    remplirDgvEchantillon();
                }
                else
                {
                    MessageBox.Show("La quantité maximale est 10.", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // bouton - : diminuer la quantité
            else if (e.ColumnIndex == 4)
            {
                int qte = visite.getQuantite(med);
                if (qte > 1)
                {
                    visite.supprimerEchantillon(med);
                    visite.ajouterEchantillon(med, qte - 1);
                    remplirDgvEchantillon();
                }
                else
                {
                    MessageBox.Show("La quantité minimale est 1.", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            // bouton x : supprimer l'échantillon
            else if (e.ColumnIndex == 5)
            {
                visite.supprimerEchantillon(med);
                remplirDgvEchantillon();
            }
        }

        #endregion

        #region procédures

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
            panelCentral.Top = (this.ClientSize.Height - panelCentral.Height) / 2;
        }

        private void parametrerComposant()
        {
            lblTitre.Text = "Enregistrement du bilan d'une visite";

            // ComboBox premier médicament
            cbxPremierMedicament.DataSource = new List<Medicament>(session.LesMedicaments);
            cbxPremierMedicament.DisplayMember = "Nom";
            cbxPremierMedicament.ValueMember = "Id";
            cbxPremierMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPremierMedicament.SelectedIndex = -1;

            // ComboBox second médicament
            cbxSecondMedicament.DataSource = new List<Medicament>(session.LesMedicaments);
            cbxSecondMedicament.DisplayMember = "Nom";
            cbxSecondMedicament.ValueMember = "Id";
            cbxSecondMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSecondMedicament.SelectedIndex = -1;

            // ComboBox échantillon
            cbxEchantillon.DataSource = new List<Medicament>(session.LesMedicaments);
            cbxEchantillon.DisplayMember = "Nom";
            cbxEchantillon.ValueMember = "Id";
            cbxEchantillon.DropDownStyle = ComboBoxStyle.DropDownList;

            // NumericUpDown quantité
            cptQuantite.Minimum = 1;
            cptQuantite.Maximum = 10;
            cptQuantite.Value = 1;

            // Messages d'erreur en rouge
            msgPremierMedicament.ForeColor = Color.Red;
            msgSecondMedicament.ForeColor = Color.Red;
            msgBilan.ForeColor = Color.Red;
            msgPremierMedicament.Text = "";
            msgSecondMedicament.Text = "";
            msgBilan.Text = "";

            parametrerDgvEchantillon();
        }

        private void parametrerDgvEchantillon()
        {
            dgvEchantillon.Columns.Clear();
            dgvEchantillon.Rows.Clear();

            dgvEchantillon.Enabled = true;
            dgvEchantillon.BorderStyle = BorderStyle.FixedSingle;
            dgvEchantillon.BackgroundColor = Color.White;
            dgvEchantillon.ForeColor = Color.Black;
            dgvEchantillon.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgvEchantillon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEchantillon.MultiSelect = false;
            dgvEchantillon.AllowUserToDeleteRows = false;
            dgvEchantillon.AllowUserToAddRows = false;
            dgvEchantillon.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEchantillon.AllowUserToResizeColumns = false;
            dgvEchantillon.AllowUserToResizeRows = false;
            dgvEchantillon.AllowUserToOrderColumns = false;
            dgvEchantillon.AllowDrop = false;
            dgvEchantillon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvEchantillon.ColumnHeadersVisible = true;
            dgvEchantillon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEchantillon.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgvEchantillon.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgvEchantillon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvEchantillon.ColumnHeadersHeight = 40;

            dgvEchantillon.RowHeadersVisible = false;
            dgvEchantillon.RowTemplate.Height = 30;
            dgvEchantillon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEchantillon.RowsDefaultCellStyle.BackColor = Color.White;
            dgvEchantillon.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvEchantillon.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            DataGridViewColumn col;

            // Colonne 0 : cachée, contient l'objet Medicament
            col = new DataGridViewTextBoxColumn();
            col.Name = "Medicament";
            col.HeaderText = "";
            col.Width = 0;
            col.Visible = false;
            dgvEchantillon.Columns.Add(col);

            // Colonne 1 : Nom du médicament
            col = new DataGridViewTextBoxColumn();
            col.Name = "Nom";
            col.HeaderText = "Médicament";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEchantillon.Columns.Add(col);

            // Colonne 2 : Quantité
            col = new DataGridViewTextBoxColumn();
            col.Name = "Quantite";
            col.HeaderText = "Quantité";
            col.Width = 80;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEchantillon.Columns.Add(col);

            // Colonne 3 : bouton +
            DataGridViewImageColumn colImg;
            colImg = new DataGridViewImageColumn();
            colImg.Name = "BtnPlus";
            colImg.HeaderText = "+";
            colImg.Width = 30;
            colImg.Image = SystemIcons.Information.ToBitmap(); // remplacer par icône +
            colImg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEchantillon.Columns.Add(colImg);

            // Colonne 4 : bouton -
            colImg = new DataGridViewImageColumn();
            colImg.Name = "BtnMoins";
            colImg.HeaderText = "-";
            colImg.Width = 30;
            colImg.Image = SystemIcons.Information.ToBitmap(); // remplacer par icône -
            colImg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEchantillon.Columns.Add(colImg);

            // Colonne 5 : bouton x (supprimer)
            colImg = new DataGridViewImageColumn();
            colImg.Name = "BtnSupprimer";
            colImg.HeaderText = "x";
            colImg.Width = 30;
            colImg.Image = SystemIcons.Error.ToBitmap(); // remplacer par icône x
            colImg.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEchantillon.Columns.Add(colImg);

            for (int i = 0; i < dgvEchantillon.ColumnCount; i++)
                dgvEchantillon.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void chargerLesVisites()
        {
            lesVisitesNonCompletees = session.MesVisites
                .FindAll(x => x.DateEtHeure <= DateTime.Now && x.Bilan == null);

            if (lesVisitesNonCompletees.Count == 0)
            {
                lblMessage.Text = "Toutes vos fiches sont complétées";
                panelCentral.Visible = false;
                return;
            }

            panelCentral.Visible = true;
            indexVisiteCourante = 0;
            afficherVisite();
            mettreAJourNavigation();
        }

        private void changerVisite(int deplacement)
        {
            int count = lesVisitesNonCompletees.Count;
            if (count == 0) return;

            // rotation circulaire
            indexVisiteCourante = (indexVisiteCourante + deplacement + count) % count;
            afficherVisite();
            mettreAJourNavigation();
        }

        private void afficherVisite()
        {
            Visite visite = lesVisitesNonCompletees[indexVisiteCourante];

            // infos de la visite dans panelHaut
            lblDate.Text = $" {visite.DateEtHeure:dddd dd MMMM yyyy à HH:mm}";
            lblNom.Text = $"  {visite.LePraticien.NomPrenom}";

            // vider les champs
            txtBilan.Text = "";
            cbxPremierMedicament.SelectedIndex = -1;
            cbxSecondMedicament.SelectedIndex = -1;
            msgPremierMedicament.Text = "";
            msgSecondMedicament.Text = "";
            txtBilan.Text = "";

            // remplir le dgv échantillons
            remplirDgvEchantillon();
        }

        private void remplirDgvEchantillon()
        {
            dgvEchantillon.Rows.Clear();
            Visite visite = lesVisitesNonCompletees[indexVisiteCourante];

            foreach (KeyValuePair<Medicament, int> ech in visite)
            {
                int rowIndex = dgvEchantillon.Rows.Add(
                    ech.Key,        // col 0 : objet Medicament caché
                    ech.Key.Nom,    // col 1 : nom
                    ech.Value       // col 2 : quantité
                );
                // Les colonnes image sont déjà définies dans le parametrage
            }
        }

        private void mettreAJourNavigation()
        {
            int count = lesVisitesNonCompletees.Count;
            btnSuivant.Enabled = count > 1;
            btnPrecedent.Enabled = count > 1;
            lblMessage.Visible = count > 0;

            if (count > 0)
                lblMessage.Text = $"{indexVisiteCourante + 1} / {count}";
            else
                lblMessage.Text = "Toutes vos fiches sont complétées";
        }

        private void ajouterEchantillon()
        {
            if (cbxEchantillon.SelectedIndex < 0) return;

            Medicament med = (Medicament)cbxEchantillon.SelectedItem!;
            int qte = (int)cptQuantite.Value;
            Visite visite = lesVisitesNonCompletees[indexVisiteCourante];

            visite.ajouterEchantillon(med, qte);
            remplirDgvEchantillon();
        }

        private bool controlerPremierMedicament()
        {
            if (cbxPremierMedicament.SelectedIndex < 0)
            {
                msgPremierMedicament.Text = "Le premier médicament est obligatoire.";
                return false;
            }
            msgPremierMedicament.Text = "";
            return true;
        }

        private bool controlerSecondMedicament()
        {
            if (cbxSecondMedicament.SelectedIndex < 0)
            {
                msgSecondMedicament.Text = "";
                return true; // facultatif
            }

            Medicament premier = (Medicament)cbxPremierMedicament.SelectedItem!;
            Medicament second = (Medicament)cbxSecondMedicament.SelectedItem!;

            if (premier != null && second.Id == premier.Id)
            {
                msgSecondMedicament.Text = "Le second médicament doit être différent du premier.";
                return false;
            }

            msgSecondMedicament.Text = "";
            return true;
        }

        private bool controlerBilan()
        {
            if (string.IsNullOrWhiteSpace(txtBilan.Text))
            {
                msgBilan.Text = "Le bilan est obligatoire.";
                return false;
            }
            msgBilan.Text = "";
            return true;
        }

        private void enregistrer()
        {
            bool premierMedicamentOk = controlerPremierMedicament();
            bool secondMedicamentOk = controlerSecondMedicament();
            bool bilanOk = controlerBilan();

            if (premierMedicamentOk && secondMedicamentOk && bilanOk)
            {
                Medicament premierMedicament = (Medicament)cbxPremierMedicament.SelectedItem!;
                Medicament? secondMedicament = cbxSecondMedicament.SelectedIndex >= 0
                    ? (Medicament)cbxSecondMedicament.SelectedItem!
                    : null;

                Visite visite = lesVisitesNonCompletees[indexVisiteCourante];

                try
                {
                    // mise à jour de l'objet Visite en mémoire
                    visite.enregistrerBilan(txtBilan.Text, premierMedicament, secondMedicament);

                    // enregistrement en base de données
                    Passerelle.enregistrerBilan(visite);

                    MessageBox.Show("Votre fiche visite est maintenant archivée", "Bilan enregistré",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // retirer la visite de la liste
                    lesVisitesNonCompletees.RemoveAt(indexVisiteCourante);

                    if (lesVisitesNonCompletees.Count > 0)
                    {
                        changerVisite(0);
                    }
                    else
                    {
                        lblMessage.Text = "Toutes vos fiches sont complétées";
                        panelCentral.Visible = false;
                        mettreAJourNavigation();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue : " + ex.Message, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}