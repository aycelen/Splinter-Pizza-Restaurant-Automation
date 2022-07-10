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
    public partial class PersonelEkle : Form
    {
        PizzaEntities db = new PizzaEntities();
        Personeller personel = new Personeller();
        public PersonelEkle()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Black);
            radioB.Checked = true;

        }
        public void Listele()
        {
            var personel = db.Personeller.ToList();
            dataGridView1.DataSource = personel.ToList();
            this.dataGridView1.Columns["personelID"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Personel İsim";
            dataGridView1.Columns[2].HeaderText = "Personel Soyisim";
            dataGridView1.Columns[3].HeaderText = "Personel TC";
            dataGridView1.Columns[4].HeaderText = "Personel Telefon";
            dataGridView1.Columns[5].HeaderText = "Personel Mail";
            dataGridView1.Columns[6].HeaderText = "Personel Nick";
            dataGridView1.Columns[7].HeaderText = "Personel Şifre";

            dataGridView1.Columns[8].HeaderText = "Personel Görev";
            dataGridView1.Columns[9].HeaderText = "Personel Adres";
            dataGridView1.Columns[10].HeaderText = "Personel Cinsiyet";


        }


        private void GeriDon_Click(object sender, EventArgs e)
        {
            Islemler panel = new Islemler();
            panel.Show();
            this.Hide();
        }

  
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void pkaydet_Click_1(object sender, EventArgs e)
        {
            if (padi.Text == "" || psoyadi.Text == "" || pmail.Text == "" || ptc.Text == "" || ptelefon.Text == "" || pnick.Text == "" || psifre.Text == "" || pgorev.Text == "" || padres.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }

            else
            {
                personel.perisim = padi.Text;
                personel.persoyad = psoyadi.Text;
                personel.permail = pmail.Text;
                personel.perTC = ptc.Text;
                personel.perTel = ptelefon.Text;
                personel.pernick = pnick.Text;
                personel.persifre = psifre.Text;
                personel.pgorev = pgorev.Text;
                personel.padres = padres.Text;

                if (radioE.Checked == true)
                {
                    personel.pcinsiyet = "E";
                }
                else if (radioK.Checked == true)
                {
                    personel.pcinsiyet = "K";
                }
                else if (radioB.Checked == true)
                {
                    personel.pcinsiyet = "-";
                }

                db.Personeller.Add(personel);
                db.SaveChanges();
                Listele();
            }
        }

        private void Psil_Click_1(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var personel = db.Personeller.Where(x => x.personelID == secilensatir).FirstOrDefault();
            db.Personeller.Remove(personel);
            db.SaveChanges();
            Listele();
        }

        private void Pguncelle_Click_1(object sender, EventArgs e)
        {
            int secilensatir = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var personell = db.Personeller.Where(x => x.personelID == secilensatir).FirstOrDefault();
            personell.perisim = padi.Text;
            personell.persoyad = psoyadi.Text;
            personell.permail = pmail.Text;
            personell.perTC = ptc.Text;
            personell.perTel = ptelefon.Text;
            personell.pernick = pnick.Text;
            personell.persifre = psifre.Text;
            personell.pgorev = pgorev.Text;
            personell.padres = padres.Text;

            if (radioE.Checked == true)
            {
                personell.pcinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                personell.pcinsiyet = "K";
            }
            else if (radioB.Checked == true)
            {
                personel.pcinsiyet = "-";
            }

            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            padi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            psoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ptc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ptelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pnick.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            psifre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pgorev.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            padres.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();


            if (dataGridView1.CurrentRow.Cells[10].Value.ToString().Equals("E"))
            {
                radioE.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[10].Value.ToString().Equals("K"))
            {
                radioK.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[10].Value.ToString().Equals("-"))
            {
                radioB.Checked = true;
            }
   
        }
    }
}