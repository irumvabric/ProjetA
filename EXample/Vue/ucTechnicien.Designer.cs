namespace Vue
{
    partial class ucTechnicien
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxGenre = new System.Windows.Forms.GroupBox();
            this.radHomme = new System.Windows.Forms.RadioButton();
            this.radFemme = new System.Windows.Forms.RadioButton();
            this.tbxMatricule = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateEmbouche = new System.Windows.Forms.DateTimePicker();
            this.cbxNationalite = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateNaiss";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DateEmbouche";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telephone";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nationalite";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // gbxGenre
            // 
            this.gbxGenre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbxGenre.Controls.Add(this.radFemme);
            this.gbxGenre.Controls.Add(this.radHomme);
            this.gbxGenre.Location = new System.Drawing.Point(625, 29);
            this.gbxGenre.Name = "gbxGenre";
            this.gbxGenre.Size = new System.Drawing.Size(200, 100);
            this.gbxGenre.TabIndex = 10;
            this.gbxGenre.TabStop = false;
            this.gbxGenre.Text = "Genre";
            this.gbxGenre.Enter += new System.EventHandler(this.gbxGenre_Enter);
            // 
            // radHomme
            // 
            this.radHomme.AutoSize = true;
            this.radHomme.Location = new System.Drawing.Point(30, 30);
            this.radHomme.Name = "radHomme";
            this.radHomme.Size = new System.Drawing.Size(61, 17);
            this.radHomme.TabIndex = 0;
            this.radHomme.TabStop = true;
            this.radHomme.Text = "Homme";
            this.radHomme.UseVisualStyleBackColor = true;
            this.radHomme.CheckedChanged += new System.EventHandler(this.radHomme_CheckedChanged);
            // 
            // radFemme
            // 
            this.radFemme.AutoSize = true;
            this.radFemme.Location = new System.Drawing.Point(31, 71);
            this.radFemme.Name = "radFemme";
            this.radFemme.Size = new System.Drawing.Size(59, 17);
            this.radFemme.TabIndex = 1;
            this.radFemme.TabStop = true;
            this.radFemme.Text = "Femme";
            this.radFemme.UseVisualStyleBackColor = true;
            this.radFemme.CheckedChanged += new System.EventHandler(this.radFemme_CheckedChanged);
            // 
            // tbxMatricule
            // 
            this.tbxMatricule.Location = new System.Drawing.Point(113, 29);
            this.tbxMatricule.Name = "tbxMatricule";
            this.tbxMatricule.Size = new System.Drawing.Size(200, 20);
            this.tbxMatricule.TabIndex = 11;
            this.tbxMatricule.TextChanged += new System.EventHandler(this.tbxMatricule_TextChanged);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(113, 80);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(200, 20);
            this.tbxNom.TabIndex = 12;
            this.tbxNom.TextChanged += new System.EventHandler(this.tbxNom_TextChanged);
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(436, 77);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(157, 20);
            this.tbxTelephone.TabIndex = 13;
            this.tbxTelephone.TextChanged += new System.EventHandler(this.tbxTelephone_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(436, 137);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(157, 20);
            this.tbxEmail.TabIndex = 14;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // dateTimePickerDateNaiss
            // 
            this.dateTimePickerDateNaiss.Location = new System.Drawing.Point(113, 126);
            this.dateTimePickerDateNaiss.Name = "dateTimePickerDateNaiss";
            this.dateTimePickerDateNaiss.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateNaiss.TabIndex = 15;
            this.dateTimePickerDateNaiss.ValueChanged += new System.EventHandler(this.dateTimePickerDateNaiss_ValueChanged);
            // 
            // dateTimePickerDateEmbouche
            // 
            this.dateTimePickerDateEmbouche.Location = new System.Drawing.Point(113, 184);
            this.dateTimePickerDateEmbouche.Name = "dateTimePickerDateEmbouche";
            this.dateTimePickerDateEmbouche.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateEmbouche.TabIndex = 16;
            this.dateTimePickerDateEmbouche.ValueChanged += new System.EventHandler(this.dateTimePickerDateEmbouche_ValueChanged);
            // 
            // cbxNationalite
            // 
            this.cbxNationalite.FormattingEnabled = true;
            this.cbxNationalite.Items.AddRange(new object[] {
            "Burundi",
            "RDC",
            "Rwanda",
            "Ouganda",
            "Kenya",
            "Tanzanie"});
            this.cbxNationalite.Location = new System.Drawing.Point(436, 26);
            this.cbxNationalite.Name = "cbxNationalite";
            this.cbxNationalite.Size = new System.Drawing.Size(157, 21);
            this.cbxNationalite.TabIndex = 17;
            this.cbxNationalite.SelectedIndexChanged += new System.EventHandler(this.cbxNationalite_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(287, 245);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 19;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(436, 245);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(567, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(793, 185);
            this.dataGridView1.TabIndex = 22;
            // 
            // ucTechnicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxNationalite);
            this.Controls.Add(this.dateTimePickerDateEmbouche);
            this.Controls.Add(this.dateTimePickerDateNaiss);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxMatricule);
            this.Controls.Add(this.gbxGenre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucTechnicien";
            this.Size = new System.Drawing.Size(907, 646);
            this.Load += new System.EventHandler(this.ucTechnicien_Load);
            this.gbxGenre.ResumeLayout(false);
            this.gbxGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxGenre;
        private System.Windows.Forms.RadioButton radFemme;
        private System.Windows.Forms.RadioButton radHomme;
        private System.Windows.Forms.TextBox tbxMatricule;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateNaiss;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateEmbouche;
        private System.Windows.Forms.ComboBox cbxNationalite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
