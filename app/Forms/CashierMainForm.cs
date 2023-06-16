using app.Data;
using app.Domain;
using app.Models.Common;
using app.Models.Common.Combobox;
using app.Models.Common.DataGridView;
using app.Models.Domain;
using app.Services;
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
        private decimal TotalPrice { get; set; }
        public AppDbContext db;
        public CashierMainForm()
        {
            InitializeComponent();
            InitComboboxDishes();
            cashierMainForm_btn_setOrder.Enabled = false;
            cashierMainForm_btn_deleteRow.Enabled = false;
        }
        private void CashierMainForm_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            ChecksCounter(db);
            label_fio.Text = DataStore.CurrentUser.Name;
        }

        private void ChecksCounter(AppDbContext db)
        {
            var orderId = db.Orders.Count();
            if (orderId > 0)
                orderId = db.Orders.Max(x => x.Id);
            var nextOrderId = orderId + 1;
            label_order.Text = $"№ Заказа: {nextOrderId.ToString()}";
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
            if (dishId == 0)
            {
                MessageBox.Show("Блюдо не выбрано");
                return;
            }
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
            cashierMainForm_btn_setOrder.Enabled = true;
            cashierMainForm_btn_deleteRow.Enabled = true;
            UpdateDataGridView();
            ClearData();
        }

        private void UpdateDataGridView()
        {
            cashierMainForm_dataGrid.DataSource = billList;
            DataGridView_ChangeColumnName();
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
            TotalPrice = totalPrice;
        }

        private void cashierMainForm_btn_setOrder_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var entity = new Order
            {
                TotalPrice = TotalPrice,
                Date = DateTime.Now,
                UserId = DataStore.CurrentUser.Id
            };

            var ids = billList.Select(x => x.Id);
            var dishes = db.Dishes.Where(x => ids.Any(e => e == x.Id)).ToList();
            var relations = dishes.ConvertAll(x => new DishOrder
            {
                OrderId = entity.Id,
                DishId = x.Id,
                CountDish = billList.First(d => d.Id == x.Id).Count
            });
            entity.DishOrders = relations;

            db.Orders.Add(entity);
            db.SaveChanges();

            if (cashierMainForm_checkBox_print.Checked)
            {
                var orderService = new DocumentService();
                try
                {
                    orderService.GenerateBillReport(entity.Id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при сохранении файла.");
                    return;
                }
            }
            ChecksCounter(db);
            cashierMainForm_dataGrid.DataSource = new BindingList<BillItem>();
            MessageBox.Show("ГОТОВО!");
        }

        private void cashierMainForm_btn_deleteRow_Click(object sender, EventArgs e)
        {
            if (cashierMainForm_dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = cashierMainForm_dataGrid.SelectedRows[0];
                var dishId = Convert.ToInt32(selectedRow.Cells[0].Value);
                var dish = billList.First(x => x.Id == dishId);
                billList.Remove(dish);
                ClearData();
            }
            if (cashierMainForm_dataGrid.RowCount < 1)
            {
                cashierMainForm_btn_setOrder.Enabled = false;
                cashierMainForm_btn_deleteRow.Enabled = false;
            }
        }

        private void cashierMainForm_btn_exit_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        private void DataGridView_ChangeColumnName()
        {
            cashierMainForm_dataGrid.Columns[1].HeaderText = "Название";
            cashierMainForm_dataGrid.Columns[2].HeaderText = "Цена";
            cashierMainForm_dataGrid.Columns[3].HeaderText = "Количество";
        }
    }
}


