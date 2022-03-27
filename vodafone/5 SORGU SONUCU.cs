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
    public partial class _5_SORGU_SONUCU : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Vodafone1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public _5_SORGU_SONUCU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_ANA_SAYFA aNA_SAYFA = new _2_ANA_SAYFA();
            aNA_SAYFA.a();
            aNA_SAYFA.Show();
                this.Close();
        }
        public void b()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }
            listView1.Items.Clear();
            SqlCommand sqlcom = new SqlCommand("select * from yazilar where  sehiregore + egitimduzey like '" + label3.Text + label5.Text + "'", baglanti);
            using  (SqlDataReader okudu = sqlcom.ExecuteReader())
                {
                while (okudu.Read())
                {
                    ListViewItem ekledi = new ListViewItem();
                    ekledi.Text = okudu["Id"].ToString();
                    ekledi.SubItems.Add(okudu["ad"].ToString());
                    ekledi.SubItems.Add(okudu["baslk"].ToString());
                    ekledi.SubItems.Add(okudu["Faydalı"].ToString());
                    ekledi.SubItems.Add(okudu["Faydasız "].ToString());
                    listView1.Items.Add(ekledi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            { Form2 form = new Form2();
                
               form.ıde = listView1.SelectedItems[0].SubItems[0].Text;
               form.kulad= listView1.SelectedItems[0].SubItems[1].Text;
                form.isimsoyisim();
                form.yazi();
               form.Show();
                


            }
        }
       
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

