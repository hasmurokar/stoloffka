using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Common;
using app.Models.Domain;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

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
            addDishForm_list_type.DataSource = Enum.GetValues(typeof(EnumDishType));
            addDishForm_list_type.DropDownStyle = ComboBoxStyle.DropDownList;

            initTableIngredients();

            if (DataStore.DishForm is not null)
            {
                using var db = new AppDbContext();
                var data = db.Dishes.ToList();
                addDishForm_input_dishName.Text = DataStore.DishForm.Name;
                addDishForm_input_price.Text = DataStore.DishForm.Price.ToString();
                addDishForm_input_weight.Text = DataStore.DishForm.Weight.ToString();
                addDishForm_list_type.SelectedIndex = addDishForm_list_type.FindString(DataStore.DishForm.Type.ToString());
                addDishForm_table.DataSource = data;
            }
            else
                DataStore.DishForm = new Dish();
            RefreshIngredientGrid();
        }

        private void addDishForm_btn_back_Click(object sender, EventArgs e)
        {
            var adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            Close();
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
                db.Dishes.Update(DataStore.DishForm);
                db.SaveChanges();
                MessageBox.Show("Информация о блюде обновлена");
            }
            if (DataStore.CurrentUser.Role == EnumRole.Admin)
            {
                var adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Close();
            }
            else
            {
                var chefMainForm = new ChefMainForm();
                chefMainForm.Show();
                this.Close();
            }
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
            using var db = new AppDbContext();
            var selectedRow = addDishForm_table.SelectedRows[0];
            DialogResult result = MessageBox.Show(
                                    "Удалить ингредиент?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                var recordToDelete = db.Ingredients.FirstOrDefault(r => r.Id == selectedId);
                if (recordToDelete != null)
                {
                    db.Ingredients.Remove(recordToDelete);
                    db.SaveChanges();
                    addDishForm_table.Rows.Remove(selectedRow);
                }
            }
        }
    }
}
