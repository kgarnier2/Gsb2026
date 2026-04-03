using Interface.Properties;
using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Donnee;

namespace Interface
{
    public partial class FrmConsultationVisites : FrmBase
    {
        public FrmConsultationVisites(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region procédures événementielles

        private void FrmConsultationVisites_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            parametrerDgv(dgvVisites);
            parametrerDgvEchantillons();
            remplirDgvVisites();

            // S'assurer que l'événement SelectionChanged est connecté (si le designer ne l'a pas fait)
            dgvVisites.SelectionChanged -= dgvVisites_SelectionChanged;
            dgvVisites.SelectionChanged += dgvVisites_SelectionChanged;

            // Sélectionner la première ligne pour afficher les détails au chargement (si disponible)
            if (dgvVisites.Rows.Count > 0)
                dgvVisites.Rows[0].Selected = true;

            centrerFormulaire();
        }

        private void FrmConsultationVisites_Resize(object sender, EventArgs e)
        {
            centrerFormulaire();
        }

        private void dgvVisites_SelectionChanged(object sender, EventArgs e)
        {
            afficher();
        }

        #endregion

        #region procédures

        private void parametrerComposant()
        {
            lblTitre.Text = "Consultation des visites";
            ViderAffichage();

        }

        private void parametrerDgvEchantillons()
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
            dgvEchantillon.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEchantillon.RowTemplate.Height = 30;
            dgvEchantillon.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEchantillon.RowsDefaultCellStyle.BackColor = Color.White;
            dgvEchantillon.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgvEchantillon.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            DataGridViewColumn col;

            // Colonne 0 : Médicament (largeur 200)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Medicament";
            col.HeaderText = "Médicament";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEchantillon.Columns.Add(col);

            // Colonne 1 : Quantité (largeur 100)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Quantite";
            col.HeaderText = "Quantité";
            col.Width = 100;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEchantillon.Columns.Add(col);

            dgvEchantillon.Width = getLargeur(dgvEchantillon);

            for (int i = 0; i < dgvEchantillon.ColumnCount; i++)
                dgvEchantillon.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void parametrerDgv(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            dgv.Enabled = true;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.BackgroundColor = Color.White;
            dgv.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Georgia", 11);
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgv.ColumnHeadersVisible = true;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.SelectionBackColor = Color.WhiteSmoke;
            style.SelectionForeColor = Color.Black;
            style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            style.Font = new Font("Georgia", 12, FontStyle.Bold);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.ColumnHeadersHeight = 40;

            dgv.RowHeadersVisible = false;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowTemplate.Height = 30;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.Black;

            DataGridViewColumn col;

            // Colonne 0 : cachée, contient l'objet Visite (largeur 0)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Visite";
            col.HeaderText = "";
            col.Width = 0;
            col.Visible = false;
            dgv.Columns.Add(col);

            // Colonne 1 : Date (largeur 200)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Date";
            col.HeaderText = "Programmée le";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            // Colonne 2 : Heure (largeur 50)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Heure";
            col.HeaderText = "à";
            col.Width = 50;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns.Add(col);

            // Colonne 3 : Lieu (largeur 200)
            col = new DataGridViewTextBoxColumn();
            col.Name = "Lieu";
            col.HeaderText = "sur";
            col.Width = 200;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns.Add(col);

            dgv.Width = getLargeur(dgv);

            for (int i = 0; i < dgv.ColumnCount; i++)
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private int getLargeur(DataGridView dgv)
        {
            int largeur = 0;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                    largeur += col.Width;
            }
            if (dgv.RowHeadersVisible)
                largeur += dgv.RowHeadersWidth;
            return largeur + 2;
        }

        private void centrerFormulaire()
        {
            panelCentral.Left = (this.ClientSize.Width - panelCentral.Width) / 2;
        }

        private void remplirDgvVisites()
        {
            dgvVisites.Rows.Clear();

            foreach (Visite v in session.MesVisites.OrderBy(v => v.DateEtHeure))
            {
                int rowIndex = dgvVisites.Rows.Add(
                    v,                                      // col 0 : objet Visite (cachée)
                    v.DateEtHeure.ToLongDateString(),       // col 1 : date
                    v.DateEtHeure.ToShortTimeString(),      // col 2 : heure
                    v.LePraticien.Ville                     // col 3 : ville
                );

                // Visites passées (avec bilan) affichées en vert
                if (v.Bilan is not null)
                {
                    dgvVisites.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void afficher()
        {
            Visite? v = getVisite();
            if (v is null)
            {
                ViderAffichage();
                return;
            }

            // Données du praticien
            lblPraticien.Text = v.LePraticien.NomPrenom;
            lblRue.Text = v.LePraticien.Rue;
            lblTelephone.Text = v.LePraticien.Telephone;
            lblEmail.Text = v.LePraticien.Email;
            lblType.Text = v.LePraticien.Type?.Libelle ?? "";
            lblSpecialite.Text = v.LePraticien.Specialite?.Libelle ?? "";

            // Motif et bilan
            lblMotif.Text = v.LeMotif.Libelle;
            lblBilan.Text = v.Bilan ?? "Aucun bilan renseigné";

            // Médicaments présentés (max 2)
            lstMedicament.Items.Clear();
            if (v.PremierMedicament is not null)
                lstMedicament.Items.Add(v.PremierMedicament.Nom);
            if (v.SecondMedicament is not null)
                lstMedicament.Items.Add(v.SecondMedicament.Nom);

            // Échantillons — itération directe sur la visite (IEnumerable<KeyValuePair<Medicament, int>>)
            dgvEchantillon.Rows.Clear();
            foreach (KeyValuePair<Medicament, int> ech in v)
            {
                dgvEchantillon.Rows.Add(
                    ech.Key.Nom,    // nom du médicament
                    ech.Value       // quantité
                );
            }
        }


        private void ViderAffichage()
        {
            lblPraticien.Text = "";
            lblRue.Text = "";
            lblTelephone.Text = "";
            lblEmail.Text = "";
            lblType.Text = "";
            lblSpecialite.Text = "";
            lblMotif.Text = "";
            lblBilan.Text = "";
            lstMedicament.Items.Clear();
            dgvEchantillon.Rows.Clear();
        }

        private Visite? getVisite()
        {
            if (dgvVisites.SelectedRows.Count == 0)
                return null;

            return dgvVisites.SelectedRows[0].Cells["Visite"].Value as Visite;
        }

        #endregion

        private void dgvEchantillon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}