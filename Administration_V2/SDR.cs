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
    public partial class SDR : Form
    {
        public SDR()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ajtExp ob = new ajtExp();
            ob.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            modf_Exp ob = new modf_Exp();
            ob.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            supp_Exp ob = new supp_Exp();
            ob.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Exp_GRID ob = new Exp_GRID();
            ob.Show();
        }
    }
}
