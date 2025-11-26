
namespace ShoppingMallDB
{
    partial class workerform3
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
            System.Windows.Forms.Label iD_ДоговораLabel;
            System.Windows.Forms.Label начало_действияLabel;
            System.Windows.Forms.Label конец_действияLabel;
            System.Windows.Forms.Label iD_АрендатораLabel;
            System.Windows.Forms.Label iD_СотрудникаLabel;
            System.Windows.Forms.Label iD_Объекта_недвижимостиLabel;
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.договор_арендыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договор_арендыTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.Договор_арендыTableAdapter();
            this.tableAdapterManager = new ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager();
            this.iD_ДоговораTextBox = new System.Windows.Forms.TextBox();
            this.начало_действияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.конец_действияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАрендатораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началодействияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.конецдействияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iD_АрендатораComboBox = new System.Windows.Forms.ComboBox();
            this.iD_СотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.iD_Объекта_недвижимостиComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            iD_ДоговораLabel = new System.Windows.Forms.Label();
            начало_действияLabel = new System.Windows.Forms.Label();
            конец_действияLabel = new System.Windows.Forms.Label();
            iD_АрендатораLabel = new System.Windows.Forms.Label();
            iD_СотрудникаLabel = new System.Windows.Forms.Label();
            iD_Объекта_недвижимостиLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договор_арендыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ДоговораLabel
            // 
            iD_ДоговораLabel.AutoSize = true;
            iD_ДоговораLabel.Location = new System.Drawing.Point(89, 106);
            iD_ДоговораLabel.Name = "iD_ДоговораLabel";
            iD_ДоговораLabel.Size = new System.Drawing.Size(119, 17);
            iD_ДоговораLabel.TabIndex = 8;
            iD_ДоговораLabel.Text = "Номер договора:";
            // 
            // начало_действияLabel
            // 
            начало_действияLabel.AutoSize = true;
            начало_действияLabel.Location = new System.Drawing.Point(81, 281);
            начало_действияLabel.Name = "начало_действияLabel";
            начало_действияLabel.Size = new System.Drawing.Size(127, 17);
            начало_действияLabel.TabIndex = 10;
            начало_действияLabel.Text = "Начало действия:";
            // 
            // конец_действияLabel
            // 
            конец_действияLabel.AutoSize = true;
            конец_действияLabel.Location = new System.Drawing.Point(90, 330);
            конец_действияLabel.Name = "конец_действияLabel";
            конец_действияLabel.Size = new System.Drawing.Size(118, 17);
            конец_действияLabel.TabIndex = 11;
            конец_действияLabel.Text = "Конец действия:";
            // 
            // iD_АрендатораLabel
            // 
            iD_АрендатораLabel.AutoSize = true;
            iD_АрендатораLabel.Location = new System.Drawing.Point(73, 153);
            iD_АрендатораLabel.Name = "iD_АрендатораLabel";
            iD_АрендатораLabel.Size = new System.Drawing.Size(134, 17);
            iD_АрендатораLabel.TabIndex = 17;
            iD_АрендатораLabel.Text = "Номер арендатора";
            // 
            // iD_СотрудникаLabel
            // 
            iD_СотрудникаLabel.AutoSize = true;
            iD_СотрудникаLabel.Location = new System.Drawing.Point(72, 194);
            iD_СотрудникаLabel.Name = "iD_СотрудникаLabel";
            iD_СотрудникаLabel.Size = new System.Drawing.Size(135, 17);
            iD_СотрудникаLabel.TabIndex = 18;
            iD_СотрудникаLabel.Text = "Номер сотрудника:";
            // 
            // iD_Объекта_недвижимостиLabel
            // 
            iD_Объекта_недвижимостиLabel.AutoSize = true;
            iD_Объекта_недвижимостиLabel.Location = new System.Drawing.Point(72, 241);
            iD_Объекта_недвижимостиLabel.Name = "iD_Объекта_недвижимостиLabel";
            iD_Объекта_недвижимостиLabel.Size = new System.Drawing.Size(135, 17);
            iD_Объекта_недвижимостиLabel.TabIndex = 19;
            iD_Объекта_недвижимостиLabel.Text = "Номер помещения:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 75);
            this.label1.TabIndex = 7;
            this.label1.Text = "Учет договоров";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договор_арендыBindingSource
            // 
            this.договор_арендыBindingSource.DataMember = "Договор_аренды";
            this.договор_арендыBindingSource.DataSource = this.shopMallDataSet;
            this.договор_арендыBindingSource.CurrentChanged += new System.EventHandler(this.договор_арендыBindingSource_CurrentChanged);
            // 
            // договор_арендыTableAdapter
            // 
            this.договор_арендыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаторTableAdapter = null;
            this.tableAdapterManager.Договор_арендыTableAdapter = this.договор_арендыTableAdapter;
            this.tableAdapterManager.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager.ПлатежTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Торговая_точкаTableAdapter = null;
            // 
            // iD_ДоговораTextBox
            // 
            this.iD_ДоговораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_арендыBindingSource, "ID_Договора", true));
            this.iD_ДоговораTextBox.Location = new System.Drawing.Point(214, 103);
            this.iD_ДоговораTextBox.Name = "iD_ДоговораTextBox";
            this.iD_ДоговораTextBox.Size = new System.Drawing.Size(200, 22);
            this.iD_ДоговораTextBox.TabIndex = 9;
            this.iD_ДоговораTextBox.TextChanged += new System.EventHandler(this.iD_ДоговораTextBox_TextChanged);
            // 
            // начало_действияDateTimePicker
            // 
            this.начало_действияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договор_арендыBindingSource, "Начало_действия", true));
            this.начало_действияDateTimePicker.Location = new System.Drawing.Point(214, 276);
            this.начало_действияDateTimePicker.Name = "начало_действияDateTimePicker";
            this.начало_действияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.начало_действияDateTimePicker.TabIndex = 11;
            this.начало_действияDateTimePicker.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            this.начало_действияDateTimePicker.ValueChanged += new System.EventHandler(this.начало_действияDateTimePicker_ValueChanged);
            // 
            // конец_действияDateTimePicker
            // 
            this.конец_действияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договор_арендыBindingSource, "Конец_действия", true));
            this.конец_действияDateTimePicker.Location = new System.Drawing.Point(214, 327);
            this.конец_действияDateTimePicker.Name = "конец_действияDateTimePicker";
            this.конец_действияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.конец_действияDateTimePicker.TabIndex = 12;
            this.конец_действияDateTimePicker.ValueChanged += new System.EventHandler(this.конец_действияDateTimePicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDДоговораDataGridViewTextBoxColumn,
            this.iDАрендатораDataGridViewTextBoxColumn,
            this.началодействияDataGridViewTextBoxColumn,
            this.конецдействияDataGridViewTextBoxColumn,
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.договор_арендыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(63, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1120, 239);
            this.dataGridView1.TabIndex = 15;
            // 
            // iDДоговораDataGridViewTextBoxColumn
            // 
            this.iDДоговораDataGridViewTextBoxColumn.DataPropertyName = "ID_Договора";
            this.iDДоговораDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.iDДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDДоговораDataGridViewTextBoxColumn.Name = "iDДоговораDataGridViewTextBoxColumn";
            this.iDДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDАрендатораDataGridViewTextBoxColumn
            // 
            this.iDАрендатораDataGridViewTextBoxColumn.DataPropertyName = "ID_Арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.HeaderText = "Номер арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDАрендатораDataGridViewTextBoxColumn.Name = "iDАрендатораDataGridViewTextBoxColumn";
            this.iDАрендатораDataGridViewTextBoxColumn.Width = 125;
            // 
            // началодействияDataGridViewTextBoxColumn
            // 
            this.началодействияDataGridViewTextBoxColumn.DataPropertyName = "Начало_действия";
            this.началодействияDataGridViewTextBoxColumn.HeaderText = "Начало действия";
            this.началодействияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.началодействияDataGridViewTextBoxColumn.Name = "началодействияDataGridViewTextBoxColumn";
            this.началодействияDataGridViewTextBoxColumn.Width = 125;
            // 
            // конецдействияDataGridViewTextBoxColumn
            // 
            this.конецдействияDataGridViewTextBoxColumn.DataPropertyName = "Конец_действия";
            this.конецдействияDataGridViewTextBoxColumn.HeaderText = "Конец действия";
            this.конецдействияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.конецдействияDataGridViewTextBoxColumn.Name = "конецдействияDataGridViewTextBoxColumn";
            this.конецдействияDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "Номер сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОбъектанедвижимостиDataGridViewTextBoxColumn
            // 
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.DataPropertyName = "ID_Объекта_недвижимости";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.HeaderText = "Номер помещения";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.Name = "iDОбъектанедвижимостиDataGridViewTextBoxColumn";
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить  договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iD_АрендатораComboBox
            // 
            this.iD_АрендатораComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_арендыBindingSource, "ID_Арендатора", true));
            this.iD_АрендатораComboBox.FormattingEnabled = true;
            this.iD_АрендатораComboBox.Location = new System.Drawing.Point(214, 150);
            this.iD_АрендатораComboBox.Name = "iD_АрендатораComboBox";
            this.iD_АрендатораComboBox.Size = new System.Drawing.Size(200, 24);
            this.iD_АрендатораComboBox.TabIndex = 18;
            // 
            // iD_СотрудникаComboBox
            // 
            this.iD_СотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_арендыBindingSource, "ID_Сотрудника", true));
            this.iD_СотрудникаComboBox.FormattingEnabled = true;
            this.iD_СотрудникаComboBox.Location = new System.Drawing.Point(214, 191);
            this.iD_СотрудникаComboBox.Name = "iD_СотрудникаComboBox";
            this.iD_СотрудникаComboBox.Size = new System.Drawing.Size(200, 24);
            this.iD_СотрудникаComboBox.TabIndex = 19;
            // 
            // iD_Объекта_недвижимостиComboBox
            // 
            this.iD_Объекта_недвижимостиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договор_арендыBindingSource, "ID_Объекта_недвижимости", true));
            this.iD_Объекта_недвижимостиComboBox.FormattingEnabled = true;
            this.iD_Объекта_недвижимостиComboBox.Location = new System.Drawing.Point(214, 238);
            this.iD_Объекта_недвижимостиComboBox.Name = "iD_Объекта_недвижимостиComboBox";
            this.iD_Объекта_недвижимостиComboBox.Size = new System.Drawing.Size(200, 24);
            this.iD_Объекта_недвижимостиComboBox.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(624, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(468, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(150, 17);
            label2.TabIndex = 22;
            label2.Text = "Поиск по арендатору";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "Показать все";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // workerform3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 640);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(iD_Объекта_недвижимостиLabel);
            this.Controls.Add(this.iD_Объекта_недвижимостиComboBox);
            this.Controls.Add(iD_СотрудникаLabel);
            this.Controls.Add(this.iD_СотрудникаComboBox);
            this.Controls.Add(iD_АрендатораLabel);
            this.Controls.Add(this.iD_АрендатораComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(конец_действияLabel);
            this.Controls.Add(this.конец_действияDateTimePicker);
            this.Controls.Add(начало_действияLabel);
            this.Controls.Add(this.начало_действияDateTimePicker);
            this.Controls.Add(iD_ДоговораLabel);
            this.Controls.Add(this.iD_ДоговораTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerform3";
            this.Text = "Учет договоров";
            this.Load += new System.EventHandler(this.workerform3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договор_арендыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource договор_арендыBindingSource;
        private ShopMallDataSetTableAdapters.Договор_арендыTableAdapter договор_арендыTableAdapter;
        private ShopMallDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_ДоговораTextBox;
        private System.Windows.Forms.DateTimePicker начало_действияDateTimePicker;
        private System.Windows.Forms.DateTimePicker конец_действияDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox iD_АрендатораComboBox;
        private System.Windows.Forms.ComboBox iD_СотрудникаComboBox;
        private System.Windows.Forms.ComboBox iD_Объекта_недвижимостиComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАрендатораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началодействияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn конецдействияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбъектанедвижимостиDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}