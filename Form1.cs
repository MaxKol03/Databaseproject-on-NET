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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new customer();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new renter();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new worker();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new test();
            frm.Show();
        }
    }
}
