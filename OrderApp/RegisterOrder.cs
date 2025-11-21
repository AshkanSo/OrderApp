using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class RegisterOrder : Form
    {
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private int _editingOrderId = 0;

        private BindingList<Detail> _temporaryDetails;
        public void LoadOrderForEdit(Order order)
        {
            _editingOrderId = order.ID;

            labelFactorNumber.Text = order.Number;
            textBoxDate.Text = order.Date;
            comboBoxCustomers.SelectedValue = order.PersonalID;

            
             comboBoxCustomers.Enabled = false; //** 

            
            _temporaryDetails.Clear();
            foreach (var detail in order.Details)
            {
                _temporaryDetails.Add(new Detail
                {
                    ID = detail.ID, 
                    ProductID = detail.ProductID,
                    Product = detail.Product,
                    Count = detail.Count,
                    Price = detail.Price,
                    SumPrice = detail.SumPrice,
                    OrderID = detail.OrderID
                });
            }

            CalculateTotalInvoice();
        }
        public RegisterOrder(AppDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            _temporaryDetails = new BindingList<Detail>();

            SetupForm();
        }

        private void SetupForm()
        {
            PersianCalendar pc = new PersianCalendar();
            textBoxDate.Text = $"{pc.GetYear(DateTime.Now)}/{pc.GetMonth(DateTime.Now):00}/{pc.GetDayOfMonth(DateTime.Now):00}";

            labelFactorNumber.Text = new Random().Next(100000, 999999).ToString();

            ConfigureGrid();
            LoadCustomers();
        }

        private void ConfigureGrid()
        {
            dataGridViewRegisterOrder.AutoGenerateColumns = false;
            dataGridViewRegisterOrder.DataSource = _temporaryDetails;
            dataGridViewRegisterOrder.RightToLeft = RightToLeft.Yes;
            dataGridViewRegisterOrder.AllowUserToAddRows = false;
            dataGridViewRegisterOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            dataGridViewRegisterOrder.CellFormatting += DataGridViewDetails_CellFormatting;
        }

        private void DataGridViewDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewRegisterOrder.Rows[e.RowIndex].DataBoundItem is Detail detail && detail.Product != null)
            {
                if (dataGridViewRegisterOrder.Columns[e.ColumnIndex].Name == "ProductName")
                {
                    e.Value = detail.Product.Name;
                    e.FormattingApplied = true;
                }
                else if (dataGridViewRegisterOrder.Columns[e.ColumnIndex].Name == "ProductCode")
                {
                    e.Value = detail.Product.Code;
                    e.FormattingApplied = true;
                }
                else if (dataGridViewRegisterOrder.Columns[e.ColumnIndex].Name == "ProductPrice")
                {
                    e.Value = detail.Price;
                }
                else if (dataGridViewRegisterOrder.Columns[e.ColumnIndex].Name == "ProductCount")
                {
                    e.Value = detail.Count;
                }
                else if (dataGridViewRegisterOrder.Columns[e.ColumnIndex].Name == "Sum")
                {
                    e.Value = detail.Count * detail.Price;
                }
            }
        }

        private void LoadCustomers()
        {
            var cutomers = _context.tblPersonals
                .Select(c => new { c.ID, DisplayName = c.Name + " - " + c.CompanyName })
                .ToList();

            comboBoxCustomers.DataSource = cutomers;
            comboBoxCustomers.DisplayMember = "DisplayName";
            comboBoxCustomers.ValueMember = "ID";
            comboBoxCustomers.SelectedIndex = -1;
        }

        private void CalculateTotalInvoice()
        {
            long total = _temporaryDetails.Sum(x => x.SumPrice);
            labelSumFactor.Text = total.ToString("N0") + " ریال";

        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            using (var productForm = new AddProductToOrder(_context))
            {
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    var newItem = productForm.ResultDetail;

                    var existingItem = _temporaryDetails.FirstOrDefault(d => d.ProductID == newItem.ProductID);

                    if (existingItem != null)
                    {
                        existingItem.Count += newItem.Count;
                        existingItem.SumPrice = existingItem.Count * existingItem.Price;

                        _temporaryDetails.ResetBindings();
                    }
                    else
                    {
                        _temporaryDetails.Add(newItem);
                    }

                    CalculateTotalInvoice();
                }
            }
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegisterOrder.CurrentRow != null)
            {
                var selectedDetail = (Detail)dataGridViewRegisterOrder.CurrentRow.DataBoundItem;

                using (var editForm = new AddProductToOrder(_context, selectedDetail))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        var index = _temporaryDetails.IndexOf(selectedDetail);

                        _temporaryDetails[index] = editForm.ResultDetail;

                        _temporaryDetails.ResetBindings();
                        CalculateTotalInvoice();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک کالا را برای ویرایش انتخاب کنید.");
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegisterOrder.CurrentRow != null)
            {
                if (MessageBox.Show("آیا از حذف این کالا مطمئن هستید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var selectedDetail = (Detail)dataGridViewRegisterOrder.CurrentRow.DataBoundItem;
                    _temporaryDetails.Remove(selectedDetail);
                    CalculateTotalInvoice();
                }
            }
            else
            {
                MessageBox.Show("لطفاً یک کالا را برای حذف انتخاب کنید.");
            }
        }

        private void FinalRegisterOrder_Click(object sender, EventArgs e)
        {
            // 1. اعتبارسنجی
            if (comboBoxCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("لطفاً مشتری را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_temporaryDetails.Count == 0)
            {
                MessageBox.Show("لیست اقلام فاکتور خالی است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_editingOrderId == 0)
                {
                    var newOrder = new Order
                    {
                        PersonalID = (int)comboBoxCustomers.SelectedValue,
                        Number = labelFactorNumber.Text,
                        Date = textBoxDate.Text,
                        Details = _temporaryDetails.Select(d => new Detail
                        {
                            ProductID = d.ProductID,
                            Count = d.Count,
                            Price = d.Price,
                            SumPrice = d.SumPrice
                        }).ToList()
                    };
                    _context.tblOrders.Add(newOrder);
                }
                else
                {
                    var orderToUpdate = _context.tblOrders
                                                .Include(o => o.Details)
                                                .FirstOrDefault(o => o.ID == _editingOrderId);

                    if (orderToUpdate != null)
                    {
                        orderToUpdate.PersonalID = (int)comboBoxCustomers.SelectedValue;
                        orderToUpdate.Date = textBoxDate.Text;
                        
                        orderToUpdate.Details.Clear(); 

                        foreach (var tempDetail in _temporaryDetails)
                        {
                            orderToUpdate.Details.Add(new Detail
                            {
                                ProductID = tempDetail.ProductID,
                                Count = tempDetail.Count,
                                Price = tempDetail.Price,
                                SumPrice = tempDetail.SumPrice,
                                OrderID = _editingOrderId
                            });
                        }
                    }
                }

                _context.SaveChanges();
                MessageBox.Show("عملیات با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ثبت: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegisterOrder_Load(object sender, EventArgs e)
        {
        }
        private void CancelRegister_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}