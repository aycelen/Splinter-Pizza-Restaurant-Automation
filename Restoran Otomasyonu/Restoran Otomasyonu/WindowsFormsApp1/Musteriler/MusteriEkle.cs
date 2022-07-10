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
    public partial class MusteriEkle : Form
    {
        PizzaEntities db = new PizzaEntities();
        Musteriler musteri = new Musteriler();

        public MusteriEkle()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            radioB.Checked = true;

        }
        public void Listele()
        {
            var musteri = db.Musteriler.ToList();
            dataGridView1.DataSource = musteri.ToList();
            this.dataGridView1.Columns["musteriID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Müşteri İsim";
            dataGridView1.Columns[2].HeaderText = "Müşteri Soyisim";
            dataGridView1.Columns[3].HeaderText = "Müşteri TC";
            dataGridView1.Columns[4].HeaderText = "Nüşteri Mail";
            dataGridView1.Columns[5].HeaderText = "Müşteri Telefon";
            dataGridView1.Columns[6].HeaderText = "Müşteri Cinsiyet";


        }
        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }



        private void Mkaydet_Click(object sender, EventArgs e)
        {
            if (madi.Text == "" || msoyadi.Text == "" || mmail.Text == "" || mtel.Text == String.Empty || mtc.Text == String.Empty)
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
            else
            {
                musteri.misim = madi.Text;
                musteri.msoyisim = msoyadi.Text;
                musteri.mmail = mmail.Text;
                musteri.mTC = mtc.Text;
                musteri.mTel = mtel.Text;

                if (radioE.Checked == true)
                {
                    musteri.mcinsiyet = "E";
                }
                else if (radioK.Checked == true)
                {
                    musteri.mcinsiyet = "K";
                }
                else if (radioB.Checked == true)
                {
                    musteri.mcinsiyet = "-";
                }

                db.Musteriler.Add(musteri);
                db.SaveChanges();
                Listele();
                //float varsa musteri.mceza=convert.todouble(mceza.text);
            }
        
       
        }

        private void GeriDon_Click(object sender, EventArgs e)
        {
            Islemler panel = new Islemler();
            panel.Show();
            this.Hide();
        }

        private void MSil_Click(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var musteri = db.Musteriler.Where(x => x.musteriID == secilensatir).FirstOrDefault();
            db.Musteriler.Remove(musteri);
            db.SaveChanges();
            Listele();
        }

        private void Mguncelle_Click(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var musteris = db.Musteriler.Where(x => x.musteriID == secilensatir).FirstOrDefault();
            musteris.misim = madi.Text;
            musteris.msoyisim = msoyadi.Text;
            musteris.mmail = mmail.Text;
            musteris.mTC = mtc.Text;
            musteris.mTel = mtel.Text;

            if (radioE.Checked == true)
            {
                musteris.mcinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                musteris.mcinsiyet = "K";
            }
            else if (radioB.Checked == true)
            {
                musteri.mcinsiyet = "-";
            }
            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            madi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            msoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            mmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mtel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("E"))
            {
                radioE.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("K"))
            {
                radioK.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString().Equals("-"))
            {
                radioB.Checked = true;
            }
 
        }

    
    }
}
