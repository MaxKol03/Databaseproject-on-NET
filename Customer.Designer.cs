
namespace ShoppingMallDB
{
    partial class customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label iD_АрендатораLabel;
            System.Windows.Forms.Label label2;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.торговаяточкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_точкаTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.Торговая_точкаTableAdapter();
            this.shopMallDataSet1 = new ShoppingMallDB.ShopMallDataSet1();
            this.торговаяточкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_точкаTableAdapter1 = new ShoppingMallDB.ShopMallDataSet1TableAdapters.Торговая_точкаTableAdapter();
            this.торговаяточкаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.shopMallDataSet11 = new ShoppingMallDB.ShopMallDataSet1();
            this.shopMallDataSet2 = new ShoppingMallDB.ShopMallDataSet2();
            this.торговаяточкаBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_точкаTableAdapter2 = new ShoppingMallDB.ShopMallDataSet2TableAdapters.Торговая_точкаTableAdapter();
            this.названиемагазинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графикработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типмагазинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            iD_АрендатораLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиемагазинаDataGridViewTextBoxColumn,
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.графикработыDataGridViewTextBoxColumn,
            this.типмагазинаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.торговаяточкаBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(62, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Поесть",
            "Одежда",
            "Техника",
            "Обувь",
            "Аксессуары",
            "Прочее"});
            this.comboBox1.Location = new System.Drawing.Point(771, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(58, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(212, 24);
            label1.TabIndex = 2;
            label1.Text = "Каталог магазинов ТЦ";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(555, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(840, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать все";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=ShopMall;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // iD_АрендатораLabel
            // 
            iD_АрендатораLabel.AutoSize = true;
            iD_АрендатораLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_АрендатораLabel.Location = new System.Drawing.Point(481, 27);
            iD_АрендатораLabel.Name = "iD_АрендатораLabel";
            iD_АрендатораLabel.Size = new System.Drawing.Size(208, 18);
            iD_АрендатораLabel.TabIndex = 24;
            iD_АрендатораLabel.Text = "Можете выбрать категорию:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(536, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 18);
            label2.TabIndex = 25;
            label2.Text = "Поиск по названию:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(771, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговаяточкаBindingSource
            // 
            this.торговаяточкаBindingSource.DataMember = "Торговая_точка";
            this.торговаяточкаBindingSource.DataSource = this.shopMallDataSet;
            // 
            // торговая_точкаTableAdapter
            // 
            this.торговая_точкаTableAdapter.ClearBeforeFill = true;
            // 
            // shopMallDataSet1
            // 
            this.shopMallDataSet1.DataSetName = "ShopMallDataSet1";
            this.shopMallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговаяточкаBindingSource1
            // 
            this.торговаяточкаBindingSource1.DataMember = "Торговая_точка";
            this.торговаяточкаBindingSource1.DataSource = this.shopMallDataSet1;
            // 
            // торговая_точкаTableAdapter1
            // 
            this.торговая_точкаTableAdapter1.ClearBeforeFill = true;
            // 
            // торговаяточкаBindingSource2
            // 
            this.торговаяточкаBindingSource2.DataMember = "Торговая_точка";
            this.торговаяточкаBindingSource2.DataSource = this.shopMallDataSet1;
            // 
            // shopMallDataSet11
            // 
            this.shopMallDataSet11.DataSetName = "ShopMallDataSet1";
            this.shopMallDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopMallDataSet2
            // 
            this.shopMallDataSet2.DataSetName = "ShopMallDataSet2";
            this.shopMallDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговаяточкаBindingSource3
            // 
            this.торговаяточкаBindingSource3.DataMember = "Торговая_точка";
            this.торговаяточкаBindingSource3.DataSource = this.shopMallDataSet2;
            // 
            // торговая_точкаTableAdapter2
            // 
            this.торговая_точкаTableAdapter2.ClearBeforeFill = true;
            // 
            // названиемагазинаDataGridViewTextBoxColumn
            // 
            this.названиемагазинаDataGridViewTextBoxColumn.DataPropertyName = "Название_магазина";
            this.названиемагазинаDataGridViewTextBoxColumn.HeaderText = "Название_магазина";
            this.названиемагазинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиемагазинаDataGridViewTextBoxColumn.Name = "названиемагазинаDataGridViewTextBoxColumn";
            this.названиемагазинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОбъектанедвижимостиDataGridViewTextBoxColumn
            // 
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.DataPropertyName = "ID_Объекта_недвижимости";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.HeaderText = "ID_Объекта_недвижимости";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.Name = "iDОбъектанедвижимостиDataGridViewTextBoxColumn";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.Width = 125;
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.Width = 125;
            // 
            // графикработыDataGridViewTextBoxColumn
            // 
            this.графикработыDataGridViewTextBoxColumn.DataPropertyName = "График_работы";
            this.графикработыDataGridViewTextBoxColumn.HeaderText = "График_работы";
            this.графикработыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.графикработыDataGridViewTextBoxColumn.Name = "графикработыDataGridViewTextBoxColumn";
            this.графикработыDataGridViewTextBoxColumn.Width = 125;
            // 
            // типмагазинаDataGridViewTextBoxColumn
            // 
            this.типмагазинаDataGridViewTextBoxColumn.DataPropertyName = "Тип_магазина";
            this.типмагазинаDataGridViewTextBoxColumn.HeaderText = "Тип_магазина";
            this.типмагазинаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типмагазинаDataGridViewTextBoxColumn.Name = "типмагазинаDataGridViewTextBoxColumn";
            this.типмагазинаDataGridViewTextBoxColumn.Width = 125;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 497);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(iD_АрендатораLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customer";
            this.Text = "Посетитель";
            this.Load += new System.EventHandler(this.customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TextBox textBox1;
        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource торговаяточкаBindingSource;
        private ShopMallDataSetTableAdapters.Торговая_точкаTableAdapter торговая_точкаTableAdapter;
        private ShopMallDataSet1 shopMallDataSet1;
        private System.Windows.Forms.BindingSource торговаяточкаBindingSource1;
        private ShopMallDataSet1TableAdapters.Торговая_точкаTableAdapter торговая_точкаTableAdapter1;
        private System.Windows.Forms.BindingSource торговаяточкаBindingSource2;
        private ShopMallDataSet1 shopMallDataSet11;
        private ShopMallDataSet2 shopMallDataSet2;
        private System.Windows.Forms.BindingSource торговаяточкаBindingSource3;
        private ShopMallDataSet2TableAdapters.Торговая_точкаTableAdapter торговая_точкаTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиемагазинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбъектанедвижимостиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типмагазинаDataGridViewTextBoxColumn;
    }
}