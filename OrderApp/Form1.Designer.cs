namespace OrderApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenu = new ToolStripMenuItem();
            DeleteToolStripMenu = new ToolStripMenuItem();
            ExitToolStripMenu = new ToolStripMenuItem();
            TimeToolStripMenu = new ToolStripMenuItem();
            panel1 = new Panel();
            buttonSearch = new Button();
            textBoxToDate = new TextBox();
            label4 = new Label();
            textBoxFromDate = new TextBox();
            label3 = new Label();
            CustomerComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewOrders = new DataGridView();
            FactorNumber = new DataGridViewTextBoxColumn();
            customer = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Sum = new DataGridViewTextBoxColumn();
            bindingSourceOrders = new BindingSource(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrders).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, EditToolStripMenu, DeleteToolStripMenu, ExitToolStripMenu, TimeToolStripMenu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(718, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(51, 24);
            CreateToolStripMenuItem.Text = "ایجاد";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // EditToolStripMenu
            // 
            EditToolStripMenu.Name = "EditToolStripMenu";
            EditToolStripMenu.Size = new Size(67, 24);
            EditToolStripMenu.Text = "ویرایش";
            EditToolStripMenu.Click += EditToolStripMenu_Click;
            // 
            // DeleteToolStripMenu
            // 
            DeleteToolStripMenu.Name = "DeleteToolStripMenu";
            DeleteToolStripMenu.Size = new Size(53, 24);
            DeleteToolStripMenu.Text = "حذف";
            DeleteToolStripMenu.Click += DeleteToolStripMenu_Click;
            // 
            // ExitToolStripMenu
            // 
            ExitToolStripMenu.Name = "ExitToolStripMenu";
            ExitToolStripMenu.Size = new Size(53, 24);
            ExitToolStripMenu.Text = "خروج";
            ExitToolStripMenu.Click += ExitToolStripMenu_Click;
            // 
            // TimeToolStripMenu
            // 
            TimeToolStripMenu.Name = "TimeToolStripMenu";
            TimeToolStripMenu.RightToLeft = RightToLeft.No;
            TimeToolStripMenu.Size = new Size(33, 24);
            TimeToolStripMenu.Text = "...";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonSearch);
            panel1.Controls.Add(textBoxToDate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxFromDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 82);
            panel1.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(21, 38);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "جستوجو";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click_1;
            // 
            // textBoxToDate
            // 
            textBoxToDate.Location = new Point(134, 38);
            textBoxToDate.Margin = new Padding(3, 2, 3, 2);
            textBoxToDate.Name = "textBoxToDate";
            textBoxToDate.Size = new Size(110, 23);
            textBoxToDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 38);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 4;
            label4.Text = "تا تاریخ : ";
            // 
            // textBoxFromDate
            // 
            textBoxFromDate.Location = new Point(312, 38);
            textBoxFromDate.Margin = new Padding(3, 2, 3, 2);
            textBoxFromDate.Name = "textBoxFromDate";
            textBoxFromDate.Size = new Size(110, 23);
            textBoxFromDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 38);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "از تاریخ : ";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(491, 38);
            CustomerComboBox.Margin = new Padding(3, 2, 3, 2);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(129, 23);
            CustomerComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(625, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "نام مشتری:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(646, 8);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "جستجو";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { FactorNumber, customer, Date, Sum });
            dataGridViewOrders.DataSource = bindingSourceOrders;
            dataGridViewOrders.Location = new Point(0, 100);
            dataGridViewOrders.Margin = new Padding(3, 2, 3, 2);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(718, 230);
            dataGridViewOrders.TabIndex = 2;
            // 
            // FactorNumber
            // 
            FactorNumber.HeaderText = "شماره فاکتور";
            FactorNumber.MinimumWidth = 6;
            FactorNumber.Name = "FactorNumber";
            FactorNumber.Width = 125;
            // 
            // customer
            // 
            customer.HeaderText = "مشتری";
            customer.MinimumWidth = 6;
            customer.Name = "customer";
            customer.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "تاریخ";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Sum
            // 
            Sum.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sum.HeaderText = "جمع کل (ریال)";
            Sum.MinimumWidth = 6;
            Sum.Name = "Sum";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 328);
            Controls.Add(dataGridViewOrders);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenu;
        private ToolStripMenuItem DeleteToolStripMenu;
        private ToolStripMenuItem ExitToolStripMenu;
        private ToolStripMenuItem TimeToolStripMenu;
        private Panel panel1;
        public BindingSource bindingSourceOrders;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn FactorNumber;
        private DataGridViewTextBoxColumn customer;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Sum;
        public Label label1;
        public Label label2;
        public TextBox textBoxToDate;
        public Label label4;
        public TextBox textBoxFromDate;
        public Label label3;
        public ComboBox CustomerComboBox;
        public DataGridView dataGridViewOrders;
        private Button buttonSearch;
    }
}
