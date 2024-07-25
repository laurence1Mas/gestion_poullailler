using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_poullailler.UserControls
{
    public partial class UserCategories : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clscategoriealiment clscatea = new Classes.clscategoriealiment();
        Classes.clscategoriemedicament clscatemed = new Classes.clscategoriemedicament();
        Classes.clscategoriepoule clscatepo = new Classes.clscategoriepoule();
        public UserCategories()
        {
            InitializeComponent();
            loardlistali();
            loardlistmed();
            loardlistpo();
        }
        private void bidingclasseA()
        {
            clscatea.Idcatealiment = txtcode2.Text;
            clscatea.Designation = txtdesignation2.Text;
        }
        private void refreshA()
        {
            txtcode2.Text = "";
            txtdesignation2.Text = "";
        }
        //==========================================================
        private void bidingclassem()
        {
           clscatemed.Idcategorie = txtcode1.Text;
            clscatemed.Designation = txtdesignation1.Text;
        }
        private void refreshm()
        {
            txtcode1.Text = "";
            txtdesignation1.Text = "";
        }
        //==========================================================
        private void bidingclassepo()
        {
            clscatepo.Idcatepoule = txtcode3.Text;
            clscatepo.Designation = txtdesignation3.Text;
        }
        private void refreshpo()
        {
            txtcode3.Text = "";
            txtdesignation3.Text = "";
        }
        private void loardlistmed()
        {
            datacatmedicament.DataSource = clsad.gestlistcatemed();
        }
        private void loardlistali()
        {
            datacataliment.DataSource = clsad.gestlistcatealiment();
        }
        private void loardlistpo()
        {
            datacatpoule.DataSource = clsad.gestlistcatepoule();
        }
        private void UserCategories_Load(object sender, EventArgs e)
        {
            loardlistali();
            loardlistmed();
            loardlistpo();
        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            bidingclassem();
            int value = clsad.addcategorimed(clscatemed);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
        }

        private void btnedit1_Click(object sender, EventArgs e)
        {
            bidingclassem();
            int value = clsad.editcategorimed(clscatemed);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            bidingclassem();
            int value = clsad.deletecategorimed(clscatemed);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistmed();
                refreshm();
            }
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            bidingclasseA();
            int value = clsad.addcategoriealiment(clscatea);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
        }

        private void btnedit2_Click(object sender, EventArgs e)
        {
            bidingclasseA();
            int value = clsad.editcategoriealiment(clscatea);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
        }

        private void btndelete2_Click(object sender, EventArgs e)
        {
            bidingclasseA();
            int value = clsad.deletecategoriealiment(clscatea);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistali();
                refreshA();
            }
        }

        private void btnsave3_Click(object sender, EventArgs e)
        {
            bidingclassepo();
            int value = clsad.addcategoriepoule(clscatepo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
        }

        private void btnedit3_Click(object sender, EventArgs e)
        {
            bidingclassepo();
            int value = clsad.editcategoriepoule(clscatepo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
        }

        private void btndelete3_Click(object sender, EventArgs e)
        {
            bidingclassepo();
            int value = clsad.deletecategoriepoule(clscatepo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "categorie poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistpo();
                refreshpo();
            }
        }

        private void datacatmedicament_DoubleClick(object sender, EventArgs e)
        {
            if(datacatmedicament.RowCount > 0) {
            txtcode1.Text = datacatmedicament["dgid1", datacatmedicament.CurrentRow.Index].Value.ToString();
                txtdesignation1.Text = datacatmedicament["dgdesignation1", datacatmedicament.CurrentRow.Index].Value.ToString();
            }
        }

        private void datacataliment_DoubleClick(object sender, EventArgs e)
        {
            if (datacataliment.RowCount > 0)
            {
                txtcode2.Text = datacataliment["dgid2", datacataliment.CurrentRow.Index].Value.ToString();
                txtdesignation2.Text = datacataliment["dgdesignation2", datacataliment.CurrentRow.Index].Value.ToString();
            }
        }

        private void datacatpoule_DoubleClick(object sender, EventArgs e)
        {
            if (datacatpoule.RowCount > 0)
            {
                txtcode3.Text = datacatpoule["dgid3", datacatpoule.CurrentRow.Index].Value.ToString();
                txtdesignation3.Text = datacatpoule["dgdesignation3", datacatpoule.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
