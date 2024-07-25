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
    public partial class UserCommande : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clscommande clscom = new Classes.clscommande();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserCommande()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            datacommande.DataSource = clsad.gestlistcommande();
            clsad.chargercomboboxpoule(cmbpoule);
            clsad.chargercomboboxclient(cmbclient);
        }
        private void bindingclass()
        {
            clscom.Codecommande = txtcode.Text;
            clscom.Poule = Convert.ToString(cmbpoule.SelectedValue);
            clscom.Client = Convert.ToString(cmbclient.SelectedValue);
            clscom.Quantite = Convert.ToInt32(txtquantite.Text);
            clscom.Prixu = Convert.ToDecimal(txtprixu.Text);
        }
        private void refresh()
        {
            txtcode.Text = "";
            txtquantite.Text = "";
            txtprixu.Text = "";
            cmbclient.Text = "";
            cmbpoule.Text = "";
        }
        private void UserCommande_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnsavec_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addcommande(clscom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btneditc_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editcommande(clscom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btndeletec_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletecommande(clscom);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnprintc_Click(object sender, EventArgs e)
        {
            Reports.listecommande rpt = new Reports.listecommande();
            rpt.DataSource = M.get_Report_COMM();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void datacommande_DoubleClick(object sender, EventArgs e)
        {
            if (datacommande.RowCount > 0)
            {
                txtcode.Text = datacommande["dgid", datacommande.CurrentRow.Index].Value.ToString();
                cmbclient.Text = datacommande["dgclient", datacommande.CurrentRow.Index].Value.ToString();
                cmbpoule.Text = datacommande["dgpoule", datacommande.CurrentRow.Index].Value.ToString();
                txtquantite.Text = datacommande["dgquantite", datacommande.CurrentRow.Index].Value.ToString();
                txtprixu.Text = datacommande["dgprix", datacommande.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprintfiche_Click(object sender, EventArgs e)
        {
            Reports.boncommande rpt = new Reports.boncommande();
            rpt.DataSource = M.get_Report_boncom("Vboncommande", "numcommande", txtcode.Text);
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
