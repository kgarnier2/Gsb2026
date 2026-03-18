using Donnee;
using Metier;
using System.Data;
using Donnee;
using Metier;

namespace Interface
{
    public partial class FrmVisiteModification : FrmBase
    {
        public FrmVisiteModification(Session uneSession) : base(uneSession)
        {
            InitializeComponent();
        }

        #region procédures événementielles
        private void FrmVisiteModification_Load(object sender, EventArgs e)
        {

            remplirDgv();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}