namespace WindowsFormsApp6
{
    partial class FormTumSarkilar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwSarkilar = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbFavori = new System.Windows.Forms.CheckBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSanatci = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSarki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSarkilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSarkilar
            // 
            this.dgwSarkilar.AllowUserToAddRows = false;
            this.dgwSarkilar.AllowUserToDeleteRows = false;
            this.dgwSarkilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSarkilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSarkilar.Location = new System.Drawing.Point(12, 210);
            this.dgwSarkilar.Name = "dgwSarkilar";
            this.dgwSarkilar.ReadOnly = true;
            this.dgwSarkilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwSarkilar.Size = new System.Drawing.Size(854, 270);
            this.dgwSarkilar.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Image = global::WindowsFormsApp6.Properties.Resources._001_delete;
            this.btnSil.Location = new System.Drawing.Point(798, 35);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 60);
            this.btnSil.TabIndex = 1;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbFavori
            // 
            this.cbFavori.AutoSize = true;
            this.cbFavori.Location = new System.Drawing.Point(111, 170);
            this.cbFavori.Name = "cbFavori";
            this.cbFavori.Size = new System.Drawing.Size(55, 17);
            this.cbFavori.TabIndex = 28;
            this.cbFavori.Text = "Favori";
            this.cbFavori.UseVisualStyleBackColor = true;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(372, 129);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(129, 20);
            this.dtTarih.TabIndex = 27;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(372, 56);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(129, 21);
            this.cmbTur.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Eklenme Tarihi";
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(372, 93);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(129, 20);
            this.txtSure.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Süresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Türü:";
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(111, 127);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(129, 20);
            this.txtYil.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yılı:";
            // 
            // txtSanatci
            // 
            this.txtSanatci.Location = new System.Drawing.Point(111, 82);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(129, 20);
            this.txtSanatci.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sanatçı Adı:";
            // 
            // txtSarki
            // 
            this.txtSarki.Location = new System.Drawing.Point(111, 38);
            this.txtSarki.Name = "txtSarki";
            this.txtSarki.Size = new System.Drawing.Size(129, 20);
            this.txtSarki.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Şarkı Adı:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::WindowsFormsApp6.Properties.Resources._007_updating;
            this.btnGuncelle.Location = new System.Drawing.Point(798, 106);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(68, 60);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormTumSarkilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 493);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cbFavori);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSarki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgwSarkilar);
            this.Name = "FormTumSarkilar";
            this.Text = "FormTumSarkilar";
            this.Load += new System.EventHandler(this.FormTumSarkilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSarkilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSarkilar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.CheckBox cbFavori;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSanatci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSarki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
    }
}