using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace hw3
{
    public partial class deluser : Form
    {
        public deluser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            deleteuser bs = new deleteuser();
            bs.delete(txtpass.Text,int.Parse(txtuserid.Text));
            MessageBox.Show("کاربر حذف شد");
        }
    }
}
