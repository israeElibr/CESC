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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SDR ob = new SDR();
            ob.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WDR ob = new WDR();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            ob.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }
    }
}
