using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Business;

namespace hw3
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            business obj = new business();
            obj.name = name.Text;
            obj.lastname = lname.Text;
            obj.sex = sex.Text;
            obj.studentId = int.Parse(studentid.Text);
            obj.tell = int.Parse(tell.Text);
            obj.password = pass.Text;
            obj.fildID = int.Parse(courseid.Text);
            obj.address = address.Text;
            obj.add();
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            new Form1().Show();
            this.Hide();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
