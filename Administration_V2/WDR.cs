using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_V2
{
    public partial class WDR : Form
    {
        public WDR()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ajt_imp ob = new ajt_imp();
            ob.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modf_imp ob = new modf_imp();
            ob.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            supp_imp ob = new supp_imp();
            ob.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imp_GRID o = new Imp_GRID();
            o.Show();
        }
    }
}
