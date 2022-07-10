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
    public partial class MasalarKontrol : Form
    {
        PizzaEntities db = new PizzaEntities();
        Urunler urun = new Urunler();
        Masalar masalar = new Masalar();
        Siparis sip = new Siparis();

        public MasalarKontrol()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.Black);

        }

        private void MasalarKontrol_Load(object sender, EventArgs e)
        {
            var urunlistele = db.Urunler.ToList();
            dataGridView1.DataSource = urunlistele.ToList();

            var siparislistele = db.Siparis.ToList();
            dataGridView2.DataSource = siparislistele.ToList();
            dataGridView2.Columns[5].Visible = false;


        }

        private void cmbUrunsip_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gelentur = cmbUrunsip.Text;
            var turler = db.Urunler.Where(x => x.urunturu.Contains(gelentur)).ToList();
            dataGridView1.DataSource = turler;

        }



        public void btnSiparisver_Click(object sender, EventArgs e)
        {

            string secilenmasa = cmbmasa.Text;
            var secilenm = db.Masalar.Where(x => x.masano.Equals(secilenmasa)).FirstOrDefault();

            int secilenurunID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var secilenurun = db.Urunler.Where(x => x.uID == secilenurunID).FirstOrDefault();

            int secilenurunfiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            var secilenurunf = db.Urunler.Where(x => x.urunfiyati == secilenurunfiyat).FirstOrDefault();


            if (secilenmasa == "")

            {
                MessageBox.Show("Masa Seçmeyi Unuttunuz");
            }
            else
            {
                Siparis siparisler = new Siparis();
                siparisler.urunID = secilenurun.uID;
                siparisler.masaID = secilenm.masaID;
                siparisler.urunfiyati = secilenurunf.urunfiyati;

                db.Siparis.Add(siparisler);
                db.SaveChanges();
                Listele();


            }



        }
   //     private void cmbmasa_SelectedIndexChanged_1(object sender, EventArgs e)
     //   {
       //     int masagelen = Convert.ToInt32(cmbmasa.Text);
            //   var turler = db.Siparis.Where(x => x.masaID.Contains(masagelen));
        //    dataGridView2.DataSource = turler;
        //}

        public void Listele()
        {
            var siparislistele = db.Siparis.ToList();
            dataGridView2.DataSource = siparislistele.ToList();
            dataGridView2.Columns[4].Visible = false;



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value);
            var masatemizle = db.Siparis.Where(x => x.masaID == secilensatir).FirstOrDefault();
            db.Siparis.Remove(masatemizle);
            db.SaveChanges();
            Listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["Hesapla"].Index)
            {

            }
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            Islemler panel = new Islemler();
            panel.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
