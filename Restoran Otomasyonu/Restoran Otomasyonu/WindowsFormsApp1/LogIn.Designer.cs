
namespace WindowsFormsApp1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.personelpanel = new System.Windows.Forms.Panel();
            this.cikisbutonu = new System.Windows.Forms.Button();
            this.GirisButonu = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.Label();
            this.kullanıcıadi = new System.Windows.Forms.Label();
            this.personelsifretb = new System.Windows.Forms.TextBox();
            this.personeladitb = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.personelpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // personelpanel
            // 
            this.personelpanel.Controls.Add(this.cikisbutonu);
            this.personelpanel.Controls.Add(this.GirisButonu);
            this.personelpanel.Controls.Add(this.sifre);
            this.personelpanel.Controls.Add(this.kullanıcıadi);
            this.personelpanel.Controls.Add(this.personelsifretb);
            this.personelpanel.Controls.Add(this.personeladitb);
            this.personelpanel.Controls.Add(this.pb1);
            this.personelpanel.Location = new System.Drawing.Point(43, 179);
            this.personelpanel.Name = "personelpanel";
            this.personelpanel.Size = new System.Drawing.Size(473, 301);
            this.personelpanel.TabIndex = 0;
            // 
            // cikisbutonu
            // 
            this.cikisbutonu.BackColor = System.Drawing.Color.Firebrick;
            this.cikisbutonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cikisbutonu.FlatAppearance.BorderSize = 2;
            this.cikisbutonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikisbutonu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisbutonu.Location = new System.Drawing.Point(240, 243);
            this.cikisbutonu.Name = "cikisbutonu";
            this.cikisbutonu.Size = new System.Drawing.Size(184, 38);
            this.cikisbutonu.TabIndex = 8;
            this.cikisbutonu.Text = "Çıkış";
            this.cikisbutonu.UseVisualStyleBackColor = false;
            this.cikisbutonu.Click += new System.EventHandler(this.cikisbutonu_Click);
            // 
            // GirisButonu
            // 
            this.GirisButonu.BackColor = System.Drawing.Color.LightGreen;
            this.GirisButonu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GirisButonu.FlatAppearance.BorderSize = 2;
            this.GirisButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GirisButonu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisButonu.Location = new System.Drawing.Point(46, 243);
            this.GirisButonu.Name = "GirisButonu";
            this.GirisButonu.Size = new System.Drawing.Size(188, 38);
            this.GirisButonu.TabIndex = 7;
            this.GirisButonu.Text = "Giriş";
            this.GirisButonu.UseVisualStyleBackColor = false;
            this.GirisButonu.Click += new System.EventHandler(this.GirisButonu_Click);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.White;
            this.sifre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sifre.Location = new System.Drawing.Point(55, 166);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(47, 17);
            this.sifre.TabIndex = 6;
            this.sifre.Text = "Şifre :";
            // 
            // kullanıcıadi
            // 
            this.kullanıcıadi.AutoSize = true;
            this.kullanıcıadi.BackColor = System.Drawing.Color.White;
            this.kullanıcıadi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıadi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullanıcıadi.Location = new System.Drawing.Point(55, 109);
            this.kullanıcıadi.Name = "kullanıcıadi";
            this.kullanıcıadi.Size = new System.Drawing.Size(101, 17);
            this.kullanıcıadi.TabIndex = 5;
            this.kullanıcıadi.Text = "Personel Adı :";
            // 
            // personelsifretb
            // 
            this.personelsifretb.Location = new System.Drawing.Point(162, 161);
            this.personelsifretb.Multiline = true;
            this.personelsifretb.Name = "personelsifretb";
            this.personelsifretb.Size = new System.Drawing.Size(262, 22);
            this.personelsifretb.TabIndex = 1;
            // 
            // personeladitb
            // 
            this.personeladitb.Location = new System.Drawing.Point(162, 104);
            this.personeladitb.Multiline = true;
            this.personeladitb.Name = "personeladitb";
            this.personeladitb.Size = new System.Drawing.Size(262, 22);
            this.personeladitb.TabIndex = 1;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(21, 21);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(437, 37);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(564, 671);
            this.Controls.Add(this.personelpanel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.personelpanel.ResumeLayout(false);
            this.personelpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel personelpanel;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button cikisbutonu;
        private System.Windows.Forms.Button GirisButonu;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label kullanıcıadi;
        private System.Windows.Forms.TextBox personeladitb;
        private System.Windows.Forms.TextBox personelsifretb;
    }
}

