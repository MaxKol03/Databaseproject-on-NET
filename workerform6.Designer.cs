
namespace ShoppingMallDB
{
    partial class workerform6
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
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label зарплатаLabel;
            System.Windows.Forms.Label статусLabel;
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager = new ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager();
            this.сотрудникBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.shopMallDataSet1 = new ShoppingMallDB.ShopMallDataSet1();
            this.сотрудникBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter1 = new ShoppingMallDB.ShopMallDataSet1TableAdapters.СотрудникTableAdapter();
            this.tableAdapterManager1 = new ShoppingMallDB.ShopMallDataSet1TableAdapters.TableAdapterManager();
            this.iD_СотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.сотрудникBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.телефонNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.зарплатаNumericUpDown = new System.Windows.Forms.NumericUpDown();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            статусLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Location = new System.Drawing.Point(35, 139);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(135, 17);
            iD_СотрудникаLabel.TabIndex = 12;
            iD_СотрудникаLabel.Text = "Номер сотрудника:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(35, 189);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 13;
            фИОLabel.Text = "ФИО:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(35, 229);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(85, 17);
            должностьLabel.TabIndex = 14;
            должностьLabel.Text = "Должность:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(35, 271);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 15;
            телефонLabel.Text = "Телефон:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Location = new System.Drawing.Point(35, 318);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(76, 17);
            зарплатаLabel.TabIndex = 16;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // статусLabel
            // 
            статусLabel.AutoSize = true;
            статусLabel.Location = new System.Drawing.Point(35, 363);
            статусLabel.Name = "статусLabel";
            статусLabel.Size = new System.Drawing.Size(57, 17);
            статусLabel.TabIndex = 17;
            статусLabel.Text = "Статус:";
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource
            // 
            this.сотрудникBindingSource.DataMember = "Сотрудник";
            this.сотрудникBindingSource.DataSource = this.shopMallDataSet;
            // 
            // сотрудникTableAdapter
            // 
            this.сотрудникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаторTableAdapter = null;
            this.tableAdapterManager.Договор_арендыTableAdapter = null;
            this.tableAdapterManager.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager.ПлатежTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = this.сотрудникTableAdapter;
            this.tableAdapterManager.Торговая_точкаTableAdapter = null;
            // 
            // сотрудникBindingSource1
            // 
            this.сотрудникBindingSource1.DataMember = "Сотрудник";
            this.сотрудникBindingSource1.DataSource = this.shopMallDataSet;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 59);
            this.label1.TabIndex = 11;
            this.label1.Text = "Учет сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shopMallDataSet1
            // 
            this.shopMallDataSet1.DataSetName = "ShopMallDataSet1";
            this.shopMallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникBindingSource2
            // 
            this.сотрудникBindingSource2.DataMember = "Сотрудник";
            this.сотрудникBindingSource2.DataSource = this.shopMallDataSet1;
            this.сотрудникBindingSource2.CurrentChanged += new System.EventHandler(this.сотрудникBindingSource2_CurrentChanged);
            // 
            // сотрудникTableAdapter1
            // 
            this.сотрудникTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TestTableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ShoppingMallDB.ShopMallDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.АрендаторTableAdapter = null;
            this.tableAdapterManager1.Договор_арендыTableAdapter = null;
            this.tableAdapterManager1.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager1.ПлатежTableAdapter = null;
            this.tableAdapterManager1.СотрудникTableAdapter = this.сотрудникTableAdapter1;
            this.tableAdapterManager1.Торговая_точкаTableAdapter = null;
            // 
            // iD_СотрудникаTextBox
            // 
            this.iD_СотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource2, "ID_Сотрудника", true));
            this.iD_СотрудникаTextBox.Location = new System.Drawing.Point(198, 139);
            this.iD_СотрудникаTextBox.Name = "iD_СотрудникаTextBox";
            this.iD_СотрудникаTextBox.Size = new System.Drawing.Size(129, 22);
            this.iD_СотрудникаTextBox.TabIndex = 13;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource2, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(198, 184);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(129, 22);
            this.фИОTextBox.TabIndex = 14;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource2, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(198, 229);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(129, 22);
            this.должностьTextBox.TabIndex = 15;
            // 
            // сотрудникBindingSource3
            // 
            this.сотрудникBindingSource3.DataMember = "Сотрудник";
            this.сотрудникBindingSource3.DataSource = this.shopMallDataSet1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Сохранить новые данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить  сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(387, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 241);
            this.dataGridView1.TabIndex = 22;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "Номер сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникBindingSource2, "Статус", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Работает",
            "Уволен"});
            this.comboBox1.Location = new System.Drawing.Point(198, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(538, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 22);
            this.textBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поиск по ФИО:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 457);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(457, 22);
            this.textBox2.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Поиск по должности:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(842, 502);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 29);
            this.button3.TabIndex = 30;
            this.button3.Text = "Показать все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 502);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 29);
            this.button7.TabIndex = 31;
            this.button7.Text = "Найти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // телефонNumericUpDown
            // 
            this.телефонNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникBindingSource2, "Телефон", true));
            this.телефонNumericUpDown.Location = new System.Drawing.Point(198, 271);
            this.телефонNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.телефонNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.телефонNumericUpDown.Name = "телефонNumericUpDown";
            this.телефонNumericUpDown.Size = new System.Drawing.Size(129, 22);
            this.телефонNumericUpDown.TabIndex = 32;
            this.телефонNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // зарплатаNumericUpDown
            // 
            this.зарплатаNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сотрудникBindingSource2, "Зарплата", true));
            this.зарплатаNumericUpDown.Location = new System.Drawing.Point(198, 316);
            this.зарплатаNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.зарплатаNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.зарплатаNumericUpDown.Name = "зарплатаNumericUpDown";
            this.зарплатаNumericUpDown.Size = new System.Drawing.Size(129, 22);
            this.зарплатаNumericUpDown.TabIndex = 33;
            this.зарплатаNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workerform6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 580);
            this.Controls.Add(this.зарплатаNumericUpDown);
            this.Controls.Add(this.телефонNumericUpDown);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(статусLabel);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerform6";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.workerform6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефонNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.зарплатаNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private ShopMallDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private ShopMallDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource сотрудникBindingSource1;
        private System.Windows.Forms.Label label1;
        private ShopMallDataSet1 shopMallDataSet1;
        private System.Windows.Forms.BindingSource сотрудникBindingSource2;
        private ShopMallDataSet1TableAdapters.СотрудникTableAdapter сотрудникTableAdapter1;
        private ShopMallDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox iD_СотрудникаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.BindingSource сотрудникBindingSource3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown телефонNumericUpDown;
        private System.Windows.Forms.NumericUpDown зарплатаNumericUpDown;
    }
}