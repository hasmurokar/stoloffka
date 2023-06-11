namespace app
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginForm_btn_entry = new System.Windows.Forms.Button();
            this.loginForm_input_login = new System.Windows.Forms.TextBox();
            this.loginForm_input_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(277, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите пароль:";
            // 
            // loginForm_btn_entry
            // 
            this.loginForm_btn_entry.BackColor = System.Drawing.Color.Tan;
            this.loginForm_btn_entry.Font = new System.Drawing.Font("Philosopher", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginForm_btn_entry.Location = new System.Drawing.Point(253, 349);
            this.loginForm_btn_entry.Name = "loginForm_btn_entry";
            this.loginForm_btn_entry.Size = new System.Drawing.Size(266, 55);
            this.loginForm_btn_entry.TabIndex = 2;
            this.loginForm_btn_entry.Text = "Войти";
            this.loginForm_btn_entry.UseVisualStyleBackColor = false;
            this.loginForm_btn_entry.Click += new System.EventHandler(this.loginForm_btn_entry_Click);
            // 
            // loginForm_input_login
            // 
            this.loginForm_input_login.Font = new System.Drawing.Font("Philosopher", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginForm_input_login.Location = new System.Drawing.Point(183, 151);
            this.loginForm_input_login.Name = "loginForm_input_login";
            this.loginForm_input_login.Size = new System.Drawing.Size(398, 38);
            this.loginForm_input_login.TabIndex = 3;
            this.loginForm_input_login.WordWrap = false;
            // 
            // loginForm_input_password
            // 
            this.loginForm_input_password.Font = new System.Drawing.Font("Philosopher", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginForm_input_password.Location = new System.Drawing.Point(183, 245);
            this.loginForm_input_password.Name = "loginForm_input_password";
            this.loginForm_input_password.PasswordChar = '*';
            this.loginForm_input_password.Size = new System.Drawing.Size(398, 38);
            this.loginForm_input_password.TabIndex = 4;
            this.loginForm_input_password.WordWrap = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(792, 497);
            this.Controls.Add(this.loginForm_input_password);
            this.Controls.Add(this.loginForm_input_login);
            this.Controls.Add(this.loginForm_btn_entry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Форма авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button loginForm_btn_entry;
        private TextBox loginForm_input_login;
        private TextBox loginForm_input_password;
    }
}