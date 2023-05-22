using app.Domain;
using app.Enums;
using app.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app.Forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            addUserForm_list_role.DataSource = Enum.GetValues(typeof(EnumRole));
        }

        private async void addUserForm_btn_addUser_Click(object sender, EventArgs e)
        {
            addUserForm_btn_addUser.Text = "Загрузка...";
            addUserForm_btn_addUser.Enabled = false;
            using var db = new AppDbContext();
            var user = new User
            {
                Name = addUserForm_input_fio.Text,
                Login = addUserForm_input_login.Text,
                Password = addUserForm_input_password.Text,
                Phone = addUserForm_input_phone.Text,
                Birthday = addUserForm_birthday.Value,
                Role = GetCurrentRole()
            };
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();

            MessageBox.Show("Пользователь добавлен");
            ResetForm();
            addUserForm_btn_addUser.Text = "Добавить";
            addUserForm_btn_addUser.Enabled = true;
        }

        private void ResetForm()
        {
            addUserForm_birthday.Value = DateTime.Now;
            addUserForm_list_role.SelectedIndex = addUserForm_list_role.FindString(EnumRole.Admin.ToString());
            addUserForm_input_fio.Clear();
            addUserForm_input_login.Clear();
            addUserForm_input_password.Clear();
            addUserForm_input_phone.Clear();
        }

        private void AddUserRole()
        {
            if (addUserForm_list_role.SelectedText == "Администратор")
            {

            }
        }

        private EnumRole GetCurrentRole()
        {
            Enum.TryParse(addUserForm_list_role.SelectedValue.ToString(), out EnumRole status);
            return status;
        }
    }
}
