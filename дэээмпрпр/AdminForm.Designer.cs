namespace дэээмпрпр
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idproductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            catbindingSource1 = new BindingSource(components);
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            manbindingSource1 = new BindingSource(components);
            suppliersIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            supbindingSource1 = new BindingSource(components);
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            unitbindingSource1 = new BindingSource(components);
            photoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            manufacturerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suppliersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prodbindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idproductDataGridViewTextBoxColumn, articleDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, manufacturerIdDataGridViewTextBoxColumn, suppliersIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, countDataGridViewTextBoxColumn, unitIdDataGridViewTextBoxColumn, photoDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, manufacturerDataGridViewTextBoxColumn, suppliersDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn });
            dataGridView1.DataSource = prodbindingSource1;
            dataGridView1.Location = new Point(20, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(756, 403);
            dataGridView1.TabIndex = 0;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            idproductDataGridViewTextBoxColumn.DataPropertyName = "Idproduct";
            idproductDataGridViewTextBoxColumn.HeaderText = "Idproduct";
            idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            articleDataGridViewTextBoxColumn.HeaderText = "Article";
            articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.DataSource = catbindingSource1;
            categoryIdDataGridViewTextBoxColumn.DisplayMember = "CategoriaName";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            categoryIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            categoryIdDataGridViewTextBoxColumn.ValueMember = "Idcategoria";
            // 
            // catbindingSource1
            // 
            catbindingSource1.DataSource = typeof(Models.Categorium);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // manufacturerIdDataGridViewTextBoxColumn
            // 
            manufacturerIdDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerId";
            manufacturerIdDataGridViewTextBoxColumn.DataSource = manbindingSource1;
            manufacturerIdDataGridViewTextBoxColumn.DisplayMember = "ManufacturName";
            manufacturerIdDataGridViewTextBoxColumn.HeaderText = "ManufacturerId";
            manufacturerIdDataGridViewTextBoxColumn.Name = "manufacturerIdDataGridViewTextBoxColumn";
            manufacturerIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            manufacturerIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            manufacturerIdDataGridViewTextBoxColumn.ValueMember = "Idmanufacturer";
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // suppliersIdDataGridViewTextBoxColumn
            // 
            suppliersIdDataGridViewTextBoxColumn.DataPropertyName = "SuppliersId";
            suppliersIdDataGridViewTextBoxColumn.DataSource = supbindingSource1;
            suppliersIdDataGridViewTextBoxColumn.DisplayMember = "SuppliersName";
            suppliersIdDataGridViewTextBoxColumn.HeaderText = "SuppliersId";
            suppliersIdDataGridViewTextBoxColumn.Name = "suppliersIdDataGridViewTextBoxColumn";
            suppliersIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            suppliersIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            suppliersIdDataGridViewTextBoxColumn.ValueMember = "Idsuppliers";
            // 
            // supbindingSource1
            // 
            supbindingSource1.DataSource = typeof(Models.Supplier);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "Count";
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            unitIdDataGridViewTextBoxColumn.DataSource = unitbindingSource1;
            unitIdDataGridViewTextBoxColumn.DisplayMember = "UnitName";
            unitIdDataGridViewTextBoxColumn.HeaderText = "UnitId";
            unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            unitIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            unitIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            unitIdDataGridViewTextBoxColumn.ValueMember = "Idunit";
            // 
            // unitbindingSource1
            // 
            unitbindingSource1.DataSource = typeof(Models.Unit);
            // 
            // photoDataGridViewTextBoxColumn
            // 
            photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            manufacturerDataGridViewTextBoxColumn.Visible = false;
            // 
            // suppliersDataGridViewTextBoxColumn
            // 
            suppliersDataGridViewTextBoxColumn.DataPropertyName = "Suppliers";
            suppliersDataGridViewTextBoxColumn.HeaderText = "Suppliers";
            suppliersDataGridViewTextBoxColumn.Name = "suppliersDataGridViewTextBoxColumn";
            suppliersDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodbindingSource1
            // 
            prodbindingSource1.DataSource = typeof(Models.Product);
            // 
            // button1
            // 
            button1.Location = new Point(20, 113);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 1;
            button1.Text = "редактировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 113);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 2;
            button2.Text = "удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(269, 113);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(379, 113);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "сохранить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(482, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 79);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Поиск";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(619, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(641, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 8;
            label2.Text = "Сортировка";
            // 
            // button5
            // 
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(93, 29);
            button5.TabIndex = 9;
            button5.Text = "Выйти";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(693, 18);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Заказы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button5;
        private Button button6;
        public BindingSource prodbindingSource1;
        public BindingSource manbindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource catbindingSource1;
        public BindingSource unitbindingSource1;
        private DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn manufacturerIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn suppliersIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn unitIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn suppliersDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        public Button button3;
        public Button button1;
        public Button button2;
        public Button button4;
    }
}