namespace gestion_poullailler.UserControls
{
    partial class UserPoules
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodepoule = new System.Windows.Forms.TextBox();
            this.txtprixu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtunite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpoids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datacategorie = new System.Windows.Forms.DataGridView();
            this.dgidcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignationcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapoule = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpoids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgunite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodecategorie = new System.Windows.Forms.TextBox();
            this.txtrecherchecate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapoule)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdesignation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcodepoule);
            this.groupBox1.Controls.Add(this.txtprixu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtunite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpoids);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtquantite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcategorie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Poules";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(459, 141);
            this.txtdesignation.Multiline = true;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(181, 34);
            this.txtdesignation.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Designation";
            // 
            // txtcodepoule
            // 
            this.txtcodepoule.Location = new System.Drawing.Point(563, 14);
            this.txtcodepoule.Multiline = true;
            this.txtcodepoule.Name = "txtcodepoule";
            this.txtcodepoule.Size = new System.Drawing.Size(87, 34);
            this.txtcodepoule.TabIndex = 10;
            this.txtcodepoule.Visible = false;
            // 
            // txtprixu
            // 
            this.txtprixu.Location = new System.Drawing.Point(459, 67);
            this.txtprixu.Multiline = true;
            this.txtprixu.Name = "txtprixu";
            this.txtprixu.Size = new System.Drawing.Size(181, 34);
            this.txtprixu.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix Unitaire";
            // 
            // txtunite
            // 
            this.txtunite.Location = new System.Drawing.Point(247, 141);
            this.txtunite.Multiline = true;
            this.txtunite.Name = "txtunite";
            this.txtunite.Size = new System.Drawing.Size(181, 34);
            this.txtunite.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unite";
            // 
            // txtpoids
            // 
            this.txtpoids.Location = new System.Drawing.Point(30, 141);
            this.txtpoids.Multiline = true;
            this.txtpoids.Name = "txtpoids";
            this.txtpoids.Size = new System.Drawing.Size(181, 34);
            this.txtpoids.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Poids";
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(247, 67);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(181, 34);
            this.txtquantite.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantite";
            // 
            // txtcategorie
            // 
            this.txtcategorie.Location = new System.Drawing.Point(30, 67);
            this.txtcategorie.Multiline = true;
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(181, 34);
            this.txtcategorie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie Poule";
            // 
            // datacategorie
            // 
            this.datacategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacategorie.BackgroundColor = System.Drawing.Color.White;
            this.datacategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidcategorie,
            this.dgdesignationcategorie});
            this.datacategorie.Location = new System.Drawing.Point(711, 89);
            this.datacategorie.Name = "datacategorie";
            this.datacategorie.Size = new System.Drawing.Size(404, 225);
            this.datacategorie.TabIndex = 1;
            this.datacategorie.DoubleClick += new System.EventHandler(this.datacategorie_DoubleClick);
            // 
            // dgidcategorie
            // 
            this.dgidcategorie.DataPropertyName = "idcatepoule";
            this.dgidcategorie.HeaderText = "id";
            this.dgidcategorie.Name = "dgidcategorie";
            // 
            // dgdesignationcategorie
            // 
            this.dgdesignationcategorie.DataPropertyName = "designation";
            this.dgdesignationcategorie.HeaderText = "designation";
            this.dgdesignationcategorie.Name = "dgdesignationcategorie";
            // 
            // datapoule
            // 
            this.datapoule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datapoule.BackgroundColor = System.Drawing.Color.White;
            this.datapoule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapoule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgcategorie,
            this.dgdesignation,
            this.dgquantite,
            this.dgpoids,
            this.dgunite,
            this.dgprixu});
            this.datapoule.Location = new System.Drawing.Point(37, 363);
            this.datapoule.Name = "datapoule";
            this.datapoule.Size = new System.Drawing.Size(1078, 247);
            this.datapoule.TabIndex = 2;
            this.datapoule.DoubleClick += new System.EventHandler(this.datapoule_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codepole";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgcategorie
            // 
            this.dgcategorie.DataPropertyName = "categoriepoule";
            this.dgcategorie.HeaderText = "categorie";
            this.dgcategorie.Name = "dgcategorie";
            // 
            // dgdesignation
            // 
            this.dgdesignation.DataPropertyName = "designation";
            this.dgdesignation.HeaderText = "designation";
            this.dgdesignation.Name = "dgdesignation";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgpoids
            // 
            this.dgpoids.DataPropertyName = "poids";
            this.dgpoids.HeaderText = "poids";
            this.dgpoids.Name = "dgpoids";
            // 
            // dgunite
            // 
            this.dgunite.DataPropertyName = "unite";
            this.dgunite.HeaderText = "unite";
            this.dgunite.Name = "dgunite";
            // 
            // dgprixu
            // 
            this.dgprixu.DataPropertyName = "prixu";
            this.dgprixu.HeaderText = "prixu";
            this.dgprixu.Name = "dgprixu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(328, 26);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 34);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.DarkRed;
            this.btnedit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(186, 26);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(103, 34);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(49, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 34);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(532, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 73);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapport";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.LightGray;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(26, 26);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(102, 34);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(845, 323);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(744, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Recherche";
            // 
            // txtcodecategorie
            // 
            this.txtcodecategorie.Location = new System.Drawing.Point(711, 49);
            this.txtcodecategorie.Multiline = true;
            this.txtcodecategorie.Name = "txtcodecategorie";
            this.txtcodecategorie.Size = new System.Drawing.Size(87, 34);
            this.txtcodecategorie.TabIndex = 11;
            this.txtcodecategorie.Visible = false;
            // 
            // txtrecherchecate
            // 
            this.txtrecherchecate.Location = new System.Drawing.Point(915, 47);
            this.txtrecherchecate.Multiline = true;
            this.txtrecherchecate.Name = "txtrecherchecate";
            this.txtrecherchecate.Size = new System.Drawing.Size(178, 34);
            this.txtrecherchecate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(814, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Recherche";
            // 
            // UserPoules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.txtrecherchecate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcodecategorie);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datapoule);
            this.Controls.Add(this.datacategorie);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserPoules";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserPoules_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapoule)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprixu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtunite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpoids;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datacategorie;
        private System.Windows.Forms.DataGridView datapoule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodepoule;
        private System.Windows.Forms.TextBox txtcodecategorie;
        private System.Windows.Forms.TextBox txtrecherchecate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignationcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpoids;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgunite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
    }
}
