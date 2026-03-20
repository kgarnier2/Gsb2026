using Metier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Interface.Properties;
using Donnee;

namespace Interface
{
    public partial class FrmVisiteBilan : FrmBase
    {
        public FrmVisiteBilan(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region procédures événementielles
        private void FrmVisiteBilan_Load(object sender, EventArgs e)
        {
            lblTitre.Text = "Enregistrer un bilan";

        }

        #endregion
    }
}
