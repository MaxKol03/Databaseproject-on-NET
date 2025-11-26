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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void арендаторBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.арендаторBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopMallDataSet);

        }

        private void test_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Арендатор". При необходимости она может быть перемещена или удалена.
            this.арендаторTableAdapter.Fill(this.shopMallDataSet.Арендатор);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.арендаторBindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
