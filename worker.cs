using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingMallDB
{
    public partial class worker : Form
    {
        public worker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new workerform1();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new workerform6();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new workerform2();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new workerform5();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new workerform3();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new workerform4();
            frm.Show();
        }
    }
}
