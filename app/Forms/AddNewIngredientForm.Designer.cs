namespace app.Forms
{
    partial class AddNewIngredientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.addNewIngredientForm_input_name = new System.Windows.Forms.TextBox();
            this.addNewIngredientForm_btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новый ингредиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // addNewIngredientForm_input_name
            // 
            this.addNewIngredientForm_input_name.Location = new System.Drawing.Point(14, 70);
            this.addNewIngredientForm_input_name.Name = "addNewIngredientForm_input_name";
            this.addNewIngredientForm_input_name.Size = new System.Drawing.Size(291, 25);
            this.addNewIngredientForm_input_name.TabIndex = 2;
            this.addNewIngredientForm_input_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNewIngredientForm_input_name_KeyPress);
            // 
            // addNewIngredientForm_btn_add
            // 
            this.addNewIngredientForm_btn_add.BackColor = System.Drawing.Color.Tan;
            this.addNewIngredientForm_btn_add.Location = new System.Drawing.Point(101, 105);
            this.addNewIngredientForm_btn_add.Name = "addNewIngredientForm_btn_add";
            this.addNewIngredientForm_btn_add.Size = new System.Drawing.Size(117, 30);
            this.addNewIngredientForm_btn_add.TabIndex = 3;
            this.addNewIngredientForm_btn_add.Text = "Добавить";
            this.addNewIngredientForm_btn_add.UseVisualStyleBackColor = false;
            this.addNewIngredientForm_btn_add.Click += new System.EventHandler(this.addNewIngredientForm_btn_add_Click);
            // 
            // AddNewIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(317, 144);
            this.Controls.Add(this.addNewIngredientForm_btn_add);
            this.Controls.Add(this.addNewIngredientForm_input_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddNewIngredientForm";
            this.Text = "Форма добавления нового ингредиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox addNewIngredientForm_input_name;
        private Button addNewIngredientForm_btn_add;
    }
}