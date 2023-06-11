namespace app.Forms
{
    partial class AddUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addUserForm_btn_back = new System.Windows.Forms.Button();
            this.addUserForm_input_fio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addUserForm_input_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUserForm_input_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addUserForm_list_role = new System.Windows.Forms.ComboBox();
            this.addUserForm_btn_addUser = new System.Windows.Forms.Button();
            this.addUserForm_birthday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addUserForm_input_phone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление пользователя";
            // 
            // addUserForm_btn_back
            // 
            this.addUserForm_btn_back.BackColor = System.Drawing.Color.Tan;
            this.addUserForm_btn_back.Location = new System.Drawing.Point(14, 13);
            this.addUserForm_btn_back.Name = "addUserForm_btn_back";
            this.addUserForm_btn_back.Size = new System.Drawing.Size(92, 29);
            this.addUserForm_btn_back.TabIndex = 1;
            this.addUserForm_btn_back.Text = "Назад";
            this.addUserForm_btn_back.UseVisualStyleBackColor = false;
            this.addUserForm_btn_back.Click += new System.EventHandler(this.addUserForm_btn_back_Click);
            // 
            // addUserForm_input_fio
            // 
            this.addUserForm_input_fio.Location = new System.Drawing.Point(14, 118);
            this.addUserForm_input_fio.Name = "addUserForm_input_fio";
            this.addUserForm_input_fio.Size = new System.Drawing.Size(578, 25);
            this.addUserForm_input_fio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите логин:";
            // 
            // addUserForm_input_login
            // 
            this.addUserForm_input_login.Location = new System.Drawing.Point(14, 194);
            this.addUserForm_input_login.Name = "addUserForm_input_login";
            this.addUserForm_input_login.Size = new System.Drawing.Size(376, 25);
            this.addUserForm_input_login.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите пароль:";
            // 
            // addUserForm_input_password
            // 
            this.addUserForm_input_password.Location = new System.Drawing.Point(16, 273);
            this.addUserForm_input_password.Name = "addUserForm_input_password";
            this.addUserForm_input_password.Size = new System.Drawing.Size(372, 25);
            this.addUserForm_input_password.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите роль пользователю:";
            // 
            // addUserForm_list_role
            // 
            this.addUserForm_list_role.FormattingEnabled = true;
            this.addUserForm_list_role.Items.AddRange(new object[] {
            "Администратор",
            "Повар",
            "Кассир"});
            this.addUserForm_list_role.Location = new System.Drawing.Point(16, 355);
            this.addUserForm_list_role.Name = "addUserForm_list_role";
            this.addUserForm_list_role.Size = new System.Drawing.Size(226, 29);
            this.addUserForm_list_role.TabIndex = 9;
            // 
            // addUserForm_btn_addUser
            // 
            this.addUserForm_btn_addUser.BackColor = System.Drawing.Color.Tan;
            this.addUserForm_btn_addUser.Font = new System.Drawing.Font("Philosopher", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addUserForm_btn_addUser.Location = new System.Drawing.Point(363, 478);
            this.addUserForm_btn_addUser.Name = "addUserForm_btn_addUser";
            this.addUserForm_btn_addUser.Size = new System.Drawing.Size(164, 34);
            this.addUserForm_btn_addUser.TabIndex = 10;
            this.addUserForm_btn_addUser.Text = "Добавить";
            this.addUserForm_btn_addUser.UseVisualStyleBackColor = false;
            this.addUserForm_btn_addUser.Click += new System.EventHandler(this.addUserForm_btn_addUser_Click);
            // 
            // addUserForm_birthday
            // 
            this.addUserForm_birthday.Location = new System.Drawing.Point(510, 194);
            this.addUserForm_birthday.Name = "addUserForm_birthday";
            this.addUserForm_birthday.Size = new System.Drawing.Size(224, 25);
            this.addUserForm_birthday.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(514, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Введите дату рождения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(510, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите номер телефона:";
            // 
            // addUserForm_input_phone
            // 
            this.addUserForm_input_phone.Location = new System.Drawing.Point(510, 273);
            this.addUserForm_input_phone.MaxLength = 11;
            this.addUserForm_input_phone.Name = "addUserForm_input_phone";
            this.addUserForm_input_phone.Size = new System.Drawing.Size(224, 25);
            this.addUserForm_input_phone.TabIndex = 14;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(900, 543);
            this.Controls.Add(this.addUserForm_input_phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addUserForm_birthday);
            this.Controls.Add(this.addUserForm_btn_addUser);
            this.Controls.Add(this.addUserForm_list_role);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addUserForm_input_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addUserForm_input_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addUserForm_input_fio);
            this.Controls.Add(this.addUserForm_btn_back);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddUserForm";
            this.Text = "Форма добавления пользователя";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button addUserForm_btn_back;
        private TextBox addUserForm_input_fio;
        private Label label2;
        private Label label3;
        private TextBox addUserForm_input_login;
        private Label label4;
        private TextBox addUserForm_input_password;
        private Label label5;
        private ComboBox addUserForm_list_role;
        private Button addUserForm_btn_addUser;
        private DateTimePicker addUserForm_birthday;
        private Label label6;
        private Label label7;
        private TextBox addUserForm_input_phone;
    }
}