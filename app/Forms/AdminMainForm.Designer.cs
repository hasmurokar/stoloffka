namespace app.Forms
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminMainForm_menu_addDish = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMainForm_menu_addUser = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMainForm_menu_dishList = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMainForm_btn_exit = new System.Windows.Forms.Button();
            this.adminMainForm_list_users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminMainForm_list_role = new System.Windows.Forms.ComboBox();
            this.adminMainForm_btn_save = new System.Windows.Forms.Button();
            this.adminMainForm_btn_delete = new System.Windows.Forms.Button();
            this.adminMainForm_btn_changeInfo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BurlyWood;
            this.menuStrip1.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMainForm_menu_addDish,
            this.adminMainForm_menu_addUser,
            this.adminMainForm_menu_dishList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(941, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminMainForm_menu_addDish
            // 
            this.adminMainForm_menu_addDish.Name = "adminMainForm_menu_addDish";
            this.adminMainForm_menu_addDish.Size = new System.Drawing.Size(140, 24);
            this.adminMainForm_menu_addDish.Text = "Добавить блюдо...";
            this.adminMainForm_menu_addDish.Click += new System.EventHandler(this.adminMainForm_menu_addDish_Click);
            // 
            // adminMainForm_menu_addUser
            // 
            this.adminMainForm_menu_addUser.Name = "adminMainForm_menu_addUser";
            this.adminMainForm_menu_addUser.Size = new System.Drawing.Size(188, 24);
            this.adminMainForm_menu_addUser.Text = "Добавить пользователя...";
            this.adminMainForm_menu_addUser.Click += new System.EventHandler(this.adminMainForm_menu_addUser_Click);
            // 
            // adminMainForm_menu_dishList
            // 
            this.adminMainForm_menu_dishList.Name = "adminMainForm_menu_dishList";
            this.adminMainForm_menu_dishList.Size = new System.Drawing.Size(108, 24);
            this.adminMainForm_menu_dishList.Text = "Список блюд";
            this.adminMainForm_menu_dishList.Click += new System.EventHandler(this.adminMainForm_menu_dishList_Click);
            // 
            // adminMainForm_btn_exit
            // 
            this.adminMainForm_btn_exit.BackColor = System.Drawing.Color.Sienna;
            this.adminMainForm_btn_exit.Location = new System.Drawing.Point(750, 295);
            this.adminMainForm_btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_btn_exit.Name = "adminMainForm_btn_exit";
            this.adminMainForm_btn_exit.Size = new System.Drawing.Size(179, 40);
            this.adminMainForm_btn_exit.TabIndex = 5;
            this.adminMainForm_btn_exit.Text = "Выйти из аккаунта";
            this.adminMainForm_btn_exit.UseVisualStyleBackColor = false;
            this.adminMainForm_btn_exit.Click += new System.EventHandler(this.adminMainForm_btn_exit_Click);
            // 
            // adminMainForm_list_users
            // 
            this.adminMainForm_list_users.CausesValidation = false;
            this.adminMainForm_list_users.Location = new System.Drawing.Point(55, 110);
            this.adminMainForm_list_users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_list_users.Name = "adminMainForm_list_users";
            this.adminMainForm_list_users.Size = new System.Drawing.Size(355, 33);
            this.adminMainForm_list_users.TabIndex = 6;
            this.adminMainForm_list_users.SelectedIndexChanged += new System.EventHandler(this.adminMainForm_list_users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назначить роль:";
            // 
            // adminMainForm_list_role
            // 
            this.adminMainForm_list_role.FormattingEnabled = true;
            this.adminMainForm_list_role.Location = new System.Drawing.Point(55, 215);
            this.adminMainForm_list_role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_list_role.Name = "adminMainForm_list_role";
            this.adminMainForm_list_role.Size = new System.Drawing.Size(355, 33);
            this.adminMainForm_list_role.TabIndex = 9;
            // 
            // adminMainForm_btn_save
            // 
            this.adminMainForm_btn_save.BackColor = System.Drawing.Color.Tan;
            this.adminMainForm_btn_save.Location = new System.Drawing.Point(600, 109);
            this.adminMainForm_btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_btn_save.Name = "adminMainForm_btn_save";
            this.adminMainForm_btn_save.Size = new System.Drawing.Size(121, 34);
            this.adminMainForm_btn_save.TabIndex = 10;
            this.adminMainForm_btn_save.Text = "Сохранить";
            this.adminMainForm_btn_save.UseVisualStyleBackColor = false;
            this.adminMainForm_btn_save.Click += new System.EventHandler(this.adminMainForm_btn_save_Click);
            // 
            // adminMainForm_btn_delete
            // 
            this.adminMainForm_btn_delete.BackColor = System.Drawing.Color.Tan;
            this.adminMainForm_btn_delete.Location = new System.Drawing.Point(600, 195);
            this.adminMainForm_btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_btn_delete.Name = "adminMainForm_btn_delete";
            this.adminMainForm_btn_delete.Size = new System.Drawing.Size(121, 34);
            this.adminMainForm_btn_delete.TabIndex = 11;
            this.adminMainForm_btn_delete.Text = "Удалить";
            this.adminMainForm_btn_delete.UseVisualStyleBackColor = false;
            this.adminMainForm_btn_delete.Click += new System.EventHandler(this.adminMainForm_btn_delete_Click);
            // 
            // adminMainForm_btn_changeInfo
            // 
            this.adminMainForm_btn_changeInfo.BackColor = System.Drawing.Color.Tan;
            this.adminMainForm_btn_changeInfo.Location = new System.Drawing.Point(527, 151);
            this.adminMainForm_btn_changeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminMainForm_btn_changeInfo.Name = "adminMainForm_btn_changeInfo";
            this.adminMainForm_btn_changeInfo.Size = new System.Drawing.Size(253, 35);
            this.adminMainForm_btn_changeInfo.TabIndex = 12;
            this.adminMainForm_btn_changeInfo.Text = "Изменить информацию";
            this.adminMainForm_btn_changeInfo.UseVisualStyleBackColor = false;
            this.adminMainForm_btn_changeInfo.Click += new System.EventHandler(this.adminMainForm_btn_changeInfo_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(941, 345);
            this.Controls.Add(this.adminMainForm_btn_changeInfo);
            this.Controls.Add(this.adminMainForm_btn_delete);
            this.Controls.Add(this.adminMainForm_btn_save);
            this.Controls.Add(this.adminMainForm_list_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminMainForm_list_users);
            this.Controls.Add(this.adminMainForm_btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Philosopher", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminMainForm";
            this.Text = "Форма администратора";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminMainForm_menu_addDish;
        private ToolStripMenuItem adminMainForm_menu_addUser;
        private Button adminMainForm_btn_exit;
        private ComboBox adminMainForm_list_users;
        private Label label1;
        private Label label2;
        private ComboBox adminMainForm_list_role;
        private Button adminMainForm_btn_save;
        private Button adminMainForm_btn_delete;
        private Button adminMainForm_btn_changeInfo;
        private ToolStripMenuItem adminMainForm_menu_dishList;
    }
}