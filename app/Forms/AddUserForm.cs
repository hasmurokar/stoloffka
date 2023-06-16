using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Domain;
using app.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            var enumValues = Enum.GetValues(typeof(EnumRole)).Cast<EnumRole>();
            addUserForm_list_role.DataSource = enumValues.Select(x => new
            {
                Value = x,
                DisplayName = EnumHelper.GetEnumDisplayName(x)
            }).ToList();
            addUserForm_list_role.DisplayMember = "DisplayName";
            addUserForm_list_role.ValueMember = "Value";
            addUserForm_list_role.DropDownStyle = ComboBoxStyle.DropDownList;
            label1.Text = DataStore.UserUpdateId is null 
                ? "Добавить пользователя" 
                : "Редактировать пользователя";
            PreloadUser();
        }
 
        private async void addUserForm_btn_addUser_Click(object sender, EventArgs e)
        {
            addUserForm_btn_addUser.Text = "Загрузка...";
            addUserForm_btn_addUser.Enabled = false;
            var errorMsg = "";
            errorMsg = InputValidation(errorMsg);

            if (string.IsNullOrEmpty(errorMsg))
            {
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
            else MessageBox.Show(errorMsg);
        }

        private string InputValidation(string errorMsg)
        {
            if (IsDublicateLogin())
            {
                errorMsg += "Пользователь с таким логином уже существует.\n";
                addUserForm_input_login.Clear();
                addUserForm_btn_addUser.Text = "Добавить";
                addUserForm_btn_addUser.Enabled = true;
            }
            if (!IsValidDateBirth())
            {
                errorMsg += "Дата рождения не может быть раньше 1940 г. и позже 2004 г.\n";
                addUserForm_btn_addUser.Text = "Добавить";
                addUserForm_btn_addUser.Enabled = true;
            }

            string regexPattern = @"^077\d{6}$";
            Regex regex = new Regex(regexPattern);
            if (!regex.IsMatch(addUserForm_input_phone.Text))
            {
                errorMsg += "Неверный формат номера телефона. Пример: 077123456. \n";
                addUserForm_input_phone.Clear();
                addUserForm_btn_addUser.Text = "Добавить";
                addUserForm_btn_addUser.Enabled = true;
            }

            return errorMsg;
        }

        private void ResetForm()
        {
            addUserForm_birthday.Value = DateTime.Now;
            addUserForm_list_role.SelectedValue = EnumRole.Admin;
            addUserForm_input_fio.Clear();
            addUserForm_input_login.Clear();
            addUserForm_input_password.Clear();
            addUserForm_input_phone.Clear();
        }

        private EnumRole GetCurrentRole()
        {
            return ((EnumRole)addUserForm_list_role.SelectedValue);
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
            addUserForm_list_role.SelectedValue = CurrentUser.Role;
        }

        private void addUserForm_input_fio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void addUserForm_input_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != '\b')
            {
                e.Handled = true;
            }
        }

        private bool IsDublicateLogin()
        {
            using (var context = new AppDbContext())
            {
                bool isDublicate = context.Users.Any(u => u.Login == addUserForm_input_login.Text);
                return isDublicate;
            }
        }

        private bool IsValidDateBirth()
        {
            if (addUserForm_birthday.Value.Year >= 2004 || addUserForm_birthday.Value.Year <= 1940)
                return false;
            else return true;
        }
    }
}
