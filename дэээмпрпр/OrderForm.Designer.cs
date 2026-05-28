namespace дэээмпрпр
{
    partial class OrderForm
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
            idorderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            articleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patronomicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            statusbindingSource1 = new BindingSource(components);
            addresIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            adsresbindingSource1 = new BindingSource(components);
            dataOrderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDeliviryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderStructureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderbindingSource1 = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adsresbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderbindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idorderDataGridViewTextBoxColumn, articleDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, patronomicDataGridViewTextBoxColumn, statusIdDataGridViewTextBoxColumn, addresIdDataGridViewTextBoxColumn, dataOrderDataGridViewTextBoxColumn, dataDeliviryDataGridViewTextBoxColumn, orderStructureDataGridViewTextBoxColumn, addresDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderbindingSource1;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 449);
            dataGridView1.TabIndex = 0;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            idorderDataGridViewTextBoxColumn.DataPropertyName = "Idorder";
            idorderDataGridViewTextBoxColumn.HeaderText = "Idorder";
            idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
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
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronomicDataGridViewTextBoxColumn
            // 
            patronomicDataGridViewTextBoxColumn.DataPropertyName = "Patronomic";
            patronomicDataGridViewTextBoxColumn.HeaderText = "Patronomic";
            patronomicDataGridViewTextBoxColumn.Name = "patronomicDataGridViewTextBoxColumn";
            // 
            // statusIdDataGridViewTextBoxColumn
            // 
            statusIdDataGridViewTextBoxColumn.DataPropertyName = "StatusId";
            statusIdDataGridViewTextBoxColumn.DataSource = statusbindingSource1;
            statusIdDataGridViewTextBoxColumn.DisplayMember = "StatusName";
            statusIdDataGridViewTextBoxColumn.HeaderText = "StatusId";
            statusIdDataGridViewTextBoxColumn.Name = "statusIdDataGridViewTextBoxColumn";
            statusIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            statusIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            statusIdDataGridViewTextBoxColumn.ValueMember = "Idstatus";
            // 
            // statusbindingSource1
            // 
            statusbindingSource1.DataSource = typeof(Models.Status);
            // 
            // addresIdDataGridViewTextBoxColumn
            // 
            addresIdDataGridViewTextBoxColumn.DataPropertyName = "AddresId";
            addresIdDataGridViewTextBoxColumn.DataSource = adsresbindingSource1;
            addresIdDataGridViewTextBoxColumn.DisplayMember = "Addres";
            addresIdDataGridViewTextBoxColumn.HeaderText = "AddresId";
            addresIdDataGridViewTextBoxColumn.Name = "addresIdDataGridViewTextBoxColumn";
            addresIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            addresIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            addresIdDataGridViewTextBoxColumn.ValueMember = "Idaddres";
            // 
            // adsresbindingSource1
            // 
            adsresbindingSource1.DataSource = typeof(Models.Addre);
            // 
            // dataOrderDataGridViewTextBoxColumn
            // 
            dataOrderDataGridViewTextBoxColumn.DataPropertyName = "DataOrder";
            dataOrderDataGridViewTextBoxColumn.HeaderText = "DataOrder";
            dataOrderDataGridViewTextBoxColumn.Name = "dataOrderDataGridViewTextBoxColumn";
            // 
            // dataDeliviryDataGridViewTextBoxColumn
            // 
            dataDeliviryDataGridViewTextBoxColumn.DataPropertyName = "DataDeliviry";
            dataDeliviryDataGridViewTextBoxColumn.HeaderText = "DataDeliviry";
            dataDeliviryDataGridViewTextBoxColumn.Name = "dataDeliviryDataGridViewTextBoxColumn";
            // 
            // orderStructureDataGridViewTextBoxColumn
            // 
            orderStructureDataGridViewTextBoxColumn.DataPropertyName = "OrderStructure";
            orderStructureDataGridViewTextBoxColumn.HeaderText = "OrderStructure";
            orderStructureDataGridViewTextBoxColumn.Name = "orderStructureDataGridViewTextBoxColumn";
            // 
            // addresDataGridViewTextBoxColumn
            // 
            addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            addresDataGridViewTextBoxColumn.HeaderText = "Addres";
            addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // orderbindingSource1
            // 
            orderbindingSource1.DataSource = typeof(Models.Order);
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(763, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "выйти";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(30, 153);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 3;
            button3.Text = "редактировать";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(171, 153);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "добавить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(266, 153);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "удалить";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(357, 153);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "сохранить";
            button6.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 679);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)statusbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)adsresbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderbindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        public BindingSource orderbindingSource1;
        private DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronomicDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn statusIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn addresIdDataGridViewTextBoxColumn;
        public BindingSource adsresbindingSource1;
        private DataGridViewTextBoxColumn dataOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDeliviryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderStructureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        public BindingSource statusbindingSource1;
        public Button button3;
        public Button button4;
        public Button button5;
        public Button button6;
    }
}