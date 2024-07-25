namespace gestion_poullailler.UserControls
{
    partial class UserClient
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
            this.label12 = new System.Windows.Forms.Label();
            this.dataclient = new System.Windows.Forms.DataGridView();
            this.dgidc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgpostnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggenrec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelephonec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgadressec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgmailc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodeclients = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtadresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttelephone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbgenre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpostnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataclient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrecherche
            // 
            this.txtrecherche.Location = new System.Drawing.Point(164, 310);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(216, 34);
            this.txtrecherche.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "Recherche";
            // 
            // dataclient
            // 
            this.dataclient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataclient.BackgroundColor = System.Drawing.Color.White;
            this.dataclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataclient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgidc,
            this.dgnom,
            this.dgpostnom,
            this.dgprenom,
            this.dggenrec,
            this.dgtelephonec,
            this.dgadressec,
            this.dgmailc});
            this.dataclient.Location = new System.Drawing.Point(38, 353);
            this.dataclient.Name = "dataclient";
            this.dataclient.Size = new System.Drawing.Size(1086, 262);
            this.dataclient.TabIndex = 16;
            this.dataclient.DoubleClick += new System.EventHandler(this.dataclient_DoubleClick);
            // 
            // dgidc
            // 
            this.dgidc.DataPropertyName = "codeclient";
            this.dgidc.HeaderText = "id";
            this.dgidc.Name = "dgidc";
            // 
            // dgnom
            // 
            this.dgnom.DataPropertyName = "nom";
            this.dgnom.HeaderText = "nom";
            this.dgnom.Name = "dgnom";
            // 
            // dgpostnom
            // 
            this.dgpostnom.DataPropertyName = "postnom";
            this.dgpostnom.HeaderText = "postnom";
            this.dgpostnom.Name = "dgpostnom";
            // 
            // dgprenom
            // 
            this.dgprenom.DataPropertyName = "prenom";
            this.dgprenom.HeaderText = "prenom";
            this.dgprenom.Name = "dgprenom";
            // 
            // dggenrec
            // 
            this.dggenrec.DataPropertyName = "genre";
            this.dggenrec.HeaderText = "genre";
            this.dggenrec.Name = "dggenrec";
            // 
            // dgtelephonec
            // 
            this.dgtelephonec.DataPropertyName = "telephone";
            this.dgtelephonec.HeaderText = "telephone";
            this.dgtelephonec.Name = "dgtelephonec";
            // 
            // dgadressec
            // 
            this.dgadressec.DataPropertyName = "adresse";
            this.dgadressec.HeaderText = "adresse";
            this.dgadressec.Name = "dgadressec";
            // 
            // dgmailc
            // 
            this.dgmailc.DataPropertyName = "mail";
            this.dgmailc.HeaderText = "mail";
            this.dgmailc.Name = "dgmailc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnprint);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(971, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(136, 73);
            this.groupBox3.TabIndex = 15;
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
            this.groupBox4.Location = new System.Drawing.Point(941, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 231);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(29, 155);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(136, 47);
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
            this.btnedit.Location = new System.Drawing.Point(30, 90);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(136, 45);
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
            this.btnsave.Location = new System.Drawing.Point(31, 26);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 44);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodeclients);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtadresse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttelephone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbgenre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtprenom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpostnom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 231);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement Clients";
            // 
            // txtcodeclients
            // 
            this.txtcodeclients.Location = new System.Drawing.Point(778, 14);
            this.txtcodeclients.Name = "txtcodeclients";
            this.txtcodeclients.Size = new System.Drawing.Size(100, 27);
            this.txtcodeclients.TabIndex = 14;
            this.txtcodeclients.Visible = false;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(41, 187);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(208, 27);
            this.txtmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail";
            // 
            // txtadresse
            // 
            this.txtadresse.Location = new System.Drawing.Point(591, 127);
            this.txtadresse.Name = "txtadresse";
            this.txtadresse.Size = new System.Drawing.Size(233, 27);
            this.txtadresse.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adresse";
            // 
            // txttelephone
            // 
            this.txttelephone.Location = new System.Drawing.Point(313, 129);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(215, 27);
            this.txttelephone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telephone";
            // 
            // cmbgenre
            // 
            this.cmbgenre.FormattingEnabled = true;
            this.cmbgenre.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cmbgenre.Location = new System.Drawing.Point(41, 125);
            this.cmbgenre.Name = "cmbgenre";
            this.cmbgenre.Size = new System.Drawing.Size(208, 29);
            this.cmbgenre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genre";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(591, 57);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(233, 27);
            this.txtprenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "PreNom";
            // 
            // txtpostnom
            // 
            this.txtpostnom.Location = new System.Drawing.Point(313, 59);
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.Size = new System.Drawing.Size(215, 27);
            this.txtpostnom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PostNom";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(41, 59);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(208, 27);
            this.txtnom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // UserClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataclient);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserClient";
            this.Size = new System.Drawing.Size(1152, 643);
            this.Load += new System.EventHandler(this.UserClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataclient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgidc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgpostnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggenrec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelephonec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgadressec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgmailc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodeclients;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtadresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttelephone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbgenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpostnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
    }
}
