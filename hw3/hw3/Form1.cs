
using Business;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw3
{
    public partial class Form1 : Form
    {
        public static DataTable tablemodel = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            business da = new business();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new register().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login s = new login();
            if (s.loginclass(txtpass.Text, int.Parse(txtstdid.Text)).Rows.Count>0)
            {
                tablemodel = s.loginclass(txtpass.Text, int.Parse(txtstdid.Text));
                
                new welcome().Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            new deletuser().Show();
        }

        
    }
}
