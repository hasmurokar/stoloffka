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
            this.dishListForm_list_dishes.AllowUserToAddRows = false;
            this.dishListForm_list_dishes.AllowUserToDeleteRows = false;
            this.dishListForm_list_dishes.AllowUserToResizeColumns = false;
            this.dishListForm_list_dishes.AllowUserToResizeRows = false;
            this.dishListForm_list_dishes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dishListForm_list_dishes.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dishListForm_list_dishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishListForm_list_dishes.Location = new System.Drawing.Point(12, 43);
            this.dishListForm_list_dishes.Name = "dishListForm_list_dishes";
            this.dishListForm_list_dishes.ReadOnly = true;
            this.dishListForm_list_dishes.RowTemplate.Height = 28;
            this.dishListForm_list_dishes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishListForm_list_dishes.Size = new System.Drawing.Size(751, 656);
            this.dishListForm_list_dishes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(303, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список блюд";
            // 
            // dishListForm_btn_back
            // 
            this.dishListForm_btn_back.BackColor = System.Drawing.Color.Tan;
            this.dishListForm_btn_back.Location = new System.Drawing.Point(12, 5);
            this.dishListForm_btn_back.Name = "dishListForm_btn_back";
            this.dishListForm_btn_back.Size = new System.Drawing.Size(109, 32);
            this.dishListForm_btn_back.TabIndex = 2;
            this.dishListForm_btn_back.Text = "Назад";
            this.dishListForm_btn_back.UseVisualStyleBackColor = false;
            this.dishListForm_btn_back.Click += new System.EventHandler(this.dishListForm_btn_back_Click);
            // 
            // dishListForm_btn_delete
            // 
            this.dishListForm_btn_delete.BackColor = System.Drawing.Color.Tan;
            this.dishListForm_btn_delete.Location = new System.Drawing.Point(789, 291);
            this.dishListForm_btn_delete.Name = "dishListForm_btn_delete";
            this.dishListForm_btn_delete.Size = new System.Drawing.Size(164, 44);
            this.dishListForm_btn_delete.TabIndex = 3;
            this.dishListForm_btn_delete.Text = "Удалить";
            this.dishListForm_btn_delete.UseVisualStyleBackColor = false;
            this.dishListForm_btn_delete.Click += new System.EventHandler(this.dishListForm_btn_delete_Click);
            // 
            // dishListForm_btn_update
            // 
            this.dishListForm_btn_update.BackColor = System.Drawing.Color.Tan;
            this.dishListForm_btn_update.Location = new System.Drawing.Point(789, 356);
            this.dishListForm_btn_update.Name = "dishListForm_btn_update";
            this.dishListForm_btn_update.Size = new System.Drawing.Size(164, 44);
            this.dishListForm_btn_update.TabIndex = 4;
            this.dishListForm_btn_update.Text = "Редактировать";
            this.dishListForm_btn_update.UseVisualStyleBackColor = false;
            this.dishListForm_btn_update.Click += new System.EventHandler(this.dishListForm_btn_update_Click);
            // 
            // DishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(974, 712);
            this.Controls.Add(this.dishListForm_btn_update);
            this.Controls.Add(this.dishListForm_btn_delete);
            this.Controls.Add(this.dishListForm_btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dishListForm_list_dishes);
            this.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DishListForm";
            this.Text = "Форма списка блюд";
            this.Load += new System.EventHandler(this.DishListForm_Load);
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