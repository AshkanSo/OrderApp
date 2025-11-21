using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class AddProductToOrder : Form
    {
        private readonly AppDbContext _context;

        public Detail ResultDetail { get; private set; }
        private bool _isEditMode;
        private int _editingDetailId;

        public AddProductToOrder(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            _isEditMode = false;

            WireUpEvents();

            LoadProducts();
        }

        public AddProductToOrder(AppDbContext context, Detail existingDetail) : this(context)
        {
            _isEditMode = true;
            _editingDetailId = existingDetail.ID;

            if (comboBoxProduct.Items.Count > 0)
            {
                comboBoxProduct.SelectedValue = existingDetail.ProductID;
            }

            textBoxPrice.Text = existingDetail.Price.ToString();
            textBoxCount.Text = existingDetail.Count.ToString();

            CalculateTotal();
        }

        private void WireUpEvents()
        {
            this.comboBoxProduct.SelectedIndexChanged += new EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            this.textBoxCount.TextChanged += new EventHandler(this.textBoxCount_TextChanged);
            this.textBoxPrice.TextChanged += new EventHandler(this.textBoxPrice_TextChanged);
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);
            this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
        }

        private void LoadProducts()
        {
            var products = _context.tblProducts
                .Select(p => new { p.ID, Display = p.Name + " - " + p.Code, p.Price, p.Name, p.Code })
                .ToList();

            comboBoxProduct.DataSource = products;
            comboBoxProduct.DisplayMember = "Display";
            comboBoxProduct.ValueMember = "ID";
            comboBoxProduct.SelectedIndex = -1;
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedIndex != -1)
            {
                dynamic selectedItem = comboBoxProduct.SelectedItem;

                if (selectedItem != null)
                {
                    textBoxPrice.Text = selectedItem.Price.ToString();

                    if (string.IsNullOrWhiteSpace(textBoxCount.Text))
                    {
                        textBoxCount.Text = "1";
                    }

                    CalculateTotal();
                }
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            string priceStr = textBoxPrice.Text.Replace(",", "");
            string countStr = textBoxCount.Text.Replace(",", "");

            if (long.TryParse(priceStr, out long price) && int.TryParse(countStr, out int count))
            {
                long total = price * count;
                textBoxSum.Text = total.ToString("N0"); 
            }
            else
            {
                textBoxSum.Text = "0";
            }
        }

        private void AddProductToOrder_Load(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا کالا را انتخاب کنید");
                return;
            }

            if (!int.TryParse(textBoxCount.Text.Replace(",", ""), out int count) || count <= 0)
            {
                MessageBox.Show("تعداد نامعتبر است");
                return;
            }

            if (!int.TryParse(textBoxPrice.Text.Replace(",", ""), out int price))
            {
                MessageBox.Show("قیمت نامعتبر است");
                return;
            }

            dynamic selectedProduct = comboBoxProduct.SelectedItem;

            ResultDetail = new Detail
            {
                ID = _isEditMode ? _editingDetailId : 0,
                ProductID = (int)comboBoxProduct.SelectedValue,
                
                Product = new Product
                {
                    ID = (int)comboBoxProduct.SelectedValue,
                    Name = selectedProduct.Name,
                    Code = selectedProduct.Code
                },
                Count = count,
                Price = price,
                SumPrice = price * count
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}