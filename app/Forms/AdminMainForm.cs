using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Common.Combobox;
using app.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace app.Forms
{
    public partial class AdminMainForm : Form
    {
        private User? CurrentUser;
        public AdminMainForm()
        {
            InitializeComponent();

        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            InitComboboxUsers();
            InitComboboxRole();
        }
        private void adminMainForm_menu_addUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            this.Close();
            addUserForm.Show();
        }

        private async void adminMainForm_btn_save_Click(object sender, EventArgs e)
        {
            adminMainForm_btn_save.Text = "Загрузка...";
            ButtonsEnable(false);
            var userId = (int)adminMainForm_list_users.SelectedValue;
            if (userId != 0)
            {
                using var db = new AppDbContext();
                var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userId);
                user.Role = (EnumRole)adminMainForm_list_role.SelectedValue;
                await db.SaveChangesAsync();
                MessageBox.Show("Роль пользователя обновлена");
                adminMainForm_btn_save.Text = "Сохранить";
                ButtonsEnable(true);
            }
            else
            {
                MessageBox.Show("Пользователь не выбран");
                adminMainForm_btn_save.Text = "Сохранить";
                ButtonsEnable(true);
            }
        }

        private void InitComboboxUsers()
        {
            using var db = new AppDbContext();
            var users = db.Users.ToList();
            var items = new List<UserCombobox>() { new UserCombobox() { Id = 0, Name = "Не выбрано" } };
            items.AddRange(users.ConvertAll(x => new UserCombobox() { Id = x.Id, Name = x.Name }));
            adminMainForm_list_users.DataSource = items;
            adminMainForm_list_users.DisplayMember = "Name";
            adminMainForm_list_users.ValueMember = "Id";
            adminMainForm_list_users.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void InitComboboxRole()
        {
            adminMainForm_list_role.DataSource = Enum.GetValues(typeof(EnumRole));
            adminMainForm_list_role.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void adminMainForm_btn_changeInfo_Click(object sender, EventArgs e)
        {
            adminMainForm_btn_changeInfo.Text = "Загрузка...";
            ButtonsEnable(false);
            var userId = (int)adminMainForm_list_users.SelectedValue;
            if (userId != 0)
            {
                DataStore.UserUpdateId = userId;
                var addUserForm = new AddUserForm();
                addUserForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не выбран");
                adminMainForm_btn_changeInfo.Text = "Изменить информацию";
                ButtonsEnable(true);
            }
        }

        private void adminMainForm_btn_delete_Click(object sender, EventArgs e)
        {
            adminMainForm_btn_delete.Text = "Загрузка...";
            ButtonsEnable(false);

            var userId = (int)adminMainForm_list_users.SelectedValue;
            DialogResult result = MessageBox.Show(
                                    "Удалить пользователя?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                using var db = new AppDbContext();
                var user = db.Users.FirstOrDefault(u => u.Id == userId);
                db.Users.Remove(user);
                db.SaveChanges();
            }

            adminMainForm_btn_delete.Text = "Удалить";
            ButtonsEnable(true);
        }

        private void adminMainForm_list_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            adminMainForm_btn_save.Enabled = adminMainForm_btn_changeInfo.Enabled = adminMainForm_btn_delete.Enabled 
                = adminMainForm_list_users.SelectedIndex != 0;
        }

        private void ButtonsEnable(bool flag)
        {
            adminMainForm_btn_save.Enabled = true;
            adminMainForm_btn_exit.Enabled = true;
            adminMainForm_btn_delete.Enabled = true;
            adminMainForm_btn_changeInfo.Enabled = true;
        }

        private void adminMainForm_btn_exit_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void adminMainForm_menu_dishList_Click(object sender, EventArgs e)
        {
            var dishListForm = new DishListForm();
            dishListForm.Show();
            this.Close();
        }

        private void adminMainForm_menu_addDish_Click(object sender, EventArgs e)
        {
            var addDishForm = new AddDishForm();
            addDishForm.Show();
            this.Close();
        }
    }
}
