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
    public partial class workerform2 : Form
    {
        public workerform2()
        {
            InitializeComponent();
        }

        private void workerform2_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";

            наличие_кухонного_оборудованияComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            наличие_оконComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.торговая_точкаTableAdapter.Fill(this.shopMallDataSet.Торговая_точка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Объект_недвижимости". При необходимости она может быть перемещена или удалена.
            this.объект_недвижимостиTableAdapter.Fill(this.shopMallDataSet.Объект_недвижимости);
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopMallDataSet.Объект_недвижимости". При необходимости она может быть перемещена или удалена.
            this.объект_недвижимостиTableAdapter.Fill(this.shopMallDataSet.Объект_недвижимости);
            dataGridView1.ReadOnly = true;

            dataGridView1.ReadOnly = true;
            iD_Объекта_недвижимостиTextBox.ReadOnly = true;
            этажComboBox.Enabled = false;
            номер_на_этажеTextBox.Enabled = false;
            площадьNumericUpDown.Enabled = false;
            наличие_оконComboBox.Enabled = false;
            наличие_подсобного_помещенияComboBox.Enabled = false;
            endDateTextBox.Enabled=false;

            int objectId = Convert.ToInt32(iD_Объекта_недвижимостиTextBox.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT TOP 1 Конец_действия FROM Договор_аренды WHERE ID_Объекта_недвижимости=@objectId ORDER BY Конец_действия DESC";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@objectId", objectId);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        DateTime endDate = Convert.ToDateTime(result);
                        string formattedDate = endDate.ToString("dd.MM.yyyy");
                        endDateTextBox.Text = formattedDate;
                }
                    else
                    {
                        // Если результат не найден, устанавливаем текст "Это помещение еще не было в аренде"
                        endDateTextBox.Text = "Это помещение еще не было в аренде";
                    }
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
        // Обработчик события CellFormatting

        private void iD_Объекта_недвижимостиTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (int.TryParse(iD_Объекта_недвижимостиTextBox.Text, out int objectId))
            {
                string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT TOP 1 Конец_действия FROM Договор_аренды WHERE ID_Объекта_недвижимости=@objectId ORDER BY Конец_действия DESC";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@objectId", objectId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            DateTime endDate = Convert.ToDateTime(result);
                            string formattedDate = endDate.ToString("dd.MM.yyyy");
                            endDateTextBox.Text = formattedDate;
                    }
                        else
                        {
                            // Если результат не найден, устанавливаем текст "Это помещение еще не было в аренде"
                            endDateTextBox.Text = "Это помещение еще не было в аренде";
                        }
                        connection.Close();
                    }
            }
            else { endDateTextBox.Text = ""; }
        }


        private void номер_на_этажеTextBox_TextChanged(object sender, EventArgs e)
        {
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = объект_недвижимостиBindingSource;
            this.Validate();
                this.объект_недвижимостиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.shopMallDataSet);
            
                MessageBox.Show("Обновление данных прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void цена_арендыTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;

            наличие_оконComboBox.Enabled = true;
            этажComboBox.Enabled = true;
            этажComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            статусComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            наличие_оконComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            наличие_подсобного_помещенияComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.DataSource = объект_недвижимостиBindingSource;

            площадьNumericUpDown.Enabled = true;

            наличие_оконComboBox.Enabled = true;

            наличие_подсобного_помещенияComboBox.Enabled = true;

            наличие_кухонного_оборудованияComboBox.Items.Add("Без выбора");

            iD_Объекта_недвижимостиTextBox.Text = "";

            этажComboBox.Text = "Этаж не выбран";

            номер_на_этажеTextBox.Text = "";

            площадьNumericUpDown.Value = 20;

            статусComboBox.Text = "";

            цена_арендыNumericUpDown.Value = 1000000;

            наличие_оконComboBox.Text = "Без выбора";

            наличие_кухонного_оборудованияComboBox.Text = "Без выбора";

            наличие_подсобного_помещенияComboBox.Text = "Без выбора";

            button1.Enabled = false;
        }

        private void этажLabel1_Click(object sender, EventArgs e)
        {

        }

        private void цена_арендыLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;
            button1.Enabled = true;

            dataGridView1.DataSource = объект_недвижимостиBindingSource;

            этажComboBox.Enabled = false;

            площадьNumericUpDown.Enabled = false;

            наличие_оконComboBox.Enabled = false;

            наличие_подсобного_помещенияComboBox.Enabled = false;

            наличие_кухонного_оборудованияComboBox.Items.Remove("Без выбора");

            iD_Объекта_недвижимостиTextBox.Text = ((int)((DataRowView)объект_недвижимостиBindingSource.Current)["ID_Объекта_недвижимости"]).ToString();

            этажComboBox.Text = ((int)((DataRowView)объект_недвижимостиBindingSource.Current)["Этаж"]).ToString();

            номер_на_этажеTextBox.Text = ((int)((DataRowView)объект_недвижимостиBindingSource.Current)["Номер_на_этаже"]).ToString();

            площадьNumericUpDown.Value = (int)((DataRowView)объект_недвижимостиBindingSource.Current)["Площадь"];

            статусComboBox.Text= (string)((DataRowView)объект_недвижимостиBindingSource.Current)["Статус"];

            цена_арендыNumericUpDown.Value = (int)((DataRowView)объект_недвижимостиBindingSource.Current)["Цена_аренды"];

            наличие_оконComboBox.Text= (string)((DataRowView)объект_недвижимостиBindingSource.Current)["Наличие_окон"];

            наличие_кухонного_оборудованияComboBox.Text= (string)((DataRowView)объект_недвижимостиBindingSource.Current)["Наличие_кухонного_оборудования"];

            наличие_подсобного_помещенияComboBox.Text= (string)((DataRowView)объект_недвижимостиBindingSource.Current)["Наличие_подсобного_помещения"];

            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;
            button1.Enabled = true;

            dataGridView1.DataSource = объект_недвижимостиBindingSource;
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;

            int цена = (int)цена_арендыNumericUpDown.Value;
            int площадь = (int)площадьNumericUpDown.Value;

            string a, b, c, d;

            if (этажComboBox.Text == "Этаж не выбран") { a = ""; }
            else { a = этажComboBox.Text; }

            if (наличие_оконComboBox.Text == "Без выбора") { b = "%"; }
            else { b = наличие_оконComboBox.Text; }

            if (наличие_кухонного_оборудованияComboBox.Text == "Без выбора") { c = "%"; }
            else { c = наличие_кухонного_оборудованияComboBox.Text; }

            if (наличие_подсобного_помещенияComboBox.Text == "Без выбора") { d = "%"; }
            else { d = наличие_подсобного_помещенияComboBox.Text; }

            string filter = "";
            if (!string.IsNullOrEmpty(a)) { filter += "Этаж = " + a + " AND "; }
            filter += "Цена_аренды <= " + цена + " AND Площадь >= " + площадь + " AND Наличие_окон LIKE '%" + b + "%' AND Наличие_кухонного_оборудования LIKE '%" + c + "%' AND Наличие_подсобного_помещения LIKE '%" + d + "%'";

            объект_недвижимостиBindingSource.Filter = filter;

        }

        private void endDateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;
            button1.Enabled = true;
            dataGridView1.DataSource = объект_недвижимостиBindingSource;
            объект_недвижимостиBindingSource.Filter = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            этажComboBox.Enabled = false;
            площадьNumericUpDown.Enabled = false;
            наличие_оконComboBox.Enabled = false;
            наличие_подсобного_помещенияComboBox.Enabled = false;

            цена_арендыNumericUpDown.Enabled = false;
            наличие_кухонного_оборудованияComboBox.Enabled = false;
            button1.Enabled = false;
            string connectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            string sqlQuery = @"
        SELECT Объект_недвижимости.*, Договор_аренды.Конец_действия 
        FROM Объект_недвижимости 
        LEFT JOIN Договор_аренды ON Объект_недвижимости.ID_Объекта_недвижимости = Договор_аренды.ID_Объекта_недвижимости
        WHERE Договор_аренды.Конец_действия = (
            SELECT TOP 1 Конец_действия
            FROM Договор_аренды
            WHERE Договор_аренды.ID_Объекта_недвижимости = Объект_недвижимости.ID_Объекта_недвижимости
            ORDER BY Конец_действия DESC
        ) OR Договор_аренды.Конец_действия IS NULL
        ORDER BY 
            ISNULL(Договор_аренды.Конец_действия, '1900-12-12'),
            Договор_аренды.Конец_действия";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                DataTable dataTable = new DataTable();

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();
                // Привязываем данные к DataGridView
                dataGridView1.DataSource = dataTable;
            }
            
        }
        private void button7_Click(object sender, EventArgs e)
        {
            цена_арендыNumericUpDown.Enabled = true;
            наличие_кухонного_оборудованияComboBox.Enabled = true;
            button1.Enabled = true;
            dataGridView1.DataSource = объект_недвижимостиBindingSource;
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

            //Находим ID объектов недвижимости этого арендатора

            List<int> objectIDs = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query1 = "SELECT ID_Объекта_недвижимости FROM Договор_аренды WHERE ID_Арендатора = @ArendatorID";
                SqlCommand command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@ArendatorID", ID_arend);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    objectIDs.Add(Convert.ToInt32(reader["ID_Объекта_недвижимости"]));
                }
                connection.Close();
            }
            if (objectIDs != null && objectIDs.Any())
            {
                string objectIDsString = string.Join(",", objectIDs.Select(id => id.ToString()));
                объект_недвижимостиBindingSource.Filter = "ID_Объекта_недвижимости IN (" + objectIDsString + ")";
            }
            else
            {
                // Обработка случая, когда objectIDs пустое множество
                объект_недвижимостиBindingSource.Filter = "1=0  "; // Очищаем фильтр
            }


        }

    }
}
