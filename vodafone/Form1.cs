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
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
        }

        private void kayıtOl_Click(object sender, EventArgs e)
        {
            _1_KAYIT kayıt = new _1_KAYIT();
            kayıt.Show();
            this.Hide();

        }
        public int x ;
        private void girisAnasayfa_Click(object sender, EventArgs e)
        {
            c();
            if (baglanti.State == ConnectionState.Closed )
            {
                baglanti.Open();

            }
            
            SqlCommand komut = new SqlCommand("select * from Kullanici", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader()) {
                while (sqlDataReader.Read())
                {
                    if (Convert.ToString(sqlDataReader["kullaniciADi"]) == kullanıcAdi.Text && (Convert.ToString(sqlDataReader["sifre"]) == sifre.Text))
                    {
                        
                    
                        if (x != 2)
                        {
                            _2_ANA_SAYFA ana = new _2_ANA_SAYFA();
                            ana.button3.Visible = false;
                        
                        }
                        _6_YAZI_EKLEME ekleme = new _6_YAZI_EKLEME();
                        ekleme.adı = kullanıcAdi.Text;
                        
                        _2_ANA_SAYFA anasayfa = new _2_ANA_SAYFA();
                        _2_ANA_SAYFA.kullanicicek = kullanıcAdi.Text;
                        anasayfa.a();
                        anasayfa.Show();
                        this.Hide();
                        sqlDataReader.Close();
                        return; 
                    }

}

                    

                
            }
        }
        private void c()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            
            SqlCommand sqlcom = new SqlCommand("select * from Kullanici where  kullaniciADi like '" + kullanıcAdi.Text + "'", baglanti);
            using (SqlDataReader okudu = sqlcom.ExecuteReader())
            {
                while (okudu.Read())
                {
                    x = Convert.ToInt32(okudu["deger"]);
                }
            }
        }
    }
    }

