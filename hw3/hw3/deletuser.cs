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
    public partial class deletuser : Form
    {
        public deletuser()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteuser del = new deleteuser();
            del.delete(txtuserpass.Text, int.Parse(txtuserid.Text));
        }
    }
}
