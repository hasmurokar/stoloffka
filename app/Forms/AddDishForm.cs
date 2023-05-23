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
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void addDishForm_btn_back_Click(object sender, EventArgs e)
        {
            var adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Close();
        }

        private void addDishForm_btn_addIngredient_Click(object sender, EventArgs e)
        {
            var addIngridientForm = new AddIngredientForm();
            addIngridientForm.Show();
        }
    }
}
