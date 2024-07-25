namespace gestion_poullailler.UserControls
{
    partial class UserCategories
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
            this.txtrecherche1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btndelete1 = new System.Windows.Forms.Button();
            this.btnedit1 = new System.Windows.Forms.Button();
            this.btnsave1 = new System.Windows.Forms.Button();
            this.txtcode1 = new System.Windows.Forms.TextBox();
            this.txtdesignation1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datacatmedicament = new System.Windows.Forms.DataGridView();
            this.dgid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btndelete2 = new System.Windows.Forms.Button();
            this.btnedit2 = new System.Windows.Forms.Button();
            this.btnsave2 = new System.Windows.Forms.Button();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.txtdesignation2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datacataliment = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtcode3 = new System.Windows.Forms.TextBox();
            this.txtrecherche3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndelete3 = new System.Windows.Forms.Button();
            this.btnedit3 = new System.Windows.Forms.Button();
            this.btnsave3 = new System.Windows.Forms.Button();
            this.txtdesignation3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datacatpoule = new System.Windows.Forms.DataGridView();
            this.dgid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdesignation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacatmedicament)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacataliment)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacatpoule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrecherche1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btndelete1);
            this.groupBox1.Controls.Add(this.btnedit1);
            this.groupBox1.Controls.Add(this.btnsave1);
            this.groupBox1.Controls.Add(this.txtcode1);
            this.groupBox1.Controls.Add(this.txtdesignation1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datacatmedicament);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorie Medicament";
            // 
            // txtrecherche1
            // 
            this.txtrecherche1.Location = new System.Drawing.Point(276, 154);
            this.txtrecherche1.Multiline = true;
            this.txtrecherche1.Name = "txtrecherche1";
            this.txtrecherche1.Size = new System.Drawing.Size(175, 25);
            this.txtrecherche1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "recherche";
            // 
            // btndelete1
            // 
            this.btndelete1.BackColor = System.Drawing.Color.Red;
            this.btndelete1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete1.ForeColor = System.Drawing.Color.White;
            this.btndelete1.Location = new System.Drawing.Point(348, 114);
            this.btndelete1.Name = "btndelete1";
            this.btndelete1.Size = new System.Drawing.Size(103, 34);
            this.btndelete1.TabIndex = 6;
            this.btndelete1.Text = "Delete";
            this.btndelete1.UseVisualStyleBackColor = false;
            this.btndelete1.Click += new System.EventHandler(this.btndelete1_Click);
            // 
            // btnedit1
            // 
            this.btnedit1.BackColor = System.Drawing.Color.Brown;
            this.btnedit1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit1.ForeColor = System.Drawing.Color.White;
            this.btnedit1.Location = new System.Drawing.Point(206, 114);
            this.btnedit1.Name = "btnedit1";
            this.btnedit1.Size = new System.Drawing.Size(103, 34);
            this.btnedit1.TabIndex = 5;
            this.btnedit1.Text = "Edit";
            this.btnedit1.UseVisualStyleBackColor = false;
            this.btnedit1.Click += new System.EventHandler(this.btnedit1_Click);
            // 
            // btnsave1
            // 
            this.btnsave1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsave1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave1.ForeColor = System.Drawing.Color.White;
            this.btnsave1.Location = new System.Drawing.Point(69, 114);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Size = new System.Drawing.Size(102, 34);
            this.btnsave1.TabIndex = 4;
            this.btnsave1.Text = "Save";
            this.btnsave1.UseVisualStyleBackColor = false;
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // txtcode1
            // 
            this.txtcode1.Location = new System.Drawing.Point(377, 19);
            this.txtcode1.Multiline = true;
            this.txtcode1.Name = "txtcode1";
            this.txtcode1.Size = new System.Drawing.Size(74, 36);
            this.txtcode1.TabIndex = 3;
            this.txtcode1.Visible = false;
            // 
            // txtdesignation1
            // 
            this.txtdesignation1.Location = new System.Drawing.Point(40, 57);
            this.txtdesignation1.Multiline = true;
            this.txtdesignation1.Name = "txtdesignation1";
            this.txtdesignation1.Size = new System.Drawing.Size(199, 36);
            this.txtdesignation1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designation";
            // 
            // datacatmedicament
            // 
            this.datacatmedicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacatmedicament.BackgroundColor = System.Drawing.Color.White;
            this.datacatmedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacatmedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid1,
            this.dgdesignation1});
            this.datacatmedicament.Location = new System.Drawing.Point(22, 182);
            this.datacatmedicament.Name = "datacatmedicament";
            this.datacatmedicament.Size = new System.Drawing.Size(468, 150);
            this.datacatmedicament.TabIndex = 0;
            this.datacatmedicament.DoubleClick += new System.EventHandler(this.datacatmedicament_DoubleClick);
            // 
            // dgid1
            // 
            this.dgid1.DataPropertyName = "idcategorie";
            this.dgid1.HeaderText = "id";
            this.dgid1.Name = "dgid1";
            // 
            // dgdesignation1
            // 
            this.dgdesignation1.DataPropertyName = "designation";
            this.dgdesignation1.HeaderText = "designation";
            this.dgdesignation1.Name = "dgdesignation1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtrecherche);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btndelete2);
            this.groupBox2.Controls.Add(this.btnedit2);
            this.groupBox2.Controls.Add(this.btnsave2);
            this.groupBox2.Controls.Add(this.txtcode2);
            this.groupBox2.Controls.Add(this.txtdesignation2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.datacataliment);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(569, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorie Aliment";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(272, 154);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(175, 25);
            this.txtrecherche.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "recherche";
            // 
            // btndelete2
            // 
            this.btndelete2.BackColor = System.Drawing.Color.Red;
            this.btndelete2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete2.ForeColor = System.Drawing.Color.White;
            this.btndelete2.Location = new System.Drawing.Point(344, 114);
            this.btndelete2.Name = "btndelete2";
            this.btndelete2.Size = new System.Drawing.Size(103, 34);
            this.btndelete2.TabIndex = 14;
            this.btndelete2.Text = "Delete";
            this.btndelete2.UseVisualStyleBackColor = false;
            this.btndelete2.Click += new System.EventHandler(this.btndelete2_Click);
            // 
            // btnedit2
            // 
            this.btnedit2.BackColor = System.Drawing.Color.Brown;
            this.btnedit2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit2.ForeColor = System.Drawing.Color.White;
            this.btnedit2.Location = new System.Drawing.Point(202, 114);
            this.btnedit2.Name = "btnedit2";
            this.btnedit2.Size = new System.Drawing.Size(103, 34);
            this.btnedit2.TabIndex = 13;
            this.btnedit2.Text = "Edit";
            this.btnedit2.UseVisualStyleBackColor = false;
            this.btnedit2.Click += new System.EventHandler(this.btnedit2_Click);
            // 
            // btnsave2
            // 
            this.btnsave2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsave2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave2.ForeColor = System.Drawing.Color.White;
            this.btnsave2.Location = new System.Drawing.Point(65, 114);
            this.btnsave2.Name = "btnsave2";
            this.btnsave2.Size = new System.Drawing.Size(102, 34);
            this.btnsave2.TabIndex = 12;
            this.btnsave2.Text = "Save";
            this.btnsave2.UseVisualStyleBackColor = false;
            this.btnsave2.Click += new System.EventHandler(this.btnsave2_Click);
            // 
            // txtcode2
            // 
            this.txtcode2.Location = new System.Drawing.Point(373, 19);
            this.txtcode2.Multiline = true;
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.Size = new System.Drawing.Size(74, 36);
            this.txtcode2.TabIndex = 11;
            this.txtcode2.Visible = false;
            // 
            // txtdesignation2
            // 
            this.txtdesignation2.Location = new System.Drawing.Point(36, 57);
            this.txtdesignation2.Multiline = true;
            this.txtdesignation2.Name = "txtdesignation2";
            this.txtdesignation2.Size = new System.Drawing.Size(199, 36);
            this.txtdesignation2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Designation";
            // 
            // datacataliment
            // 
            this.datacataliment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacataliment.BackgroundColor = System.Drawing.Color.White;
            this.datacataliment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacataliment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid2,
            this.dgdesignation2});
            this.datacataliment.Location = new System.Drawing.Point(20, 182);
            this.datacataliment.Name = "datacataliment";
            this.datacataliment.Size = new System.Drawing.Size(486, 150);
            this.datacataliment.TabIndex = 1;
            this.datacataliment.DoubleClick += new System.EventHandler(this.datacataliment_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtcode3);
            this.groupBox3.Controls.Add(this.txtrecherche3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btndelete3);
            this.groupBox3.Controls.Add(this.btnedit3);
            this.groupBox3.Controls.Add(this.btnsave3);
            this.groupBox3.Controls.Add(this.txtdesignation3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.datacatpoule);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(90, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(974, 241);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categorie Poule";
            // 
            // txtcode3
            // 
            this.txtcode3.Location = new System.Drawing.Point(310, 49);
            this.txtcode3.Multiline = true;
            this.txtcode3.Name = "txtcode3";
            this.txtcode3.Size = new System.Drawing.Size(74, 36);
            this.txtcode3.TabIndex = 14;
            this.txtcode3.Visible = false;
            // 
            // txtrecherche3
            // 
            this.txtrecherche3.Location = new System.Drawing.Point(771, 18);
            this.txtrecherche3.Multiline = true;
            this.txtrecherche3.Name = "txtrecherche3";
            this.txtrecherche3.Size = new System.Drawing.Size(175, 25);
            this.txtrecherche3.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "recherche";
            // 
            // btndelete3
            // 
            this.btndelete3.BackColor = System.Drawing.Color.Red;
            this.btndelete3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete3.ForeColor = System.Drawing.Color.White;
            this.btndelete3.Location = new System.Drawing.Point(301, 151);
            this.btndelete3.Name = "btndelete3";
            this.btndelete3.Size = new System.Drawing.Size(103, 34);
            this.btndelete3.TabIndex = 11;
            this.btndelete3.Text = "Delete";
            this.btndelete3.UseVisualStyleBackColor = false;
            this.btndelete3.Click += new System.EventHandler(this.btndelete3_Click);
            // 
            // btnedit3
            // 
            this.btnedit3.BackColor = System.Drawing.Color.DarkRed;
            this.btnedit3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit3.ForeColor = System.Drawing.Color.White;
            this.btnedit3.Location = new System.Drawing.Point(159, 151);
            this.btnedit3.Name = "btnedit3";
            this.btnedit3.Size = new System.Drawing.Size(103, 34);
            this.btnedit3.TabIndex = 10;
            this.btnedit3.Text = "Edit";
            this.btnedit3.UseVisualStyleBackColor = false;
            this.btnedit3.Click += new System.EventHandler(this.btnedit3_Click);
            // 
            // btnsave3
            // 
            this.btnsave3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnsave3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave3.ForeColor = System.Drawing.Color.White;
            this.btnsave3.Location = new System.Drawing.Point(22, 151);
            this.btnsave3.Name = "btnsave3";
            this.btnsave3.Size = new System.Drawing.Size(102, 34);
            this.btnsave3.TabIndex = 9;
            this.btnsave3.Text = "Save";
            this.btnsave3.UseVisualStyleBackColor = false;
            this.btnsave3.Click += new System.EventHandler(this.btnsave3_Click);
            // 
            // txtdesignation3
            // 
            this.txtdesignation3.Location = new System.Drawing.Point(22, 94);
            this.txtdesignation3.Multiline = true;
            this.txtdesignation3.Name = "txtdesignation3";
            this.txtdesignation3.Size = new System.Drawing.Size(199, 36);
            this.txtdesignation3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Designation";
            // 
            // datacatpoule
            // 
            this.datacatpoule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacatpoule.BackgroundColor = System.Drawing.Color.White;
            this.datacatpoule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacatpoule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid3,
            this.dgdesignation3});
            this.datacatpoule.Location = new System.Drawing.Point(420, 49);
            this.datacatpoule.Name = "datacatpoule";
            this.datacatpoule.Size = new System.Drawing.Size(528, 174);
            this.datacatpoule.TabIndex = 1;
            this.datacatpoule.DoubleClick += new System.EventHandler(this.datacatpoule_DoubleClick);
            // 
            // dgid3
            // 
            this.dgid3.DataPropertyName = "idcatepoule";
            this.dgid3.HeaderText = "id";
            this.dgid3.Name = "dgid3";
            // 
            // dgdesignation3
            // 
            this.dgdesignation3.DataPropertyName = "designation";
            this.dgdesignation3.HeaderText = "designation";
            this.dgdesignation3.Name = "dgdesignation3";
            // 
            // dgid2
            // 
            this.dgid2.DataPropertyName = "idcatealiment";
            this.dgid2.HeaderText = "id";
            this.dgid2.Name = "dgid2";
            // 
            // dgdesignation2
            // 
            this.dgdesignation2.DataPropertyName = "designation";
            this.dgdesignation2.HeaderText = "designation";
            this.dgdesignation2.Name = "dgdesignation2";
            // 
            // UserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserCategories";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserCategories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacatmedicament)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacataliment)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacatpoule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrecherche1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndelete1;
        private System.Windows.Forms.Button btnedit1;
        private System.Windows.Forms.Button btnsave1;
        private System.Windows.Forms.TextBox txtcode1;
        private System.Windows.Forms.TextBox txtdesignation1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datacatmedicament;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndelete2;
        private System.Windows.Forms.Button btnedit2;
        private System.Windows.Forms.Button btnsave2;
        private System.Windows.Forms.TextBox txtcode2;
        private System.Windows.Forms.TextBox txtdesignation2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView datacataliment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtcode3;
        private System.Windows.Forms.TextBox txtrecherche3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndelete3;
        private System.Windows.Forms.Button btnedit3;
        private System.Windows.Forms.Button btnsave3;
        private System.Windows.Forms.TextBox txtdesignation3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView datacatpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdesignation2;
    }
}
