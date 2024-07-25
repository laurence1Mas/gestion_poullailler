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
    public partial class UserAgents : UserControl
    {
        Classes.clsDataaccess.dataAccess clsad = new Classes.clsDataaccess.dataAccess();
        Classes.clsagent clsAg = new Classes.clsagent();
        public UserAgents()
        {
            InitializeComponent();

        }
        private void bindingclass()
        {
            clsAg.Codeagent = txtcodeagent.Text;
            clsAg.Noms = txtnomsf.Text;
            clsAg.Genre = Convert.ToString(cmbgenref.SelectedItem);
            clsAg.Adresse = txtadressef.Text;
            clsAg.Telephone = txttelephonef.Text;
            clsAg.Mail = txtmail.Text;
        }
        private void refresh()
        {
            txtcodeagent.Text = "";
            txtnomsf.Text = "";
            cmbgenref.Text = "";
            txtadressef.Text = "";
            txttelephonef.Text = "";
            txtmail.Text = "";
        }
        private void loadlist()
        {
            dataagent.DataSource = clsad.gestlistagent();
        }
        private void UserAgents_Load(object sender, EventArgs e)
        {
            loadlist();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.addagent(clsAg);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.editagent(clsAg);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                //refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingclass();
            int value = clsad.deleteagent(clsAg);
            if (value >= 1)
            {
                MessageBox.Show("Operation effectuée avec succès", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
            else
            {
                MessageBox.Show("erreur dans l'operation", "Agent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlist();
                refresh();
            }
        }

        private void dataagent_DoubleClick(object sender, EventArgs e)
        {
            if(dataagent.RowCount > 0)
            {
                txtcodeagent.Text = dataagent["dgid", dataagent.CurrentRow.Index].Value.ToString();
                txtnomsf.Text = dataagent["dgnoms", dataagent.CurrentRow.Index].Value.ToString();
                cmbgenref.Text = dataagent["dggenre", dataagent.CurrentRow.Index].Value.ToString();
                txttelephonef.Text = dataagent["dgtelephone", dataagent.CurrentRow.Index].Value.ToString();
                txtadressef.Text = dataagent["dgadresse", dataagent.CurrentRow.Index].Value.ToString();
                txtmail.Text = dataagent["dgmail", dataagent.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }
    }
}
