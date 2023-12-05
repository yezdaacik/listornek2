namespace list_uygulama_815
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.lbKisiler = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSirs = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnArtran = new System.Windows.Forms.Button();
            this.btnAzalan = new System.Windows.Forms.Button();
            this.btnKarakter = new System.Windows.Forms.Button();
            this.btnMharfi = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAharfi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(216, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(109, 41);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Kişi Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(53, 28);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(100, 20);
            this.txtKisi.TabIndex = 1;
            // 
            // lbKisiler
            // 
            this.lbKisiler.FormattingEnabled = true;
            this.lbKisiler.Location = new System.Drawing.Point(12, 54);
            this.lbKisiler.Name = "lbKisiler";
            this.lbKisiler.Size = new System.Drawing.Size(169, 277);
            this.lbKisiler.TabIndex = 2;
            this.lbKisiler.SelectedIndexChanged += new System.EventHandler(this.lbKisiler_SelectedIndexChanged);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(216, 79);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(109, 41);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSirs
            // 
            this.btnSirs.Location = new System.Drawing.Point(216, 126);
            this.btnSirs.Name = "btnSirs";
            this.btnSirs.Size = new System.Drawing.Size(109, 41);
            this.btnSirs.TabIndex = 4;
            this.btnSirs.Text = "Sıra";
            this.btnSirs.UseVisualStyleBackColor = true;
            this.btnSirs.Click += new System.EventHandler(this.btnSirs_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(216, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 41);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "RemoveAt ile sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(216, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(109, 41);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove ile sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(216, 267);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 41);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnArtran
            // 
            this.btnArtran.Location = new System.Drawing.Point(348, 220);
            this.btnArtran.Name = "btnArtran";
            this.btnArtran.Size = new System.Drawing.Size(100, 41);
            this.btnArtran.TabIndex = 8;
            this.btnArtran.Text = "Artan sıralama";
            this.btnArtran.UseVisualStyleBackColor = true;
            this.btnArtran.Click += new System.EventHandler(this.btnArtran_Click);
            // 
            // btnAzalan
            // 
            this.btnAzalan.Location = new System.Drawing.Point(348, 267);
            this.btnAzalan.Name = "btnAzalan";
            this.btnAzalan.Size = new System.Drawing.Size(100, 41);
            this.btnAzalan.TabIndex = 9;
            this.btnAzalan.Text = "Azalan sıralama";
            this.btnAzalan.UseVisualStyleBackColor = true;
            this.btnAzalan.Click += new System.EventHandler(this.btnAzalan_Click);
            // 
            // btnKarakter
            // 
            this.btnKarakter.Location = new System.Drawing.Point(348, 173);
            this.btnKarakter.Name = "btnKarakter";
            this.btnKarakter.Size = new System.Drawing.Size(100, 41);
            this.btnKarakter.TabIndex = 10;
            this.btnKarakter.Text = "5 karakterli kişi sayısı";
            this.btnKarakter.UseVisualStyleBackColor = true;
            this.btnKarakter.Click += new System.EventHandler(this.btnKarakter_Click);
            // 
            // btnMharfi
            // 
            this.btnMharfi.Location = new System.Drawing.Point(348, 126);
            this.btnMharfi.Name = "btnMharfi";
            this.btnMharfi.Size = new System.Drawing.Size(100, 41);
            this.btnMharfi.TabIndex = 11;
            this.btnMharfi.Text = "M harfi ile başlayan öğrenciler";
            this.btnMharfi.UseVisualStyleBackColor = true;
            this.btnMharfi.Click += new System.EventHandler(this.btnMharfi_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(348, 79);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 41);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "kişileri temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAharfi
            // 
            this.btnAharfi.Location = new System.Drawing.Point(348, 32);
            this.btnAharfi.Name = "btnAharfi";
            this.btnAharfi.Size = new System.Drawing.Size(100, 41);
            this.btnAharfi.TabIndex = 13;
            this.btnAharfi.Text = "A ile biten öğrenci sayısı";
            this.btnAharfi.UseVisualStyleBackColor = true;
            this.btnAharfi.Click += new System.EventHandler(this.btnAharfi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 343);
            this.Controls.Add(this.btnAharfi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnMharfi);
            this.Controls.Add(this.btnKarakter);
            this.Controls.Add(this.btnAzalan);
            this.Controls.Add(this.btnArtran);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSirs);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lbKisiler);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKisi;
        private System.Windows.Forms.ListBox lbKisiler;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSirs;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnArtran;
        private System.Windows.Forms.Button btnAzalan;
        private System.Windows.Forms.Button btnKarakter;
        private System.Windows.Forms.Button btnMharfi;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAharfi;
    }
}

