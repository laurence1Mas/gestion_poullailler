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
    public partial class UserFournisseur : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clsfournisseur clsfr = new Classes.clsfournisseur();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserFournisseur()
        {
            InitializeComponent();
            loardlistfour();
        }
        private void bindingclass()
        {
            clsfr.Codefournisseur = txtcodefournisseur.Text;
            clsfr.Noms = txtnomsf.Text;
            clsfr.Genre = Convert.ToString(cnbgenref.SelectedItem);
            clsfr.Adresse = txtadressef.Text;
            clsfr.Telephone = txttelephonef.Text;
            clsfr.Mail = txtmailf.Text;
        }

        private void refresh()
        {
            txtcodefournisseur.Text = "";
            txtnomsf.Text = "";
            cnbgenref.Text = "";
            txtadressef.Text = "";
            txttelephonef.Text = "";
            txtmailf.Text = "";
        }

        private void loardlistfour()
        {
            datafournisseur.DataSource = clsad.gestlistfournisseur();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UserFourniClient_Load(object sender, EventArgs e)
        {
            loardlistfour();
        }

        private void btnsavef_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addfournisseur(clsfr);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
        }

        private void btneditf_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editfournisseur(clsfr);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
        }

        private void btndeletef_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletefournisseur(clsfr);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "fournisseur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistfour();
                refresh();
            }
        }

        private void datafournisseur_DoubleClick(object sender, EventArgs e)
        {
            if (datafournisseur.RowCount > 0)
            {
                txtcodefournisseur.Text = datafournisseur["dgidf", datafournisseur.CurrentRow.Index].Value.ToString();
                txtnomsf.Text = datafournisseur["dgnoms", datafournisseur.CurrentRow.Index].Value.ToString();
                cnbgenref.Text = datafournisseur["dggenre", datafournisseur.CurrentRow.Index].Value.ToString();
                txttelephonef.Text = datafournisseur["dgtelephonef", datafournisseur.CurrentRow.Index].Value.ToString();
                txtadressef.Text = datafournisseur["dgadressef", datafournisseur.CurrentRow.Index].Value.ToString();
                txtmailf.Text = datafournisseur["dgmailf", datafournisseur.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprintf_Click(object sender, EventArgs e)
        {
            Reports.listeFournisseur rpt = new Reports.listeFournisseur();
            rpt.DataSource = M.get_Report_FOUR();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
