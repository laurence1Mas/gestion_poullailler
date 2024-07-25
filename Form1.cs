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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserCategories());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserPoules());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserFournisseur());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserAlimentConsommation());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserTraitement());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Height = button8.Height;
            panel4.Top = button8.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserLivraison());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserMortalite());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Height = button9.Height;
            panel4.Top = button9.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserCommande());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Height = button7.Height;
            panel4.Top = button7.Top;
            container.Controls.Clear();
            container.Controls.Add(new UserControls.UserAgents());
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEdit1.Text== "alimentation")
            {

                container.Controls.Clear();
                container.Controls.Add(new UserControls.UserTraitement());
            }
            else if (comboBoxEdit1.Text == "categorie")
            {
                container.Controls.Clear();
                container.Controls.Add(new UserControls.UserTraitement());
            }
        }
    }
}
