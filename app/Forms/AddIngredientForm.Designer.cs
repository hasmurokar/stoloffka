namespace app.Forms
{
    partial class AddIngredientForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.addIngredientForm_btn_addNew = new System.Windows.Forms.Button();
            this.addIngredientForm_btn_save = new System.Windows.Forms.Button();
            this.addIngredientForm_weight = new System.Windows.Forms.NumericUpDown();
            this.addIngredientForm_list_ingredients = new System.Windows.Forms.ComboBox();
            this.addIngredientForm_btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addIngredientForm_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить ингредиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вес (г)";
            // 
            // addIngredientForm_btn_addNew
            // 
            this.addIngredientForm_btn_addNew.BackColor = System.Drawing.Color.Tan;
            this.addIngredientForm_btn_addNew.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientForm_btn_addNew.Location = new System.Drawing.Point(312, 52);
            this.addIngredientForm_btn_addNew.Name = "addIngredientForm_btn_addNew";
            this.addIngredientForm_btn_addNew.Size = new System.Drawing.Size(175, 34);
            this.addIngredientForm_btn_addNew.TabIndex = 4;
            this.addIngredientForm_btn_addNew.Text = "Добавить новый";
            this.addIngredientForm_btn_addNew.UseVisualStyleBackColor = false;
            this.addIngredientForm_btn_addNew.Click += new System.EventHandler(this.addIngredientForm_btn_addNew_Click);
            // 
            // addIngredientForm_btn_save
            // 
            this.addIngredientForm_btn_save.BackColor = System.Drawing.Color.Tan;
            this.addIngredientForm_btn_save.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientForm_btn_save.Location = new System.Drawing.Point(230, 98);
            this.addIngredientForm_btn_save.Name = "addIngredientForm_btn_save";
            this.addIngredientForm_btn_save.Size = new System.Drawing.Size(255, 48);
            this.addIngredientForm_btn_save.TabIndex = 6;
            this.addIngredientForm_btn_save.Text = "Сохранить";
            this.addIngredientForm_btn_save.UseVisualStyleBackColor = false;
            this.addIngredientForm_btn_save.Click += new System.EventHandler(this.addIngredientForm_btn_save_Click);
            // 
            // addIngredientForm_weight
            // 
            this.addIngredientForm_weight.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientForm_weight.Location = new System.Drawing.Point(12, 120);
            this.addIngredientForm_weight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.addIngredientForm_weight.Name = "addIngredientForm_weight";
            this.addIngredientForm_weight.Size = new System.Drawing.Size(120, 25);
            this.addIngredientForm_weight.TabIndex = 7;
            // 
            // addIngredientForm_list_ingredients
            // 
            this.addIngredientForm_list_ingredients.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientForm_list_ingredients.FormattingEnabled = true;
            this.addIngredientForm_list_ingredients.Location = new System.Drawing.Point(12, 56);
            this.addIngredientForm_list_ingredients.Name = "addIngredientForm_list_ingredients";
            this.addIngredientForm_list_ingredients.Size = new System.Drawing.Size(200, 29);
            this.addIngredientForm_list_ingredients.TabIndex = 8;
            this.addIngredientForm_list_ingredients.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addIngredientForm_list_ingredients_KeyPress);
            // 
            // addIngredientForm_btn_search
            // 
            this.addIngredientForm_btn_search.BackColor = System.Drawing.Color.Tan;
            this.addIngredientForm_btn_search.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addIngredientForm_btn_search.Location = new System.Drawing.Point(218, 52);
            this.addIngredientForm_btn_search.Name = "addIngredientForm_btn_search";
            this.addIngredientForm_btn_search.Size = new System.Drawing.Size(88, 34);
            this.addIngredientForm_btn_search.TabIndex = 9;
            this.addIngredientForm_btn_search.Text = "Поиск";
            this.addIngredientForm_btn_search.UseVisualStyleBackColor = false;
            this.addIngredientForm_btn_search.Click += new System.EventHandler(this.addIngredientForm_btn_search_Click);
            // 
            // AddIngredientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(497, 163);
            this.Controls.Add(this.addIngredientForm_btn_search);
            this.Controls.Add(this.addIngredientForm_list_ingredients);
            this.Controls.Add(this.addIngredientForm_weight);
            this.Controls.Add(this.addIngredientForm_btn_save);
            this.Controls.Add(this.addIngredientForm_btn_addNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddIngredientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма добавления ингредиентов";
            this.Load += new System.EventHandler(this.AddIngredientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addIngredientForm_weight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button addIngredientForm_btn_addNew;
        private Button addIngredientForm_btn_save;
        private NumericUpDown addIngredientForm_weight;
        private ComboBox addIngredientForm_list_ingredients;
        private Button addIngredientForm_btn_search;
    }
}