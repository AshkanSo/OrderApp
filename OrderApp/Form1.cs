using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic; 
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace OrderApp
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public Form1(AppDbContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            SetupGrid();

            LoadCustomers();
            FillDate();
            LoadOrders();
        }

        private void SetupGrid()
        {
            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.MultiSelect = false;

            if (dataGridViewOrders.Columns["FactorNumber"] != null)
                dataGridViewOrders.Columns["FactorNumber"].DataPropertyName = "Number";

            if (dataGridViewOrders.Columns["customer"] != null)
            {
                dataGridViewOrders.Columns["customer"].DataPropertyName = "CustomerName";
                dataGridViewOrders.Columns["customer"].Width = 200;
            }

            if (dataGridViewOrders.Columns["Sum"] != null)
            {
                dataGridViewOrders.Columns["Sum"].DataPropertyName = "TotalAmount";
                dataGridViewOrders.Columns["Sum"].DefaultCellStyle.Format = "N0";
            }

            if (dataGridViewOrders.Columns["Date"] != null)
                dataGridViewOrders.Columns["Date"].DataPropertyName = "Date";
        }

        private void LoadCustomers()
        {
            var customers = _context.tblPersonals
                .Select(p => new CustomerViewModel
                {
                    Id = p.ID,
                    DisplayName = p.Name + " - " + p.CompanyName
                })
                .ToList();

            customers.Insert(0, new CustomerViewModel { Id = 0, DisplayName = "--- همه مشتریان ---" });

            CustomerComboBox.DataSource = customers;
            CustomerComboBox.DisplayMember = "DisplayName";
            CustomerComboBox.ValueMember = "Id";

            CustomerComboBox.SelectedIndex = 0;
        }

        private void FillDate()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime now = DateTime.Now;
            DateTime oneMonthAgo = now.AddMonths(-1);

            string todayStr = $"{pc.GetYear(now):0000}/{pc.GetMonth(now):00}/{pc.GetDayOfMonth(now):00}";

            string lastMonthStr = $"{pc.GetYear(oneMonthAgo):0000}/{pc.GetMonth(oneMonthAgo):00}/{pc.GetDayOfMonth(oneMonthAgo):00}";

            TimeToolStripMenu.Text = todayStr;

            textBoxFromDate.Text = lastMonthStr; 
            textBoxToDate.Text = todayStr;       
        }

        private void LoadOrders()
        {
            var query = _context.tblOrders
                .Include(o => o.Personal)
                .Include(o => o.Details)
                .AsQueryable();

            if (CustomerComboBox.SelectedIndex != -1 &&
                CustomerComboBox.SelectedValue is int customerId &&
                customerId > 0)
            {
                query = query.Where(o => o.PersonalID == customerId);
            }

            if (!string.IsNullOrWhiteSpace(textBoxFromDate.Text))
            {
                query = query.Where(o => o.Date.CompareTo(textBoxFromDate.Text) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(textBoxToDate.Text))
            {
                query = query.Where(o => o.Date.CompareTo(textBoxToDate.Text) <= 0);
            }

            var orders = query
                .OrderByDescending(o => o.ID)
                .Select(o => new
                {
                    o.ID,
                    Number = o.Number,
                    CustomerName = o.Personal.Name + " - " + o.Personal.CompanyName,
                    o.Date,
                    TotalAmount = o.Details.Sum(d => d.SumPrice)
                })
                .ToList();

            bindingSourceOrders.DataSource = orders;
            dataGridViewOrders.DataSource = bindingSourceOrders;
        }


        private void buttonSearch_Click(object sender, EventArgs e) => LoadOrders();

        private void buttonSearch_Click_1(object sender, EventArgs e) => LoadOrders();

        private void ExitToolStripMenu_Click(object sender, EventArgs e) => Application.Exit();

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var orderForm = new RegisterOrder(_context, _serviceProvider))
            {
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrders();
                }
            }
        }

        private void DeleteToolStripMenu_Click(object sender, EventArgs e)
        {
            if (bindingSourceOrders.Current == null)
            {
                MessageBox.Show("لطفا یک سفارش را انتخاب کنید");
                return;
            }

            if (MessageBox.Show("آیا از حذف این سفارش و تمام اقلام آن اطمینان دارید؟", "هشدار حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    dynamic selectedItem = bindingSourceOrders.Current;
                    int orderId = selectedItem.ID;

                    var order = _context.tblOrders.Include(o => o.Details).FirstOrDefault(o => o.ID == orderId);
                    if (order != null)
                    {
                        _context.tblOrders.Remove(order);
                        _context.SaveChanges();
                        LoadOrders();
                        MessageBox.Show("حذف با موفقیت انجام شد");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در حذف: " + ex.Message);
                }
            }
        }

        private void EditToolStripMenu_Click(object sender, EventArgs e)
        {
            if (bindingSourceOrders.Current == null)
            {
                MessageBox.Show("لطفا یک سفارش را انتخاب کنید");
                return;
            }

            try
            {
                dynamic selectedItem = bindingSourceOrders.Current;
                int orderId = selectedItem.ID;

                var orderToEdit = _context.tblOrders
                    .Include(o => o.Details)
                    .ThenInclude(d => d.Product)
                    .FirstOrDefault(o => o.ID == orderId);

                if (orderToEdit != null)
                {
                    using (var editForm = new RegisterOrder(_context, _serviceProvider))
                    {
                        editForm.LoadOrderForEdit(orderToEdit);

                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            _context.ChangeTracker.Clear();
                            LoadOrders();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری فرم ویرایش: " + ex.Message);
            }
        }
    }

    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
    }
}