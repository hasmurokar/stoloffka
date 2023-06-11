using app.Data;
using app.Domain;
using app.Models.Common;
using app.Models.Common.Combobox;
using app.Models.Common.DataGridView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class CashierMainForm : Form
    {
        private BindingList<BillItem> billList = new();
        public AppDbContext db;
        public CashierMainForm()
        {
            InitializeComponent();
            InitComboboxDishes();
        }
        private void CashierMainForm_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var orderId = db.Orders.Count();
            if (orderId > 0)
                orderId = db.Orders.Max(x => x.Id);
            var nextOrderId = orderId + 1;
            label_order.Text += nextOrderId.ToString();
            label_fio.Text = DataStore.CurrentUser.Name;
        }
        private void InitComboboxDishes()
        {
            using var db = new AppDbContext();
            var dishes = db.Dishes.ToList();
            var items = new List<FillCombobox>() { new FillCombobox() { Id = 0, Name = "Не выбрано" } };
            items.AddRange(dishes.ConvertAll(x => new FillCombobox() { Id = x.Id, Name = x.Name }));
            cashierMainForm_list_dish.DataSource = items;
            cashierMainForm_list_dish.DisplayMember = "Name";
            cashierMainForm_list_dish.ValueMember = "Id";
            cashierMainForm_list_dish.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void cashierMainForm_btn_addDish_Click(object sender, EventArgs e)
        {
            var dishId = (int)cashierMainForm_list_dish.SelectedValue;
            using var db = new AppDbContext();
            var data = db.Dishes.FirstOrDefault(d => d.Id == dishId);
            var count = Convert.ToInt32(cashierMainForm_dishCount.Value);

            var exist = billList.FirstOrDefault(x => x.Id == data.Id);
            if (exist != null)
                billList.Remove(exist);

            var item = new BillItem
            {
                Id = dishId,
                Name = data.Name,
                Price = data.Price,
                Count = count
            };
            billList.Add(item);
            UpdateDataGridView();
            ClearData();
        }

        private void UpdateDataGridView()
        {
            cashierMainForm_dataGrid.DataSource = billList;
            UpdateTotalPrice();
        }

        private void ClearData()
        {
            cashierMainForm_dishCount.Value = 1;
            cashierMainForm_list_dish.SelectedIndex = 0;
        }
        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in billList)
            {
                totalPrice += item.Price * item.Count;
            }
            label_totalPrice.Text = $"Стоимость заказа:  {totalPrice}";
        }

        private void cashierMainForm_btn_setOrder_Click(object sender, EventArgs e)
        {

        }
    }
}


