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
    public partial class UserClient : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clsclient clscl = new Classes.clsclient();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserClient()
        {
            InitializeComponent();
            loardlistclient();
        }
        private void bindingclasscli()
        {
            clscl.Codeclient = txtcodeclients.Text;
            clscl.Nom = txtnom.Text;
            clscl.Postnom = txtpostnom.Text;
            clscl.Prenom = txtprenom.Text;
            clscl.Genre = Convert.ToString(cmbgenre.SelectedItem);
            clscl.Adresse = txtadresse.Text;
            clscl.Telephone = txttelephone.Text;
            clscl.Mail = txtmail.Text;
        }
        private void refreshcli()
        {
            txtcodeclients.Text = "";
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtprenom.Text = "";
            cmbgenre.Text = "";
            txtadresse.Text = "";
            txttelephone.Text = "";
            txtmail.Text = "";
        }
        private void loardlistclient()
        {
            dataclient.DataSource = clsad.gestlistclient();
        }
        private void UserClient_Load(object sender, EventArgs e)
        {
            loardlistclient();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclasscli();
            int value = clsad.addclient(clscl);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclasscli();
            int value = clsad.editclient(clscl);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclasscli();
            int value = clsad.deleteclient(clscl);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loardlistclient();
                refreshcli();
            }
        }

        private void dataclient_DoubleClick(object sender, EventArgs e)
        {
            if (dataclient.RowCount > 0)
            {
                txtcodeclients.Text = dataclient["dgidc", dataclient.CurrentRow.Index].Value.ToString();
                txtnom.Text = dataclient["dgnom", dataclient.CurrentRow.Index].Value.ToString();
                txtpostnom.Text = dataclient["dgpostnom", dataclient.CurrentRow.Index].Value.ToString();
                txtprenom.Text = dataclient["dgprenom", dataclient.CurrentRow.Index].Value.ToString();
                cmbgenre.Text = dataclient["dggenrec", dataclient.CurrentRow.Index].Value.ToString();
                txttelephone.Text = dataclient["dgtelephonec", dataclient.CurrentRow.Index].Value.ToString();
                txtadresse.Text = dataclient["dgadressec", dataclient.CurrentRow.Index].Value.ToString();
                txtmail.Text = dataclient["dgmailc", dataclient.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports.listClient rpt = new Reports.listClient();
            rpt.DataSource = M.get_Report_CLIENT();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
