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
    public partial class UserMortalite : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clsmortalite clsm = new Classes.clsmortalite();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserMortalite()
        {
            InitializeComponent();
            loadlist();
        }
        private void bindingclass()
        {
            clsm.Idmortalite = txtcodemortalite.Text;
            clsm.Poule = txtcodepoule.Text;
            clsm.Nombre_vivant =Convert.ToInt32 (txtnbrvivant.Text);
            clsm.Nombre_malade = Convert.ToInt32(txtnbrmalade.Text);
            clsm.Nombre_mort = Convert.ToInt32(txtnbrmort.Text);
        }
        private void loadlist()
        {
            datamortalite.DataSource = clsad.gestlistmortalite();
            datapoule.DataSource = clsad.gestlistpoule();
        }
        private void UserMortalite_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void datapoule_DoubleClick(object sender, EventArgs e)
        {
            if (datapoule.RowCount > 0)
            {
                txtcodepoule.Text = datapoule["dgidpoule", datapoule.CurrentRow.Index].Value.ToString();
                txtpoule.Text = datapoule["dgdesignation", datapoule.CurrentRow.Index].Value.ToString();
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addmortalite(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
        }

        private void datamortalite_DoubleClick(object sender, EventArgs e)
        {

            if (datamortalite.RowCount > 0)
            {
                txtcodemortalite.Text = datamortalite["dgid", datamortalite.CurrentRow.Index].Value.ToString();
                txtpoule.Text = datamortalite["dgpoule", datamortalite.CurrentRow.Index].Value.ToString();
                txtnbrvivant.Text = datamortalite["dgnbrV", datamortalite.CurrentRow.Index].Value.ToString();
                txtnbrmalade.Text = datamortalite["dgnbrM", datamortalite.CurrentRow.Index].Value.ToString();
                txtnbrmort.Text = datamortalite["dgnbrMo", datamortalite.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editmortalite(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletemortalite(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "mortalite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports.listemortalite rpt = new Reports.listemortalite();
            rpt.DataSource = M.get_Report_MORTa();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
