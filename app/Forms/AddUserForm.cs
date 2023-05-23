using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Domain;
using Microsoft.EntityFrameworkCore;
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
        private User? CurrentUser;
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            addUserForm_list_role.DataSource = Enum.GetValues(typeof(EnumRole));
            addUserForm_list_role.DropDownStyle = ComboBoxStyle.DropDownList;
            PreloadUser();
        }

 
        private async void addUserForm_btn_addUser_Click(object sender, EventArgs e)
        {
            addUserForm_btn_addUser.Text = "Загрузка...";
            addUserForm_btn_addUser.Enabled = false;

            if (DataStore.UserUpdateId is null)
            {
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
            else
            {
                using var db = new AppDbContext();
                CurrentUser.Name = addUserForm_input_fio.Text;
                CurrentUser.Login = addUserForm_input_login.Text;
                CurrentUser.Password = addUserForm_input_password.Text;
                CurrentUser.Phone = addUserForm_input_phone.Text;
                CurrentUser.Birthday = addUserForm_birthday.Value;
                CurrentUser.Role = GetCurrentRole();
                db.Users.Update(CurrentUser);
                await db.SaveChangesAsync();

                MessageBox.Show("Информация о пользователе обновлена");
                ResetForm();
                addUserForm_btn_addUser.Text = "Добавить";
                addUserForm_btn_addUser.Enabled = true;
                DataStore.UserUpdateId = null;
                var adminMainForm = new AdminMainForm();
                adminMainForm.Show();
                this.Close();
            }
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

        private EnumRole GetCurrentRole()
        {
            Enum.TryParse(addUserForm_list_role.SelectedValue.ToString(), out EnumRole status);
            return status;
        }

        private void addUserForm_btn_back_Click(object sender, EventArgs e)
        {
            var adminMainForm = new AdminMainForm();
            adminMainForm.Show();
            this.Close();
        }

        private void PreloadUser()
        {
            if (DataStore.UserUpdateId is null) return;

            using var db = new AppDbContext();
            CurrentUser = db.Users.FirstOrDefault(u => u.Id == DataStore.UserUpdateId);
            addUserForm_input_fio.Text = CurrentUser.Name;
            addUserForm_input_login.Text = CurrentUser.Login;
            addUserForm_input_password.Text = CurrentUser.Password;
            addUserForm_input_phone.Text = CurrentUser.Phone;
            addUserForm_birthday.Value = CurrentUser.Birthday;
            addUserForm_list_role.SelectedIndex = addUserForm_list_role.FindString(CurrentUser.Role.ToString());
        }
    }
}
