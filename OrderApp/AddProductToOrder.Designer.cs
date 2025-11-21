namespace OrderApp
{
    partial class AddProductToOrder
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
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxProduct = new ComboBox();
            label2 = new Label();
            textBoxPrice = new TextBox();
            textBoxCount = new TextBox();
            textBoxSum = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonSave);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(492, 51);
            panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(235, 18);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.RightToLeft = RightToLeft.Yes;
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "انصراف";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(354, 18);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.RightToLeft = RightToLeft.Yes;
            buttonSave.Size = new Size(82, 22);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "ذخیره";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 98);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "کالا : ";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(110, 98);
            comboBoxProduct.Margin = new Padding(3, 2, 3, 2);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.RightToLeft = RightToLeft.Yes;
            comboBoxProduct.Size = new Size(223, 23);
            comboBoxProduct.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 150);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "قیمت واحد : ";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(110, 148);
            textBoxPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.RightToLeft = RightToLeft.Yes;
            textBoxPrice.Size = new Size(223, 23);
            textBoxPrice.TabIndex = 4;
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(110, 197);
            textBoxCount.Margin = new Padding(3, 2, 3, 2);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.RightToLeft = RightToLeft.Yes;
            textBoxCount.Size = new Size(223, 23);
            textBoxCount.TabIndex = 5;
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(110, 235);
            textBoxSum.Margin = new Padding(3, 2, 3, 2);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.RightToLeft = RightToLeft.Yes;
            textBoxSum.Size = new Size(223, 23);
            textBoxSum.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 200);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "تعداد : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 240);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "جمع کل : ";
            // 
            // AddProductToOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 338);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxSum);
            Controls.Add(textBoxCount);
            Controls.Add(textBoxPrice);
            Controls.Add(label2);
            Controls.Add(comboBoxProduct);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AddProductToOrder";
            Text = "AddProductToOrder";
            Load += AddProductToOrder_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        public Button buttonCancel;
        public Button buttonSave;
        public Label label1;
        public ComboBox comboBoxProduct;
        public Label label2;
        public TextBox textBoxPrice;
        public TextBox textBoxCount;
        public TextBox textBoxSum;
        public Label label3;
        public Label label4;
    }
}