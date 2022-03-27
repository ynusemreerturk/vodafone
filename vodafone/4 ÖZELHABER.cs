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
    public partial class Form2 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public string ıde;
        public string kulad;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi();

            SqlCommand commander = new SqlCommand(" update uyeler set Faydalı=@fayd where Id=@ıdee ", baglanti);
            commander.Parameters.AddWithValue("@fayd", Convert.ToString(x + 1));
        }
        public void yazi()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select * from yazilar where Id like '" + ıde + "'", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {

                    textBox1.Text = Convert.ToString(sqlDataReader["yazim"]);


                }
            }
        }
        public int x;
        public int z;
        public void sayi()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select * from yazilar where Id like '" + ıde + "'", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {

                    x = Convert.ToInt32(sqlDataReader["Faydalı"]);
                    z = Convert.ToInt32(sqlDataReader["Faydasız"]);
                    button1.Visible = false;

                }
            }
        }
        public void isimsoyisim()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select * from Kullanici where KullaniciAdi like '" + kulad + "'", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {

                    label1.Text = Convert.ToString(sqlDataReader["isim"]);
                    label2.Text = Convert.ToString(sqlDataReader["soyisim"]);


                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi();

            SqlCommand commander = new SqlCommand(" update uyeler set Faydalı=@fayd where Id=@ıdee ", baglanti);
            commander.Parameters.AddWithValue("@fayd", Convert.ToString(z + 1));
            button2.Visible = false;
        }
    }
} 
