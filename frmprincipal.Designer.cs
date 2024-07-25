namespace gestion_poullailler
{
    partial class frmprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnfournisseur = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btnagent = new System.Windows.Forms.Button();
            this.btntraitement = new System.Windows.Forms.Button();
            this.btnmortalite = new System.Windows.Forms.Button();
            this.btnconsomation = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolPoule = new System.Windows.Forms.ToolStripDropDownButton();
            this.categoriePouleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pouleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAliment = new System.Windows.Forms.ToolStripDropDownButton();
            this.categorieAlimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMedicament = new System.Windows.Forms.ToolStripDropDownButton();
            this.categorieMedicamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCommande = new System.Windows.Forms.ToolStripDropDownButton();
            this.enteteCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toollivraison = new System.Windows.Forms.ToolStripDropDownButton();
            this.enteteLivraisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailLivraisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rapportJournalierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportJournalierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnmortalite);
            this.panel1.Controls.Add(this.btnconsomation);
            this.panel1.Controls.Add(this.btnagent);
            this.panel1.Controls.Add(this.btntraitement);
            this.panel1.Controls.Add(this.btnclient);
            this.panel1.Controls.Add(this.btnfournisseur);
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 658);
            this.panel1.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.White;
            this.container.Location = new System.Drawing.Point(207, 33);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1152, 643);
            this.container.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1369, 26);
            this.panel3.TabIndex = 2;
            // 
            // btnfournisseur
            // 
            this.btnfournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfournisseur.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnfournisseur.FlatAppearance.BorderSize = 0;
            this.btnfournisseur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnfournisseur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnfournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfournisseur.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfournisseur.ForeColor = System.Drawing.Color.White;
            this.btnfournisseur.Location = new System.Drawing.Point(0, 152);
            this.btnfournisseur.Name = "btnfournisseur";
            this.btnfournisseur.Size = new System.Drawing.Size(203, 43);
            this.btnfournisseur.TabIndex = 0;
            this.btnfournisseur.Text = "Fournisseur";
            this.btnfournisseur.UseVisualStyleBackColor = true;
            this.btnfournisseur.Click += new System.EventHandler(this.btnfournisseur_Click);
            // 
            // btnclient
            // 
            this.btnclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclient.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclient.ForeColor = System.Drawing.Color.White;
            this.btnclient.Location = new System.Drawing.Point(0, 218);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(203, 43);
            this.btnclient.TabIndex = 1;
            this.btnclient.Text = "Client";
            this.btnclient.UseVisualStyleBackColor = true;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnagent
            // 
            this.btnagent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagent.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnagent.FlatAppearance.BorderSize = 0;
            this.btnagent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnagent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnagent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagent.ForeColor = System.Drawing.Color.White;
            this.btnagent.Location = new System.Drawing.Point(0, 288);
            this.btnagent.Name = "btnagent";
            this.btnagent.Size = new System.Drawing.Size(203, 43);
            this.btnagent.TabIndex = 3;
            this.btnagent.Text = "Agent";
            this.btnagent.UseVisualStyleBackColor = true;
            this.btnagent.Click += new System.EventHandler(this.btnagent_Click);
            // 
            // btntraitement
            // 
            this.btntraitement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntraitement.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btntraitement.FlatAppearance.BorderSize = 0;
            this.btntraitement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btntraitement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btntraitement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntraitement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntraitement.ForeColor = System.Drawing.Color.White;
            this.btntraitement.Location = new System.Drawing.Point(0, 353);
            this.btntraitement.Name = "btntraitement";
            this.btntraitement.Size = new System.Drawing.Size(203, 43);
            this.btntraitement.TabIndex = 2;
            this.btntraitement.Text = "Traitement";
            this.btntraitement.UseVisualStyleBackColor = true;
            this.btntraitement.Click += new System.EventHandler(this.btntraitement_Click);
            // 
            // btnmortalite
            // 
            this.btnmortalite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmortalite.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnmortalite.FlatAppearance.BorderSize = 0;
            this.btnmortalite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnmortalite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnmortalite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmortalite.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmortalite.ForeColor = System.Drawing.Color.White;
            this.btnmortalite.Location = new System.Drawing.Point(0, 488);
            this.btnmortalite.Name = "btnmortalite";
            this.btnmortalite.Size = new System.Drawing.Size(203, 43);
            this.btnmortalite.TabIndex = 5;
            this.btnmortalite.Text = "Mortalite";
            this.btnmortalite.UseVisualStyleBackColor = true;
            this.btnmortalite.Click += new System.EventHandler(this.btnmortalite_Click);
            // 
            // btnconsomation
            // 
            this.btnconsomation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsomation.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnconsomation.FlatAppearance.BorderSize = 0;
            this.btnconsomation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnconsomation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnconsomation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsomation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsomation.ForeColor = System.Drawing.Color.White;
            this.btnconsomation.Location = new System.Drawing.Point(0, 420);
            this.btnconsomation.Name = "btnconsomation";
            this.btnconsomation.Size = new System.Drawing.Size(203, 43);
            this.btnconsomation.TabIndex = 4;
            this.btnconsomation.Text = "Consommantion";
            this.btnconsomation.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolPoule,
            this.toolStripSeparator2,
            this.toolAliment,
            this.toolStripSeparator3,
            this.toolMedicament,
            this.toolStripSeparator4,
            this.toolCommande,
            this.toolStripSeparator5,
            this.toollivraison});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1369, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolPoule
            // 
            this.toolPoule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolPoule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriePouleToolStripMenuItem,
            this.pouleToolStripMenuItem});
            this.toolPoule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolPoule.Image = ((System.Drawing.Image)(resources.GetObject("toolPoule.Image")));
            this.toolPoule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPoule.Name = "toolPoule";
            this.toolPoule.Size = new System.Drawing.Size(67, 25);
            this.toolPoule.Text = "poule";
            // 
            // categoriePouleToolStripMenuItem
            // 
            this.categoriePouleToolStripMenuItem.Name = "categoriePouleToolStripMenuItem";
            this.categoriePouleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.categoriePouleToolStripMenuItem.Text = "CategoriePoule";
            // 
            // pouleToolStripMenuItem
            // 
            this.pouleToolStripMenuItem.Name = "pouleToolStripMenuItem";
            this.pouleToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pouleToolStripMenuItem.Text = "Poule";
            this.pouleToolStripMenuItem.Click += new System.EventHandler(this.pouleToolStripMenuItem_Click);
            // 
            // toolAliment
            // 
            this.toolAliment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAliment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieAlimentToolStripMenuItem,
            this.alimentsToolStripMenuItem});
            this.toolAliment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAliment.Image = ((System.Drawing.Image)(resources.GetObject("toolAliment.Image")));
            this.toolAliment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAliment.Name = "toolAliment";
            this.toolAliment.Size = new System.Drawing.Size(125, 25);
            this.toolAliment.Text = "Alimentation";
            // 
            // categorieAlimentToolStripMenuItem
            // 
            this.categorieAlimentToolStripMenuItem.Name = "categorieAlimentToolStripMenuItem";
            this.categorieAlimentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.categorieAlimentToolStripMenuItem.Text = "CategorieAliment";
            // 
            // alimentsToolStripMenuItem
            // 
            this.alimentsToolStripMenuItem.Name = "alimentsToolStripMenuItem";
            this.alimentsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alimentsToolStripMenuItem.Text = "Aliments";
            // 
            // toolMedicament
            // 
            this.toolMedicament.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolMedicament.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieMedicamentToolStripMenuItem,
            this.medicamentsToolStripMenuItem});
            this.toolMedicament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolMedicament.Image = ((System.Drawing.Image)(resources.GetObject("toolMedicament.Image")));
            this.toolMedicament.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMedicament.Name = "toolMedicament";
            this.toolMedicament.Size = new System.Drawing.Size(125, 25);
            this.toolMedicament.Text = "Medicament";
            // 
            // categorieMedicamentToolStripMenuItem
            // 
            this.categorieMedicamentToolStripMenuItem.Name = "categorieMedicamentToolStripMenuItem";
            this.categorieMedicamentToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.categorieMedicamentToolStripMenuItem.Text = "CategorieMedicament";
            // 
            // medicamentsToolStripMenuItem
            // 
            this.medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            this.medicamentsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.medicamentsToolStripMenuItem.Text = "Medicaments";
            // 
            // toolCommande
            // 
            this.toolCommande.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCommande.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enteteCommandeToolStripMenuItem,
            this.detailCommandeToolStripMenuItem,
            this.rapportJournalierToolStripMenuItem});
            this.toolCommande.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolCommande.Image = ((System.Drawing.Image)(resources.GetObject("toolCommande.Image")));
            this.toolCommande.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCommande.Name = "toolCommande";
            this.toolCommande.Size = new System.Drawing.Size(118, 25);
            this.toolCommande.Text = "Commande";
            // 
            // enteteCommandeToolStripMenuItem
            // 
            this.enteteCommandeToolStripMenuItem.Name = "enteteCommandeToolStripMenuItem";
            this.enteteCommandeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.enteteCommandeToolStripMenuItem.Text = "En-tete Commande";
            // 
            // detailCommandeToolStripMenuItem
            // 
            this.detailCommandeToolStripMenuItem.Name = "detailCommandeToolStripMenuItem";
            this.detailCommandeToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.detailCommandeToolStripMenuItem.Text = "Detail Commande";
            // 
            // toollivraison
            // 
            this.toollivraison.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toollivraison.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enteteLivraisonToolStripMenuItem,
            this.detailLivraisonToolStripMenuItem,
            this.rapportJournalierToolStripMenuItem1});
            this.toollivraison.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toollivraison.Image = ((System.Drawing.Image)(resources.GetObject("toollivraison.Image")));
            this.toollivraison.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toollivraison.Name = "toollivraison";
            this.toollivraison.Size = new System.Drawing.Size(88, 25);
            this.toollivraison.Text = "Livraison";
            // 
            // enteteLivraisonToolStripMenuItem
            // 
            this.enteteLivraisonToolStripMenuItem.Name = "enteteLivraisonToolStripMenuItem";
            this.enteteLivraisonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.enteteLivraisonToolStripMenuItem.Text = "En-tete Livraison";
            // 
            // detailLivraisonToolStripMenuItem
            // 
            this.detailLivraisonToolStripMenuItem.Name = "detailLivraisonToolStripMenuItem";
            this.detailLivraisonToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.detailLivraisonToolStripMenuItem.Text = "Detail Livraison";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // rapportJournalierToolStripMenuItem
            // 
            this.rapportJournalierToolStripMenuItem.Name = "rapportJournalierToolStripMenuItem";
            this.rapportJournalierToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.rapportJournalierToolStripMenuItem.Text = "Rapport Journalier";
            // 
            // rapportJournalierToolStripMenuItem1
            // 
            this.rapportJournalierToolStripMenuItem1.Name = "rapportJournalierToolStripMenuItem1";
            this.rapportJournalierToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.rapportJournalierToolStripMenuItem1.Text = "Rapport Journalier";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Name = "frmprincipal";
            this.Text = "frmprincipal";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnmortalite;
        private System.Windows.Forms.Button btnconsomation;
        private System.Windows.Forms.Button btnagent;
        private System.Windows.Forms.Button btntraitement;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnfournisseur;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolPoule;
        private System.Windows.Forms.ToolStripMenuItem categoriePouleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pouleToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolAliment;
        private System.Windows.Forms.ToolStripMenuItem categorieAlimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolMedicament;
        private System.Windows.Forms.ToolStripMenuItem categorieMedicamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolCommande;
        private System.Windows.Forms.ToolStripMenuItem enteteCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toollivraison;
        private System.Windows.Forms.ToolStripMenuItem enteteLivraisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailLivraisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem rapportJournalierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportJournalierToolStripMenuItem1;
    }
}