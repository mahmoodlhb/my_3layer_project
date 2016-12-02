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
    public partial class welcome : Form
    {
        Business.student std;
        public static int stdid;
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            List<Business.student> lst = new List<Business.student>();
            std = new Business.student();
            Business.studentsec sec=new Business.studentsec();
            lst = test(Form1.tablemodel);
            std=lst.First();
            txtlname.Text = std.lastname;
            txtname.Text = std.name;
            txtstdid.Text = std.studentId.ToString();
            dataGridView1.DataSource = sec.schedule();
            stdid = std.studentId;
           
        }
        private List<Business.student> test(DataTable dt)
        {
            var convertedList = (from rw in dt.AsEnumerable()
                                 select new Business.student()
                                 {
                                     id = Convert.ToInt32(rw["id"]),
                                     name = Convert.ToString(rw["name"]),
                                     lastname = Convert.ToString(rw["lastname"]),
                                     password = Convert.ToString(rw["password"]),
                                     studentId = Convert.ToInt32(rw["studentId"]),
                                     tell = Convert.ToInt32(rw["tell"]),
                                     address = Convert.ToString(rw["address"]),
                                     sex = Convert.ToString(rw["sex"]),
                                     fieldID = Convert.ToInt32(rw["fieldID"])
                                 }).ToList();

            return convertedList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(txtcode.Text);
                
                Business.business s = new Business.business();
                s.addtosection(stdid, code);
            }
            catch (Exception ex)
            {
                var f = ex;
            }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new barname_haftegi().Show();
        }
    }
}
