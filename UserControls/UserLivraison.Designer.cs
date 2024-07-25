namespace gestion_poullailler.UserControls
{
    partial class UserLivraison
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
            this.btnprint = new System.Windows.Forms.Button();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.datalivraison = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtlieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtprixu = new System.Windows.Forms.TextBox();
            this.cmbagent = new System.Windows.Forms.ComboBox();
            this.datelivr = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcommande = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgagent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dglieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalivraison)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprint);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(802, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 73);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport";
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.LightGray;
            this.btnprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.White;
            this.btnprint.Location = new System.Drawing.Point(12, 26);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(97, 34);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(853, 359);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(200, 34);
            this.txtrecherche.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(752, 372);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 30;
            this.label13.Text = "Recherche";
            // 
            // datalivraison
            // 
            this.datalivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datalivraison.BackgroundColor = System.Drawing.Color.White;
            this.datalivraison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalivraison.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgcommande,
            this.dgagent,
            this.dgquantite,
            this.dgprix,
            this.dglieu});
            this.datalivraison.Location = new System.Drawing.Point(49, 399);
            this.datalivraison.Name = "datalivraison";
            this.datalivraison.Size = new System.Drawing.Size(1055, 212);
            this.datalivraison.TabIndex = 29;
            this.datalivraison.DoubleClick += new System.EventHandler(this.datalivraison_DoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndelete);
            this.groupBox6.Controls.Add(this.btnedit);
            this.groupBox6.Controls.Add(this.btnsave);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(124, 270);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(656, 76);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(465, 29);
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
            this.btnedit.Location = new System.Drawing.Point(273, 26);
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
            this.btnsave.Location = new System.Drawing.Point(98, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(102, 34);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtlieu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.txtprixu);
            this.groupBox2.Controls.Add(this.cmbagent);
            this.groupBox2.Controls.Add(this.datelivr);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbcommande);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtquantite);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(49, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 228);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Livraison";
            // 
            // txtlieu
            // 
            this.txtlieu.Location = new System.Drawing.Point(753, 69);
            this.txtlieu.Name = "txtlieu";
            this.txtlieu.Size = new System.Drawing.Size(266, 27);
            this.txtlieu.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lieu";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(932, 26);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 27);
            this.txtcode.TabIndex = 18;
            this.txtcode.Visible = false;
            // 
            // txtprixu
            // 
            this.txtprixu.Location = new System.Drawing.Point(428, 141);
            this.txtprixu.Name = "txtprixu";
            this.txtprixu.Size = new System.Drawing.Size(266, 27);
            this.txtprixu.TabIndex = 17;
            // 
            // cmbagent
            // 
            this.cmbagent.FormattingEnabled = true;
            this.cmbagent.Location = new System.Drawing.Point(428, 67);
            this.cmbagent.Name = "cmbagent";
            this.cmbagent.Size = new System.Drawing.Size(266, 29);
            this.cmbagent.TabIndex = 16;
            // 
            // datelivr
            // 
            this.datelivr.Location = new System.Drawing.Point(753, 144);
            this.datelivr.Name = "datelivr";
            this.datelivr.Size = new System.Drawing.Size(263, 27);
            this.datelivr.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // cmbcommande
            // 
            this.cmbcommande.FormattingEnabled = true;
            this.cmbcommande.Location = new System.Drawing.Point(90, 70);
            this.cmbcommande.Name = "cmbcommande";
            this.cmbcommande.Size = new System.Drawing.Size(261, 29);
            this.cmbcommande.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Prix Unitaire";
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(88, 144);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(263, 27);
            this.txtquantite.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Agents";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Commande";
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codelivraison";
            this.dgid.HeaderText = "num";
            this.dgid.Name = "dgid";
            // 
            // dgcommande
            // 
            this.dgcommande.DataPropertyName = "commande";
            this.dgcommande.HeaderText = "commande";
            this.dgcommande.Name = "dgcommande";
            // 
            // dgagent
            // 
            this.dgagent.DataPropertyName = "agent";
            this.dgagent.HeaderText = "agent";
            this.dgagent.Name = "dgagent";
            // 
            // dgquantite
            // 
            this.dgquantite.DataPropertyName = "quantite";
            this.dgquantite.HeaderText = "quantite";
            this.dgquantite.Name = "dgquantite";
            // 
            // dgprix
            // 
            this.dgprix.DataPropertyName = "prixu";
            this.dgprix.HeaderText = "prix";
            this.dgprix.Name = "dgprix";
            // 
            // dglieu
            // 
            this.dglieu.DataPropertyName = "lieulivraison";
            this.dglieu.HeaderText = "lieu";
            this.dglieu.Name = "dglieu";
            // 
            // UserLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.datalivraison);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserLivraison";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserLivraison_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datalivraison)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datalivraison;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtlieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtprixu;
        private System.Windows.Forms.ComboBox cmbagent;
        private System.Windows.Forms.DateTimePicker datelivr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcommande;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgagent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dglieu;
    }
}
