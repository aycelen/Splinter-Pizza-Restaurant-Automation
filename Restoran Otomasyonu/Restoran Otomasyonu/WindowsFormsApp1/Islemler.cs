using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
            islempanel.BackColor = Color.FromArgb(150, Color.White);
           

        }


        private void Musteribt_Click(object sender, EventArgs e)
        {
            MusteriEkle panel = new MusteriEkle();
            panel.Show();
            this.Hide();
        }

        private void Personelbt_Click(object sender, EventArgs e)
        {
            PersonelEkle panel = new PersonelEkle();
            panel.Show();
            this.Hide();
        }

        private void masalarbt_Click(object sender, EventArgs e)
        {
           MasalarKontrol panel = new MasalarKontrol();
           panel.Show();
           this.Hide();
        }

        private void Islemler_Load(object sender, EventArgs e)
        {

        }

        private void urunlerbt_Click(object sender, EventArgs e)
        {
            UrunlerIslem panel = new UrunlerIslem();
            panel.Show();
            this.Hide();
        }
    }
}
