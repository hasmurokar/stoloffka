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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminMainForm_menu_addDish,
            this.adminMainForm_menu_addUser,
            this.adminMainForm_menu_dishList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminMainForm_menu_addDish
            // 
            this.adminMainForm_menu_addDish.Name = "adminMainForm_menu_addDish";
            this.adminMainForm_menu_addDish.Size = new System.Drawing.Size(137, 23);
            this.adminMainForm_menu_addDish.Text = "Добавить блюдо...";
            // 
            // adminMainForm_menu_addUser
            // 
            this.adminMainForm_menu_addUser.Name = "adminMainForm_menu_addUser";
            this.adminMainForm_menu_addUser.Size = new System.Drawing.Size(180, 23);
            this.adminMainForm_menu_addUser.Text = "Добавить пользователя...";
            // 
            // adminMainForm_menu_dishList
            // 
            this.adminMainForm_menu_dishList.Name = "adminMainForm_menu_dishList";
            this.adminMainForm_menu_dishList.Size = new System.Drawing.Size(105, 23);
            this.adminMainForm_menu_dishList.Text = "Список блюд";
            // 
            // adminMainForm_btn_exit
            // 
            this.adminMainForm_btn_exit.BackColor = System.Drawing.Color.RosyBrown;
            this.adminMainForm_btn_exit.Location = new System.Drawing.Point(600, 224);
            this.adminMainForm_btn_exit.Name = "adminMainForm_btn_exit";
            this.adminMainForm_btn_exit.Size = new System.Drawing.Size(143, 30);
            this.adminMainForm_btn_exit.TabIndex = 5;
            this.adminMainForm_btn_exit.Text = "Выйти из аккаунта";
            this.adminMainForm_btn_exit.UseVisualStyleBackColor = false;
            // 
            // adminMainForm_list_users
            // 
            this.adminMainForm_list_users.FormattingEnabled = true;
            this.adminMainForm_list_users.Location = new System.Drawing.Point(44, 84);
            this.adminMainForm_list_users.Name = "adminMainForm_list_users";
            this.adminMainForm_list_users.Size = new System.Drawing.Size(285, 27);
            this.adminMainForm_list_users.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назначить роль:";
            // 
            // adminMainForm_list_role
            // 
            this.adminMainForm_list_role.FormattingEnabled = true;
            this.adminMainForm_list_role.Location = new System.Drawing.Point(44, 163);
            this.adminMainForm_list_role.Name = "adminMainForm_list_role";
            this.adminMainForm_list_role.Size = new System.Drawing.Size(285, 27);
            this.adminMainForm_list_role.TabIndex = 9;
            // 
            // adminMainForm_btn_save
            // 
            this.adminMainForm_btn_save.Location = new System.Drawing.Point(480, 83);
            this.adminMainForm_btn_save.Name = "adminMainForm_btn_save";
            this.adminMainForm_btn_save.Size = new System.Drawing.Size(97, 26);
            this.adminMainForm_btn_save.TabIndex = 10;
            this.adminMainForm_btn_save.Text = "Сохранить";
            this.adminMainForm_btn_save.UseVisualStyleBackColor = true;
            // 
            // adminMainForm_btn_delete
            // 
            this.adminMainForm_btn_delete.Location = new System.Drawing.Point(480, 148);
            this.adminMainForm_btn_delete.Name = "adminMainForm_btn_delete";
            this.adminMainForm_btn_delete.Size = new System.Drawing.Size(97, 26);
            this.adminMainForm_btn_delete.TabIndex = 11;
            this.adminMainForm_btn_delete.Text = "Удалить";
            this.adminMainForm_btn_delete.UseVisualStyleBackColor = true;
            // 
            // adminMainForm_btn_changeInfo
            // 
            this.adminMainForm_btn_changeInfo.Location = new System.Drawing.Point(422, 115);
            this.adminMainForm_btn_changeInfo.Name = "adminMainForm_btn_changeInfo";
            this.adminMainForm_btn_changeInfo.Size = new System.Drawing.Size(202, 27);
            this.adminMainForm_btn_changeInfo.TabIndex = 12;
            this.adminMainForm_btn_changeInfo.Text = "Изменить информацию";
            this.adminMainForm_btn_changeInfo.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 262);
            this.Controls.Add(this.adminMainForm_btn_changeInfo);
            this.Controls.Add(this.adminMainForm_btn_delete);
            this.Controls.Add(this.adminMainForm_btn_save);
            this.Controls.Add(this.adminMainForm_list_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminMainForm_list_users);
            this.Controls.Add(this.adminMainForm_btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.Text = "Форма администратора";
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