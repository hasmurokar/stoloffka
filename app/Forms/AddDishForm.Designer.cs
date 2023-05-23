namespace app.Forms
{
    partial class AddDishForm
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
            this.addDishForm_btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addDishForm_input_dishName = new System.Windows.Forms.TextBox();
            this.addDishForm_input_weight = new System.Windows.Forms.TextBox();
            this.addDishForm_list_type = new System.Windows.Forms.ComboBox();
            this.addDishForm_input_price = new System.Windows.Forms.TextBox();
            this.addDishForm_btn_save = new System.Windows.Forms.Button();
            this.addDishForm_btn_addIngredient = new System.Windows.Forms.Button();
            this.addDishForm_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.addDishForm_table)).BeginInit();
            this.SuspendLayout();
            // 
            // addDishForm_btn_back
            // 
            this.addDishForm_btn_back.Location = new System.Drawing.Point(12, 12);
            this.addDishForm_btn_back.Name = "addDishForm_btn_back";
            this.addDishForm_btn_back.Size = new System.Drawing.Size(76, 27);
            this.addDishForm_btn_back.TabIndex = 0;
            this.addDishForm_btn_back.Text = "Назад";
            this.addDishForm_btn_back.UseVisualStyleBackColor = true;
            this.addDishForm_btn_back.Click += new System.EventHandler(this.addDishForm_btn_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление/редактирование блюда:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип блюда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ингредиенты блюда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Общая масса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена";
            // 
            // addDishForm_input_dishName
            // 
            this.addDishForm_input_dishName.Location = new System.Drawing.Point(13, 89);
            this.addDishForm_input_dishName.Name = "addDishForm_input_dishName";
            this.addDishForm_input_dishName.Size = new System.Drawing.Size(282, 26);
            this.addDishForm_input_dishName.TabIndex = 8;
            // 
            // addDishForm_input_weight
            // 
            this.addDishForm_input_weight.Location = new System.Drawing.Point(209, 482);
            this.addDishForm_input_weight.Name = "addDishForm_input_weight";
            this.addDishForm_input_weight.Size = new System.Drawing.Size(161, 26);
            this.addDishForm_input_weight.TabIndex = 9;
            // 
            // addDishForm_list_type
            // 
            this.addDishForm_list_type.FormattingEnabled = true;
            this.addDishForm_list_type.Location = new System.Drawing.Point(13, 140);
            this.addDishForm_list_type.Name = "addDishForm_list_type";
            this.addDishForm_list_type.Size = new System.Drawing.Size(170, 27);
            this.addDishForm_list_type.TabIndex = 12;
            // 
            // addDishForm_input_price
            // 
            this.addDishForm_input_price.Location = new System.Drawing.Point(13, 482);
            this.addDishForm_input_price.Name = "addDishForm_input_price";
            this.addDishForm_input_price.Size = new System.Drawing.Size(160, 26);
            this.addDishForm_input_price.TabIndex = 13;
            // 
            // addDishForm_btn_save
            // 
            this.addDishForm_btn_save.Location = new System.Drawing.Point(298, 531);
            this.addDishForm_btn_save.Name = "addDishForm_btn_save";
            this.addDishForm_btn_save.Size = new System.Drawing.Size(151, 28);
            this.addDishForm_btn_save.TabIndex = 14;
            this.addDishForm_btn_save.Text = "Сохранить";
            this.addDishForm_btn_save.UseVisualStyleBackColor = true;
            // 
            // addDishForm_btn_addIngredient
            // 
            this.addDishForm_btn_addIngredient.Location = new System.Drawing.Point(554, 187);
            this.addDishForm_btn_addIngredient.Name = "addDishForm_btn_addIngredient";
            this.addDishForm_btn_addIngredient.Size = new System.Drawing.Size(189, 29);
            this.addDishForm_btn_addIngredient.TabIndex = 15;
            this.addDishForm_btn_addIngredient.Text = "Добавить ингредиент";
            this.addDishForm_btn_addIngredient.UseVisualStyleBackColor = true;
            this.addDishForm_btn_addIngredient.Click += new System.EventHandler(this.addDishForm_btn_addIngredient_Click);
            // 
            // addDishForm_table
            // 
            this.addDishForm_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addDishForm_table.Location = new System.Drawing.Point(13, 219);
            this.addDishForm_table.Name = "addDishForm_table";
            this.addDishForm_table.RowTemplate.Height = 28;
            this.addDishForm_table.Size = new System.Drawing.Size(752, 238);
            this.addDishForm_table.TabIndex = 16;
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 571);
            this.Controls.Add(this.addDishForm_table);
            this.Controls.Add(this.addDishForm_btn_addIngredient);
            this.Controls.Add(this.addDishForm_btn_save);
            this.Controls.Add(this.addDishForm_input_price);
            this.Controls.Add(this.addDishForm_list_type);
            this.Controls.Add(this.addDishForm_input_weight);
            this.Controls.Add(this.addDishForm_input_dishName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addDishForm_btn_back);
            this.Name = "AddDishForm";
            this.Text = "Форма добавления и редактирования блюда";
            ((System.ComponentModel.ISupportInitialize)(this.addDishForm_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addDishForm_btn_back;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox addDishForm_input_dishName;
        private TextBox addDishForm_input_weight;
        private ComboBox addDishForm_list_type;
        private TextBox addDishForm_input_price;
        private Button addDishForm_btn_save;
        private Button addDishForm_btn_addIngredient;
        private DataGridView addDishForm_table;
    }
}