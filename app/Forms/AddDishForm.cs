using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Common;
using app.Models.Domain;
using app.Services;
using System.ComponentModel;
using System.Data;

namespace app.Forms
{
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(EnumDishType)).Cast<EnumDishType>();
            addDishForm_list_type.DataSource = enumValues.Select(x => new
            {
                Value = x,
                DisplayName = EnumHelper.GetEnumDisplayName(x)
            }).ToList();
            addDishForm_list_type.DisplayMember = "DisplayName";
            addDishForm_list_type.ValueMember = "Value";
            addDishForm_list_type.DropDownStyle = ComboBoxStyle.DropDownList;

            initTableIngredients();

            if (DataStore.DishForm is not null)
            {
                using var db = new AppDbContext();
                addDishForm_input_dishName.Text = DataStore.DishForm.Name;
                addDishForm_input_price.Text = DataStore.DishForm.Price.ToString();
                addDishForm_input_weight.Text = DataStore.DishForm.Weight.ToString();
                addDishForm_list_type.SelectedValue = DataStore.DishForm.Type;
            }
            else
                DataStore.DishForm = new Dish();
            RefreshIngredientGrid();
            label1.Text = DataStore.DishForm.Id == 0
                ? "Добавить блюдо"
                : "Редактировать блюдо";
        }

        private void addDishForm_btn_back_Click(object sender, EventArgs e)
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

        private void addDishForm_btn_addIngredient_Click(object sender, EventArgs e)
        {
            var addIngridientForm = new AddIngredientForm();
            addIngridientForm.Show();
        }

        private void RefreshIngredientGrid()
        {
            var listTarget = DataStore.DishForm.Ingredients.ConvertAll(x => new ModelOutputIngredients
            {
                Name = x.Kind.Name,
                Weight = x.Weight
            });
            var list = new BindingList<ModelOutputIngredients>(listTarget);
            addDishForm_table.DataSource = list;
        }

        private void AddDishForm_Click(object sender, EventArgs e)
        {
            RefreshIngredientGrid();
        }

        private async void addDishForm_btn_save_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            DataStore.DishForm.Name = addDishForm_input_dishName.Text;
            DataStore.DishForm.Price = Convert.ToDecimal(addDishForm_input_price.Text);
            DataStore.DishForm.Weight = Convert.ToDecimal(addDishForm_input_weight.Text);
            DataStore.DishForm.Type = GetCurrentDishType();

            if (DataStore.DishForm.Id == 0)
            {
                DataStore.DishForm.UserId = DataStore.CurrentUser.Id;
                var tempIngredients = DataStore.DishForm.Ingredients;
                DataStore.DishForm.Ingredients = new();
                db.Dishes.Add(DataStore.DishForm);
                db.SaveChanges();

                DataStore.DishForm.Ingredients.AddRange(tempIngredients);
                db.SaveChanges();

                MessageBox.Show("Блюдо добавлено");
            }
            else
            {
                var dish = db.Dishes.First(d => d.Id == DataStore.DishForm.Id);
                dish.Name = addDishForm_input_dishName.Text;
                dish.Price = Convert.ToDecimal(addDishForm_input_price.Text);
                dish.Weight = Convert.ToDecimal(addDishForm_input_weight.Text);
                dish.Type = GetCurrentDishType();

                var existIngredients = db.Ingredients
                    .Where(i => i.Dishes.Any(d => d.Id == DataStore.DishForm.Id))
                    .Select(i => i.Id)
                    .ToList();
                var removedIngredients = existIngredients
                    .Except(DataStore.DishForm.Ingredients.Select(i => i.Id))
                    .ToList();

                if (removedIngredients.Count > 0)
                {
                    var entities = db.Ingredients.Where(i => removedIngredients.Any(x => x == i.Id));
                    db.Ingredients.RemoveRange(entities);
                }

                var newIngredients = DataStore.DishForm.Ingredients
                    .Where(i => i.Id == 0)
                    .ToList();

                if (newIngredients.Count > 0)
                    dish.Ingredients.AddRange(newIngredients);

                db.SaveChanges();
                MessageBox.Show("Информация о блюде обновлена");
            }

            var dishListForm = new DishListForm();
            dishListForm.Show();
            this.Close();
        }

        private EnumDishType GetCurrentDishType()
        {
            Enum.TryParse(addDishForm_list_type.SelectedValue.ToString(), out EnumDishType status);
            return status;
        }

        private void initTableIngredients()
        {
            addDishForm_table.DataSource = new BindingList<ModelOutputIngredients>();
            addDishForm_table.Columns[0].HeaderText = "Название";
            addDishForm_table.Columns[1].HeaderText = "Вес(г)";
            foreach (DataGridViewColumn column in addDishForm_table.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void addDishForm_btn_deleteIngredient_Click(object sender, EventArgs e)
        {
            var selectedRow = addDishForm_table.SelectedRows[0];
            DialogResult result = MessageBox.Show(
                                    "Удалить ингредиент?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                var selectedName = selectedRow.Cells["Name"].Value.ToString();
                var ingredient = DataStore.DishForm.Ingredients.FirstOrDefault(r => r.Kind.Name == selectedName);
                if (ingredient != null)
                    DataStore.DishForm.Ingredients.Remove(ingredient);
            }
        }
    }
}
