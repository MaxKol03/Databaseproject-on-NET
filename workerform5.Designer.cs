
namespace ShoppingMallDB
{
    partial class workerform5
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
            System.Windows.Forms.Label название_магазинаLabel;
            System.Windows.Forms.Label iD_Объекта_недвижимостиLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label график_работыLabel;
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.торговая_точкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_точкаTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.Торговая_точкаTableAdapter();
            this.tableAdapterManager = new ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager();
            this.название_магазинаTextBox = new System.Windows.Forms.TextBox();
            this.график_работыTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.названиемагазинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.графикработыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.торговаяточкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.номер_телефонаNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iD_Объекта_недвижимостиComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            название_магазинаLabel = new System.Windows.Forms.Label();
            iD_Объекта_недвижимостиLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            график_работыLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_точкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_телефонаNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // название_магазинаLabel
            // 
            название_магазинаLabel.AutoSize = true;
            название_магазинаLabel.Location = new System.Drawing.Point(99, 134);
            название_магазинаLabel.Name = "название_магазинаLabel";
            название_магазинаLabel.Size = new System.Drawing.Size(141, 17);
            название_магазинаLabel.TabIndex = 1;
            название_магазинаLabel.Text = "Название магазина:";
            // 
            // iD_Объекта_недвижимостиLabel
            // 
            iD_Объекта_недвижимостиLabel.AutoSize = true;
            iD_Объекта_недвижимостиLabel.Location = new System.Drawing.Point(54, 178);
            iD_Объекта_недвижимостиLabel.Name = "iD_Объекта_недвижимостиLabel";
            iD_Объекта_недвижимостиLabel.Size = new System.Drawing.Size(186, 17);
            iD_Объекта_недвижимостиLabel.TabIndex = 3;
            iD_Объекта_недвижимостиLabel.Text = "ID Объекта недвижимости:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(115, 226);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(125, 17);
            номер_телефонаLabel.TabIndex = 5;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // график_работыLabel
            // 
            график_работыLabel.AutoSize = true;
            график_работыLabel.Location = new System.Drawing.Point(125, 276);
            график_работыLabel.Name = "график_работыLabel";
            график_работыLabel.Size = new System.Drawing.Size(115, 17);
            график_работыLabel.TabIndex = 7;
            график_работыLabel.Text = "График работы:";
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // торговая_точкаBindingSource
            // 
            this.торговая_точкаBindingSource.DataMember = "Торговая_точка";
            this.торговая_точкаBindingSource.DataSource = this.shopMallDataSet;
            // 
            // торговая_точкаTableAdapter
            // 
            this.торговая_точкаTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Торговая_точкаTableAdapter = this.торговая_точкаTableAdapter;
            // 
            // название_магазинаTextBox
            // 
            this.название_магазинаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговая_точкаBindingSource, "Название_магазина", true));
            this.название_магазинаTextBox.Location = new System.Drawing.Point(246, 131);
            this.название_магазинаTextBox.Name = "название_магазинаTextBox";
            this.название_магазинаTextBox.Size = new System.Drawing.Size(158, 22);
            this.название_магазинаTextBox.TabIndex = 2;
            // 
            // график_работыTextBox
            // 
            this.график_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговая_точкаBindingSource, "График_работы", true));
            this.график_работыTextBox.Location = new System.Drawing.Point(246, 273);
            this.график_работыTextBox.Name = "график_работыTextBox";
            this.график_работыTextBox.Size = new System.Drawing.Size(158, 22);
            this.график_работыTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Учет магазинов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиемагазинаDataGridViewTextBoxColumn,
            this.iDОбъектанедвижимостиDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.графикработыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.торговая_точкаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(76, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 191);
            this.dataGridView1.TabIndex = 10;
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
            // торговаяточкаBindingSource
            // 
            this.торговаяточкаBindingSource.DataMember = "Торговая_точка";
            this.торговаяточкаBindingSource.DataSource = this.shopMallDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить новые данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить  магазин";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // номер_телефонаNumericUpDown
            // 
            this.номер_телефонаNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.торговая_точкаBindingSource, "Номер_телефона", true));
            this.номер_телефонаNumericUpDown.Location = new System.Drawing.Point(246, 224);
            this.номер_телефонаNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.номер_телефонаNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.номер_телефонаNumericUpDown.Name = "номер_телефонаNumericUpDown";
            this.номер_телефонаNumericUpDown.Size = new System.Drawing.Size(158, 22);
            this.номер_телефонаNumericUpDown.TabIndex = 18;
            this.номер_телефонаNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // iD_Объекта_недвижимостиComboBox
            // 
            this.iD_Объекта_недвижимостиComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.торговая_точкаBindingSource, "ID_Объекта_недвижимости", true));
            this.iD_Объекта_недвижимостиComboBox.FormattingEnabled = true;
            this.iD_Объекта_недвижимостиComboBox.Location = new System.Drawing.Point(246, 175);
            this.iD_Объекта_недвижимостиComboBox.Name = "iD_Объекта_недвижимостиComboBox";
            this.iD_Объекта_недвижимостиComboBox.Size = new System.Drawing.Size(158, 24);
            this.iD_Объекта_недвижимостиComboBox.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Удалить магазин ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(514, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 46);
            this.label3.TabIndex = 22;
            this.label3.Text = "Примечание: удалить запись о магазине можно только если аренда под него закончила" +
    "сь";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 375);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 25);
            this.button4.TabIndex = 29;
            this.button4.Text = "Показать все";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 22);
            this.textBox1.TabIndex = 28;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(76, 375);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 25);
            this.button7.TabIndex = 27;
            this.button7.Text = "Найти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Поиск по названию:";
            // 
            // workerform5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 668);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.iD_Объекта_недвижимостиComboBox);
            this.Controls.Add(this.номер_телефонаNumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(график_работыLabel);
            this.Controls.Add(this.график_работыTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(iD_Объекта_недвижимостиLabel);
            this.Controls.Add(название_магазинаLabel);
            this.Controls.Add(this.название_магазинаTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerform5";
            this.Text = "Учет магазинов";
            this.Load += new System.EventHandler(this.workerform5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_точкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговаяточкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номер_телефонаNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource торговая_точкаBindingSource;
        private ShopMallDataSetTableAdapters.Торговая_точкаTableAdapter торговая_точкаTableAdapter;
        private ShopMallDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox название_магазинаTextBox;
        private System.Windows.Forms.TextBox график_работыTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиемагазинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбъектанедвижимостиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикработыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource торговаяточкаBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown номер_телефонаNumericUpDown;
        private System.Windows.Forms.ComboBox iD_Объекта_недвижимостиComboBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
    }
}