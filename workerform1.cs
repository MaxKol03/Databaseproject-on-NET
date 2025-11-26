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
    public partial class workerform1 : Form
    {
        public workerform1()
        {
            InitializeComponent();
        }
        private void workerform1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet1.Арендатор". При необходимости она может быть перемещена или удалена.
            this.арендаторTableAdapter1.Fill(this.shopMallDataSet1.Арендатор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet1.Арендатор". При необходимости она может быть перемещена или удалена.
            this.арендаторTableAdapter1.Fill(this.shopMallDataSet1.Арендатор);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.shopMallDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Арендатор". При необходимости она может быть перемещена или удалена.
            this.арендаторTableAdapter.Fill(this.shopMallDataSet.Арендатор);
            dataGridView1.ReadOnly = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            button3.Enabled = false;
            button7.Enabled = false;
            button1.Enabled = false;
            арендаторBindingSource2.AddNew();
            телефон_представителяNumericUpDown.Value = 8000000000;
            int NewID;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string query = "SELECT MAX(ID_Арендатора) FROM Арендатор";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                NewID = maxID + 1;
                connection.Close();
            }
            iD_АрендатораTextBox.Text = NewID.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int count = 0;
            string companyName = название_компанииTextBox.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["названиекомпанииDataGridViewTextBoxColumn"].Value != null && row.Cells["названиекомпанииDataGridViewTextBoxColumn"].Value.ToString() == companyName)
                {
                    count++;
                }
            }

            int count1 = 0;
            long phoneNumber = Convert.ToInt64(телефон_представителяNumericUpDown.Value); // Получаем значение из NumericUpdown

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Проверяем, что значение в ячейке не пустое и совпадает с введенным значением телефона представителя
                if (row.Cells["телефонпредставителяDataGridViewTextBoxColumn"].Value != DBNull.Value
                    && Convert.ToInt64(row.Cells["телефонпредставителяDataGridViewTextBoxColumn"].Value) == phoneNumber)
                {
                    count1++;
                }
            }

            if (count == 1 && count1 == 1)
            {
                try
                {
                    this.Validate();
                    this.арендаторBindingSource2.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.shopMallDataSet);
                    MessageBox.Show("Обновление данных прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Enabled = true;
                    button3.Enabled = true;
                    button7.Enabled = true;
                    button1.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Компания с таким названием или номером телефона уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            арендаторBindingSource2.Filter = "Название_компании LIKE '%" + textBox1.Text + "%'";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_АрендатораTextBox_TextChanged_3(object sender, EventArgs e)
        {
            iD_АрендатораTextBox.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            арендаторBindingSource2.Filter = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
