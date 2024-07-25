using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_poullailler
{
    public partial class frmprincipal : Form
    {
        ToolTip tool = new ToolTip();
        public frmprincipal()
        {
            InitializeComponent();
            //tool.SetToolTip(toolPoule, "poule");
        }

        private void btnmortalite_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserMortalite());
        }

        private void btnagent_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserAgents());
        }

        private void btntraitement_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserTraitement());
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserClient());
        }

        private void pouleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserPoules());
        }

        private void btnfournisseur_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserFournisseur());
        }
    }
}
