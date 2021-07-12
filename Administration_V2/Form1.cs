using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administration_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=CTOR01\SQLEXPRESS;Initial Catalog=Administration;Integrated Security=True");

        DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx.Open();
            pw.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text != "" && pw.Text != "")
            {

                SqlDataAdapter sa = new SqlDataAdapter("Select Count(*) from directeur where Username ='" + user.Text + "'and PW='" + pw.Text + "' ", cnx);
                sa.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form2 obj1 = new Form2();
                    obj1.Show();
                }
                else
                { label2.Show(); }


            }
            else
            {
               label1.Show() ;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
