
namespace WindowsFormsApp1
{
    partial class MasalarKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasalarKontrol));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbUrunsip = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmasa = new System.Windows.Forms.ComboBox();
            this.btnSiparisver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriDon = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(702, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbUrunsip
            // 
            this.cmbUrunsip.FormattingEnabled = true;
            this.cmbUrunsip.Items.AddRange(new object[] {
            "Gazlı İçeçekler",
            "Tatlılar",
            "Alkollü İçeçekler",
            "Sıcak İçeçekler",
            "Soğuk İçeçekler",
            "Arasıcaklar",
            "Pizzalar",
            "Özel Soslar",
            ""});
            this.cmbUrunsip.Location = new System.Drawing.Point(883, 57);
            this.cmbUrunsip.Name = "cmbUrunsip";
            this.cmbUrunsip.Size = new System.Drawing.Size(140, 23);
            this.cmbUrunsip.TabIndex = 1;
            this.cmbUrunsip.SelectedIndexChanged += new System.EventHandler(this.cmbUrunsip_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 104);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(528, 380);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(726, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürünler Liste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Siparişler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Masa Numarası Seçiniz";
            // 
            // cmbmasa
            // 
            this.cmbmasa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbmasa.FormattingEnabled = true;
            this.cmbmasa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbmasa.Location = new System.Drawing.Point(272, 30);
            this.cmbmasa.Name = "cmbmasa";
            this.cmbmasa.Size = new System.Drawing.Size(121, 23);
            this.cmbmasa.TabIndex = 7;
            // 
            // btnSiparisver
            // 
            this.btnSiparisver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiparisver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisver.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSiparisver.Location = new System.Drawing.Point(334, 60);
            this.btnSiparisver.Name = "btnSiparisver";
            this.btnSiparisver.Size = new System.Drawing.Size(123, 23);
            this.btnSiparisver.TabIndex = 8;
            this.btnSiparisver.Text = "Sipariş Gir";
            this.btnSiparisver.UseVisualStyleBackColor = false;
            this.btnSiparisver.Click += new System.EventHandler(this.btnSiparisver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GeriDon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbmasa);
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.btnSiparisver);
            this.panel1.Controls.Add(this.cmbUrunsip);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(61, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 551);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GeriDon
            // 
            this.GeriDon.BackColor = System.Drawing.Color.White;
            this.GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriDon.Location = new System.Drawing.Point(1192, 11);
            this.GeriDon.Name = "GeriDon";
            this.GeriDon.Size = new System.Drawing.Size(139, 52);
            this.GeriDon.TabIndex = 33;
            this.GeriDon.Text = "Ana İşlemlere Dön";
            this.GeriDon.UseVisualStyleBackColor = false;
            this.GeriDon.Click += new System.EventHandler(this.GeriDon_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.ForeColor = System.Drawing.Color.Maroon;
            this.btnsil.Location = new System.Drawing.Point(205, 60);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(123, 23);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "Masa Sipariş Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Masa Toplam :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(592, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 36;
            // 
            // MasalarKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1504, 711);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MasalarKontrol";
            this.Text = "MasalarKontrol";
            this.Load += new System.EventHandler(this.MasalarKontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbUrunsip;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmasa;
        private System.Windows.Forms.Button btnSiparisver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button GeriDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}