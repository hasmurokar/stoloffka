using app.Data;
using app.Domain;
using app.Models.Domain;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app.Forms
{
    public partial class AddIngredientForm : Form
    {
        public AddIngredientForm()
        {
            InitializeComponent();
        }

        private void AddIngredientForm_Load(object sender, EventArgs e)
        {
            addIngredientForm_list_ingredients.DataSource = new List<IngredientKind>();
            addIngredientForm_list_ingredients.ValueMember = "Id";
            addIngredientForm_list_ingredients.DisplayMember = "Name";
        }

        private async void addIngredientForm_btn_save_Click(object sender, EventArgs e)
        {
            if (addIngredientForm_list_ingredients.SelectedValue == null)
            {
                MessageBox.Show("Название ингредиента не выбрано");
                return;
            }

            var kindId = (int)addIngredientForm_list_ingredients.SelectedValue;

            if (kindId != 0)
            {
                var exist = DataStore.DishForm.Ingredients.FirstOrDefault(x => x.Kind.Id == kindId);
                if (exist != null)
                    DataStore.DishForm.Ingredients.Remove(exist);

                using var db = new AppDbContext();
                var kind = db.IngredientKinds.FirstOrDefault(k => k.Id == kindId);
                var ingredient = new Ingredient
                {
                    Kind = kind,
                    Weight = addIngredientForm_weight.Value,
                    KindId = kind.Id
                };
                DataStore.DishForm.Ingredients.Add(ingredient);
                MessageBox.Show("Ингредиент добавлен");
                addIngredientForm_list_ingredients.SelectedValue = "";
                addIngredientForm_weight.Value = 0;
            }
            else
                MessageBox.Show("Название ингредиента не выбрано");
        }

        private void addIngredientForm_btn_addNew_Click(object sender, EventArgs e)
        {
            var addNewIngredientForm = new AddNewIngredientForm();
            addNewIngredientForm.Show();
        }

        private void addIngredientForm_list_ingredients_TextChanged(object sender, EventArgs e)
        {
            string searchText = addIngredientForm_list_ingredients.Text;

            addIngredientForm_list_ingredients.DataSource = string.IsNullOrEmpty(searchText) ? new List<IngredientKind>() 
                                                                                             : GetIngredientKindsFilter(searchText);
            addIngredientForm_list_ingredients.Text = searchText;

            addIngredientForm_list_ingredients.DroppedDown = addIngredientForm_list_ingredients.Items.Count > 0;
        }

        private List<IngredientKind> GetIngredientKindsFilter(string term = "")
        {
            using var db = new AppDbContext();
            return db.IngredientKinds.Where(x => x.Name.ToLower().Contains(term.ToLower())).ToList();
        }

        private void addIngredientForm_btn_search_Click(object sender, EventArgs e)
        {
            addIngredientForm_list_ingredients_TextChanged(null, EventArgs.Empty);
        }

        private void addIngredientForm_list_ingredients_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
