using app.Domain;
using app.Models.Domain;
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
    public partial class AddNewIngredientForm : Form
    {
        public AddNewIngredientForm()
        {
            InitializeComponent();
        }

        private async void addNewIngredientForm_btn_add_Click(object sender, EventArgs e)
        {
            if (!IsDublicateIngredient())
            {
                addNewIngredientForm_btn_add.Text = "Загрузка...";
                addNewIngredientForm_btn_add.Enabled = false;
                addNewIngredientForm_input_name.Enabled = false;
                using var db = new AppDbContext();
                var ingridient = new IngredientKind
                {
                    Name = addNewIngredientForm_input_name.Text,
                };
                await db.IngredientKinds.AddAsync(ingridient);
                await db.SaveChangesAsync();

                MessageBox.Show("Ингредиент добавлен");
                addNewIngredientForm_input_name.Clear();
                addNewIngredientForm_btn_add.Text = "Добавить";
                addNewIngredientForm_btn_add.Enabled = true;
                addNewIngredientForm_input_name.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ингредиент с таким названием уже существует");
                addNewIngredientForm_btn_add.Text = "Добавить";
                addNewIngredientForm_input_name.Clear();
                addNewIngredientForm_btn_add.Enabled = true;
                addNewIngredientForm_input_name.Enabled = true;
            }
        }

        private void addNewIngredientForm_input_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }
        private bool IsDublicateIngredient()
        {
            using (var context = new AppDbContext())
            {
                bool isDublicate = context.IngredientKinds.Any(u => u.Name == addNewIngredientForm_input_name.Text);
                return isDublicate;
            }
        }
    }
}
