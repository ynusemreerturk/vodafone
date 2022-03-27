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
    public partial class _6_YAZI_EKLEME : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public _6_YAZI_EKLEME()
        {
            InitializeComponent();
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
        public string adı;
        

        private void button1_Click(object sender, EventArgs e)
        {
            string kayit = "insert into yazilar (ad,kategori,altbirim,sehiregore,yasaralik,egitimduzey,sporrr,dizfilm,sosak,bilet,tellet,sanark,dogakt,yazim,baslk) values (@adf,@kat,@alt,@sehir,@yasar,@egitim,@spr,@diz,@sos,@bil,@telet,@san,@dog,@yaz,@bas)";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            komut.Parameters.AddWithValue("@adf", adı);
            komut.Parameters.AddWithValue("@kat", comboBox5.Text);
            komut.Parameters.AddWithValue("@alt", comboBox3.Text);
            komut.Parameters.AddWithValue("@bas", textBox2.Text);
           komut.Parameters.AddWithValue("@yaz", textBox1.Text);
           
            komut.Parameters.AddWithValue("@sehir", comboBox4.Text);
            komut.Parameters.AddWithValue("@yasar", comboBox2.Text);
            komut.Parameters.AddWithValue("@egitim", comboBox1.Text);
            
            komut.Parameters.AddWithValue("@spr", a);
            komut.Parameters.AddWithValue("@diz", b);
            komut.Parameters.AddWithValue("@sos", c);
            komut.Parameters.AddWithValue("@bil", d);
            komut.Parameters.AddWithValue("@telet", q);
            komut.Parameters.AddWithValue("@san", f);
            komut.Parameters.AddWithValue("@dog", g);
            komut.ExecuteNonQuery();
            baglanti.Close();

           


       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2_ANA_SAYFA ana = new _2_ANA_SAYFA();
            ana.Show();
            this.Close();
        }

        private void _6_YAZI_EKLEME_Load(object sender, EventArgs e)
        {

        }
    } }
