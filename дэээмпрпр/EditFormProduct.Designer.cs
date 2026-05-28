namespace дэээмпрпр
{
    partial class EditFormProduct
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
            button1 = new Button();
            prodbindingSource1 = new BindingSource(components);
            manbindingSource1 = new BindingSource(components);
            supbindingSource1 = new BindingSource(components);
            catbindingSource1 = new BindingSource(components);
            unitbindingSource1 = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox4 = new ComboBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)prodbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(170, 598);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // prodbindingSource1
            // 
            prodbindingSource1.DataSource = typeof(Models.Product);
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // supbindingSource1
            // 
            supbindingSource1.DataSource = typeof(Models.Supplier);
            // 
            // catbindingSource1
            // 
            catbindingSource1.DataSource = typeof(Models.Categorium);
            // 
            // unitbindingSource1
            // 
            unitbindingSource1.DataSource = typeof(Models.Unit);
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", prodbindingSource1, "Article", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox1.Location = new Point(170, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", prodbindingSource1, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(170, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", prodbindingSource1, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(170, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", prodbindingSource1, "CategoryId", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = catbindingSource1;
            comboBox1.DisplayMember = "CategoriaName";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.ValueMember = "Idcategoria";
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", manbindingSource1, "Idmanufacturer", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.DataSource = manbindingSource1;
            comboBox2.DisplayMember = "ManufacturName";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(169, 258);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.ValueMember = "Idmanufacturer";
            // 
            // comboBox3
            // 
            comboBox3.DataBindings.Add(new Binding("SelectedValue", supbindingSource1, "Idsuppliers", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox3.DataSource = supbindingSource1;
            comboBox3.DisplayMember = "SuppliersName";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(170, 305);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            comboBox3.ValueMember = "Idsuppliers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 60);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 118);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 8;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 162);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 9;
            label3.Text = "Категория";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 211);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Описание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 266);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 11;
            label5.Text = "Производитель";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 313);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Поставщик";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 360);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 13;
            label7.Text = "Цена";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(326, 393);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 14;
            label8.Text = "Скидка";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(324, 444);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 15;
            label9.Text = "Кол-во на складе";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(324, 498);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 16;
            label10.Text = "Единица измерения";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(324, 549);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 17;
            label11.Text = "Фото";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", prodbindingSource1, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.Location = new Point(170, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", prodbindingSource1, "Discount", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Location = new Point(170, 393);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", prodbindingSource1, "Count", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox6.Location = new Point(170, 441);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(120, 23);
            textBox6.TabIndex = 20;
            // 
            // comboBox4
            // 
            comboBox4.DataBindings.Add(new Binding("SelectedValue", unitbindingSource1, "Idunit", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox4.DataSource = unitbindingSource1;
            comboBox4.DisplayMember = "UnitName";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(170, 498);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 21;
            comboBox4.ValueMember = "Idunit";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", prodbindingSource1, "Photo", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox7.Location = new Point(169, 546);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(122, 23);
            textBox7.TabIndex = 22;
            // 
            // EditFormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 687);
            Controls.Add(textBox7);
            Controls.Add(comboBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "EditFormProduct";
            Text = "EditFormProduct";
            Load += EditFormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)prodbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitbindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public BindingSource prodbindingSource1;
        public BindingSource manbindingSource1;
        public BindingSource supbindingSource1;
        public BindingSource catbindingSource1;
        public BindingSource unitbindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        public Button button1;
        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        public ComboBox comboBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox textBox6;
        public ComboBox comboBox4;
        public TextBox textBox7;
    }
}