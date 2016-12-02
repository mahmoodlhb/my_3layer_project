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
    public partial class barname_haftegi : Form
    {
        public barname_haftegi()
        {
            InitializeComponent();
        }

        private void barname_haftegi_Load(object sender, EventArgs e)
        {
            
            Business.sec p = new Business.sec();
            dataGridView1.DataSource = p.plan(welcome.stdid);
        }
    }
}
