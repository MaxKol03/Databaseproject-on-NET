
namespace ShoppingMallDB
{
    partial class workerform1
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
            System.Windows.Forms.Label название_компанииLabel;
            System.Windows.Forms.Label телефон_представителяLabel;
            System.Windows.Forms.Label iD_АрендатораLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.shopMallDataSet = new ShoppingMallDB.ShopMallDataSet();
            this.арендаторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.арендаторTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.АрендаторTableAdapter();
            this.tableAdapterManager = new ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDАрендатораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиекомпанииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонпредставителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендаторBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.арендаторBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.сотрудникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникTableAdapter = new ShoppingMallDB.ShopMallDataSetTableAdapters.СотрудникTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.название_компанииTextBox = new System.Windows.Forms.TextBox();
            this.iD_АрендатораTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.shopMallDataSet1 = new ShoppingMallDB.ShopMallDataSet1();
            this.арендаторBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.арендаторTableAdapter1 = new ShoppingMallDB.ShopMallDataSet1TableAdapters.АрендаторTableAdapter();
            this.tableAdapterManager1 = new ShoppingMallDB.ShopMallDataSet1TableAdapters.TableAdapterManager();
            this.телефон_представителяNumericUpDown = new System.Windows.Forms.NumericUpDown();
            название_компанииLabel = new System.Windows.Forms.Label();
            телефон_представителяLabel = new System.Windows.Forms.Label();
            iD_АрендатораLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефон_представителяNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // название_компанииLabel
            // 
            название_компанииLabel.AutoSize = true;
            название_компанииLabel.Location = new System.Drawing.Point(174, 136);
            название_компанииLabel.Name = "название_компанииLabel";
            название_компанииLabel.Size = new System.Drawing.Size(144, 17);
            название_компанииLabel.TabIndex = 21;
            название_компанииLabel.Text = "Название компании:";
            // 
            // телефон_представителяLabel
            // 
            телефон_представителяLabel.AutoSize = true;
            телефон_представителяLabel.Location = new System.Drawing.Point(142, 184);
            телефон_представителяLabel.Name = "телефон_представителяLabel";
            телефон_представителяLabel.Size = new System.Drawing.Size(176, 17);
            телефон_представителяLabel.TabIndex = 22;
            телефон_представителяLabel.Text = "Телефон представителя:";
            // 
            // iD_АрендатораLabel
            // 
            iD_АрендатораLabel.AutoSize = true;
            iD_АрендатораLabel.Location = new System.Drawing.Point(209, 94);
            iD_АрендатораLabel.Name = "iD_АрендатораLabel";
            iD_АрендатораLabel.Size = new System.Drawing.Size(109, 17);
            iD_АрендатораLabel.TabIndex = 23;
            iD_АрендатораLabel.Text = "ID Арендатора:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Учет арендаторов";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // shopMallDataSet
            // 
            this.shopMallDataSet.DataSetName = "ShopMallDataSet";
            this.shopMallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендаторBindingSource
            // 
            this.арендаторBindingSource.DataMember = "Арендатор";
            this.арендаторBindingSource.DataSource = this.shopMallDataSet;
            // 
            // арендаторTableAdapter
            // 
            this.арендаторTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShoppingMallDB.ShopMallDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаторTableAdapter = this.арендаторTableAdapter;
            this.tableAdapterManager.Договор_арендыTableAdapter = null;
            this.tableAdapterManager.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager.ПлатежTableAdapter = null;
            this.tableAdapterManager.СотрудникTableAdapter = null;
            this.tableAdapterManager.Торговая_точкаTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDАрендатораDataGridViewTextBoxColumn,
            this.названиекомпанииDataGridViewTextBoxColumn,
            this.телефонпредставителяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.арендаторBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(69, 354);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 236);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDАрендатораDataGridViewTextBoxColumn
            // 
            this.iDАрендатораDataGridViewTextBoxColumn.DataPropertyName = "ID_Арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.HeaderText = "Номер арендатора";
            this.iDАрендатораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDАрендатораDataGridViewTextBoxColumn.Name = "iDАрендатораDataGridViewTextBoxColumn";
            this.iDАрендатораDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиекомпанииDataGridViewTextBoxColumn
            // 
            this.названиекомпанииDataGridViewTextBoxColumn.DataPropertyName = "Название_компании";
            this.названиекомпанииDataGridViewTextBoxColumn.HeaderText = "Название компании";
            this.названиекомпанииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиекомпанииDataGridViewTextBoxColumn.Name = "названиекомпанииDataGridViewTextBoxColumn";
            this.названиекомпанииDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонпредставителяDataGridViewTextBoxColumn
            // 
            this.телефонпредставителяDataGridViewTextBoxColumn.DataPropertyName = "Телефон_представителя";
            this.телефонпредставителяDataGridViewTextBoxColumn.HeaderText = "Телефон представителя";
            this.телефонпредставителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонпредставителяDataGridViewTextBoxColumn.Name = "телефонпредставителяDataGridViewTextBoxColumn";
            this.телефонпредставителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // арендаторBindingSource2
            // 
            this.арендаторBindingSource2.DataMember = "Арендатор";
            this.арендаторBindingSource2.DataSource = this.shopMallDataSet;
            // 
            // арендаторBindingSource1
            // 
            this.арендаторBindingSource1.DataMember = "Арендатор";
            this.арендаторBindingSource1.DataSource = this.shopMallDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить  арендатора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Сохранить новые данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Поиск по названию:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(69, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 25);
            this.button7.TabIndex = 20;
            this.button7.Text = "Найти";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // название_компанииTextBox
            // 
            this.название_компанииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаторBindingSource2, "Название_компании", true));
            this.название_компанииTextBox.Location = new System.Drawing.Point(375, 131);
            this.название_компанииTextBox.Name = "название_компанииTextBox";
            this.название_компанииTextBox.Size = new System.Drawing.Size(157, 22);
            this.название_компанииTextBox.TabIndex = 22;
            // 
            // iD_АрендатораTextBox
            // 
            this.iD_АрендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаторBindingSource2, "ID_Арендатора", true));
            this.iD_АрендатораTextBox.Location = new System.Drawing.Point(375, 91);
            this.iD_АрендатораTextBox.Name = "iD_АрендатораTextBox";
            this.iD_АрендатораTextBox.Size = new System.Drawing.Size(157, 22);
            this.iD_АрендатораTextBox.TabIndex = 24;
            this.iD_АрендатораTextBox.TextChanged += new System.EventHandler(this.iD_АрендатораTextBox_TextChanged_3);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 25);
            this.button3.TabIndex = 25;
            this.button3.Text = "Показать все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // shopMallDataSet1
            // 
            this.shopMallDataSet1.DataSetName = "ShopMallDataSet1";
            this.shopMallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендаторBindingSource3
            // 
            this.арендаторBindingSource3.DataMember = "Арендатор";
            this.арендаторBindingSource3.DataSource = this.shopMallDataSet1;
            // 
            // арендаторTableAdapter1
            // 
            this.арендаторTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TestTableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ShoppingMallDB.ShopMallDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.АрендаторTableAdapter = this.арендаторTableAdapter1;
            this.tableAdapterManager1.Договор_арендыTableAdapter = null;
            this.tableAdapterManager1.Объект_недвижимостиTableAdapter = null;
            this.tableAdapterManager1.ПлатежTableAdapter = null;
            this.tableAdapterManager1.СотрудникTableAdapter = null;
            this.tableAdapterManager1.Торговая_точкаTableAdapter = null;
            // 
            // телефон_представителяNumericUpDown
            // 
            this.телефон_представителяNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.арендаторBindingSource2, "Телефон_представителя", true));
            this.телефон_представителяNumericUpDown.Location = new System.Drawing.Point(375, 184);
            this.телефон_представителяNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.телефон_представителяNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.телефон_представителяNumericUpDown.Name = "телефон_представителяNumericUpDown";
            this.телефон_представителяNumericUpDown.Size = new System.Drawing.Size(157, 22);
            this.телефон_представителяNumericUpDown.TabIndex = 26;
            this.телефон_представителяNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // workerform1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 648);
            this.Controls.Add(this.телефон_представителяNumericUpDown);
            this.Controls.Add(this.button3);
            this.Controls.Add(iD_АрендатораLabel);
            this.Controls.Add(this.iD_АрендатораTextBox);
            this.Controls.Add(телефон_представителяLabel);
            this.Controls.Add(название_компанииLabel);
            this.Controls.Add(this.название_компанииTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workerform1";
            this.Text = "Учет сотрудников";
            this.Load += new System.EventHandler(this.workerform1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopMallDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаторBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.телефон_представителяNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ShopMallDataSet shopMallDataSet;
        private System.Windows.Forms.BindingSource арендаторBindingSource;
        private ShopMallDataSetTableAdapters.АрендаторTableAdapter арендаторTableAdapter;
        private ShopMallDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource арендаторBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource сотрудникBindingSource;
        private ShopMallDataSetTableAdapters.СотрудникTableAdapter сотрудникTableAdapter;
        private System.Windows.Forms.BindingSource арендаторBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАрендатораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиекомпанииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонпредставителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox название_компанииTextBox;
        private System.Windows.Forms.TextBox iD_АрендатораTextBox;
        private System.Windows.Forms.Button button3;
        private ShopMallDataSet1 shopMallDataSet1;
        private System.Windows.Forms.BindingSource арендаторBindingSource3;
        private ShopMallDataSet1TableAdapters.АрендаторTableAdapter арендаторTableAdapter1;
        private ShopMallDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.NumericUpDown телефон_представителяNumericUpDown;
    }
}