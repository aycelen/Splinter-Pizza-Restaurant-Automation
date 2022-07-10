
namespace WindowsFormsApp1
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriDon = new System.Windows.Forms.Button();
            this.msil = new System.Windows.Forms.Button();
            this.mguncelle = new System.Windows.Forms.Button();
            this.mkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.radioK = new System.Windows.Forms.RadioButton();
            this.radioE = new System.Windows.Forms.RadioButton();
            this.msoyadi = new System.Windows.Forms.TextBox();
            this.mmail = new System.Windows.Forms.TextBox();
            this.mtel = new System.Windows.Forms.TextBox();
            this.mtc = new System.Windows.Forms.TextBox();
            this.madi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.msil);
            this.panel1.Controls.Add(this.mguncelle);
            this.panel1.Controls.Add(this.mkaydet);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.radioB);
            this.panel1.Controls.Add(this.radioK);
            this.panel1.Controls.Add(this.radioE);
            this.panel1.Controls.Add(this.msoyadi);
            this.panel1.Controls.Add(this.mmail);
            this.panel1.Controls.Add(this.mtel);
            this.panel1.Controls.Add(this.mtc);
            this.panel1.Controls.Add(this.madi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 644);
            this.panel1.TabIndex = 0;
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.White;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Location = new System.Drawing.Point(115, 494);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(324, 43);
            this.GeriDon.TabIndex = 5;
            this.GeriDon.Text = "Ana İşlemlere Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // msil
            // 
            this.msil.BackColor = System.Drawing.Color.White;
            this.msil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.msil.ForeColor = System.Drawing.Color.DarkRed;
            this.msil.Location = new System.Drawing.Point(115, 445);
            this.msil.Name = "msil";
            this.msil.Size = new System.Drawing.Size(324, 43);
            this.msil.TabIndex = 4;
            this.msil.Text = "Sil";
            this.msil.UseVisualStyleBackColor = false;
            this.msil.Click += new System.EventHandler(this.MSil_Click);
            // 
            // mguncelle
            // 
            this.mguncelle.BackColor = System.Drawing.Color.White;
            this.mguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mguncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.mguncelle.Location = new System.Drawing.Point(115, 396);
            this.mguncelle.Name = "mguncelle";
            this.mguncelle.Size = new System.Drawing.Size(324, 43);
            this.mguncelle.TabIndex = 4;
            this.mguncelle.Text = "Güncelle";
            this.mguncelle.UseVisualStyleBackColor = false;
            this.mguncelle.Click += new System.EventHandler(this.Mguncelle_Click);
            // 
            // mkaydet
            // 
            this.mkaydet.BackColor = System.Drawing.Color.White;
            this.mkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mkaydet.ForeColor = System.Drawing.Color.Green;
            this.mkaydet.Location = new System.Drawing.Point(115, 347);
            this.mkaydet.Name = "mkaydet";
            this.mkaydet.Size = new System.Drawing.Size(324, 43);
            this.mkaydet.TabIndex = 4;
            this.mkaydet.Text = "Kaydet";
            this.mkaydet.UseVisualStyleBackColor = false;
            this.mkaydet.Click += new System.EventHandler(this.Mkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 527);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.BackColor = System.Drawing.Color.Black;
            this.radioB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioB.ForeColor = System.Drawing.SystemColors.Window;
            this.radioB.Location = new System.Drawing.Point(311, 258);
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
            this.radioK.Location = new System.Drawing.Point(266, 258);
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
            this.radioE.Location = new System.Drawing.Point(224, 258);
            this.radioE.Name = "radioE";
            this.radioE.Size = new System.Drawing.Size(41, 26);
            this.radioE.TabIndex = 2;
            this.radioE.TabStop = true;
            this.radioE.Text = "E";
            this.radioE.UseVisualStyleBackColor = false;
            // 
            // msoyadi
            // 
            this.msoyadi.Location = new System.Drawing.Point(224, 119);
            this.msoyadi.Name = "msoyadi";
            this.msoyadi.Size = new System.Drawing.Size(215, 26);
            this.msoyadi.TabIndex = 1;
            // 
            // mmail
            // 
            this.mmail.Location = new System.Drawing.Point(224, 189);
            this.mmail.Name = "mmail";
            this.mmail.Size = new System.Drawing.Size(215, 26);
            this.mmail.TabIndex = 1;
            // 
            // mtel
            // 
            this.mtel.Location = new System.Drawing.Point(224, 226);
            this.mtel.Name = "mtel";
            this.mtel.Size = new System.Drawing.Size(215, 26);
            this.mtel.TabIndex = 1;
            // 
            // mtc
            // 
            this.mtc.Location = new System.Drawing.Point(224, 151);
            this.mtc.Name = "mtc";
            this.mtc.Size = new System.Drawing.Size(215, 26);
            this.mtc.TabIndex = 1;
            // 
            // madi
            // 
            this.madi.Location = new System.Drawing.Point(224, 87);
            this.madi.Name = "madi";
            this.madi.Size = new System.Drawing.Size(215, 26);
            this.madi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(104, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "CİNSİYET :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(104, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-POSTA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(104, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "TELEFON :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(104, 158);
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
            this.label2.Location = new System.Drawing.Point(104, 129);
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
            this.label1.Location = new System.Drawing.Point(104, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // MusteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 704);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriEkle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.RadioButton radioK;
        private System.Windows.Forms.RadioButton radioE;
        private System.Windows.Forms.TextBox msoyadi;
        private System.Windows.Forms.TextBox mmail;
        private System.Windows.Forms.TextBox mtel;
        private System.Windows.Forms.TextBox mtc;
        private System.Windows.Forms.TextBox madi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mkaydet;
        private System.Windows.Forms.Button msil;
        private System.Windows.Forms.Button mguncelle;
        private System.Windows.Forms.Button GeriDon;
    }
}