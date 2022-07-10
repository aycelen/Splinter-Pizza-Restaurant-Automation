
namespace WindowsFormsApp1
{
    partial class UrunlerIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunlerIslem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GeriDon = new System.Windows.Forms.Button();
            this.Usil = new System.Windows.Forms.Button();
            this.Uguncelle = new System.Windows.Forms.Button();
            this.Ukaydet = new System.Windows.Forms.Button();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lbUrunFiyati = new System.Windows.Forms.Label();
            this.lbUrunTanimi = new System.Windows.Forms.Label();
            this.lbUrunAdi = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.GeriDon);
            this.panel1.Controls.Add(this.Usil);
            this.panel1.Controls.Add(this.Uguncelle);
            this.panel1.Controls.Add(this.Ukaydet);
            this.panel1.Controls.Add(this.txtUrunFiyati);
            this.panel1.Controls.Add(this.txtUrunAdi);
            this.panel1.Controls.Add(this.lbUrunFiyati);
            this.panel1.Controls.Add(this.lbUrunTanimi);
            this.panel1.Controls.Add(this.lbUrunAdi);
            this.panel1.Controls.Add(this.cmbUrun);
            this.panel1.Location = new System.Drawing.Point(69, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 493);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(430, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 362);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.White;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Location = new System.Drawing.Point(42, 386);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(324, 43);
            this.GeriDon.TabIndex = 32;
            this.GeriDon.Text = "Ana İşlemlere Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Usil
            // 
            this.Usil.BackColor = System.Drawing.Color.White;
            this.Usil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usil.ForeColor = System.Drawing.Color.DarkRed;
            this.Usil.Location = new System.Drawing.Point(42, 337);
            this.Usil.Name = "Usil";
            this.Usil.Size = new System.Drawing.Size(324, 43);
            this.Usil.TabIndex = 29;
            this.Usil.Text = "Sil";
            this.Usil.UseVisualStyleBackColor = false;
            this.Usil.Click += new System.EventHandler(this.Usil_Click);
            // 
            // Uguncelle
            // 
            this.Uguncelle.BackColor = System.Drawing.Color.White;
            this.Uguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uguncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Uguncelle.Location = new System.Drawing.Point(42, 288);
            this.Uguncelle.Name = "Uguncelle";
            this.Uguncelle.Size = new System.Drawing.Size(324, 43);
            this.Uguncelle.TabIndex = 30;
            this.Uguncelle.Text = "Güncelle";
            this.Uguncelle.UseVisualStyleBackColor = false;
            this.Uguncelle.Click += new System.EventHandler(this.Uguncelle_Click);
            // 
            // Ukaydet
            // 
            this.Ukaydet.BackColor = System.Drawing.Color.White;
            this.Ukaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ukaydet.ForeColor = System.Drawing.Color.Green;
            this.Ukaydet.Location = new System.Drawing.Point(42, 239);
            this.Ukaydet.Name = "Ukaydet";
            this.Ukaydet.Size = new System.Drawing.Size(324, 43);
            this.Ukaydet.TabIndex = 31;
            this.Ukaydet.Text = "Kaydet";
            this.Ukaydet.UseVisualStyleBackColor = false;
            this.Ukaydet.Click += new System.EventHandler(this.Ukaydet_Click);
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(245, 131);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(121, 24);
            this.txtUrunFiyati.TabIndex = 24;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(245, 101);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(121, 24);
            this.txtUrunAdi.TabIndex = 23;
            // 
            // lbUrunFiyati
            // 
            this.lbUrunFiyati.AutoSize = true;
            this.lbUrunFiyati.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUrunFiyati.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunFiyati.Location = new System.Drawing.Point(47, 134);
            this.lbUrunFiyati.Name = "lbUrunFiyati";
            this.lbUrunFiyati.Size = new System.Drawing.Size(114, 21);
            this.lbUrunFiyati.TabIndex = 27;
            this.lbUrunFiyati.Text = "Ürün Fiyatı  : ";
            // 
            // lbUrunTanimi
            // 
            this.lbUrunTanimi.AutoSize = true;
            this.lbUrunTanimi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUrunTanimi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunTanimi.Location = new System.Drawing.Point(47, 70);
            this.lbUrunTanimi.Name = "lbUrunTanimi";
            this.lbUrunTanimi.Size = new System.Drawing.Size(125, 21);
            this.lbUrunTanimi.TabIndex = 26;
            this.lbUrunTanimi.Text = "Ürün Tanımı  : ";
            // 
            // lbUrunAdi
            // 
            this.lbUrunAdi.AutoSize = true;
            this.lbUrunAdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUrunAdi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUrunAdi.Location = new System.Drawing.Point(47, 102);
            this.lbUrunAdi.Name = "lbUrunAdi";
            this.lbUrunAdi.Size = new System.Drawing.Size(99, 21);
            this.lbUrunAdi.TabIndex = 25;
            this.lbUrunAdi.Text = "Ürün Adı  : ";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Items.AddRange(new object[] {
            "Gazlı İçeçekler",
            "Tatlılar",
            "Alkollü İçeçekler",
            "Sıcak İçeçekler",
            "Soğuk İçeçekler",
            "Arasıcaklar",
            "Pizzalar",
            "Özel Soslar",
            ""});
            this.cmbUrun.Location = new System.Drawing.Point(245, 67);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 29);
            this.cmbUrun.TabIndex = 0;
            // 
            // UrunlerIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1397, 616);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UrunlerIslem";
            this.Text = "UrunlerIslem";
            this.Load += new System.EventHandler(this.UrunlerIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lbUrunFiyati;
        private System.Windows.Forms.Label lbUrunTanimi;
        private System.Windows.Forms.Label lbUrunAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Button Usil;
        private System.Windows.Forms.Button Uguncelle;
        private System.Windows.Forms.Button Ukaydet;
        private System.Windows.Forms.ComboBox cmbUrun;
    }
}