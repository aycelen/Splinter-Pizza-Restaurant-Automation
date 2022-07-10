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
    public partial class LogIn : Form
    {
        PizzaEntities db = new PizzaEntities();
        
            public LogIn()
        {
            InitializeComponent();
            personelpanel.BackColor = Color.FromArgb(150, Color.Black);
            pb1.BackColor = Color.FromArgb(150, Color.Gray);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
           
        }

        private void GirisButonu_Click(object sender, EventArgs e)
        {
            string personeladi = personeladitb.Text;
            string personelsifre=personelsifretb.Text;

            //linq sorguları
            var personel = db.Personeller.Where(x => x.pernick.Equals(personeladi)&& x.persifre.Equals(personelsifre)).FirstOrDefault();            

            if (personel==null)
            {
                MessageBox.Show("Kullanıcı adı veya şifrenizi hatalı girdiniz!");

            }
            else
            {
                MessageBox.Show("Başarılı.");
                Islemler panel = new Islemler();
                panel.Show();
                this.Hide();


            }
        }

        private void cikisbutonu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak İstediğinizie Emin Misiniz?","Hu hu ayrılıyorsun kaptannnn !!!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

