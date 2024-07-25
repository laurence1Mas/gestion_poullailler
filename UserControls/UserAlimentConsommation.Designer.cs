namespace gestion_poullailler.UserControls
{
    partial class UserAlimentConsommation
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnprintc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndeletec = new System.Windows.Forms.Button();
            this.btneditc = new System.Windows.Forms.Button();
            this.btnsavec = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcodeconsomation = new System.Windows.Forms.TextBox();
            this.txtunitec = new System.Windows.Forms.TextBox();
            this.cmbaliment = new System.Windows.Forms.ComboBox();
            this.datecons = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbpoule = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquantitec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodealiement = new System.Windows.Forms.TextBox();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.cmbfournisseurs = new System.Windows.Forms.ComboBox();
            this.cmbcategoriealiment = new System.Windows.Forms.ComboBox();
            this.txtprixU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtunite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataaliment = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgfournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgunite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprixu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataconsommation = new System.Windows.Forms.DataGridView();
            this.dgidc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpoule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgaliment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantitec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgunitec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrecherchec = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaliment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataconsommation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprintc);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1014, 275);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(105, 73);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport";
            // 
            // btnprintc
            // 
            this.btnprintc.BackColor = System.Drawing.Color.LightGray;
            this.btnprintc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintc.ForeColor = System.Drawing.Color.White;
            this.btnprintc.Location = new System.Drawing.Point(12, 26);
            this.btnprintc.Name = "btnprintc";
            this.btnprintc.Size = new System.Drawing.Size(87, 34);
            this.btnprintc.TabIndex = 13;
            this.btnprintc.Text = "Print";
            this.btnprintc.UseVisualStyleBackColor = false;
            this.btnprintc.Click += new System.EventHandler(this.btnprintc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndeletec);
            this.groupBox6.Controls.Add(this.btneditc);
            this.groupBox6.Controls.Add(this.btnsavec);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(635, 272);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 76);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btndeletec
            // 
            this.btndeletec.BackColor = System.Drawing.Color.Red;
            this.btndeletec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletec.ForeColor = System.Drawing.Color.White;
            this.btndeletec.Location = new System.Drawing.Point(254, 29);
            this.btndeletec.Name = "btndeletec";
            this.btndeletec.Size = new System.Drawing.Size(103, 34);
            this.btndeletec.TabIndex = 14;
            this.btndeletec.Text = "Delete";
            this.btndeletec.UseVisualStyleBackColor = false;
            this.btndeletec.Click += new System.EventHandler(this.btndeletec_Click);
            // 
            // btneditc
            // 
            this.btneditc.BackColor = System.Drawing.Color.DarkRed;
            this.btneditc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditc.ForeColor = System.Drawing.Color.White;
            this.btneditc.Location = new System.Drawing.Point(136, 29);
            this.btneditc.Name = "btneditc";
            this.btneditc.Size = new System.Drawing.Size(103, 34);
            this.btneditc.TabIndex = 13;
            this.btneditc.Text = "Edit";
            this.btneditc.UseVisualStyleBackColor = false;
            this.btneditc.Click += new System.EventHandler(this.btneditc_Click);
            // 
            // btnsavec
            // 
            this.btnsavec.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsavec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavec.ForeColor = System.Drawing.Color.White;
            this.btnsavec.Location = new System.Drawing.Point(15, 29);
            this.btnsavec.Name = "btnsavec";
            this.btnsavec.Size = new System.Drawing.Size(102, 34);
            this.btnsavec.TabIndex = 12;
            this.btnsavec.Text = "Save";
            this.btnsavec.UseVisualStyleBackColor = false;
            this.btnsavec.Click += new System.EventHandler(this.btnsavec_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(33, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(578, 76);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(405, 29);
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
            this.btnedit.Location = new System.Drawing.Point(227, 29);
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
            this.btnsave.Location = new System.Drawing.Point(70, 29);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 34);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcodeconsomation);
            this.groupBox2.Controls.Add(this.txtunitec);
            this.groupBox2.Controls.Add(this.cmbaliment);
            this.groupBox2.Controls.Add(this.datecons);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbpoule);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtquantitec);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Consommation";
            // 
            // txtcodeconsomation
            // 
            this.txtcodeconsomation.Location = new System.Drawing.Point(368, 24);
            this.txtcodeconsomation.Name = "txtcodeconsomation";
            this.txtcodeconsomation.Size = new System.Drawing.Size(100, 27);
            this.txtcodeconsomation.TabIndex = 16;
            this.txtcodeconsomation.Visible = false;
            // 
            // txtunitec
            // 
            this.txtunitec.Location = new System.Drawing.Point(259, 141);
            this.txtunitec.Name = "txtunitec";
            this.txtunitec.Size = new System.Drawing.Size(219, 27);
            this.txtunitec.TabIndex = 17;
            // 
            // cmbaliment
            // 
            this.cmbaliment.FormattingEnabled = true;
            this.cmbaliment.Location = new System.Drawing.Point(259, 67);
            this.cmbaliment.Name = "cmbaliment";
            this.cmbaliment.Size = new System.Drawing.Size(219, 29);
            this.cmbaliment.TabIndex = 16;
            // 
            // datecons
            // 
            this.datecons.Location = new System.Drawing.Point(86, 181);
            this.datecons.Name = "datecons";
            this.datecons.Size = new System.Drawing.Size(271, 27);
            this.datecons.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // cmbpoule
            // 
            this.cmbpoule.FormattingEnabled = true;
            this.cmbpoule.Location = new System.Drawing.Point(14, 67);
            this.cmbpoule.Name = "cmbpoule";
            this.cmbpoule.Size = new System.Drawing.Size(225, 29);
            this.cmbpoule.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Unites";
            // 
            // txtquantitec
            // 
            this.txtquantitec.Location = new System.Drawing.Point(14, 141);
            this.txtquantitec.Name = "txtquantitec";
            this.txtquantitec.Size = new System.Drawing.Size(225, 27);
            this.txtquantitec.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Aliments";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Poules";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodealiement);
            this.groupBox1.Controls.Add(this.txtquantite);
            this.groupBox1.Controls.Add(this.cmbfournisseurs);
            this.groupBox1.Controls.Add(this.cmbcategoriealiment);
            this.groupBox1.Controls.Add(this.txtprixU);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtunite);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdesignation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 231);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Aliment";
            // 
            // txtcodealiement
            // 
            this.txtcodealiement.Location = new System.Drawing.Point(478, 24);
            this.txtcodealiement.Name = "txtcodealiement";
            this.txtcodealiement.Size = new System.Drawing.Size(100, 27);
            this.txtcodealiement.TabIndex = 15;
            this.txtcodealiement.Visible = false;
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(6, 147);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(177, 27);
            this.txtquantite.TabIndex = 14;
            // 
            // cmbfournisseurs
            // 
            this.cmbfournisseurs.FormattingEnabled = true;
            this.cmbfournisseurs.Location = new System.Drawing.Point(215, 78);
            this.cmbfournisseurs.Name = "cmbfournisseurs";
            this.cmbfournisseurs.Size = new System.Drawing.Size(177, 29);
            this.cmbfournisseurs.TabIndex = 13;
            // 
            // cmbcategoriealiment
            // 
            this.cmbcategoriealiment.FormattingEnabled = true;
            this.cmbcategoriealiment.Location = new System.Drawing.Point(6, 79);
            this.cmbcategoriealiment.Name = "cmbcategoriealiment";
            this.cmbcategoriealiment.Size = new System.Drawing.Size(177, 29);
            this.cmbcategoriealiment.TabIndex = 12;
            // 
            // txtprixU
            // 
            this.txtprixU.Location = new System.Drawing.Point(413, 147);
            this.txtprixU.Name = "txtprixU";
            this.txtprixU.Size = new System.Drawing.Size(177, 27);
            this.txtprixU.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Prix Unitaire";
            // 
            // txtunite
            // 
            this.txtunite.Location = new System.Drawing.Point(215, 147);
            this.txtunite.Name = "txtunite";
            this.txtunite.Size = new System.Drawing.Size(177, 27);
            this.txtunite.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Unite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite";
            // 
            // txtdesignation
            // 
            this.txtdesignation.Location = new System.Drawing.Point(413, 79);
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(177, 27);
            this.txtdesignation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fournisseurs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorie Aliment";
            // 
            // dataaliment
            // 
            this.dataaliment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataaliment.BackgroundColor = System.Drawing.Color.White;
            this.dataaliment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataaliment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgcategorie,
            this.dgdesignation,
            this.dgfournisseur,
            this.dgquantite,
            this.dgunite,
            this.dgprixu});
            this.dataaliment.Location = new System.Drawing.Point(33, 402);
            this.dataaliment.Name = "dataaliment";
            this.dataaliment.Size = new System.Drawing.Size(596, 212);
            this.dataaliment.TabIndex = 15;
            this.dataaliment.DoubleClick += new System.EventHandler(this.dataaliment_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codealiment";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgcategorie
            // 
            this.dgcategorie.DataPropertyName = "categoriealiment";
            this.dgcategorie.HeaderText = "categorie";
            this.dgcategorie.Name = "dgcategorie";
            // 
            // dgdesignation
            // 
            this.dgdesignation.DataPropertyName = "designation";
            this.dgdesignation.HeaderText = "designation";
            this.dgdesignation.Name = "dgdesignation";
            // 
            // dgfournisseur
            // 
            this.dgfournisseur.DataPropertyName = "fournisseur";
            this.dgfournisseur.HeaderText = "fournisseur";
            this.dgfournisseur.Name = "dgfournisseur";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
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
            // dataconsommation
            // 
            this.dataconsommation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataconsommation.BackgroundColor = System.Drawing.Color.White;
            this.dataconsommation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataconsommation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidc,
            this.dgpoule,
            this.dgaliment,
            this.dgquantitec,
            this.dgunitec,
            this.dgdate});
            this.dataconsommation.Location = new System.Drawing.Point(635, 402);
            this.dataconsommation.Name = "dataconsommation";
            this.dataconsommation.Size = new System.Drawing.Size(497, 212);
            this.dataconsommation.TabIndex = 16;
            this.dataconsommation.DoubleClick += new System.EventHandler(this.dataconsommation_DoubleClick);
            // 
            // dgidc
            // 
            this.dgidc.DataPropertyName = "codeconsommation";
            this.dgidc.HeaderText = "id";
            this.dgidc.Name = "dgidc";
            // 
            // dgpoule
            // 
            this.dgpoule.DataPropertyName = "poule";
            this.dgpoule.HeaderText = "poule";
            this.dgpoule.Name = "dgpoule";
            // 
            // dgaliment
            // 
            this.dgaliment.DataPropertyName = "aliment";
            this.dgaliment.HeaderText = "aliment";
            this.dgaliment.Name = "dgaliment";
            // 
            // dgquantitec
            // 
            this.dgquantitec.DataPropertyName = "quantite";
            this.dgquantitec.HeaderText = "quantite";
            this.dgquantitec.Name = "dgquantitec";
            // 
            // dgunitec
            // 
            this.dgunitec.DataPropertyName = "unite";
            this.dgunitec.HeaderText = "unite";
            this.dgunitec.Name = "dgunitec";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "dateconsommation";
            this.dgdate.HeaderText = "date";
            this.dgdate.Name = "dgdate";
            // 
            // txtrecherchec
            // 
            this.txtrecherchec.Location = new System.Drawing.Point(903, 362);
            this.txtrecherchec.Multiline = true;
            this.txtrecherchec.Name = "txtrecherchec";
            this.txtrecherchec.Size = new System.Drawing.Size(200, 34);
            this.txtrecherchec.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(802, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Recherche";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(395, 362);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(294, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Recherche";
            // 
            // UserAlimentConsommation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.txtrecherchec);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataconsommation);
            this.Controls.Add(this.dataaliment);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserAlimentConsommation";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserAlimentConsommation_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataaliment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataconsommation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnprintc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btndeletec;
        private System.Windows.Forms.Button btneditc;
        private System.Windows.Forms.Button btnsavec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbpoule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquantitec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtprixU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtunite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.ComboBox cmbfournisseurs;
        private System.Windows.Forms.ComboBox cmbcategoriealiment;
        private System.Windows.Forms.TextBox txtunitec;
        private System.Windows.Forms.ComboBox cmbaliment;
        private System.Windows.Forms.DateTimePicker datecons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataaliment;
        private System.Windows.Forms.DataGridView dataconsommation;
        private System.Windows.Forms.TextBox txtrecherchec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcodeconsomation;
        private System.Windows.Forms.TextBox txtcodealiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgfournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgunite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprixu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgaliment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantitec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgunitec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
    }
}
