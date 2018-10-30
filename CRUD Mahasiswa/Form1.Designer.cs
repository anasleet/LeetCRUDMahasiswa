namespace CRUD_Mahasiswa
{
    partial class Form1
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
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTampilkanData = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskNpm1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNama1 = new System.Windows.Forms.TextBox();
            this.txtAngkatan1 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstMahasiswa = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mskNpm2 = new System.Windows.Forms.MaskedTextBox();
            this.txtNama2 = new System.Windows.Forms.TextBox();
            this.txtAngkatan2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCari1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskNpm3 = new System.Windows.Forms.MaskedTextBox();
            this.txtNama3 = new System.Windows.Forms.TextBox();
            this.txtAngkatan3 = new System.Windows.Forms.TextBox();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.btnTampilkanData.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTesKoneksi
            // 
            this.btnTesKoneksi.Location = new System.Drawing.Point(12, 12);
            this.btnTesKoneksi.Name = "btnTesKoneksi";
            this.btnTesKoneksi.Size = new System.Drawing.Size(105, 23);
            this.btnTesKoneksi.TabIndex = 0;
            this.btnTesKoneksi.Text = "Tes Koneksi";
            this.btnTesKoneksi.UseVisualStyleBackColor = true;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btnTampilkanData);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 296);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.txtAngkatan1);
            this.tabPage1.Controls.Add(this.txtNama1);
            this.tabPage1.Controls.Add(this.mskNpm1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Controls.Add(this.lstMahasiswa);
            this.btnTampilkanData.Controls.Add(this.button1);
            this.btnTampilkanData.Location = new System.Drawing.Point(4, 22);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Padding = new System.Windows.Forms.Padding(3);
            this.btnTampilkanData.Size = new System.Drawing.Size(331, 270);
            this.btnTampilkanData.TabIndex = 1;
            this.btnTampilkanData.Text = "Read";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCari1);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.txtAngkatan2);
            this.tabPage3.Controls.Add(this.txtNama2);
            this.tabPage3.Controls.Add(this.mskNpm2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(331, 270);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.btnCari2);
            this.tabPage4.Controls.Add(this.txtAngkatan3);
            this.tabPage4.Controls.Add(this.txtNama3);
            this.tabPage4.Controls.Add(this.mskNpm3);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(331, 270);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angkatan";
            // 
            // mskNpm1
            // 
            this.mskNpm1.Location = new System.Drawing.Point(101, 22);
            this.mskNpm1.Mask = "##.##.####";
            this.mskNpm1.Name = "mskNpm1";
            this.mskNpm1.Size = new System.Drawing.Size(100, 20);
            this.mskNpm1.TabIndex = 3;
            // 
            // txtNama1
            // 
            this.txtNama1.Location = new System.Drawing.Point(101, 52);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(201, 20);
            this.txtNama1.TabIndex = 4;
            // 
            // txtAngkatan1
            // 
            this.txtAngkatan1.Location = new System.Drawing.Point(101, 82);
            this.txtAngkatan1.Name = "txtAngkatan1";
            this.txtAngkatan1.Size = new System.Drawing.Size(100, 20);
            this.txtAngkatan1.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(41, 118);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tampilkan Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstMahasiswa
            // 
            this.lstMahasiswa.FormattingEnabled = true;
            this.lstMahasiswa.Location = new System.Drawing.Point(6, 35);
            this.lstMahasiswa.Name = "lstMahasiswa";
            this.lstMahasiswa.Size = new System.Drawing.Size(319, 225);
            this.lstMahasiswa.TabIndex = 1;
            this.lstMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lstMahasiswa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "NPM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Angkatan";
            // 
            // mskNpm2
            // 
            this.mskNpm2.Location = new System.Drawing.Point(93, 23);
            this.mskNpm2.Mask = "##.##.####";
            this.mskNpm2.Name = "mskNpm2";
            this.mskNpm2.Size = new System.Drawing.Size(100, 20);
            this.mskNpm2.TabIndex = 3;
            // 
            // txtNama2
            // 
            this.txtNama2.Location = new System.Drawing.Point(93, 58);
            this.txtNama2.Name = "txtNama2";
            this.txtNama2.Size = new System.Drawing.Size(171, 20);
            this.txtNama2.TabIndex = 4;
            // 
            // txtAngkatan2
            // 
            this.txtAngkatan2.Location = new System.Drawing.Point(93, 87);
            this.txtAngkatan2.Name = "txtAngkatan2";
            this.txtAngkatan2.Size = new System.Drawing.Size(102, 20);
            this.txtAngkatan2.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(34, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCari1
            // 
            this.btnCari1.Location = new System.Drawing.Point(199, 20);
            this.btnCari1.Name = "btnCari1";
            this.btnCari1.Size = new System.Drawing.Size(65, 23);
            this.btnCari1.TabIndex = 8;
            this.btnCari1.Text = "Cari";
            this.btnCari1.UseVisualStyleBackColor = true;
            this.btnCari1.Click += new System.EventHandler(this.btnCari1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "NPM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Angkatan";
            // 
            // mskNpm3
            // 
            this.mskNpm3.Location = new System.Drawing.Point(89, 36);
            this.mskNpm3.Mask = "##.##.####";
            this.mskNpm3.Name = "mskNpm3";
            this.mskNpm3.Size = new System.Drawing.Size(100, 20);
            this.mskNpm3.TabIndex = 3;
            // 
            // txtNama3
            // 
            this.txtNama3.Location = new System.Drawing.Point(89, 65);
            this.txtNama3.Name = "txtNama3";
            this.txtNama3.Size = new System.Drawing.Size(175, 20);
            this.txtNama3.TabIndex = 4;
            // 
            // txtAngkatan3
            // 
            this.txtAngkatan3.Location = new System.Drawing.Point(89, 96);
            this.txtAngkatan3.Name = "txtAngkatan3";
            this.txtAngkatan3.Size = new System.Drawing.Size(100, 20);
            this.txtAngkatan3.TabIndex = 5;
            // 
            // btnCari2
            // 
            this.btnCari2.Location = new System.Drawing.Point(195, 34);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(75, 23);
            this.btnCari2.TabIndex = 6;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = true;
            this.btnCari2.Click += new System.EventHandler(this.btnCari2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(33, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 346);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTesKoneksi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.btnTampilkanData.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage btnTampilkanData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtAngkatan1;
        private System.Windows.Forms.TextBox txtNama1;
        private System.Windows.Forms.MaskedTextBox mskNpm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstMahasiswa;
        private System.Windows.Forms.Button btnCari1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAngkatan2;
        private System.Windows.Forms.TextBox txtNama2;
        private System.Windows.Forms.MaskedTextBox mskNpm2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.TextBox txtAngkatan3;
        private System.Windows.Forms.TextBox txtNama3;
        private System.Windows.Forms.MaskedTextBox mskNpm3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

