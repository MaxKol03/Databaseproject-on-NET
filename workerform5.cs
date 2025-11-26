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
    public partial class workerform5 : Form
    {
        public workerform5()
        {
            InitializeComponent();
        }

        private void workerform5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Торговая_точка". При необходимости она может быть перемещена или удалена.
            this.торговая_точкаTableAdapter.Fill(this.shopMallDataSet.Торговая_точка);
            dataGridView1.ReadOnly = true;
            название_магазинаTextBox.ReadOnly = true;
            iD_Объекта_недвижимостиComboBox.Enabled = false;
            
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query2 = "SELECT ID_Объекта_недвижимости FROM Объект_недвижимости WHERE Статус='Свободен'";
                SqlCommand command = new SqlCommand(query2, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iD_Объекта_недвижимостиComboBox.Items.Add(reader["ID_Объекта_недвижимости"]);
                }

                // Закрыть читатель данных
                reader.Close();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            название_магазинаTextBox.ReadOnly = false;
            iD_Объекта_недвижимостиComboBox.Enabled = true;
            iD_Объекта_недвижимостиComboBox.SelectedIndex = -1;
            торговая_точкаBindingSource.AddNew();
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            номер_телефонаNumericUpDown.Value = 8000000000;
            dataGridView1.Enabled = false;
            iD_Объекта_недвижимостиComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            try
            {
                // Получение выбранного ID_Объекта_недвижимости из ComboBox
                int selectedObjectID = Int32.Parse(iD_Объекта_недвижимостиComboBox.Text);

                // Проверка наличия записей в таблице Договор_аренды с указанным ID_Объекта_недвижимости и действующих на текущую дату
                bool hasRecords;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                SELECT COUNT(*) 
                FROM Договор_аренды 
                WHERE ID_Объекта_недвижимости = @ObjectID 
                AND Конец_действия > GETDATE()";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ObjectID", selectedObjectID);
                    int count = (int)command.ExecuteScalar();
                    hasRecords = count > 0;
                    connection.Close();
                }

                // Если записи есть, то удаляем текущую запись из торговой точки
                if (!hasRecords)
                {
                    торговая_точкаBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Нельзя удалить торговую точку, связанную с договором аренды, который еще действует.");
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Не удалось удалить запись, проверьте, все ли поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Здесь происходит попыптка обновления таблицы "Торговая точка"
            try
            {
                this.Validate();
                this.торговая_точкаBindingSource.EndEdit();
                int rowsAffected = this.tableAdapterManager.UpdateAll(this.shopMallDataSet);
                //Вывод сообщения об успехе или ошибке
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Обновление таблицы прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    dataGridView1.Enabled = true;

                    int objectId = Convert.ToInt32(iD_Объекта_недвижимостиComboBox.Text);

                    // Обновляем статус объекта недвижимости на "Занят"
                    string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
                    string updateQuery = "UPDATE Объект_недвижимости SET Статус = 'Занят' WHERE ID_Объекта_недвижимости = @ObjectId";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@ObjectId", objectId);
                        command.ExecuteNonQuery();
                    }

                    // Применяем изменения в источнике данных
                    this.shopMallDataSet.AcceptChanges();

                    string connectionString1 = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connectionString1))
                    {
                        connection.Open();
                        string query2 = "SELECT ID_Объекта_недвижимости FROM Объект_недвижимости WHERE Статус='Свободен'";
                        SqlCommand command = new SqlCommand(query2, connection);
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            iD_Объекта_недвижимостиComboBox.Items.Add(reader["ID_Объекта_недвижимости"]);
                        }

                        // Закрыть читатель данных
                        reader.Close();
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Вывод ошибки
            catch (Exception)
            {
                MessageBox.Show("Все поля должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            торговая_точкаBindingSource.Filter = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            торговая_точкаBindingSource.Filter = "Название_магазина LIKE '%" + textBox1.Text + "%'";
        }
    }
}
