using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vodafone
{
    public partial class _1_KAYIT : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public _1_KAYIT()
        {
            InitializeComponent();
        }

        private void geriKayit_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Close();
        }
        public int a = 0;
        public int b = 0;
        public int c = 0;
        public int d = 0;
        public int q = 0;
        public int f = 0;
        public int g = 0;
        private void ekonomiCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (true)
            {
                 a = 1;
            }
 
        }

        private void siysetCheck_CheckedChanged(object sender, EventArgs e)
        {
          b = 1;   
        }

        private void teknolojiCheck_CheckedChanged(object sender, EventArgs e)
        {
          c = 1;
        }

        private void sporCheck_CheckedChanged(object sender, EventArgs e)
        {        
         d = 1;         
        }

        private void uzayCheck_CheckedChanged(object sender, EventArgs e)
        {
         q = 1;
        }

        private void arabaCheck_CheckedChanged(object sender, EventArgs e)
        {
        f = 1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          g = 1;
        }

        private void kayitKayit_Click(object sender, EventArgs e)
        { string kayit = "insert into Kullanici (kullaniciAdi,isim,soyisim,yas,sehir,egitim,mail,telefon,cinsiyet,sifre,spor,dizifilm,sosyal,bilgisayar,telefonetkin,sanal,doga) values (@kullani,@izim,@soyizim,@ys,@sehr,@egit,@mai,@tel,@cins,@sif,@spr,@diz,@sos,@bil,@telet,@san,@dog)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            if (baglanti.State==ConnectionState.Closed)
            {
                baglanti.Open();
            }
            if (textBox6.Text == textBox7.Text)
            {
                komut.Parameters.AddWithValue("@izim",textBox1.Text);
                komut.Parameters.AddWithValue("@soyizim",textBox2.Text);
                komut.Parameters.AddWithValue("@kullani",textBox3.Text);
                komut.Parameters.AddWithValue("@ys",comboBox2.Text);
                komut.Parameters.AddWithValue("@sehr",comboBox4.Text);
                komut.Parameters.AddWithValue("@egit",comboBox3.Text);
                komut.Parameters.AddWithValue("@mai",textBox4.Text);
                komut.Parameters.AddWithValue("@tel",textBox5.Text);
                komut.Parameters.AddWithValue("@cins", comboBox1.Text);
                komut.Parameters.AddWithValue("@sif", textBox6.Text);
                komut.Parameters.AddWithValue("@spr", a);
            komut.Parameters.AddWithValue("@diz", b);
            komut.Parameters.AddWithValue("@sos", c);
            komut.Parameters.AddWithValue("@bil", d);
            komut.Parameters.AddWithValue("@telet", q);
            komut.Parameters.AddWithValue("@san", f);
            komut.Parameters.AddWithValue("@dog", g);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                
                baglanti.Close();
                MessageBox.Show("kayıt tamamlnadı!");


            }
            else
                MessageBox.Show("Şifreler uyuşmamaktadır!");
            

        }
        

       
    }
}
