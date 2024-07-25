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
    public partial class UserAlimentConsommation : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clsaliment clsa = new Classes.clsaliment();
        Classes.clsconsommation clsc = new Classes.clsconsommation();
        Classes.MYCONNECTION M = new Classes.MYCONNECTION();
        public UserAlimentConsommation()
        {
            InitializeComponent();
            loadlistaliemnt();
            loadlistconsommation();
        }
        private void bindingclassaliment()
        {
            clsa.Codealiment = txtcodealiement.Text;
            clsa.Categoriealiment = Convert.ToString(cmbcategoriealiment.SelectedValue);
            clsa.Designation = txtdesignation.Text;
            clsa.Fournisseur = Convert.ToString(cmbfournisseurs.SelectedValue);
            clsa.Quantite = Convert.ToInt32(txtquantite.Text);
            clsa.Unite = txtunite.Text;
            clsa.Prixu = Convert.ToDecimal(txtprixU.Text);
        }
        private void refresh1()
        {
            txtcodealiement.Text = "";
            cmbcategoriealiment.Text = "";
            txtdesignation.Text = "";
            cmbfournisseurs.Text = "";
            txtquantite.Text = "";
            txtunite.Text = "";
            txtprixU.Text = "";
        }
        private void refresh2()
        {
            txtcodeconsomation.Text = "";
            cmbaliment.Text = "";
            cmbpoule.Text = "";
            txtquantitec.Text = "";
            txtunitec.Text = "";
        }
        private void bindingclassconsommation()
        {
            clsc.Codeconsommation = txtcodeconsomation.Text;
            clsc.Poule = Convert.ToString(cmbpoule.SelectedValue);
            clsc.Aliment = Convert.ToString(cmbaliment.SelectedValue);
            clsc.Quantite = Convert.ToInt32(txtquantitec.Text);
            clsc.Unite = txtunitec.Text;
        }
        private void loadlistaliemnt()
        {
            dataaliment.DataSource = clsad.gestlistaliemnt();
            clsad.chargercombobox(cmbcategoriealiment);
            clsad.chargercomboboxfournisseur(cmbfournisseurs);
        }
        private void loadlistconsommation()
        {
            dataconsommation.DataSource = clsad.gestlistconsommation();
            clsad.chargercomboboxaliment(cmbaliment);
            clsad.chargercomboboxpoule(cmbpoule);
        }
        private void UserAlimentConsommation_Load(object sender, EventArgs e)
        {
            loadlistaliemnt();
            loadlistconsommation();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            bindingclassaliment();
            int value = clsad.addaliment(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            bindingclassaliment();
            int value = clsad.editaliment(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bindingclassaliment();
            int value = clsad.deletealiment(clsa);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "aliment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistaliemnt();
                refresh1();
            }
        }

        private void btnsavec_Click(object sender, EventArgs e)
        {
            bindingclassconsommation();
            int value = clsad.addconsommation(clsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
        }

        private void btneditc_Click(object sender, EventArgs e)
        {
            bindingclassconsommation();
            int value = clsad.editconsommation(clsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
        }

        private void btndeletec_Click(object sender, EventArgs e)
        {
            bindingclassconsommation();
            int value = clsad.deleteconsommation(clsc);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "consommation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlistconsommation();
                refresh2();
            }
        }

        private void dataaliment_DoubleClick(object sender, EventArgs e)
        {
            if(dataaliment.RowCount > 0)
            {
                txtcodealiement.Text = dataaliment["dgid", dataaliment.CurrentRow.Index].Value.ToString();
                cmbcategoriealiment.Text = dataaliment["dgcategorie", dataaliment.CurrentRow.Index].Value.ToString();
                txtdesignation.Text = dataaliment["dgdesignation", dataaliment.CurrentRow.Index].Value.ToString();
                cmbfournisseurs.Text = dataaliment["dgfournisseur", dataaliment.CurrentRow.Index].Value.ToString();
                txtquantite.Text = dataaliment["dgquantite", dataaliment.CurrentRow.Index].Value.ToString();
                txtunite.Text = dataaliment["dgunite", dataaliment.CurrentRow.Index].Value.ToString();
                txtprixU.Text = dataaliment["dgprixu", dataaliment.CurrentRow.Index].Value.ToString();


            }
        }

        private void dataconsommation_DoubleClick(object sender, EventArgs e)
        {
            if (dataconsommation.RowCount > 0)
            {
                txtcodeconsomation.Text = dataconsommation["dgidc", dataconsommation.CurrentRow.Index].Value.ToString();
                cmbpoule.Text = dataconsommation["dgpoule", dataconsommation.CurrentRow.Index].Value.ToString();
                cmbaliment.Text = dataconsommation["dgaliment", dataconsommation.CurrentRow.Index].Value.ToString();
                txtquantitec.Text = dataconsommation["dgquantitec", dataconsommation.CurrentRow.Index].Value.ToString();
                txtunitec.Text = dataconsommation["dgunitec", dataconsommation.CurrentRow.Index].Value.ToString();
                datecons.Text = dataconsommation["dgdate", dataconsommation.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprintc_Click(object sender, EventArgs e)
        {
            Reports.listeConsommation rpt = new Reports.listeConsommation();
            rpt.DataSource = M.get_Report_CONS();
            using (ReportPrintTool printool = new ReportPrintTool(rpt))
            {
                printool.ShowPreviewDialog();
            }
        }
    }
}
