using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vodafone
{
    public partial class _3__PROFİL : Form
    {
        public _3__PROFİL()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _2_ANA_SAYFA _2_ANA_SAYFA = new _2_ANA_SAYFA();
            _2_ANA_SAYFA.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _7_HESAP_AYARLARI hESAP_AYARLARI = new _7_HESAP_AYARLARI();
            hESAP_AYARLARI.Show();
            this.Close();
        }
    }
}
