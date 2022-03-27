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
    public partial class _2_ANA_SAYFA : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public _2_ANA_SAYFA()
        {
            InitializeComponent();
        }
        public static string kullanicicek;
        private void _2_ANA_SAYFA_Load(object sender, System.EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select * from yazilar", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    _5_SORGU_SONUCU bes = new _5_SORGU_SONUCU();
                    bes.label1.Text = Convert.ToString(sqlDataReader["kategori"]);
                    bes.label2.Text = Convert.ToString(sqlDataReader["altbirim"]);
                    bes.label3.Text = Convert.ToString(sqlDataReader["sehiregore"]);
                    int yasdegis = Convert.ToInt32(sqlDataReader["yasaralik"]);
                    int yasdegis1 = yasdegis + 3;
                    int yasdegis2 = yasdegis - 3;
                    bes.label4.Text = ("" + yasdegis2 + "-" + yasdegis1);
                    bes.label5.Text = Convert.ToString(sqlDataReader["egitimduzey"]);
                  //  bes.label6.Text = Convert.ToString(sqlDataReader["Id"]);
                    

                    if (1 == Convert.ToInt32(sqlDataReader["sporrr"]))
                    {
                        bes.checkBox1.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["dizfilm"]))
                    {
                        bes.checkBox2.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["sosak"]))
                    {
                        bes.checkBox3.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["bilet"]))
                    {
                        bes.checkBox4.Checked = true;
                    }
                    if (1== Convert.ToInt32(sqlDataReader["tellet"]))
                    {
                        bes.checkBox5.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["sanark"]))
                    {
                        bes.checkBox6.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["dogakt"]))
                    {
                        bes.checkBox7.Checked = true;
                    }
                    bes.b();
                    bes.Show();
                    
                    this.Close();
                    return ;
                }                    
            }
        }
     



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void a()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            SqlCommand komut = new SqlCommand("select * from Kullanici", baglanti);
            using (SqlDataReader sqlDataReader = komut.ExecuteReader())
            {
                while (sqlDataReader.Read())
                {
                    comboBox3.Text = Convert.ToString(sqlDataReader["sehir"]);
                    comboBox4.Text = Convert.ToString(sqlDataReader["yas"]);
                    comboBox5.Text = Convert.ToString(sqlDataReader["egitim"]);
                    comboBox6.Text = Convert.ToString(sqlDataReader["cinsiyet"]);
                    if (1 == Convert.ToInt32(sqlDataReader["spor"]))
                    {
                        sporch.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["dizifilm"]))
                    {
                        dizich.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["sosyal"]))
                    {
                        sosyalch.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["bilgisayar"]))
                    {
                        bilgich.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["telefonetkin"]))
                    {
                        telefonch.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["sanal"]))
                    {
                        sanalch.Checked = true;
                    }
                    if (1 == Convert.ToInt32(sqlDataReader["doga"]))
                    {
                        dogach.Checked = true;
                    }

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            _6_YAZI_EKLEME ekle = new _6_YAZI_EKLEME();
            ekle.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _3__PROFİL _3__PROFİL = new _3__PROFİL();
            _3__PROFİL.Show();
            this.Close();
        }
    }
}
