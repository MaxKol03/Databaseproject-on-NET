using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShoppingMallDB
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet2.Торговая_точка". При необходимости она может быть перемещена или удалена.
            this.торговая_точкаTableAdapter2.Fill(this.shopMallDataSet2.Торговая_точка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet1.Торговая_точка". При необходимости она может быть перемещена или удалена.
            this.торговая_точкаTableAdapter1.Fill(this.shopMallDataSet1.Торговая_точка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Торговая_точка". При необходимости она может быть перемещена или удалена.
            this.торговая_точкаTableAdapter.Fill(this.shopMallDataSet.Торговая_точка);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filterExpression = "";

            // Проверяем значение из textbox1
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                filterExpression += "Название_магазина LIKE '%" + textBox1.Text + "%'";
            }

            // Проверяем значение из combobox1
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                if (!string.IsNullOrEmpty(filterExpression))
                {
                    filterExpression += " AND ";
                }
                filterExpression += "Тип_магазина = '" + comboBox1.Text + "'";
            }
            // Применяем фильтр к BindingSource
            торговаяточкаBindingSource3.Filter = filterExpression;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            торговаяточкаBindingSource3.Filter = "";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
