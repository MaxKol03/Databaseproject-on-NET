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
using System.Diagnostics;
namespace ShoppingMallDB
{
    public partial class workerform3 : Form
    {
        public workerform3()
        {
            InitializeComponent();
        }
        private void workerform3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Договор_аренды". При необходимости она может быть перемещена или удалена.
            this.договор_арендыTableAdapter.Fill(this.shopMallDataSet.Договор_аренды);
            dataGridView1.ReadOnly = true;
            //Блокируем редактирование уже существующих договоров
            iD_ДоговораTextBox.ReadOnly = true;
            iD_АрендатораComboBox.Enabled = false;
            iD_СотрудникаComboBox.Enabled = false;
            iD_Объекта_недвижимостиComboBox.Enabled = false;
            начало_действияDateTimePicker.Enabled = false;
            конец_действияDateTimePicker.MinDate = DateTime.Today;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            // Добавляем список значений в поле ID_Арендатора
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT ID_Арендатора FROM Арендатор";
                SqlCommand command = new SqlCommand(query1, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iD_АрендатораComboBox.Items.Add(reader["ID_Арендатора"]);
                }

                // Закрыть читатель данных
                reader.Close();
                connection.Close();
            }
            // Добавляем список значений в поле ID_Сотрудника
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query2 = "SELECT ID_Сотрудника FROM Сотрудник WHERE Должность='Менеджер аренды' AND Статус='Работает'";
                SqlCommand command = new SqlCommand(query2, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iD_СотрудникаComboBox.Items.Add(reader["ID_Сотрудника"]);
                }

                // Закрыть читатель данных
                reader.Close();
                connection.Close();
            }
            // Добавляем список значений в поле ID_Помещения
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
             // Добавляем список значений из столбца название_компании из таблицы Арендатор
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
        }
        private void iD_ДоговораTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            договор_арендыBindingSource.AddNew();
            iD_АрендатораComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            iD_СотрудникаComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            iD_Объекта_недвижимостиComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            iD_АрендатораComboBox.SelectedIndex = -1;
            iD_СотрудникаComboBox.SelectedIndex = -1;
            iD_АрендатораComboBox.Enabled = true;
            iD_СотрудникаComboBox.Enabled = true;
            iD_Объекта_недвижимостиComboBox.Enabled = true;
            начало_действияDateTimePicker.Enabled = true;
            начало_действияDateTimePicker.MinDate = DateTime.Today.AddDays(-1);
            начало_действияDateTimePicker.Value = DateTime.Today;
            конец_действияDateTimePicker.Value = DateTime.Today.AddMonths(1);
            dataGridView1.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            // Генерация ID договора
            int NewID;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string query = "SELECT MAX(ID_Договора) FROM Договор_аренды";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                object result = command.ExecuteScalar();
                int maxID = Convert.ToInt32(result);
                NewID = maxID + 1;
                connection.Close();
            }

            iD_ДоговораTextBox.Text = NewID.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                // Завершаем редактирование источника данных
                this.договор_арендыBindingSource.EndEdit();

                // Обновляем данные в таблице "Договор_аренды"
                this.договор_арендыTableAdapter.Update(this.shopMallDataSet.Договор_аренды);

                dataGridView1.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                // Получаем ID выбранного объекта недвижимости
                

                // Выводим сообщение об успешном обновлении
                MessageBox.Show("Обновление таблицы прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, выводим сообщение об ошибке
                MessageBox.Show("Произошла ошибка при обновлении данных, выберите значение для всех полей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void договор_арендыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void начало_действияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            конец_действияDateTimePicker.MinDate = начало_действияDateTimePicker.Value.AddMonths(1);
            начало_действияDateTimePicker.MinDate = DateTime.Today;
        }
        private void начало_действияDateTimePicker_Click(object sender, EventArgs e)
        {
            начало_действияDateTimePicker.MinDate = DateTime.Today;
        }
        private void конец_действияDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedCompanyName = comboBox1.Text;
            // Выполним запрос к базе данных для поиска ID арендатора по названию компании
            string query = "SELECT ID_Арендатора FROM Арендатор WHERE Название_компании = @CompanyName";
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            int ID_arend = 1;
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
            договор_арендыBindingSource.Filter = "ID_арендатора = " + ID_arend;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            договор_арендыBindingSource.Filter = "";
        }
    }
}
