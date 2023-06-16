using app.Domain;
using app.Models.Common;
using app.Models.Common.Combobox;
using app.Models.Common.DataGridView;
using app.Models.Domain;
using app.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;

namespace app.Forms
{
    public partial class ChefMainForm : Form
    {
        private BindingList<DocumentDishItem> listDishes = new();
        public ChefMainForm()
        {
            InitializeComponent();
        }

        private void ChefMainForm_Load(object sender, EventArgs e)
        {
            
            InitComboboxDishes();
            UpdateDishesTable();
            ClearSelectedDish();
            chefMainForm_list_count.DataSource = new BindingList<NameWeightType>();
            chefMainForm_list_count.Columns[0].HeaderText = "Название";
            chefMainForm_list_count.Columns[1].HeaderText = "Ингредиенты";
            cfehMainForm_btn_addToDoc.Enabled = false;
            chefMainForm_btn_clearListDoc.Enabled = false;
            chefMainForm_btn_saveDoc.Enabled = false;
            foreach (DataGridViewColumn column in chefMainForm_list_count.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            foreach (DataGridViewColumn column in chefMainForm_list_document.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void UpdateDishesTable()
        {
            chefMainForm_list_document.DataSource = listDishes;
            chefMainForm_list_document.Columns[1].HeaderText = "Название";
            chefMainForm_list_document.Columns[2].HeaderText = "Количество";
            chefMainForm_list_document.Columns[3].HeaderText = "Цена";
        }

        private void InitComboboxDishes()
        {
            using var db = new AppDbContext();
            var dishes = db.Dishes.ToList();
            var items = new List<FillCombobox>() { new FillCombobox() { Id = 0, Name = "Не выбрано" } };
            items.AddRange(dishes.ConvertAll(x => new FillCombobox() { Id = x.Id, Name = x.Name }));
            chefMainForm_combobox_dish.DataSource = items;
            chefMainForm_combobox_dish.DisplayMember = "Name";
            chefMainForm_combobox_dish.ValueMember = "Id";
            chefMainForm_combobox_dish.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void chefMainForm_btn_count_Click(object sender, EventArgs e)
        {
            AddIngredientsToTable();
            cfehMainForm_btn_addToDoc.Enabled = true;
        }

        private void AddIngredientsToTable()
        {
            var dishId = (int)chefMainForm_combobox_dish.SelectedValue;
            using var db = new AppDbContext();
            var data = db.Dishes
                .Include(t => t.Ingredients)
                .ThenInclude(i => i.Kind)
                .FirstOrDefault(d => d.Id == dishId);
            var ingredient = data.Ingredients;
            var count = Convert.ToDecimal(chefMainForm_portionCount.Value);

            var dataBind = ingredient.Select(x => new NameWeightType
            {
                Name = x.Kind.Name,
                Weight = x.Weight * count,
            }).ToList();
            var dishName = data.Name;
            chefMainForm_label_dishName.Text = dishName;
            chefMainForm_list_count.DataSource = dataBind;
        }

        private void cfehMainForm_btn_addToDoc_Click(object sender, EventArgs e)
        {
            var dishId = (int)chefMainForm_combobox_dish.SelectedValue;
            using var db = new AppDbContext();
            var dish = db.Dishes
                .FirstOrDefault(d => d.Id == dishId);
            var count = Convert.ToDecimal(chefMainForm_portionCount.Value);

            var exist = listDishes.FirstOrDefault(x => x.Id == dishId);
            if (exist != null)
                listDishes.Remove(exist);

            listDishes.Add(new DocumentDishItem
            {
                Id = dish.Id,
                Name = dish.Name,
                Count = Convert.ToInt32(count),
                TotalPrice = dish.Price * count,
            });
            chefMainForm_btn_clearListDoc.Enabled = true;
            chefMainForm_btn_saveDoc.Enabled = true;
            cfehMainForm_btn_addToDoc.Enabled = false;
            chefMainForm_combobox_dish.Enabled = true;
            chefMainForm_list_document.DataSource = listDishes;
            ClearSelectedDish();
        }

        private void ClearSelectedDish()
        {
            chefMainForm_list_count.DataSource = new BindingList<NameWeightType>();
            chefMainForm_combobox_dish.SelectedIndex = 0;
            chefMainForm_portionCount.Value = 1;
            cfehMainForm_btn_addToDoc.Text = "Добавить в документ";
        }

        private void chefMainForm_btn_saveDoc_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var entity = new DocumentDish
            {
                Date = DateTime.Now,
                Name = $"Отчет за {DateTime.Now:g}",
                Count = listDishes.Count
            };

            db.Documents.Add(entity);
            db.SaveChanges();

            var ids = listDishes.Select(x => x.Id);
            var dishes = db.Dishes.Where(x => ids.Any(e => e == x.Id)).ToList();
            var dishDocumentRelation = dishes.ConvertAll(x => new DishDocumentRelation
            {
                DocumentDishId = entity.Id,
                DishId = x.Id,
                CountDish = listDishes.First(d => d.Id == x.Id).Count
            });

            entity.DishDocumentRelations = dishDocumentRelation;
            db.SaveChanges();

            if (chefMainForm_checkBox_print.Checked)
            {
                var documentService = new DocumentService();
                try
                {
                    documentService.GenerateDocReportDish(entity.Id);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при сохранении файла.");
                    return;
                }
            }

            chefMainForm_list_document.DataSource = new BindingList<DocumentDishItem>();
            MessageBox.Show("ГОТОВО!");
            cfehMainForm_btn_addToDoc.Enabled = false;
            chefMainForm_btn_clearListDoc.Enabled = false;
            chefMainForm_btn_saveDoc.Enabled = false;
        }

        

        private void chefMainForm_list_document_SelectionChanged(object sender, EventArgs e)
        {
            if (chefMainForm_list_document.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = chefMainForm_list_document.SelectedRows[0];
                var dishId = Convert.ToInt32(selectedRow.Cells[0].Value);
                var count = Convert.ToInt32(selectedRow.Cells[2].Value);
                chefMainForm_combobox_dish.SelectedValue = dishId;
                chefMainForm_portionCount.Value = count;
                AddIngredientsToTable();
                cfehMainForm_btn_addToDoc.Text = "Редактировать";
                chefMainForm_combobox_dish.Enabled = false;
                cfehMainForm_btn_addToDoc.Enabled = true;
            }
        }

        private void chefMainForm_btn_clearListDoc_Click(object sender, EventArgs e)
        {
            if (chefMainForm_list_document.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = chefMainForm_list_document.SelectedRows[0];
                var dishId = Convert.ToInt32(selectedRow.Cells[0].Value);
                var dish = listDishes.First(x => x.Id == dishId);
                listDishes.Remove(dish);
                ClearSelectedDish();
            }
        }

        private void chefMainForm_btn_exit_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void chefMainForm_btn_viewDishes_Click(object sender, EventArgs e)
        {
            var dishListForm = new DishListForm();
            dishListForm.Show();
            this.Close();
        }

        private void chefMainForm_btn_viewDocs_Click(object sender, EventArgs e)
        {
            var docListForm = new DocsListForm();
            docListForm.Show();
            this.Close();
        }
    }
}
