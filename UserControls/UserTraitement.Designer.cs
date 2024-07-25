namespace gestion_poullailler.UserControls
{
    partial class UserTraitement
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datamedicament = new System.Windows.Forms.DataGridView();
            this.dgidm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datatraitement = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpoule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgunite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndeleteM = new System.Windows.Forms.Button();
            this.btneditM = new System.Windows.Forms.Button();
            this.btnsaveM = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcodemedicament = new System.Windows.Forms.TextBox();
            this.cmbcategorie = new System.Windows.Forms.ComboBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodetraitement = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbunite = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmedicament = new System.Windows.Forms.ComboBox();
            this.cmbpoule = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdose = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrechercheM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datamedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatraitement)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(795, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Recherche";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(145, 381);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Recherche";
            // 
            // datamedicament
            // 
            this.datamedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datamedicament.BackgroundColor = System.Drawing.Color.White;
            this.datamedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidm,
            this.dgcategorie,
            this.dgdesignation});
            this.datamedicament.Location = new System.Drawing.Point(634, 421);
            this.datamedicament.Name = "datamedicament";
            this.datamedicament.Size = new System.Drawing.Size(494, 194);
            this.datamedicament.TabIndex = 20;
            this.datamedicament.DoubleClick += new System.EventHandler(this.datamedicament_DoubleClick);
            // 
            // dgidm
            // 
            this.dgidm.DataPropertyName = "codemedicament";
            this.dgidm.HeaderText = "id";
            this.dgidm.Name = "dgidm";
            // 
            // dgcategorie
            // 
            this.dgcategorie.DataPropertyName = "categoriemedicament";
            this.dgcategorie.HeaderText = "categorie";
            this.dgcategorie.Name = "dgcategorie";
            // 
            // dgdesignation
            // 
            this.dgdesignation.DataPropertyName = "designation";
            this.dgdesignation.HeaderText = "designation";
            this.dgdesignation.Name = "dgdesignation";
            // 
            // datatraitement
            // 
            this.datatraitement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatraitement.BackgroundColor = System.Drawing.Color.White;
            this.datatraitement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatraitement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgpoule,
            this.dgmedicament,
            this.dgdose,
            this.dgunite,
            this.dgdate});
            this.datatraitement.Location = new System.Drawing.Point(25, 421);
            this.datatraitement.Name = "datatraitement";
            this.datatraitement.Size = new System.Drawing.Size(597, 194);
            this.datatraitement.TabIndex = 19;
            this.datatraitement.DoubleClick += new System.EventHandler(this.datatraitement_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codetraitement";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgpoule
            // 
            this.dgpoule.DataPropertyName = "poule";
            this.dgpoule.HeaderText = "poule";
            this.dgpoule.Name = "dgpoule";
            // 
            // dgmedicament
            // 
            this.dgmedicament.DataPropertyName = "medicament";
            this.dgmedicament.HeaderText = "medicament";
            this.dgmedicament.Name = "dgmedicament";
            // 
            // dgdose
            // 
            this.dgdose.DataPropertyName = "dose";
            this.dgdose.HeaderText = "dose";
            this.dgdose.Name = "dgdose";
            // 
            // dgunite
            // 
            this.dgunite.DataPropertyName = "Unite";
            this.dgunite.HeaderText = "unite";
            this.dgunite.Name = "dgunite";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "datetraitement";
            this.dgdate.HeaderText = "date";
            this.dgdate.Name = "dgdate";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndeleteM);
            this.groupBox6.Controls.Add(this.btneditM);
            this.groupBox6.Controls.Add(this.btnsaveM);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(713, 277);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 76);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btndeleteM
            // 
            this.btndeleteM.BackColor = System.Drawing.Color.Red;
            this.btndeleteM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteM.ForeColor = System.Drawing.Color.White;
            this.btndeleteM.Location = new System.Drawing.Point(254, 29);
            this.btndeleteM.Name = "btndeleteM";
            this.btndeleteM.Size = new System.Drawing.Size(103, 34);
            this.btndeleteM.TabIndex = 14;
            this.btndeleteM.Text = "Delete";
            this.btndeleteM.UseVisualStyleBackColor = false;
            this.btndeleteM.Click += new System.EventHandler(this.btndeleteM_Click);
            // 
            // btneditM
            // 
            this.btneditM.BackColor = System.Drawing.Color.DarkRed;
            this.btneditM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditM.ForeColor = System.Drawing.Color.White;
            this.btneditM.Location = new System.Drawing.Point(136, 29);
            this.btneditM.Name = "btneditM";
            this.btneditM.Size = new System.Drawing.Size(103, 34);
            this.btneditM.TabIndex = 13;
            this.btneditM.Text = "Edit";
            this.btneditM.UseVisualStyleBackColor = false;
            this.btneditM.Click += new System.EventHandler(this.btneditM_Click);
            // 
            // btnsaveM
            // 
            this.btnsaveM.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsaveM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveM.ForeColor = System.Drawing.Color.White;
            this.btnsaveM.Location = new System.Drawing.Point(15, 29);
            this.btnsaveM.Name = "btnsaveM";
            this.btnsaveM.Size = new System.Drawing.Size(102, 34);
            this.btnsaveM.TabIndex = 12;
            this.btnsaveM.Text = "Save";
            this.btnsaveM.UseVisualStyleBackColor = false;
            this.btnsaveM.Click += new System.EventHandler(this.btnsaveM_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(474, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 73);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapport";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.LightGray;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(17, 26);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(102, 34);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(32, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(436, 76);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(309, 29);
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
            this.btnedit.Location = new System.Drawing.Point(167, 29);
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
            this.btnsave.Location = new System.Drawing.Point(30, 29);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 34);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcodemedicament);
            this.groupBox2.Controls.Add(this.cmbcategorie);
            this.groupBox2.Controls.Add(this.txtdesignation);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(634, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 231);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Medicaments";
            // 
            // txtcodemedicament
            // 
            this.txtcodemedicament.Location = new System.Drawing.Point(370, 16);
            this.txtcodemedicament.Name = "txtcodemedicament";
            this.txtcodemedicament.Size = new System.Drawing.Size(100, 27);
            this.txtcodemedicament.TabIndex = 13;
            this.txtcodemedicament.Visible = false;
            // 
            // cmbcategorie
            // 
            this.cmbcategorie.FormattingEnabled = true;
            this.cmbcategorie.Location = new System.Drawing.Point(15, 89);
            this.cmbcategorie.Name = "cmbcategorie";
            this.cmbcategorie.Size = new System.Drawing.Size(224, 29);
            this.cmbcategorie.TabIndex = 8;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(254, 89);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(216, 27);
            this.txtdesignation.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Designation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Categorie Medicament";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodetraitement);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.cmbunite);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbmedicament);
            this.groupBox1.Controls.Add(this.cmbpoule);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdose);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 231);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Traitements";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcodetraitement
            // 
            this.txtcodetraitement.Location = new System.Drawing.Point(481, 27);
            this.txtcodetraitement.Name = "txtcodetraitement";
            this.txtcodetraitement.Size = new System.Drawing.Size(100, 27);
            this.txtcodetraitement.TabIndex = 12;
            this.txtcodetraitement.Visible = false;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(21, 157);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(265, 27);
            this.date.TabIndex = 11;
            // 
            // cmbunite
            // 
            this.cmbunite.FormattingEnabled = true;
            this.cmbunite.Items.AddRange(new object[] {
            "mg",
            "g",
            "ml",
            "l"});
            this.cmbunite.Location = new System.Drawing.Point(413, 155);
            this.cmbunite.Name = "cmbunite";
            this.cmbunite.Size = new System.Drawing.Size(177, 29);
            this.cmbunite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unite";
            // 
            // cmbmedicament
            // 
            this.cmbmedicament.FormattingEnabled = true;
            this.cmbmedicament.Location = new System.Drawing.Point(215, 89);
            this.cmbmedicament.Name = "cmbmedicament";
            this.cmbmedicament.Size = new System.Drawing.Size(177, 29);
            this.cmbmedicament.TabIndex = 8;
            // 
            // cmbpoule
            // 
            this.cmbpoule.FormattingEnabled = true;
            this.cmbpoule.Location = new System.Drawing.Point(21, 87);
            this.cmbpoule.Name = "cmbpoule";
            this.cmbpoule.Size = new System.Drawing.Size(177, 29);
            this.cmbpoule.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // txtdose
            // 
            this.txtdose.Location = new System.Drawing.Point(413, 89);
            this.txtdose.Name = "txtdose";
            this.txtdose.Size = new System.Drawing.Size(177, 27);
            this.txtdose.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicaments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poules";
            // 
            // txtrechercheM
            // 
            this.txtrechercheM.Location = new System.Drawing.Point(888, 381);
            this.txtrechercheM.Multiline = true;
            this.txtrechercheM.Name = "txtrechercheM";
            this.txtrechercheM.Size = new System.Drawing.Size(216, 34);
            this.txtrechercheM.TabIndex = 24;
            // 
            // UserTraitement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtrechercheM);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.datamedicament);
            this.Controls.Add(this.datatraitement);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserTraitement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserTraitement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datamedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatraitement)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView datamedicament;
        private System.Windows.Forms.DataGridView datatraitement;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btndeleteM;
        private System.Windows.Forms.Button btneditM;
        private System.Windows.Forms.Button btnsaveM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbpoule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcategorie;
        private System.Windows.Forms.TextBox txtrechercheM;
        private System.Windows.Forms.ComboBox cmbmedicament;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox cmbunite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodemedicament;
        private System.Windows.Forms.TextBox txtcodetraitement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgunite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
    }
}
