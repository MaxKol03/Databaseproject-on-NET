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
using System.Runtime.InteropServices;


namespace ShoppingMallDB
{
    public partial class workerform4 : Form
    {
        public workerform4()
        {
            InitializeComponent();
            iD_ПлатежаTextBox.ReadOnly = true;
        }


        private void workerform4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Платеж". При необходимости она может быть перемещена или удалена.
            this.платежTableAdapter.Fill(this.shopMallDataSet.Платеж);
            dataGridView1.ReadOnly = true;
            iD_ДоговораComboBox.Enabled = false;
            размерNumericUpDown.Enabled = false;
            датаDateTimePicker.Enabled = false;
            
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            // Добавляем список значений в поле ID_Арендатора
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT ID_Договора FROM Договор_аренды";
                SqlCommand command = new SqlCommand(query1, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iD_ДоговораComboBox.Items.Add(reader["ID_Договора"]);
                }

                // Закрыть читатель данных
                reader.Close();
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT Название_компании FROM Арендатор";
                SqlCommand command = new SqlCommand(query1, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Название_компании"]);
                }
                reader.Close();
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query2 = "SELECT ID_Объекта_недвижимости FROM Объект_недвижимости";
                SqlCommand command = new SqlCommand(query2, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["ID_Объекта_недвижимости"]);
                }
                reader.Close();
                connection.Close();
            }

        }

        private void iD_ПлатежаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iD_ДоговораComboBox.SelectedIndex = -1;
            iD_ДоговораComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
            платежBindingSource.AddNew();
            dataGridView1.Enabled = false;

            iD_ДоговораComboBox.Enabled = true;

            размерNumericUpDown.Enabled = true;
            dataGridView1.Enabled = false;
            размерNumericUpDown.Value = 500;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            int NewID;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string query = "SELECT MAX(ID_Платежа) FROM Платеж";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                NewID = maxID + 1;
            }
            iD_ПлатежаTextBox.Text = NewID.ToString();
            датаDateTimePicker.MinDate = DateTime.Today.AddMonths(-1);
            датаDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            датаDateTimePicker.Value = DateTime.Today;

            датаDateTimePicker.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.платежBindingSource.EndEdit();
                int rowsAffected = this.tableAdapterManager.UpdateAll(this.shopMallDataSet);
                //Вывод сообщения об успехе или ошибке
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Обновление таблицы прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Enabled = true;
                    
                    dataGridView1.ReadOnly = true;
                    iD_ДоговораComboBox.Enabled = false;
                    размерNumericUpDown.Enabled = false;
                    датаDateTimePicker.Enabled = false;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Изменений данных нет", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Вывод ошибки
            catch (Exception ex)
            {
                MessageBox.Show("Заполнить нужно все поля, проверьте данные: ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedCompanyName = comboBox1.Text;
            // Выполним запрос к базе данных для поиска ID арендатора по названию компании
            string query = "SELECT ID_Арендатора FROM Арендатор WHERE Название_компании = @CompanyName";
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            int ID_arend = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CompanyName", selectedCompanyName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    ID_arend = Convert.ToInt32(result);
                }
            }

            //Находим ID объектов недвижимости этого арендатора

            List<int> objectIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT ID_Договора FROM Договор_аренды WHERE ID_Арендатора = @ArendatorID";
                SqlCommand command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@ArendatorID", ID_arend);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    objectIDs.Add(Convert.ToInt32(reader["ID_Договора"]));
                }
                connection.Close();
            }
            if (objectIDs != null && objectIDs.Any())
            {
                string objectIDsString = string.Join(",", objectIDs.Select(id => id.ToString()));
                платежBindingSource.Filter = "ID_Договора IN (" + objectIDsString + ")";
            }
            else
            {
                // Обработка случая, когда objectIDs пустое множество
                платежBindingSource.Filter = "1=0"; // Очищаем фильтр
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedObj = comboBox2.Text;
            int objectID;
            List<int> contractIDs = new List<int>();
            if (int.TryParse(selectedObj, out objectID))
            {
                // Выполним запрос к базе данных для поиска ID арендатора по названию компании
                string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query1 = "SELECT ID_Договора FROM Договор_аренды WHERE ID_Объекта_недвижимости = @ObjectID";
                    SqlCommand command = new SqlCommand(query1, connection);
                    command.Parameters.AddWithValue("@ObjectID", objectID);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        contractIDs.Add(Convert.ToInt32(reader["ID_Договора"]));
                    }
                    connection.Close();
                }
            }
            if (contractIDs != null && contractIDs.Any())
            {
                string objectIDsString = string.Join(",", contractIDs.Select(id => id.ToString()));
                платежBindingSource.Filter = "ID_Договора IN (" + objectIDsString + ")";
            }
            else
            {
                // Обработка случая, когда objectIDs пустое множество
                платежBindingSource.Filter = "1=0"; // Очищаем фильтр
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            платежBindingSource.Filter = "";
        }

        private void датаDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            датаDateTimePicker.MaxDate = DateTime.Today;
        }
        private void датаDateTimePicker_DropDown(object sender, EventArgs e)
        {
            датаDateTimePicker.MaxDate = DateTime.Today;
        }

        private void iD_ДоговораComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
