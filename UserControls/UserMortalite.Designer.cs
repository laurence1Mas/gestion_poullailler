namespace gestion_poullailler.UserControls
{
    partial class UserMortalite
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.datamortalite = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpoule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnbrv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnbrM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnbrMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapoule = new System.Windows.Forms.DataGridView();
            this.dgidpoule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtcodemortalite = new System.Windows.Forms.TextBox();
            this.txtnbrmalade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnbrmort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnbrvivant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpoule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecherchepoule = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodepoule = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamortalite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapoule)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(845, 316);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(744, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Recherche";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(532, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 73);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapport";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 76);
            this.groupBox2.TabIndex = 13;
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
            this.btnsave.BackColor = System.Drawing.Color.SeaGreen;
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
            // datamortalite
            // 
            this.datamortalite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datamortalite.BackgroundColor = System.Drawing.Color.White;
            this.datamortalite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamortalite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgpoule,
            this.dgnbrv,
            this.dgnbrM,
            this.dgnbrMo,
            this.dgdate});
            this.datamortalite.Location = new System.Drawing.Point(37, 356);
            this.datamortalite.Name = "datamortalite";
            this.datamortalite.Size = new System.Drawing.Size(1078, 247);
            this.datamortalite.TabIndex = 12;
            this.datamortalite.DoubleClick += new System.EventHandler(this.datamortalite_DoubleClick);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "idmortalite";
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgpoule
            // 
            this.dgpoule.DataPropertyName = "poule";
            this.dgpoule.HeaderText = "poule";
            this.dgpoule.Name = "dgpoule";
            // 
            // dgnbrv
            // 
            this.dgnbrv.DataPropertyName = "nombre_vivant";
            this.dgnbrv.HeaderText = "Nombre_vivant";
            this.dgnbrv.Name = "dgnbrv";
            // 
            // dgnbrM
            // 
            this.dgnbrM.DataPropertyName = "nombre_malade";
            this.dgnbrM.HeaderText = "Nombre_malade";
            this.dgnbrM.Name = "dgnbrM";
            // 
            // dgnbrMo
            // 
            this.dgnbrMo.DataPropertyName = "nombre_mort";
            this.dgnbrMo.HeaderText = "Nombre_mort";
            this.dgnbrMo.Name = "dgnbrMo";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "dateprelevement";
            this.dgdate.HeaderText = "dateprelevement";
            this.dgdate.Name = "dgdate";
            // 
            // datapoule
            // 
            this.datapoule.BackgroundColor = System.Drawing.Color.White;
            this.datapoule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datapoule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidpoule,
            this.dgcategorie,
            this.dgdesignation});
            this.datapoule.Location = new System.Drawing.Point(711, 82);
            this.datapoule.Name = "datapoule";
            this.datapoule.Size = new System.Drawing.Size(404, 225);
            this.datapoule.TabIndex = 11;
            this.datapoule.DoubleClick += new System.EventHandler(this.datapoule_DoubleClick);
            // 
            // dgidpoule
            // 
            this.dgidpoule.DataPropertyName = "codepole";
            this.dgidpoule.HeaderText = "id";
            this.dgidpoule.Name = "dgidpoule";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtcodemortalite);
            this.groupBox1.Controls.Add(this.txtnbrmalade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnbrmort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnbrvivant);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtpoule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Mortalite";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 27);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtcodemortalite
            // 
            this.txtcodemortalite.Location = new System.Drawing.Point(560, 13);
            this.txtcodemortalite.Multiline = true;
            this.txtcodemortalite.Name = "txtcodemortalite";
            this.txtcodemortalite.Size = new System.Drawing.Size(87, 27);
            this.txtcodemortalite.TabIndex = 10;
            this.txtcodemortalite.Visible = false;
            // 
            // txtnbrmalade
            // 
            this.txtnbrmalade.Location = new System.Drawing.Point(459, 67);
            this.txtnbrmalade.Multiline = true;
            this.txtnbrmalade.Name = "txtnbrmalade";
            this.txtnbrmalade.Size = new System.Drawing.Size(181, 34);
            this.txtnbrmalade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre malade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // txtnbrmort
            // 
            this.txtnbrmort.Location = new System.Drawing.Point(30, 141);
            this.txtnbrmort.Multiline = true;
            this.txtnbrmort.Name = "txtnbrmort";
            this.txtnbrmort.Size = new System.Drawing.Size(181, 34);
            this.txtnbrmort.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre mort";
            // 
            // txtnbrvivant
            // 
            this.txtnbrvivant.Location = new System.Drawing.Point(247, 67);
            this.txtnbrvivant.Multiline = true;
            this.txtnbrvivant.Name = "txtnbrvivant";
            this.txtnbrvivant.Size = new System.Drawing.Size(181, 34);
            this.txtnbrvivant.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre vivant";
            // 
            // txtpoule
            // 
            this.txtpoule.Location = new System.Drawing.Point(30, 67);
            this.txtpoule.Multiline = true;
            this.txtpoule.Name = "txtpoule";
            this.txtpoule.Size = new System.Drawing.Size(181, 34);
            this.txtpoule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poules";
            // 
            // txtrecherchepoule
            // 
            this.txtrecherchepoule.Location = new System.Drawing.Point(885, 39);
            this.txtrecherchepoule.Multiline = true;
            this.txtrecherchepoule.Name = "txtrecherchepoule";
            this.txtrecherchepoule.Size = new System.Drawing.Size(216, 34);
            this.txtrecherchepoule.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(784, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recherche";
            // 
            // txtcodepoule
            // 
            this.txtcodepoule.Location = new System.Drawing.Point(703, 49);
            this.txtcodepoule.Multiline = true;
            this.txtcodepoule.Name = "txtcodepoule";
            this.txtcodepoule.Size = new System.Drawing.Size(75, 27);
            this.txtcodepoule.TabIndex = 12;
            this.txtcodepoule.Visible = false;
            // 
            // UserMortalite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtcodepoule);
            this.Controls.Add(this.txtrecherchepoule);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datamortalite);
            this.Controls.Add(this.datapoule);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserMortalite";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserMortalite_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datamortalite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapoule)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView datamortalite;
        private System.Windows.Forms.DataGridView datapoule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodemortalite;
        private System.Windows.Forms.TextBox txtnbrmalade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnbrmort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnbrvivant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpoule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtrecherchepoule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcodepoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnbrv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnbrM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnbrMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
    }
}
