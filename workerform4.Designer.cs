
namespace ShoppingMallDB
{
    partial class workerform4
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
            System.Windows.Forms.Label iD_ПлатежаLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label iD_ДоговораLabel;
            System.Windows.Forms.Label размерLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.платежBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.платежTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.ПлатежTableAdapter();
            this.tableAdapterManager = new ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager();
            this.iD_ПлатежаTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDПлатежаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.платежBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.iD_ДоговораComboBox = new System.Windows.Forms.ComboBox();
            this.размерNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_ПлатежаLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            iD_ДоговораLabel = new System.Windows.Forms.Label();
            размерLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ПлатежаLabel
            // 
            iD_ПлатежаLabel.AutoSize = true;
            iD_ПлатежаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ПлатежаLabel.Location = new System.Drawing.Point(128, 96);
            iD_ПлатежаLabel.Name = "iD_ПлатежаLabel";
            iD_ПлатежаLabel.Size = new System.Drawing.Size(92, 18);
            iD_ПлатежаLabel.TabIndex = 1;
            iD_ПлатежаLabel.Text = "ID Платежа:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(173, 241);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(47, 18);
            датаLabel.TabIndex = 7;
            датаLabel.Text = "Дата:";
            // 
            // iD_ДоговораLabel
            // 
            iD_ДоговораLabel.AutoSize = true;
            iD_ДоговораLabel.Location = new System.Drawing.Point(128, 152);
            iD_ДоговораLabel.Name = "iD_ДоговораLabel";
            iD_ДоговораLabel.Size = new System.Drawing.Size(92, 17);
            iD_ДоговораLabel.TabIndex = 15;
            iD_ДоговораLabel.Text = "ID Договора:";
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(159, 196);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(61, 17);
            размерLabel.TabIndex = 16;
            размерLabel.Text = "Размер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(79, 412);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 18);
            label2.TabIndex = 20;
            label2.Text = "Арендатор (поиск):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(56, 509);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(164, 18);
            label3.TabIndex = 21;
            label3.Text = "ID помещения (поиск):";
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // платежBindingSource
            // 
            this.платежBindingSource.DataMember = "Платеж";
            this.платежBindingSource.DataSource = this.shopMallDataSet;
            // 
            // платежTableAdapter
            // 
            this.платежTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаторTableAdapter = null;
            this.tableAdapterManager.Договор_арендыTableAdapter = null;
            this.tableAdapterManager.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager.ПлатежTableAdapter = this.платежTableAdapter;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Торговая_точкаTableAdapter = null;
            // 
            // iD_ПлатежаTextBox
            // 
            this.iD_ПлатежаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.платежBindingSource, "ID_Платежа", true));
            this.iD_ПлатежаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ПлатежаTextBox.Location = new System.Drawing.Point(242, 96);
            this.iD_ПлатежаTextBox.Name = "iD_ПлатежаTextBox";
            this.iD_ПлатежаTextBox.Size = new System.Drawing.Size(200, 24);
            this.iD_ПлатежаTextBox.TabIndex = 2;
            this.iD_ПлатежаTextBox.TextChanged += new System.EventHandler(this.iD_ПлатежаTextBox_TextChanged);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.платежBindingSource, "Дата", true));
            this.датаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.датаDateTimePicker.Location = new System.Drawing.Point(242, 241);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.датаDateTimePicker.TabIndex = 8;
            this.датаDateTimePicker.ValueChanged += new System.EventHandler(this.датаDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Учет платежей";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПлатежаDataGridViewTextBoxColumn,
            this.iDДоговораDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.платежBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(569, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(725, 486);
            this.dataGridView1.TabIndex = 10;
            // 
            // iDПлатежаDataGridViewTextBoxColumn
            // 
            this.iDПлатежаDataGridViewTextBoxColumn.DataPropertyName = "ID_Платежа";
            this.iDПлатежаDataGridViewTextBoxColumn.HeaderText = "ID_Платежа";
            this.iDПлатежаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПлатежаDataGridViewTextBoxColumn.Name = "iDПлатежаDataGridViewTextBoxColumn";
            this.iDПлатежаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDДоговораDataGridViewTextBoxColumn
            // 
            this.iDДоговораDataGridViewTextBoxColumn.DataPropertyName = "ID_Договора";
            this.iDДоговораDataGridViewTextBoxColumn.HeaderText = "ID_Договора";
            this.iDДоговораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDДоговораDataGridViewTextBoxColumn.Name = "iDДоговораDataGridViewTextBoxColumn";
            this.iDДоговораDataGridViewTextBoxColumn.Width = 125;
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.размерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            this.размерDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            this.датаDataGridViewTextBoxColumn.Width = 125;
            // 
            // платежBindingSource1
            // 
            this.платежBindingSource1.DataMember = "Платеж";
            this.платежBindingSource1.DataSource = this.shopMallDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 32);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить новые данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить  платеж";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iD_ДоговораComboBox
            // 
            this.iD_ДоговораComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.платежBindingSource, "ID_Договора", true));
            this.iD_ДоговораComboBox.FormattingEnabled = true;
            this.iD_ДоговораComboBox.Location = new System.Drawing.Point(242, 149);
            this.iD_ДоговораComboBox.Name = "iD_ДоговораComboBox";
            this.iD_ДоговораComboBox.Size = new System.Drawing.Size(200, 24);
            this.iD_ДоговораComboBox.TabIndex = 16;
            this.iD_ДоговораComboBox.SelectedIndexChanged += new System.EventHandler(this.iD_ДоговораComboBox_SelectedIndexChanged);
            // 
            // размерNumericUpDown
            // 
            this.размерNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.платежBindingSource, "Размер", true));
            this.размерNumericUpDown.Location = new System.Drawing.Point(243, 196);
            this.размерNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.размерNumericUpDown.Name = "размерNumericUpDown";
            this.размерNumericUpDown.Size = new System.Drawing.Size(199, 22);
            this.размерNumericUpDown.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 406);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 503);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(204, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 32);
            this.button3.TabIndex = 22;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 32);
            this.button4.TabIndex = 23;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(238, 611);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(204, 32);
            this.button5.TabIndex = 24;
            this.button5.Text = "Показать все";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // workerform4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 693);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(размерLabel);
            this.Controls.Add(this.размерNumericUpDown);
            this.Controls.Add(iD_ДоговораLabel);
            this.Controls.Add(this.iD_ДоговораComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(iD_ПлатежаLabel);
            this.Controls.Add(this.iD_ПлатежаTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerform4";
            this.Text = "Платежи";
            this.Load += new System.EventHandler(this.workerform4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.размерNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource платежBindingSource;
        private ShopMallDataSetTableAdapters.ПлатежTableAdapter платежTableAdapter;
        private ShopMallDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_ПлатежаTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПлатежаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource платежBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox iD_ДоговораComboBox;
        private System.Windows.Forms.NumericUpDown размерNumericUpDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}