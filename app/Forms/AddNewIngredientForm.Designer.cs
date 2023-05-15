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
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить новый ингредиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование";
            // 
            // addNewIngredientForm_input_name
            // 
            this.addNewIngredientForm_input_name.Location = new System.Drawing.Point(12, 63);
            this.addNewIngredientForm_input_name.Name = "addNewIngredientForm_input_name";
            this.addNewIngredientForm_input_name.Size = new System.Drawing.Size(259, 26);
            this.addNewIngredientForm_input_name.TabIndex = 2;
            // 
            // addNewIngredientForm_btn_add
            // 
            this.addNewIngredientForm_btn_add.Location = new System.Drawing.Point(90, 95);
            this.addNewIngredientForm_btn_add.Name = "addNewIngredientForm_btn_add";
            this.addNewIngredientForm_btn_add.Size = new System.Drawing.Size(104, 27);
            this.addNewIngredientForm_btn_add.TabIndex = 3;
            this.addNewIngredientForm_btn_add.Text = "Добавить";
            this.addNewIngredientForm_btn_add.UseVisualStyleBackColor = true;
            // 
            // AddNewIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 130);
            this.Controls.Add(this.addNewIngredientForm_btn_add);
            this.Controls.Add(this.addNewIngredientForm_input_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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