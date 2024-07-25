namespace gestion_poullailler.UserControls
{
    partial class UserAgents
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
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataagent = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodeagent = new System.Windows.Forms.TextBox();
            this.cmbgenref = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtadressef = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelephonef = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnomsf = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataagent)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(215, 315);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 18;
            this.label13.Text = "Recherche";
            // 
            // dataagent
            // 
            this.dataagent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataagent.BackgroundColor = System.Drawing.Color.White;
            this.dataagent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataagent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgnoms,
            this.dggenre,
            this.dgadresse,
            this.dgtelephone,
            this.dgmail});
            this.dataagent.Location = new System.Drawing.Point(30, 355);
            this.dataagent.Name = "dataagent";
            this.dataagent.Size = new System.Drawing.Size(1097, 260);
            this.dataagent.TabIndex = 17;
            this.dataagent.DoubleClick += new System.EventHandler(this.dataagent_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codeagent";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
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
            // dgadresse
            // 
            this.dgadresse.DataPropertyName = "adresse";
            this.dgadresse.HeaderText = "adresse";
            this.dgadresse.Name = "dgadresse";
            // 
            // dgtelephone
            // 
            this.dgtelephone.DataPropertyName = "telephone";
            this.dgtelephone.HeaderText = "telephone";
            this.dgtelephone.Name = "dgtelephone";
            // 
            // dgmail
            // 
            this.dgmail.DataPropertyName = "mail";
            this.dgmail.HeaderText = "mail";
            this.dgmail.Name = "dgmail";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(926, 41);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(182, 217);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(30, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(30, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 44);
            this.button3.TabIndex = 13;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(31, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 40);
            this.button4.TabIndex = 12;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmail);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtcodeagent);
            this.groupBox2.Controls.Add(this.cmbgenref);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtadressef);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txttelephonef);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtnomsf);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 231);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Fournisseurs";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(627, 72);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(220, 27);
            this.txtmail.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mail";
            // 
            // txtcodeagent
            // 
            this.txtcodeagent.Location = new System.Drawing.Point(747, 14);
            this.txtcodeagent.Name = "txtcodeagent";
            this.txtcodeagent.Size = new System.Drawing.Size(100, 27);
            this.txtcodeagent.TabIndex = 14;
            this.txtcodeagent.Visible = false;
            // 
            // cmbgenref
            // 
            this.cmbgenref.FormattingEnabled = true;
            this.cmbgenref.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbgenref.Location = new System.Drawing.Point(339, 149);
            this.cmbgenref.Name = "cmbgenref";
            this.cmbgenref.Size = new System.Drawing.Size(220, 29);
            this.cmbgenref.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Genre";
            // 
            // txtadressef
            // 
            this.txtadressef.Location = new System.Drawing.Point(31, 151);
            this.txtadressef.Name = "txtadressef";
            this.txtadressef.Size = new System.Drawing.Size(240, 27);
            this.txtadressef.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Adresse";
            // 
            // txttelephonef
            // 
            this.txttelephonef.Location = new System.Drawing.Point(339, 72);
            this.txttelephonef.Name = "txttelephonef";
            this.txttelephonef.Size = new System.Drawing.Size(220, 27);
            this.txttelephonef.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telephone";
            // 
            // txtnomsf
            // 
            this.txtnomsf.Location = new System.Drawing.Point(31, 69);
            this.txtnomsf.Name = "txtnomsf";
            this.txtnomsf.Size = new System.Drawing.Size(240, 27);
            this.txtnomsf.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Noms";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprint);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(926, 264);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 73);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.LightGray;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(39, 26);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(110, 34);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // UserAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataagent);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserAgents";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserAgents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataagent)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataagent;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcodeagent;
        private System.Windows.Forms.ComboBox cmbgenref;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtadressef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelephonef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnomsf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmail;
    }
}
