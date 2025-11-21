namespace OrderApp
{
    partial class RegisterOrder
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
            menuStrip1 = new MenuStrip();
            FinalRegisterOrder = new ToolStripMenuItem();
            CancelRegister = new ToolStripMenuItem();
            panel1 = new Panel();
            labelSumFactor = new Label();
            label3 = new Label();
            labelFactorNumber = new Label();
            label2 = new Label();
            textBoxDate = new TextBox();
            label1 = new Label();
            comboBoxCustomers = new ComboBox();
            label = new Label();
            panel2 = new Panel();
            buttonCreateOrder = new Button();
            buttonEditOrder = new Button();
            buttonDeleteOrder = new Button();
            bindingSourceRegisterOrder = new BindingSource(components);
            dataGridViewRegisterOrder = new DataGridView();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceRegisterOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisterOrder).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FinalRegisterOrder, CancelRegister });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(700, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FinalRegisterOrder
            // 
            FinalRegisterOrder.Name = "FinalRegisterOrder";
            FinalRegisterOrder.Size = new Size(84, 24);
            FinalRegisterOrder.Text = "ثبت نهایی";
            FinalRegisterOrder.Click += FinalRegisterOrder_Click;
            // 
            // CancelRegister
            // 
            CancelRegister.Name = "CancelRegister";
            CancelRegister.Size = new Size(68, 24);
            CancelRegister.Text = "انصراف";
            CancelRegister.Click += CancelRegister_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(labelSumFactor);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelFactorNumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxCustomers);
            panel1.Controls.Add(label);
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 120);
            panel1.TabIndex = 1;
            // 
            // labelSumFactor
            // 
            labelSumFactor.AutoSize = true;
            labelSumFactor.Location = new Point(539, 70);
            labelSumFactor.Name = "labelSumFactor";
            labelSumFactor.RightToLeft = RightToLeft.Yes;
            labelSumFactor.Size = new Size(13, 15);
            labelSumFactor.TabIndex = 7;
            labelSumFactor.Text = "..";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 70);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(87, 15);
            label3.TabIndex = 6;
            label3.Text = "جمع کل فاکتور : ";
            // 
            // labelFactorNumber
            // 
            labelFactorNumber.AutoSize = true;
            labelFactorNumber.Location = new Point(179, 70);
            labelFactorNumber.Name = "labelFactorNumber";
            labelFactorNumber.Size = new Size(10, 15);
            labelFactorNumber.TabIndex = 5;
            labelFactorNumber.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 70);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "شماره فاکتور : ";
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(36, 21);
            textBoxDate.Margin = new Padding(3, 2, 3, 2);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(188, 23);
            textBoxDate.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 23);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "تاریخ";
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(434, 17);
            comboBoxCustomers.Margin = new Padding(3, 2, 3, 2);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(191, 23);
            comboBoxCustomers.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(646, 17);
            label.Name = "label";
            label.Size = new Size(41, 15);
            label.TabIndex = 0;
            label.Text = "مشتری";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(buttonCreateOrder);
            panel2.Controls.Add(buttonEditOrder);
            panel2.Controls.Add(buttonDeleteOrder);
            panel2.Location = new Point(0, 122);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 50);
            panel2.TabIndex = 2;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(599, 13);
            buttonCreateOrder.Margin = new Padding(3, 2, 3, 2);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(82, 22);
            buttonCreateOrder.TabIndex = 3;
            buttonCreateOrder.Text = "ایجاد";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(499, 13);
            buttonEditOrder.Margin = new Padding(3, 2, 3, 2);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(82, 22);
            buttonEditOrder.TabIndex = 4;
            buttonEditOrder.Text = "ویرایش";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(401, 13);
            buttonDeleteOrder.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(82, 22);
            buttonDeleteOrder.TabIndex = 5;
            buttonDeleteOrder.Text = "حذف";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // dataGridViewRegisterOrder
            // 
            dataGridViewRegisterOrder.AutoGenerateColumns = false;
            dataGridViewRegisterOrder.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewRegisterOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRegisterOrder.Columns.AddRange(new DataGridViewColumn[] { ProductName, ProductCode, ProductPrice, ProductCount, Sum });
            dataGridViewRegisterOrder.DataSource = bindingSourceRegisterOrder;
            dataGridViewRegisterOrder.Location = new Point(0, 176);
            dataGridViewRegisterOrder.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRegisterOrder.Name = "dataGridViewRegisterOrder";
            dataGridViewRegisterOrder.RightToLeft = RightToLeft.Yes;
            dataGridViewRegisterOrder.RowHeadersWidth = 51;
            dataGridViewRegisterOrder.Size = new Size(700, 194);
            dataGridViewRegisterOrder.TabIndex = 3;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "نام کالا";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.Width = 125;
            // 
            // ProductCode
            // 
            ProductCode.HeaderText = "کد کالا";
            ProductCode.MinimumWidth = 6;
            ProductCode.Name = "ProductCode";
            ProductCode.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "فی واحد";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Width = 125;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "تعداد";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.Width = 125;
            // 
            // Sum
            // 
            Sum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sum.HeaderText = "جمع کل";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            // 
            // RegisterOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 370);
            Controls.Add(dataGridViewRegisterOrder);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegisterOrder";
            Text = "RegisterOrder";
            Load += RegisterOrder_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceRegisterOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRegisterOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public MenuStrip menuStrip1;
        public ToolStripMenuItem FinalRegisterOrder;
        public ToolStripMenuItem CancelRegister;
        public Panel panel1;
        public TextBox textBoxDate;
        public Label label1;
        public ComboBox comboBoxCustomers;
        public Label label;
        public Panel panel2;
        public Button buttonCreateOrder;
        public Button buttonEditOrder;
        public Button buttonDeleteOrder;
        public BindingSource bindingSourceRegisterOrder;
        public DataGridView dataGridViewRegisterOrder;
        public DataGridViewTextBoxColumn ProductName;
        public DataGridViewTextBoxColumn ProductCode;
        public DataGridViewTextBoxColumn ProductPrice;
        public DataGridViewTextBoxColumn ProductCount;
        public DataGridViewTextBoxColumn Sum;
        public Label labelFactorNumber;
        public Label label2;
        private Label labelSumFactor;
        private Label label3;
    }
}