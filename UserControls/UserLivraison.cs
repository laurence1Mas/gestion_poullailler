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
    public partial class UserLivraison : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clslivraison clsLi = new Classes.clslivraison();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserLivraison()
        {
            InitializeComponent();
            loadlist();
        }
        private void loadlist()
        {
            datalivraison.DataSource = clsad.gestlistlivraison();
            clsad.chargercomboboxagent(cmbagent);
            clsad.chargercomboboxCommande(cmbcommande);
        }
        private void bindingclass()
        {
            clsLi.Codelivraison = txtcode.Text;
            clsLi.Commande = Convert.ToString(cmbcommande.SelectedValue);
            clsLi.Agent = Convert.ToString(cmbagent.SelectedValue);
            clsLi.Quantite = Convert.ToInt32(txtquantite.Text);
            clsLi.Prixu = Convert.ToDecimal(txtprixu.Text);
            clsLi.Lieulivraison = txtlieu.Text;
        }

        private void refresh()
        {
            txtcode.Text = "";
            cmbagent.Text = "";
            cmbcommande.Text = "";
            txtquantite.Text = "";
            txtprixu.Text = "";
            txtlieu.Text = "";
        }
        private void UserLivraison_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addlivraison(clsLi);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editlivraison(clsLi);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deletelivraison(clsLi);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Reports.listelivraison rpt = new Reports.listelivraison();
            rpt.DataSource = M.get_Report_LIV();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }

        private void datalivraison_DoubleClick(object sender, EventArgs e)
        {
            if (datalivraison.RowCount > 0)
            {
                txtcode.Text = datalivraison["dgid", datalivraison.CurrentRow.Index].Value.ToString();
                cmbcommande.Text = datalivraison["dgcommande", datalivraison.CurrentRow.Index].Value.ToString();
                cmbagent.Text = datalivraison["dgagent", datalivraison.CurrentRow.Index].Value.ToString();
                txtquantite.Text = datalivraison["dgquantite", datalivraison.CurrentRow.Index].Value.ToString();
                txtprixu.Text = datalivraison["dgprix", datalivraison.CurrentRow.Index].Value.ToString();
                txtlieu.Text = datalivraison["dglieu", datalivraison.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
