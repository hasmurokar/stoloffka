namespace app.Forms
{
    partial class DishListForm
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
            this.dishListForm_list_dishes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dishListForm_btn_back = new System.Windows.Forms.Button();
            this.dishListForm_btn_delete = new System.Windows.Forms.Button();
            this.dishListForm_btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dishListForm_list_dishes)).BeginInit();
            this.SuspendLayout();
            // 
            // dishListForm_list_dishes
            // 
            this.dishListForm_list_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishListForm_list_dishes.Location = new System.Drawing.Point(12, 41);
            this.dishListForm_list_dishes.Name = "dishListForm_list_dishes";
            this.dishListForm_list_dishes.RowTemplate.Height = 28;
            this.dishListForm_list_dishes.Size = new System.Drawing.Size(751, 623);
            this.dishListForm_list_dishes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список блюд";
            // 
            // dishListForm_btn_back
            // 
            this.dishListForm_btn_back.Location = new System.Drawing.Point(12, 5);
            this.dishListForm_btn_back.Name = "dishListForm_btn_back";
            this.dishListForm_btn_back.Size = new System.Drawing.Size(109, 30);
            this.dishListForm_btn_back.TabIndex = 2;
            this.dishListForm_btn_back.Text = "Назад";
            this.dishListForm_btn_back.UseVisualStyleBackColor = true;
            // 
            // dishListForm_btn_delete
            // 
            this.dishListForm_btn_delete.Location = new System.Drawing.Point(789, 276);
            this.dishListForm_btn_delete.Name = "dishListForm_btn_delete";
            this.dishListForm_btn_delete.Size = new System.Drawing.Size(164, 42);
            this.dishListForm_btn_delete.TabIndex = 3;
            this.dishListForm_btn_delete.Text = "Удалить";
            this.dishListForm_btn_delete.UseVisualStyleBackColor = true;
            // 
            // dishListForm_btn_update
            // 
            this.dishListForm_btn_update.Location = new System.Drawing.Point(789, 338);
            this.dishListForm_btn_update.Name = "dishListForm_btn_update";
            this.dishListForm_btn_update.Size = new System.Drawing.Size(164, 42);
            this.dishListForm_btn_update.TabIndex = 4;
            this.dishListForm_btn_update.Text = "Редактировать";
            this.dishListForm_btn_update.UseVisualStyleBackColor = true;
            // 
            // DishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 676);
            this.Controls.Add(this.dishListForm_btn_update);
            this.Controls.Add(this.dishListForm_btn_delete);
            this.Controls.Add(this.dishListForm_btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishListForm_list_dishes);
            this.Name = "DishListForm";
            this.Text = "Форма списка блюд";
            ((System.ComponentModel.ISupportInitialize)(this.dishListForm_list_dishes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dishListForm_list_dishes;
        private Label label1;
        private Button dishListForm_btn_back;
        private Button dishListForm_btn_delete;
        private Button dishListForm_btn_update;
    }
}