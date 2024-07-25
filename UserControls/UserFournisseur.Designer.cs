namespace gestion_poullailler.UserControls
{
    partial class UserFournisseur
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmailf = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcodefournisseur = new System.Windows.Forms.TextBox();
            this.cnbgenref = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtadressef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelephonef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnomsf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnprintf = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndeletef = new System.Windows.Forms.Button();
            this.btneditf = new System.Windows.Forms.Button();
            this.btnsavef = new System.Windows.Forms.Button();
            this.datafournisseur = new System.Windows.Forms.DataGridView();
            this.dgidf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelephonef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadressef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmailf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrecherchef = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datafournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmailf);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtcodefournisseur);
            this.groupBox2.Controls.Add(this.cnbgenref);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtadressef);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txttelephonef);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtnomsf);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(65, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Fournisseurs";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtmailf
            // 
            this.txtmailf.Location = new System.Drawing.Point(319, 150);
            this.txtmailf.Name = "txtmailf";
            this.txtmailf.Size = new System.Drawing.Size(225, 27);
            this.txtmailf.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = "Mail";
            // 
            // txtcodefournisseur
            // 
            this.txtcodefournisseur.Location = new System.Drawing.Point(715, 16);
            this.txtcodefournisseur.Name = "txtcodefournisseur";
            this.txtcodefournisseur.Size = new System.Drawing.Size(100, 27);
            this.txtcodefournisseur.TabIndex = 14;
            this.txtcodefournisseur.Visible = false;
            // 
            // cnbgenref
            // 
            this.cnbgenref.FormattingEnabled = true;
            this.cnbgenref.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cnbgenref.Location = new System.Drawing.Point(613, 79);
            this.cnbgenref.Name = "cnbgenref";
            this.cnbgenref.Size = new System.Drawing.Size(207, 29);
            this.cnbgenref.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Genre";
            // 
            // txtadressef
            // 
            this.txtadressef.Location = new System.Drawing.Point(29, 150);
            this.txtadressef.Name = "txtadressef";
            this.txtadressef.Size = new System.Drawing.Size(225, 27);
            this.txtadressef.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Adresse";
            // 
            // txttelephonef
            // 
            this.txttelephonef.Location = new System.Drawing.Point(316, 81);
            this.txttelephonef.Name = "txttelephonef";
            this.txttelephonef.Size = new System.Drawing.Size(228, 27);
            this.txttelephonef.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telephone";
            // 
            // txtnomsf
            // 
            this.txtnomsf.Location = new System.Drawing.Point(29, 79);
            this.txtnomsf.Name = "txtnomsf";
            this.txtnomsf.Size = new System.Drawing.Size(225, 27);
            this.txtnomsf.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Noms";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprintf);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(939, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 73);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport";
            // 
            // btnprintf
            // 
            this.btnprintf.BackColor = System.Drawing.Color.LightGray;
            this.btnprintf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintf.ForeColor = System.Drawing.Color.White;
            this.btnprintf.Location = new System.Drawing.Point(24, 26);
            this.btnprintf.Name = "btnprintf";
            this.btnprintf.Size = new System.Drawing.Size(125, 34);
            this.btnprintf.TabIndex = 13;
            this.btnprintf.Text = "Print";
            this.btnprintf.UseVisualStyleBackColor = false;
            this.btnprintf.Click += new System.EventHandler(this.btnprintf_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndeletef);
            this.groupBox6.Controls.Add(this.btneditf);
            this.groupBox6.Controls.Add(this.btnsavef);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(939, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 230);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btndeletef
            // 
            this.btndeletef.BackColor = System.Drawing.Color.Red;
            this.btndeletef.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletef.ForeColor = System.Drawing.Color.White;
            this.btndeletef.Location = new System.Drawing.Point(24, 164);
            this.btndeletef.Name = "btndeletef";
            this.btndeletef.Size = new System.Drawing.Size(125, 44);
            this.btndeletef.TabIndex = 14;
            this.btndeletef.Text = "Delete";
            this.btndeletef.UseVisualStyleBackColor = false;
            this.btndeletef.Click += new System.EventHandler(this.btndeletef_Click);
            // 
            // btneditf
            // 
            this.btneditf.BackColor = System.Drawing.Color.DarkRed;
            this.btneditf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditf.ForeColor = System.Drawing.Color.White;
            this.btneditf.Location = new System.Drawing.Point(24, 94);
            this.btneditf.Name = "btneditf";
            this.btneditf.Size = new System.Drawing.Size(125, 46);
            this.btneditf.TabIndex = 13;
            this.btneditf.Text = "Edit";
            this.btneditf.UseVisualStyleBackColor = false;
            this.btneditf.Click += new System.EventHandler(this.btneditf_Click);
            // 
            // btnsavef
            // 
            this.btnsavef.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsavef.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavef.ForeColor = System.Drawing.Color.White;
            this.btnsavef.Location = new System.Drawing.Point(24, 37);
            this.btnsavef.Name = "btnsavef";
            this.btnsavef.Size = new System.Drawing.Size(125, 41);
            this.btnsavef.TabIndex = 12;
            this.btnsavef.Text = "Save";
            this.btnsavef.UseVisualStyleBackColor = false;
            this.btnsavef.Click += new System.EventHandler(this.btnsavef_Click);
            // 
            // datafournisseur
            // 
            this.datafournisseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datafournisseur.BackgroundColor = System.Drawing.Color.White;
            this.datafournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datafournisseur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidf,
            this.dgnoms,
            this.dggenre,
            this.dgtelephonef,
            this.dgadressef,
            this.dgmailf});
            this.datafournisseur.Location = new System.Drawing.Point(35, 352);
            this.datafournisseur.Name = "datafournisseur";
            this.datafournisseur.Size = new System.Drawing.Size(1093, 259);
            this.datafournisseur.TabIndex = 10;
            this.datafournisseur.DoubleClick += new System.EventHandler(this.datafournisseur_DoubleClick);
            // 
            // dgidf
            // 
            this.dgidf.DataPropertyName = "codefournisseur";
            this.dgidf.HeaderText = "id";
            this.dgidf.Name = "dgidf";
            // 
            // dgnoms
            // 
            this.dgnoms.DataPropertyName = "noms";
            this.dgnoms.HeaderText = "noms";
            this.dgnoms.Name = "dgnoms";
            // 
            // dggenre
            // 
            this.dggenre.DataPropertyName = "genre";
            this.dggenre.HeaderText = "genre";
            this.dggenre.Name = "dggenre";
            // 
            // dgtelephonef
            // 
            this.dgtelephonef.DataPropertyName = "telephone";
            this.dgtelephonef.HeaderText = "telephone";
            this.dgtelephonef.Name = "dgtelephonef";
            // 
            // dgadressef
            // 
            this.dgadressef.DataPropertyName = "adresse";
            this.dgadressef.HeaderText = "adresse";
            this.dgadressef.Name = "dgadressef";
            // 
            // dgmailf
            // 
            this.dgmailf.DataPropertyName = "Mail";
            this.dgmailf.HeaderText = "mail";
            this.dgmailf.Name = "dgmailf";
            // 
            // txtrecherchef
            // 
            this.txtrecherchef.Location = new System.Drawing.Point(193, 309);
            this.txtrecherchef.Multiline = true;
            this.txtrecherchef.Name = "txtrecherchef";
            this.txtrecherchef.Size = new System.Drawing.Size(216, 34);
            this.txtrecherchef.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(92, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Recherche";
            // 
            // UserFourniClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtrecherchef);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.datafournisseur);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserFourniClient";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserFourniClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datafournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtadressef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelephonef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnomsf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cnbgenref;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnprintf;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btndeletef;
        private System.Windows.Forms.Button btneditf;
        private System.Windows.Forms.Button btnsavef;
        private System.Windows.Forms.DataGridView datafournisseur;
        private System.Windows.Forms.TextBox txtrecherchef;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcodefournisseur;
        private System.Windows.Forms.TextBox txtmailf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelephonef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadressef;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmailf;
    }
}
