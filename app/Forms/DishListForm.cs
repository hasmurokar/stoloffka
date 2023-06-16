using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Common.DataGridView;
using app.Services;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace app.Forms
{
    public partial class DishListForm : Form
    {
        private AppDbContext db;
        public DishListForm()
        {
            InitializeComponent();
            db = new AppDbContext();
        }
        private void DishListForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            DataGridView_ChangeColumnName();
            foreach (DataGridViewColumn column in dishListForm_list_dishes.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void UpdateTable()
        {
            var enity = db.Dishes.ToList();
            var data = enity.ConvertAll(e => new DishListItem
            {
                Id = e.Id,
                Name = e.Name,
                Price = e.Price,
                Weight = e.Weight,
                Type = EnumHelper.GetEnumDisplayName(e.Type)
            });
            dishListForm_list_dishes.DataSource = data;
        }

        private void dishListForm_btn_back_Click(object sender, EventArgs e)
        {
            switch (DataStore.CurrentUser.Role)
            {
                case EnumRole.Admin:
                    var adminMainForm = new AdminMainForm();
                    this.Close();
                    adminMainForm.Show();
                    break;
                case EnumRole.Chef:
                    var chefMainForm = new ChefMainForm();
                    this.Close();
                    chefMainForm.Show();
                    break;
            }
        }
        private void DataGridView_ChangeColumnName()
        {
            dishListForm_list_dishes.Columns[1].HeaderText = "Название";
            dishListForm_list_dishes.Columns[2].HeaderText = "Цена";
            dishListForm_list_dishes.Columns[3].HeaderText = "Вес";
            dishListForm_list_dishes.Columns[4].HeaderText = "Тип";
        }

        private void dishListForm_btn_delete_Click(object sender, EventArgs e)
        {
            dishListForm_btn_delete.Text = "Загрузка...";
            ButtonsEnable(false);
            var selectedRow = dishListForm_list_dishes.SelectedRows[0];
            DialogResult result = MessageBox.Show(
                                    "Удалить блюдо?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                var recordToDelete = db.Dishes.FirstOrDefault(r => r.Id == selectedId);
                if (recordToDelete != null)
                {
                    recordToDelete.State = EnityStateEnum.Archived;
                    db.SaveChanges();
                    UpdateTable();
                }
            }
            dishListForm_btn_delete.Text = "Удалить";
            ButtonsEnable(true);
        }

        private void dishListForm_btn_update_Click(object sender, EventArgs e)
        {
            var value = dishListForm_list_dishes.SelectedRows[0];
            var id = Convert.ToInt32(value.Cells[0].Value);
            using var db = new AppDbContext();
            DataStore.DishForm = db.Dishes
                .Include(d => d.Ingredients)
                .ThenInclude(i => i.Kind)
                .First(x => x.Id == id);
            var addDishForm = new AddDishForm();
            addDishForm.Show();
            this.Close();
        }
        private void ButtonsEnable(bool flag)
        {
            dishListForm_btn_delete.Enabled = true;
            dishListForm_btn_update.Enabled = true;
            dishListForm_btn_back.Enabled = true;
        }
    }
}
