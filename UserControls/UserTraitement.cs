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
    public partial class UserTraitement : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clstraitement clst = new Classes.clstraitement();
        Classes.clsmedicament clsm = new Classes.clsmedicament();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserTraitement()
        {
            InitializeComponent();
        }
        private void bindingclassmedi()
        {
            clsm.Codemedicament = txtcodemedicament.Text;
            clsm.Categoriemedicament = Convert.ToString(cmbcategorie.SelectedValue);
            clsm.Designation = txtdesignation.Text;
        }

        private void refreshm()
        {
            txtcodemedicament.Text = "";
            txtdesignation.Text = "";
            cmbcategorie.Text = "";
        }

        private void bindingclass()
        {
            clst.Codetraitement = txtcodetraitement.Text;
            clst.Poule = Convert.ToString(cmbpoule.SelectedValue);
            clst.Medicament = Convert.ToString(cmbmedicament.SelectedValue);
            clst.Dose = Convert.ToInt32(txtdose.Text);
            clst.Unite = Convert.ToString(cmbunite.SelectedValue);
        }
        private void refresh()
        {
            txtcodetraitement.Text = "";
            cmbpoule.Text = "";
            cmbmedicament.Text = "";
            txtdose.Text = "";
            cmbunite.Text = "";
        }
        private void loadlistmed()
        {
            datamedicament.DataSource = clsad.gestlistmedicament();
            clsad.chargercomboboxcatemed(cmbcategorie);
        }
        private void loadlisttraitement()
        {
            datatraitement.DataSource = clsad.gestlisttraitement();
            clsad.chargercomboboxpoule(cmbpoule);
            clsad.chargercomboboxcmedicament(cmbmedicament);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserTraitement_Load(object sender, EventArgs e)
        {
            loadlistmed();
            loadlisttraitement();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addtraitement(clst);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.edittraitement(clst);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletetraitement(clst);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlisttraitement();
                refresh();
            }
        }

        private void btnsaveM_Click(object sender, EventArgs e)
        {
            bindingclassmedi();
            int value = clsad.addmedicament(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
        }

        private void btneditM_Click(object sender, EventArgs e)
        {
            bindingclassmedi();
            int value = clsad.editmedicament(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
        }

        private void btndeleteM_Click(object sender, EventArgs e)
        {
            bindingclassmedi();
            int value = clsad.deletemedicament(clsm);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "medicament", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistmed();
                refreshm();
            }
        }

        private void datatraitement_DoubleClick(object sender, EventArgs e)
        {
            if (datatraitement.RowCount > 0)
            {
                txtcodetraitement.Text = datatraitement["dgid", datatraitement.CurrentRow.Index].Value.ToString();
                cmbpoule.Text = datatraitement["dgpoule", datatraitement.CurrentRow.Index].Value.ToString();
                cmbmedicament.Text = datatraitement["dgmedicament", datatraitement.CurrentRow.Index].Value.ToString();
                txtdose.Text = datatraitement["dgdose", datatraitement.CurrentRow.Index].Value.ToString();
                cmbunite.Text = datatraitement["dgunite", datatraitement.CurrentRow.Index].Value.ToString();
                date.Text = datatraitement["dgdate", datatraitement.CurrentRow.Index].Value.ToString();
            }
        }

        private void datamedicament_DoubleClick(object sender, EventArgs e)
        {
            if(datamedicament.RowCount > 0)
            {
                txtcodemedicament.Text = datamedicament["dgidm", datamedicament.CurrentRow.Index].Value.ToString();
                cmbcategorie.Text = datamedicament["dgcategorie", datamedicament.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = datamedicament["dgdesignation", datamedicament.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports.listetraitement rpt = new Reports.listetraitement();
            rpt.DataSource = M.get_Report_trait();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
