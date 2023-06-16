namespace app.Forms
{
    partial class CashierMainForm
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
            this.cashierMainForm_pickDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierMainForm_list_dish = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cashierMainForm_btn_addDish = new System.Windows.Forms.Button();
            this.cashierMainForm_dishCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.label_order = new System.Windows.Forms.Label();
            this.cashierMainForm_dataGrid = new System.Windows.Forms.DataGridView();
            this.cashierMainForm_btn_setOrder = new System.Windows.Forms.Button();
            this.cashierMainForm_btn_exit = new System.Windows.Forms.Button();
            this.cashierMainForm_btn_deleteRow = new System.Windows.Forms.Button();
            this.cashierMainForm_checkBox_print = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_dishCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierMainForm_pickDate
            // 
            this.cashierMainForm_pickDate.CalendarFont = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_pickDate.Enabled = false;
            this.cashierMainForm_pickDate.Location = new System.Drawing.Point(47, 105);
            this.cashierMainForm_pickDate.Name = "cashierMainForm_pickDate";
            this.cashierMainForm_pickDate.Size = new System.Drawing.Size(200, 24);
            this.cashierMainForm_pickDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Philosopher", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            // 
            // cashierMainForm_list_dish
            // 
            this.cashierMainForm_list_dish.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_list_dish.FormattingEnabled = true;
            this.cashierMainForm_list_dish.Location = new System.Drawing.Point(47, 221);
            this.cashierMainForm_list_dish.Name = "cashierMainForm_list_dish";
            this.cashierMainForm_list_dish.Size = new System.Drawing.Size(200, 29);
            this.cashierMainForm_list_dish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выбрать блюдо";
            // 
            // cashierMainForm_btn_addDish
            // 
            this.cashierMainForm_btn_addDish.BackColor = System.Drawing.Color.Tan;
            this.cashierMainForm_btn_addDish.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_btn_addDish.Location = new System.Drawing.Point(90, 322);
            this.cashierMainForm_btn_addDish.Name = "cashierMainForm_btn_addDish";
            this.cashierMainForm_btn_addDish.Size = new System.Drawing.Size(109, 32);
            this.cashierMainForm_btn_addDish.TabIndex = 5;
            this.cashierMainForm_btn_addDish.Text = "Добавить";
            this.cashierMainForm_btn_addDish.UseVisualStyleBackColor = false;
            this.cashierMainForm_btn_addDish.Click += new System.EventHandler(this.cashierMainForm_btn_addDish_Click);
            // 
            // cashierMainForm_dishCount
            // 
            this.cashierMainForm_dishCount.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_dishCount.Location = new System.Drawing.Point(47, 291);
            this.cashierMainForm_dishCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cashierMainForm_dishCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cashierMainForm_dishCount.Name = "cashierMainForm_dishCount";
            this.cashierMainForm_dishCount.Size = new System.Drawing.Size(200, 25);
            this.cashierMainForm_dishCount.TabIndex = 6;
            this.cashierMainForm_dishCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кол-во позиций";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Philosopher", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(415, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "ФИО кассира";
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Font = new System.Drawing.Font("Philosopher", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fio.Location = new System.Drawing.Point(352, 106);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(93, 29);
            this.label_fio.TabIndex = 9;
            this.label_fio.Text = "________";
            this.label_fio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_totalPrice.Location = new System.Drawing.Point(306, 246);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(177, 25);
            this.label_totalPrice.TabIndex = 11;
            this.label_totalPrice.Text = "Стоимость заказа:  ";
            // 
            // label_order
            // 
            this.label_order.AutoSize = true;
            this.label_order.Font = new System.Drawing.Font("Philosopher", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_order.Location = new System.Drawing.Point(376, 198);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(107, 25);
            this.label_order.TabIndex = 10;
            this.label_order.Text = "№ Заказа:  ";
            // 
            // cashierMainForm_dataGrid
            // 
            this.cashierMainForm_dataGrid.AllowUserToAddRows = false;
            this.cashierMainForm_dataGrid.AllowUserToDeleteRows = false;
            this.cashierMainForm_dataGrid.AllowUserToResizeColumns = false;
            this.cashierMainForm_dataGrid.AllowUserToResizeRows = false;
            this.cashierMainForm_dataGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.cashierMainForm_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierMainForm_dataGrid.Location = new System.Drawing.Point(675, 44);
            this.cashierMainForm_dataGrid.Name = "cashierMainForm_dataGrid";
            this.cashierMainForm_dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cashierMainForm_dataGrid.RowTemplate.Height = 28;
            this.cashierMainForm_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cashierMainForm_dataGrid.Size = new System.Drawing.Size(443, 578);
            this.cashierMainForm_dataGrid.TabIndex = 12;
            // 
            // cashierMainForm_btn_setOrder
            // 
            this.cashierMainForm_btn_setOrder.BackColor = System.Drawing.Color.Tan;
            this.cashierMainForm_btn_setOrder.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_btn_setOrder.Location = new System.Drawing.Point(183, 448);
            this.cashierMainForm_btn_setOrder.Name = "cashierMainForm_btn_setOrder";
            this.cashierMainForm_btn_setOrder.Size = new System.Drawing.Size(274, 41);
            this.cashierMainForm_btn_setOrder.TabIndex = 13;
            this.cashierMainForm_btn_setOrder.Text = "Оформить заказ";
            this.cashierMainForm_btn_setOrder.UseVisualStyleBackColor = false;
            this.cashierMainForm_btn_setOrder.Click += new System.EventHandler(this.cashierMainForm_btn_setOrder_Click);
            // 
            // cashierMainForm_btn_exit
            // 
            this.cashierMainForm_btn_exit.BackColor = System.Drawing.Color.Sienna;
            this.cashierMainForm_btn_exit.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_btn_exit.Location = new System.Drawing.Point(12, 628);
            this.cashierMainForm_btn_exit.Name = "cashierMainForm_btn_exit";
            this.cashierMainForm_btn_exit.Size = new System.Drawing.Size(131, 36);
            this.cashierMainForm_btn_exit.TabIndex = 15;
            this.cashierMainForm_btn_exit.Text = "Выход";
            this.cashierMainForm_btn_exit.UseVisualStyleBackColor = false;
            this.cashierMainForm_btn_exit.Click += new System.EventHandler(this.cashierMainForm_btn_exit_Click);
            // 
            // cashierMainForm_btn_deleteRow
            // 
            this.cashierMainForm_btn_deleteRow.BackColor = System.Drawing.Color.Tan;
            this.cashierMainForm_btn_deleteRow.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_btn_deleteRow.Location = new System.Drawing.Point(675, 628);
            this.cashierMainForm_btn_deleteRow.Name = "cashierMainForm_btn_deleteRow";
            this.cashierMainForm_btn_deleteRow.Size = new System.Drawing.Size(443, 36);
            this.cashierMainForm_btn_deleteRow.TabIndex = 16;
            this.cashierMainForm_btn_deleteRow.Text = "Удалить позицию";
            this.cashierMainForm_btn_deleteRow.UseVisualStyleBackColor = false;
            this.cashierMainForm_btn_deleteRow.Click += new System.EventHandler(this.cashierMainForm_btn_deleteRow_Click);
            // 
            // cashierMainForm_checkBox_print
            // 
            this.cashierMainForm_checkBox_print.AutoSize = true;
            this.cashierMainForm_checkBox_print.Font = new System.Drawing.Font("Philosopher", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierMainForm_checkBox_print.Location = new System.Drawing.Point(183, 496);
            this.cashierMainForm_checkBox_print.Name = "cashierMainForm_checkBox_print";
            this.cashierMainForm_checkBox_print.Size = new System.Drawing.Size(160, 25);
            this.cashierMainForm_checkBox_print.TabIndex = 17;
            this.cashierMainForm_checkBox_print.Text = "Сохранить в файл";
            this.cashierMainForm_checkBox_print.UseVisualStyleBackColor = true;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1135, 677);
            this.Controls.Add(this.cashierMainForm_checkBox_print);
            this.Controls.Add(this.cashierMainForm_btn_deleteRow);
            this.Controls.Add(this.cashierMainForm_btn_exit);
            this.Controls.Add(this.cashierMainForm_btn_setOrder);
            this.Controls.Add(this.cashierMainForm_dataGrid);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label_order);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cashierMainForm_dishCount);
            this.Controls.Add(this.cashierMainForm_btn_addDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cashierMainForm_list_dish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashierMainForm_pickDate);
            this.Font = new System.Drawing.Font("Philosopher", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CashierMainForm";
            this.Text = "Форма кассира";
            this.Load += new System.EventHandler(this.CashierMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_dishCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker cashierMainForm_pickDate;
        private Label label1;
        private Label label2;
        private ComboBox cashierMainForm_list_dish;
        private Label label3;
        private Button cashierMainForm_btn_addDish;
        private NumericUpDown cashierMainForm_dishCount;
        private Label label4;
        private Label label5;
        private Label label_fio;
        private Label label_totalPrice;
        private Label label_order;
        private DataGridView cashierMainForm_dataGrid;
        private Button cashierMainForm_btn_setOrder;
        private Button cashierMainForm_btn_exit;
        private Button cashierMainForm_btn_deleteRow;
        private CheckBox cashierMainForm_checkBox_print;
    }
}