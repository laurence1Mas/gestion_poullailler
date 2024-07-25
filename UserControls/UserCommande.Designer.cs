namespace gestion_poullailler.UserControls
{
    partial class UserCommande
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
            this.txtrecherchec = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.datacommande = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btndeletec = new System.Windows.Forms.Button();
            this.btneditc = new System.Windows.Forms.Button();
            this.btnsavec = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtprixu = new System.Windows.Forms.TextBox();
            this.cmbclient = new System.Windows.Forms.ComboBox();
            this.datecom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbpoule = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnprintfiche = new System.Windows.Forms.Button();
            this.btnprintc = new System.Windows.Forms.Button();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpoule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgquantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datacommande)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherchec
            // 
            this.txtrecherchec.Location = new System.Drawing.Point(849, 364);
            this.txtrecherchec.Multiline = true;
            this.txtrecherchec.Name = "txtrecherchec";
            this.txtrecherchec.Size = new System.Drawing.Size(200, 34);
            this.txtrecherchec.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(748, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "Recherche";
            // 
            // datacommande
            // 
            this.datacommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datacommande.BackgroundColor = System.Drawing.Color.White;
            this.datacommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgclient,
            this.dgpoule,
            this.dgquantite,
            this.dgprix,
            this.dgdate});
            this.datacommande.Location = new System.Drawing.Point(45, 404);
            this.datacommande.Name = "datacommande";
            this.datacommande.Size = new System.Drawing.Size(1055, 212);
            this.datacommande.TabIndex = 23;
            this.datacommande.DoubleClick += new System.EventHandler(this.datacommande_DoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btndeletec);
            this.groupBox6.Controls.Add(this.btneditc);
            this.groupBox6.Controls.Add(this.btnsavec);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(128, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(656, 76);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btndeletec
            // 
            this.btndeletec.BackColor = System.Drawing.Color.Red;
            this.btndeletec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletec.ForeColor = System.Drawing.Color.White;
            this.btndeletec.Location = new System.Drawing.Point(465, 29);
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
            this.btneditc.Location = new System.Drawing.Point(273, 26);
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
            this.btnsavec.Location = new System.Drawing.Point(98, 26);
            this.btnsavec.Name = "btnsavec";
            this.btnsavec.Size = new System.Drawing.Size(102, 34);
            this.btnsavec.TabIndex = 12;
            this.btnsavec.Text = "Save";
            this.btnsavec.UseVisualStyleBackColor = false;
            this.btnsavec.Click += new System.EventHandler(this.btnsavec_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcode);
            this.groupBox2.Controls.Add(this.txtprixu);
            this.groupBox2.Controls.Add(this.cmbclient);
            this.groupBox2.Controls.Add(this.datecom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbpoule);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtquantite);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 220);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enregistrement Commandes";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(873, 13);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(100, 27);
            this.txtcode.TabIndex = 18;
            this.txtcode.Visible = false;
            // 
            // txtprixu
            // 
            this.txtprixu.Location = new System.Drawing.Point(376, 145);
            this.txtprixu.Name = "txtprixu";
            this.txtprixu.Size = new System.Drawing.Size(266, 27);
            this.txtprixu.TabIndex = 17;
            // 
            // cmbclient
            // 
            this.cmbclient.FormattingEnabled = true;
            this.cmbclient.Location = new System.Drawing.Point(376, 71);
            this.cmbclient.Name = "cmbclient";
            this.cmbclient.Size = new System.Drawing.Size(266, 29);
            this.cmbclient.TabIndex = 16;
            // 
            // datecom
            // 
            this.datecom.Location = new System.Drawing.Point(682, 73);
            this.datecom.Name = "datecom";
            this.datecom.Size = new System.Drawing.Size(249, 27);
            this.datecom.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // cmbpoule
            // 
            this.cmbpoule.FormattingEnabled = true;
            this.cmbpoule.Location = new System.Drawing.Point(58, 71);
            this.cmbpoule.Name = "cmbpoule";
            this.cmbpoule.Size = new System.Drawing.Size(261, 29);
            this.cmbpoule.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Prix Unitaire";
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(56, 145);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(263, 27);
            this.txtquantite.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Clients";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 21);
            this.label10.TabIndex = 6;
            this.label10.Text = "Poules";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnprintfiche);
            this.groupBox5.Controls.Add(this.btnprintc);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(798, 277);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 73);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rapport";
            // 
            // btnprintfiche
            // 
            this.btnprintfiche.BackColor = System.Drawing.Color.LightGray;
            this.btnprintfiche.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintfiche.ForeColor = System.Drawing.Color.White;
            this.btnprintfiche.Location = new System.Drawing.Point(134, 26);
            this.btnprintfiche.Name = "btnprintfiche";
            this.btnprintfiche.Size = new System.Drawing.Size(97, 34);
            this.btnprintfiche.TabIndex = 14;
            this.btnprintfiche.Text = "Fiche";
            this.btnprintfiche.UseVisualStyleBackColor = false;
            this.btnprintfiche.Click += new System.EventHandler(this.btnprintfiche_Click);
            // 
            // btnprintc
            // 
            this.btnprintc.BackColor = System.Drawing.Color.LightGray;
            this.btnprintc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintc.ForeColor = System.Drawing.Color.White;
            this.btnprintc.Location = new System.Drawing.Point(12, 26);
            this.btnprintc.Name = "btnprintc";
            this.btnprintc.Size = new System.Drawing.Size(97, 34);
            this.btnprintc.TabIndex = 13;
            this.btnprintc.Text = "Print";
            this.btnprintc.UseVisualStyleBackColor = false;
            this.btnprintc.Click += new System.EventHandler(this.btnprintc_Click);
            // 
            // dgid
            // 
            this.dgid.DataPropertyName = "codecommande";
            this.dgid.HeaderText = "num";
            this.dgid.Name = "dgid";
            // 
            // dgclient
            // 
            this.dgclient.DataPropertyName = "client";
            this.dgclient.HeaderText = "client";
            this.dgclient.Name = "dgclient";
            // 
            // dgpoule
            // 
            this.dgpoule.DataPropertyName = "poule";
            this.dgpoule.HeaderText = "poule";
            this.dgpoule.Name = "dgpoule";
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
            this.dgprix.HeaderText = "prixu";
            this.dgprix.Name = "dgprix";
            // 
            // dgdate
            // 
            this.dgdate.DataPropertyName = "datecommande";
            this.dgdate.HeaderText = "date";
            this.dgdate.Name = "dgdate";
            // 
            // UserCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtrecherchec);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.datacommande);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserCommande";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datacommande)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherchec;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView datacommande;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btndeletec;
        private System.Windows.Forms.Button btneditc;
        private System.Windows.Forms.Button btnsavec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtprixu;
        private System.Windows.Forms.ComboBox cmbclient;
        private System.Windows.Forms.DateTimePicker datecom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbpoule;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnprintc;
        private System.Windows.Forms.Button btnprintfiche;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpoule;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgquantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdate;
    }
}
