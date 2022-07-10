
namespace WindowsFormsApp1
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriDon = new System.Windows.Forms.Button();
            this.Psil = new System.Windows.Forms.Button();
            this.Pguncelle = new System.Windows.Forms.Button();
            this.Pkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.psoyadi = new System.Windows.Forms.TextBox();
            this.pmail = new System.Windows.Forms.TextBox();
            this.padres = new System.Windows.Forms.TextBox();
            this.psifre = new System.Windows.Forms.TextBox();
            this.pgorev = new System.Windows.Forms.TextBox();
            this.pnick = new System.Windows.Forms.TextBox();
            this.ptelefon = new System.Windows.Forms.TextBox();
            this.ptc = new System.Windows.Forms.TextBox();
            this.padi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.GeriDon);
            this.panel1.Controls.Add(this.Psil);
            this.panel1.Controls.Add(this.Pguncelle);
            this.panel1.Controls.Add(this.Pkaydet);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.radioB);
            this.panel1.Controls.Add(this.radioK);
            this.panel1.Controls.Add(this.radioE);
            this.panel1.Controls.Add(this.psoyadi);
            this.panel1.Controls.Add(this.pmail);
            this.panel1.Controls.Add(this.padres);
            this.panel1.Controls.Add(this.psifre);
            this.panel1.Controls.Add(this.pgorev);
            this.panel1.Controls.Add(this.pnick);
            this.panel1.Controls.Add(this.ptelefon);
            this.panel1.Controls.Add(this.ptc);
            this.panel1.Controls.Add(this.padi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1634, 644);
            this.panel1.TabIndex = 1;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.White;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Location = new System.Drawing.Point(112, 532);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(324, 43);
            this.GeriDon.TabIndex = 5;
            this.GeriDon.Text = "Ana İşlemlere Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // Psil
            // 
            this.Psil.BackColor = System.Drawing.Color.White;
            this.Psil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Psil.ForeColor = System.Drawing.Color.DarkRed;
            this.Psil.Location = new System.Drawing.Point(112, 483);
            this.Psil.Name = "Psil";
            this.Psil.Size = new System.Drawing.Size(324, 43);
            this.Psil.TabIndex = 4;
            this.Psil.Text = "Sil";
            this.Psil.UseVisualStyleBackColor = false;
            this.Psil.Click += new System.EventHandler(this.Psil_Click_1);
            // 
            // Pguncelle
            // 
            this.Pguncelle.BackColor = System.Drawing.Color.White;
            this.Pguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pguncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Pguncelle.Location = new System.Drawing.Point(112, 434);
            this.Pguncelle.Name = "Pguncelle";
            this.Pguncelle.Size = new System.Drawing.Size(324, 43);
            this.Pguncelle.TabIndex = 4;
            this.Pguncelle.Text = "Güncelle";
            this.Pguncelle.UseVisualStyleBackColor = false;
            this.Pguncelle.Click += new System.EventHandler(this.Pguncelle_Click_1);
            // 
            // Pkaydet
            // 
            this.Pkaydet.BackColor = System.Drawing.Color.White;
            this.Pkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pkaydet.ForeColor = System.Drawing.Color.Green;
            this.Pkaydet.Location = new System.Drawing.Point(112, 385);
            this.Pkaydet.Name = "Pkaydet";
            this.Pkaydet.Size = new System.Drawing.Size(324, 43);
            this.Pkaydet.TabIndex = 4;
            this.Pkaydet.Text = "Kaydet";
            this.Pkaydet.UseVisualStyleBackColor = false;
            this.Pkaydet.Click += new System.EventHandler(this.pkaydet_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1054, 527);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.BackColor = System.Drawing.Color.Black;
            this.radioB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioB.ForeColor = System.Drawing.SystemColors.Window;
            this.radioB.Location = new System.Drawing.Point(304, 338);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(207, 26);
            this.radioB.TabIndex = 2;
            this.radioB.TabStop = true;
            this.radioB.Text = "Blirtmek İstemiyorum";
            this.radioB.UseVisualStyleBackColor = false;
            // 
            // radioK
            // 
            this.radioK.AutoSize = true;
            this.radioK.BackColor = System.Drawing.Color.Black;
            this.radioK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioK.ForeColor = System.Drawing.SystemColors.Window;
            this.radioK.Location = new System.Drawing.Point(259, 338);
            this.radioK.Name = "radioK";
            this.radioK.Size = new System.Drawing.Size(42, 26);
            this.radioK.TabIndex = 2;
            this.radioK.TabStop = true;
            this.radioK.Text = "K";
            this.radioK.UseVisualStyleBackColor = false;
            // 
            // radioE
            // 
            this.radioE.AutoSize = true;
            this.radioE.BackColor = System.Drawing.Color.Black;
            this.radioE.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioE.ForeColor = System.Drawing.SystemColors.Window;
            this.radioE.Location = new System.Drawing.Point(217, 338);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(41, 26);
            this.radioE.TabIndex = 2;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = false;
            // 
            // psoyadi
            // 
            this.psoyadi.Location = new System.Drawing.Point(259, 81);
            this.psoyadi.Name = "psoyadi";
            this.psoyadi.Size = new System.Drawing.Size(215, 20);
            this.psoyadi.TabIndex = 1;
            // 
            // pmail
            // 
            this.pmail.Location = new System.Drawing.Point(259, 144);
            this.pmail.Name = "pmail";
            this.pmail.Size = new System.Drawing.Size(215, 20);
            this.pmail.TabIndex = 1;
            // 
            // padres
            // 
            this.padres.Location = new System.Drawing.Point(259, 225);
            this.padres.Name = "padres";
            this.padres.Size = new System.Drawing.Size(215, 20);
            this.padres.TabIndex = 1;
            // 
            // psifre
            // 
            this.psifre.Location = new System.Drawing.Point(259, 285);
            this.psifre.Name = "psifre";
            this.psifre.Size = new System.Drawing.Size(215, 20);
            this.psifre.TabIndex = 1;
            // 
            // pgorev
            // 
            this.pgorev.Location = new System.Drawing.Point(259, 199);
            this.pgorev.Name = "pgorev";
            this.pgorev.Size = new System.Drawing.Size(215, 20);
            this.pgorev.TabIndex = 1;
            // 
            // pnick
            // 
            this.pnick.Location = new System.Drawing.Point(259, 259);
            this.pnick.Name = "pnick";
            this.pnick.Size = new System.Drawing.Size(215, 20);
            this.pnick.TabIndex = 1;
            // 
            // ptelefon
            // 
            this.ptelefon.Location = new System.Drawing.Point(259, 173);
            this.ptelefon.Name = "ptelefon";
            this.ptelefon.Size = new System.Drawing.Size(215, 20);
            this.ptelefon.TabIndex = 1;
            // 
            // ptc
            // 
            this.ptc.Location = new System.Drawing.Point(259, 112);
            this.ptc.Name = "ptc";
            this.ptc.Size = new System.Drawing.Size(215, 20);
            this.ptc.TabIndex = 1;
            // 
            // padi
            // 
            this.padi.Location = new System.Drawing.Point(259, 46);
            this.padi.Name = "padi";
            this.padi.Size = new System.Drawing.Size(215, 20);
            this.padi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(64, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "CİNSİYET :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(64, 225);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "ADRES :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(64, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-POSTA :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(64, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "ŞİFRE :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(64, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "GÖREV :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(64, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(64, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "PERSONEL NİCK :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(64, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(65, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "SOYAD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1793, 668);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Button Psil;
        private System.Windows.Forms.Button Pguncelle;
        private System.Windows.Forms.Button Pkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.TextBox psoyadi;
        private System.Windows.Forms.TextBox pmail;
        private System.Windows.Forms.TextBox pnick;
        private System.Windows.Forms.TextBox ptelefon;
        private System.Windows.Forms.TextBox ptc;
        private System.Windows.Forms.TextBox padi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox psifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox padres;
        private System.Windows.Forms.TextBox pgorev;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}