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
    public partial class workerform6 : Form
    {
        public workerform6()
        {
            InitializeComponent();
            iD_СотрудникаTextBox.ReadOnly = true;
        }

        private void workerform6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet1.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter1.Fill(this.shopMallDataSet1.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.shopMallDataSet.Сотрудник);
            dataGridView1.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource2.AddNew();
            int NewID;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string query = "SELECT MAX(ID_Сотрудника) FROM Сотрудник";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                NewID = maxID + 1;
            }
            iD_СотрудникаTextBox.Text = NewID.ToString();
            comboBox1.Text = "Работает";
            dataGridView1.Enabled = false;
            button1.Enabled = false;
            телефонNumericUpDown.Value = 8000000000;
            button3.Enabled = false;
            button7.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                    this.Validate();
                    this.сотрудникBindingSource2.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.shopMallDataSet);
                    MessageBox.Show("Обновление данных прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button7.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Все поля кроме поля 'Зарплата' должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сотрудникBindingSource2_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource2.Filter = "ФИО LIKE '%" + textBox1.Text + "%' AND Должность LIKE '%" + textBox2.Text + "%'";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource2.Filter = "";
        }
    }
}
