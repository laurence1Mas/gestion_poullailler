using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace gestion_poullailler.UserControls
{
    public partial class UserPoules : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clscategoriepoule clscatepoule = new Classes.clscategoriepoule();
        Classes.clspoule clspo = new Classes.clspoule();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserPoules()
        {
            InitializeComponent();
        }

        private void bindingclass()
        {
            clspo.Codepole = txtcodepoule.Text;
            clspo.Categoriepoule = txtcodecategorie.Text;
            clspo.Designation = txtdesignation.Text;
            clspo.Quantite =Convert.ToInt32( txtquantite.Text);
            clspo.Poids = Convert.ToDecimal(txtpoids.Text);
            clspo.Unite = txtunite.Text;
            clspo.Prixu = Convert.ToDecimal(txtprixu.Text);
        }
        private void refresh()
        {
            txtcodepoule.Text = "";
            txtcodecategorie.Text = "";
            txtdesignation.Text = "";
            txtquantite.Text = "";
            txtpoids.Text = "";
            txtunite.Text = "";
            txtprixu.Text = "";
            txtcategorie.Text = "";
        }
        private void loadlist()
        {
            datacategorie.DataSource = clsad.gestlistcatepoule();
            datapoule.DataSource = clsad.gestlistpoule();
        }

        private void UserPoules_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void datacategorie_DoubleClick(object sender, EventArgs e)
        {
            if (datacategorie.RowCount > 0)
            {
                txtcodecategorie.Text = datacategorie["dgidcategorie", datacategorie.CurrentRow.Index].Value.ToString();
                txtcategorie.Text = datacategorie["dgdesignationcategorie", datacategorie.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addpoule(clspo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editpoule(clspo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletepoule(clspo);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "poule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void datapoule_DoubleClick(object sender, EventArgs e)
        {
            if (datapoule.RowCount > 0)
            {
                txtcodepoule.Text = datapoule["dgid", datapoule.CurrentRow.Index].Value.ToString();
                txtcategorie.Text = datapoule["dgcategorie", datapoule.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = datapoule["dgdesignation", datapoule.CurrentRow.Index].Value.ToString();
                txtquantite.Text = datapoule["dgquantite", datapoule.CurrentRow.Index].Value.ToString();
                txtpoids.Text = datapoule["dgpoids", datapoule.CurrentRow.Index].Value.ToString();
                txtunite.Text = datapoule["dgunite", datapoule.CurrentRow.Index].Value.ToString();
                txtprixu.Text = datapoule["dgprixu", datapoule.CurrentRow.Index].Value.ToString();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports.listePoule rpt = new Reports.listePoule();
            rpt.DataSource = M.get_Report_POULE();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
