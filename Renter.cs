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

    public partial class renter : Form
    {
        
        public renter()
        {
            InitializeComponent();
        }

        private void renter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Торговая_точка". При необходимости она может быть перемещена или удалена.
            this.торговая_точкаTableAdapter.Fill(this.shopMallDataSet.Торговая_точка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Платеж". При необходимости она может быть перемещена или удалена.
            this.платежTableAdapter.Fill(this.shopMallDataSet.Платеж);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Объект_недвижимости". При необходимости она может быть перемещена или удалена.
            this.объект_недвижимостиTableAdapter.Fill(this.shopMallDataSet.Объект_недвижимости);
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new customer();
            frm.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string companyName = textBox1.Text.Trim();
            string phoneNumber = textBox2.Text.Trim();
            int arrendatorID;
            // Проверяем, что значения не пустые
            if (!string.IsNullOrWhiteSpace(companyName) && !string.IsNullOrWhiteSpace(phoneNumber))
            {
                // Формируем запрос SQL для поиска арендатора
                string query = "SELECT ID_Арендатора FROM Арендатор WHERE Название_компании = @CompanyName AND Телефон_представителя = @PhoneNumber";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем параметры к запросу
                        command.Parameters.AddWithValue("@CompanyName", companyName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        connection.Open();
                        // Выполняем запрос и получаем результат
                        object result = command.ExecuteScalar();
                        connection.Close();

                        // Проверяем, найден ли арендатор
                        if (result != null)
                        {
                            // Преобразуем результат в int (ID_Арендатора)
                            arrendatorID = Convert.ToInt32(result);

                            dataGridView1.DataSource = this.объектнедвижимостиBindingSource1;
                            dataGridView3.DataSource = this.торговая_точкаBindingSource;
                            dataGridView2.DataSource = this.платежBindingSource;
                            List<int> objectIDs = new List<int>();

                            using (SqlConnection connection1 = new SqlConnection(connectionString))
                            {
                                connection1.Open();
                                string query1 = "SELECT ID_Объекта_недвижимости FROM Договор_аренды WHERE ID_Арендатора = @ArendatorID AND Конец_действия > GETDATE()";
                                SqlCommand command1 = new SqlCommand(query1, connection1);
                                command1.Parameters.AddWithValue("@ArendatorID", arrendatorID); // Используем переменную arrendatorID
                                SqlDataReader reader = command1.ExecuteReader();
                                while (reader.Read())
                                {
                                    objectIDs.Add(Convert.ToInt32(reader["ID_Объекта_недвижимости"]));
                                }
                                connection1.Close();
                            }

                            if (objectIDs != null && objectIDs.Any())
                            {
                                string objectIDsString = string.Join(",", objectIDs);
                                объектнедвижимостиBindingSource1.Filter = "ID_Объекта_недвижимости IN (" + objectIDsString + ")";
                                торговая_точкаBindingSource.Filter= "ID_Объекта_недвижимости IN (" + objectIDsString + ")";
                            }
                            else
                            {
                                объектнедвижимостиBindingSource1.Filter = "1=0"; // Очищаем фильтр
                                торговая_точкаBindingSource.Filter = "1=0";
                            }
                            //ищем платежи

                            List<int> objectIDs1 = new List<int>();
                            using (SqlConnection connection2 = new SqlConnection(connectionString))
                            {
                                connection2.Open();
                                string query3 = "SELECT ID_Договора FROM Договор_аренды WHERE ID_Арендатора = @ArendatorID";
                                SqlCommand command2 = new SqlCommand(query3, connection2);
                                command2.Parameters.AddWithValue("@ArendatorID", arrendatorID);
                                SqlDataReader reader = command2.ExecuteReader();
                                while (reader.Read())
                                {
                                    objectIDs1.Add(Convert.ToInt32(reader["ID_Договора"]));
                                }
                                connection2.Close();
                            }

                            if (objectIDs1.Any())
                            {
                                string objectIDsString = string.Join(",", objectIDs1);
                                платежBindingSource.Filter = "ID_Договора IN (" + objectIDsString + ")";
                            }
                            else
                            {
                                // Если objectIDs пустое множество, то фильтруем, чтобы ничего не отображалось
                                платежBindingSource.Filter = "1 = 0"; // Это всегда ложное утверждение
                            }

                            // Далее используйте переменную arrendatorID по вашему усмотрению
                        }
                        else
                        {
                            // Если арендатор не найден, выводим сообщение
                            MessageBox.Show("Такого арендатора не существует");
                        }
                    }
                }
            }
            else
            {
                // Если одно из полей пустое, выводим сообщение
                MessageBox.Show("Поля не должны быть пустыми");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
