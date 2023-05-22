namespace app.Forms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void adminMainForm_menu_addUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserForm();
            this.Close();
            addUserForm.Show();
        }
    }
}
