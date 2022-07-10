
namespace WindowsFormsApp1
{
    partial class Islemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islemler));
            this.islempanel = new System.Windows.Forms.Panel();
            this.personelbt = new System.Windows.Forms.Button();
            this.urunlerbt = new System.Windows.Forms.Button();
            this.masalarbt = new System.Windows.Forms.Button();
            this.musteribt = new System.Windows.Forms.Button();
            this.islempanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // islempanel
            // 
            this.islempanel.Controls.Add(this.personelbt);
            this.islempanel.Controls.Add(this.urunlerbt);
            this.islempanel.Controls.Add(this.masalarbt);
            this.islempanel.Controls.Add(this.musteribt);
            this.islempanel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islempanel.ForeColor = System.Drawing.Color.SeaGreen;
            this.islempanel.Location = new System.Drawing.Point(228, 120);
            this.islempanel.Name = "islempanel";
            this.islempanel.Size = new System.Drawing.Size(722, 445);
            this.islempanel.TabIndex = 0;
            // 
            // personelbt
            // 
            this.personelbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("personelbt.BackgroundImage")));
            this.personelbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personelbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personelbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personelbt.Location = new System.Drawing.Point(114, 79);
            this.personelbt.Name = "personelbt";
            this.personelbt.Size = new System.Drawing.Size(210, 145);
            this.personelbt.TabIndex = 1;
            this.personelbt.Text = "Personeller";
            this.personelbt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.personelbt.UseVisualStyleBackColor = true;
            this.personelbt.Click += new System.EventHandler(this.Personelbt_Click);
            // 
            // urunlerbt
            // 
            this.urunlerbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("urunlerbt.BackgroundImage")));
            this.urunlerbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urunlerbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urunlerbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urunlerbt.Location = new System.Drawing.Point(410, 253);
            this.urunlerbt.Name = "urunlerbt";
            this.urunlerbt.Size = new System.Drawing.Size(210, 145);
            this.urunlerbt.TabIndex = 1;
            this.urunlerbt.Text = "Ürünler";
            this.urunlerbt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.urunlerbt.UseVisualStyleBackColor = true;
            this.urunlerbt.Click += new System.EventHandler(this.urunlerbt_Click);
            // 
            // masalarbt
            // 
            this.masalarbt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("masalarbt.BackgroundImage")));
            this.masalarbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.masalarbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.masalarbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.masalarbt.Location = new System.Drawing.Point(114, 253);
            this.masalarbt.Name = "masalarbt";
            this.masalarbt.Size = new System.Drawing.Size(210, 145);
            this.masalarbt.TabIndex = 1;
            this.masalarbt.Text = "Masalar";
            this.masalarbt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.masalarbt.UseVisualStyleBackColor = true;
            this.masalarbt.Click += new System.EventHandler(this.masalarbt_Click);
            // 
            // musteribt
            // 
            this.musteribt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musteribt.BackgroundImage")));
            this.musteribt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.musteribt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.musteribt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteribt.Location = new System.Drawing.Point(410, 79);
            this.musteribt.Name = "musteribt";
            this.musteribt.Size = new System.Drawing.Size(210, 145);
            this.musteribt.TabIndex = 1;
            this.musteribt.Text = "Müşteriler";
            this.musteribt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteribt.UseVisualStyleBackColor = true;
            this.musteribt.Click += new System.EventHandler(this.Musteribt_Click);
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1129, 701);
            this.Controls.Add(this.islempanel);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Islemler";
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            this.islempanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel islempanel;
        private System.Windows.Forms.Button musteribt;
        private System.Windows.Forms.Button personelbt;
        private System.Windows.Forms.Button urunlerbt;
        private System.Windows.Forms.Button masalarbt;
    }
}