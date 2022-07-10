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
    public partial class UrunlerIslem : Form
    {


        PizzaEntities db = new PizzaEntities();
        Urunler urun = new Urunler();
        public UrunlerIslem()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Black);

        }
        public void Listele()
        {
            var urunler = db.Urunler.ToList();
            dataGridView1.DataSource = urunler.ToList();
            dataGridView1.Columns[1].HeaderText = "Ürün Türü";
            dataGridView1.Columns[2].HeaderText = "Ürün Adı";
            dataGridView1.Columns[3].HeaderText = "Ürün Fiyatı";
            dataGridView1.Columns["Siparis"].Visible = false;
        }

        private void Ukaydet_Click(object sender, EventArgs e)
        {

            if (txtUrunAdi.Text == "" || txtUrunFiyati.Text == "" || cmbUrun.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else if (urun.urunadi == txtUrunAdi.Text)
            {
                MessageBox.Show("Bu ürünü Daha Önce Eklediniz!");
            }
            else
            {
                urun.urunadi = txtUrunAdi.Text;
                urun.urunfiyati = Convert.ToDouble(txtUrunFiyati.Text);
                urun.urunturu = cmbUrun.Text;
                db.Urunler.Add(urun);
                db.SaveChanges();
                Listele();
                txtUrunAdi.Clear();
                txtUrunFiyati.Clear();
            }

        }
        
    
        private void UrunlerIslem_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            Islemler panel = new Islemler();
            panel.Show();
            this.Hide();
        }

        private void Usil_Click(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var uruns = db.Urunler.Where(x => x.uID == secilensatir).FirstOrDefault();
            db.Urunler.Remove(uruns);
            db.SaveChanges();
            Listele();
        }

        private void Uguncelle_Click(object sender, EventArgs e)
        {
                int secilensatir = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var urunl = db.Urunler.Where(x => x.uID == secilensatir).FirstOrDefault();
                urunl.urunadi = txtUrunAdi.Text;
                urunl.urunfiyati = Convert.ToDouble(txtUrunFiyati.Text);
                urunl.urunturu = cmbUrun.Text;
                db.SaveChanges();
                Listele();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbUrun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtUrunFiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }
    }

}
