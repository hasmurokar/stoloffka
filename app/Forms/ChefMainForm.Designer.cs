namespace app.Forms
{
    partial class ChefMainForm
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
            this.chefMainForm_btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chefMainForm_combobox_dish = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chefMainForm_portionCount = new System.Windows.Forms.NumericUpDown();
            this.chefMainForm_btn_count = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chefMainForm_label_dishName = new System.Windows.Forms.Label();
            this.chefMainForm_date = new System.Windows.Forms.DateTimePicker();
            this.chefMainForm_list_count = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cfehMainForm_btn_addToDoc = new System.Windows.Forms.Button();
            this.chefMainForm_list_document = new System.Windows.Forms.DataGridView();
            this.chefMainForm_btn_saveDoc = new System.Windows.Forms.Button();
            this.chefMainForm_btn_clearListDoc = new System.Windows.Forms.Button();
            this.chefMainForm_btn_viewDishes = new System.Windows.Forms.Button();
            this.chefMainForm_btn_viewDocs = new System.Windows.Forms.Button();
            this.chefMainForm_checkBox_print = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_portionCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_document)).BeginInit();
            this.SuspendLayout();
            // 
            // chefMainForm_btn_exit
            // 
            this.chefMainForm_btn_exit.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_exit.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_btn_exit.Location = new System.Drawing.Point(823, 13);
            this.chefMainForm_btn_exit.Name = "chefMainForm_btn_exit";
            this.chefMainForm_btn_exit.Size = new System.Drawing.Size(113, 31);
            this.chefMainForm_btn_exit.TabIndex = 2;
            this.chefMainForm_btn_exit.Text = "Выйти";
            this.chefMainForm_btn_exit.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_exit.Click += new System.EventHandler(this.chefMainForm_btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите название блюда";
            // 
            // chefMainForm_combobox_dish
            // 
            this.chefMainForm_combobox_dish.BackColor = System.Drawing.Color.White;
            this.chefMainForm_combobox_dish.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_combobox_dish.FormattingEnabled = true;
            this.chefMainForm_combobox_dish.Location = new System.Drawing.Point(12, 33);
            this.chefMainForm_combobox_dish.Name = "chefMainForm_combobox_dish";
            this.chefMainForm_combobox_dish.Size = new System.Drawing.Size(285, 29);
            this.chefMainForm_combobox_dish.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во порций:";
            // 
            // chefMainForm_portionCount
            // 
            this.chefMainForm_portionCount.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_portionCount.Location = new System.Drawing.Point(12, 85);
            this.chefMainForm_portionCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.chefMainForm_portionCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chefMainForm_portionCount.Name = "chefMainForm_portionCount";
            this.chefMainForm_portionCount.Size = new System.Drawing.Size(120, 25);
            this.chefMainForm_portionCount.TabIndex = 8;
            this.chefMainForm_portionCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chefMainForm_btn_count
            // 
            this.chefMainForm_btn_count.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_count.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_btn_count.Location = new System.Drawing.Point(153, 77);
            this.chefMainForm_btn_count.Name = "chefMainForm_btn_count";
            this.chefMainForm_btn_count.Size = new System.Drawing.Size(144, 39);
            this.chefMainForm_btn_count.TabIndex = 9;
            this.chefMainForm_btn_count.Text = "Рассчитать";
            this.chefMainForm_btn_count.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_count.Click += new System.EventHandler(this.chefMainForm_btn_count_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вам потребуется ингредиентов:";
            // 
            // chefMainForm_label_dishName
            // 
            this.chefMainForm_label_dishName.AutoSize = true;
            this.chefMainForm_label_dishName.Location = new System.Drawing.Point(12, 168);
            this.chefMainForm_label_dishName.Name = "chefMainForm_label_dishName";
            this.chefMainForm_label_dishName.Size = new System.Drawing.Size(285, 20);
            this.chefMainForm_label_dishName.TabIndex = 12;
            this.chefMainForm_label_dishName.Text = "______________________________________________";
            this.chefMainForm_label_dishName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chefMainForm_date
            // 
            this.chefMainForm_date.CalendarFont = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_date.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chefMainForm_date.Location = new System.Drawing.Point(508, 79);
            this.chefMainForm_date.Name = "chefMainForm_date";
            this.chefMainForm_date.Size = new System.Drawing.Size(200, 25);
            this.chefMainForm_date.TabIndex = 13;
            // 
            // chefMainForm_list_count
            // 
            this.chefMainForm_list_count.AllowUserToAddRows = false;
            this.chefMainForm_list_count.AllowUserToDeleteRows = false;
            this.chefMainForm_list_count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chefMainForm_list_count.Location = new System.Drawing.Point(13, 235);
            this.chefMainForm_list_count.Name = "chefMainForm_list_count";
            this.chefMainForm_list_count.ReadOnly = true;
            this.chefMainForm_list_count.RowTemplate.Height = 28;
            this.chefMainForm_list_count.Size = new System.Drawing.Size(285, 376);
            this.chefMainForm_list_count.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(529, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчетный документ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(544, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Выберите дату";
            // 
            // cfehMainForm_btn_addToDoc
            // 
            this.cfehMainForm_btn_addToDoc.BackColor = System.Drawing.Color.Tan;
            this.cfehMainForm_btn_addToDoc.Location = new System.Drawing.Point(13, 617);
            this.cfehMainForm_btn_addToDoc.Name = "cfehMainForm_btn_addToDoc";
            this.cfehMainForm_btn_addToDoc.Size = new System.Drawing.Size(284, 36);
            this.cfehMainForm_btn_addToDoc.TabIndex = 17;
            this.cfehMainForm_btn_addToDoc.Text = "Добавить в документ";
            this.cfehMainForm_btn_addToDoc.UseVisualStyleBackColor = false;
            this.cfehMainForm_btn_addToDoc.Click += new System.EventHandler(this.cfehMainForm_btn_addToDoc_Click);
            // 
            // chefMainForm_list_document
            // 
            this.chefMainForm_list_document.AllowUserToAddRows = false;
            this.chefMainForm_list_document.AllowUserToDeleteRows = false;
            this.chefMainForm_list_document.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chefMainForm_list_document.Location = new System.Drawing.Point(354, 123);
            this.chefMainForm_list_document.Name = "chefMainForm_list_document";
            this.chefMainForm_list_document.ReadOnly = true;
            this.chefMainForm_list_document.RowTemplate.Height = 28;
            this.chefMainForm_list_document.Size = new System.Drawing.Size(519, 346);
            this.chefMainForm_list_document.TabIndex = 18;
            this.chefMainForm_list_document.SelectionChanged += new System.EventHandler(this.chefMainForm_list_document_SelectionChanged);
            // 
            // chefMainForm_btn_saveDoc
            // 
            this.chefMainForm_btn_saveDoc.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_saveDoc.Location = new System.Drawing.Point(354, 480);
            this.chefMainForm_btn_saveDoc.Name = "chefMainForm_btn_saveDoc";
            this.chefMainForm_btn_saveDoc.Size = new System.Drawing.Size(144, 28);
            this.chefMainForm_btn_saveDoc.TabIndex = 19;
            this.chefMainForm_btn_saveDoc.Text = "Сохранить";
            this.chefMainForm_btn_saveDoc.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_saveDoc.Click += new System.EventHandler(this.chefMainForm_btn_saveDoc_Click);
            // 
            // chefMainForm_btn_clearListDoc
            // 
            this.chefMainForm_btn_clearListDoc.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_clearListDoc.Location = new System.Drawing.Point(774, 476);
            this.chefMainForm_btn_clearListDoc.Name = "chefMainForm_btn_clearListDoc";
            this.chefMainForm_btn_clearListDoc.Size = new System.Drawing.Size(99, 28);
            this.chefMainForm_btn_clearListDoc.TabIndex = 20;
            this.chefMainForm_btn_clearListDoc.Text = "Удалить";
            this.chefMainForm_btn_clearListDoc.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_clearListDoc.Click += new System.EventHandler(this.chefMainForm_btn_clearListDoc_Click);
            // 
            // chefMainForm_btn_viewDishes
            // 
            this.chefMainForm_btn_viewDishes.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_viewDishes.Location = new System.Drawing.Point(488, 565);
            this.chefMainForm_btn_viewDishes.Name = "chefMainForm_btn_viewDishes";
            this.chefMainForm_btn_viewDishes.Size = new System.Drawing.Size(267, 36);
            this.chefMainForm_btn_viewDishes.TabIndex = 22;
            this.chefMainForm_btn_viewDishes.Text = "Просмотреть список блюд";
            this.chefMainForm_btn_viewDishes.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_viewDishes.Click += new System.EventHandler(this.chefMainForm_btn_viewDishes_Click);
            // 
            // chefMainForm_btn_viewDocs
            // 
            this.chefMainForm_btn_viewDocs.BackColor = System.Drawing.Color.Tan;
            this.chefMainForm_btn_viewDocs.Location = new System.Drawing.Point(488, 607);
            this.chefMainForm_btn_viewDocs.Name = "chefMainForm_btn_viewDocs";
            this.chefMainForm_btn_viewDocs.Size = new System.Drawing.Size(267, 36);
            this.chefMainForm_btn_viewDocs.TabIndex = 23;
            this.chefMainForm_btn_viewDocs.Text = "Просмотреть список документов";
            this.chefMainForm_btn_viewDocs.UseVisualStyleBackColor = false;
            this.chefMainForm_btn_viewDocs.Click += new System.EventHandler(this.chefMainForm_btn_viewDocs_Click);
            // 
            // chefMainForm_checkBox_print
            // 
            this.chefMainForm_checkBox_print.AutoSize = true;
            this.chefMainForm_checkBox_print.Location = new System.Drawing.Point(504, 480);
            this.chefMainForm_checkBox_print.Name = "chefMainForm_checkBox_print";
            this.chefMainForm_checkBox_print.Size = new System.Drawing.Size(147, 24);
            this.chefMainForm_checkBox_print.TabIndex = 24;
            this.chefMainForm_checkBox_print.Text = "Сохранить в файл";
            this.chefMainForm_checkBox_print.UseVisualStyleBackColor = true;
            // 
            // ChefMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(943, 656);
            this.Controls.Add(this.chefMainForm_checkBox_print);
            this.Controls.Add(this.chefMainForm_btn_viewDocs);
            this.Controls.Add(this.chefMainForm_btn_viewDishes);
            this.Controls.Add(this.chefMainForm_btn_clearListDoc);
            this.Controls.Add(this.chefMainForm_btn_saveDoc);
            this.Controls.Add(this.chefMainForm_list_document);
            this.Controls.Add(this.cfehMainForm_btn_addToDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chefMainForm_list_count);
            this.Controls.Add(this.chefMainForm_date);
            this.Controls.Add(this.chefMainForm_label_dishName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chefMainForm_btn_count);
            this.Controls.Add(this.chefMainForm_portionCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chefMainForm_combobox_dish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chefMainForm_btn_exit);
            this.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "ChefMainForm";
            this.Text = "Форма расчета повара";
            this.Load += new System.EventHandler(this.ChefMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_portionCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_document)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button chefMainForm_btn_exit;
        private Label label1;
        private ComboBox chefMainForm_combobox_dish;
        private Label label2;
        private NumericUpDown chefMainForm_portionCount;
        private Button chefMainForm_btn_count;
        private Label label4;
        private Label chefMainForm_label_dishName;
        private DateTimePicker chefMainForm_date;
        private DataGridView chefMainForm_list_count;
        private Label label3;
        private Label label6;
        private Button cfehMainForm_btn_addToDoc;
        private DataGridView chefMainForm_list_document;
        private Button chefMainForm_btn_saveDoc;
        private Button chefMainForm_btn_clearListDoc;
        private Button chefMainForm_btn_viewDishes;
        private Button chefMainForm_btn_viewDocs;
        private CheckBox chefMainForm_checkBox_print;
    }
}