using app.Data;
using app.Domain;
using app.Enums;
using app.Forms;
using app.Models.Domain;
using app.Services;

namespace app
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private async void loginForm_btn_entry_Click(object sender, EventArgs e)
        {
            var login = loginForm_input_login.Text;
            var password = loginForm_input_password.Text;
            var result = await _authService.LogIn(login, password);
            if (result)
            {
                switch (DataStore.CurrentUser.Role)
                {
                    case EnumRole.Admin:
                        var adminMainForm = new AdminMainForm();
                        this.Hide();
                        adminMainForm.Show();
                        break;
                    case EnumRole.Cashier:
                        var cashierMainForm = new CashierMainForm();
                        this.Hide();
                        cashierMainForm.Show();
                        break;
                    case EnumRole.Chef:
                        var chefMainForm = new ChefMainForm();
                        this.Hide();
                        chefMainForm.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пароль или логин введен неверно!");
                loginForm_input_login.Clear();
                loginForm_input_password.Clear();
            }
        }
    }
}