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
            this.cashierMainForm_diahCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_fio = new System.Windows.Forms.Label();
            this.label_orderNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashierMainForm_btn_setOrder = new System.Windows.Forms.Button();
            this.cashierMainForm_btn_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cashierMainForm_btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_diahCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cashierMainForm_pickDate
            // 
            this.cashierMainForm_pickDate.Location = new System.Drawing.Point(47, 100);
            this.cashierMainForm_pickDate.Name = "cashierMainForm_pickDate";
            this.cashierMainForm_pickDate.Size = new System.Drawing.Size(200, 26);
            this.cashierMainForm_pickDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(210, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата";
            // 
            // cashierMainForm_list_dish
            // 
            this.cashierMainForm_list_dish.FormattingEnabled = true;
            this.cashierMainForm_list_dish.Location = new System.Drawing.Point(47, 210);
            this.cashierMainForm_list_dish.Name = "cashierMainForm_list_dish";
            this.cashierMainForm_list_dish.Size = new System.Drawing.Size(200, 27);
            this.cashierMainForm_list_dish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выбрать блюдо";
            // 
            // cashierMainForm_btn_addDish
            // 
            this.cashierMainForm_btn_addDish.Location = new System.Drawing.Point(84, 310);
            this.cashierMainForm_btn_addDish.Name = "cashierMainForm_btn_addDish";
            this.cashierMainForm_btn_addDish.Size = new System.Drawing.Size(109, 30);
            this.cashierMainForm_btn_addDish.TabIndex = 5;
            this.cashierMainForm_btn_addDish.Text = "Добавить";
            this.cashierMainForm_btn_addDish.UseVisualStyleBackColor = true;
            // 
            // cashierMainForm_diahCount
            // 
            this.cashierMainForm_diahCount.Location = new System.Drawing.Point(47, 278);
            this.cashierMainForm_diahCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.cashierMainForm_diahCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cashierMainForm_diahCount.Name = "cashierMainForm_diahCount";
            this.cashierMainForm_diahCount.Size = new System.Drawing.Size(200, 26);
            this.cashierMainForm_diahCount.TabIndex = 6;
            this.cashierMainForm_diahCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кол-во позиций";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "ФИО кассира";
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(348, 106);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(273, 19);
            this.label_fio.TabIndex = 9;
            this.label_fio.Text = "____________________________________________";
            // 
            // label_orderNumber
            // 
            this.label_orderNumber.AutoSize = true;
            this.label_orderNumber.Location = new System.Drawing.Point(348, 238);
            this.label_orderNumber.Name = "label_orderNumber";
            this.label_orderNumber.Size = new System.Drawing.Size(273, 19);
            this.label_orderNumber.TabIndex = 11;
            this.label_orderNumber.Text = "____________________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(430, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "№ Заказа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(675, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(443, 549);
            this.dataGridView1.TabIndex = 12;
            // 
            // cashierMainForm_btn_setOrder
            // 
            this.cashierMainForm_btn_setOrder.Location = new System.Drawing.Point(188, 399);
            this.cashierMainForm_btn_setOrder.Name = "cashierMainForm_btn_setOrder";
            this.cashierMainForm_btn_setOrder.Size = new System.Drawing.Size(274, 39);
            this.cashierMainForm_btn_setOrder.TabIndex = 13;
            this.cashierMainForm_btn_setOrder.Text = "Оформить заказ";
            this.cashierMainForm_btn_setOrder.UseVisualStyleBackColor = true;
            // 
            // cashierMainForm_btn_print
            // 
            this.cashierMainForm_btn_print.Location = new System.Drawing.Point(188, 456);
            this.cashierMainForm_btn_print.Name = "cashierMainForm_btn_print";
            this.cashierMainForm_btn_print.Size = new System.Drawing.Size(274, 38);
            this.cashierMainForm_btn_print.TabIndex = 14;
            this.cashierMainForm_btn_print.Text = "Распечатать чек";
            this.cashierMainForm_btn_print.UseVisualStyleBackColor = true;
            // 
            // cashierMainForm_btn_exit
            // 
            this.cashierMainForm_btn_exit.Location = new System.Drawing.Point(12, 577);
            this.cashierMainForm_btn_exit.Name = "cashierMainForm_btn_exit";
            this.cashierMainForm_btn_exit.Size = new System.Drawing.Size(111, 27);
            this.cashierMainForm_btn_exit.TabIndex = 15;
            this.cashierMainForm_btn_exit.Text = "Выход";
            this.cashierMainForm_btn_exit.UseVisualStyleBackColor = true;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 616);
            this.Controls.Add(this.cashierMainForm_btn_exit);
            this.Controls.Add(this.cashierMainForm_btn_print);
            this.Controls.Add(this.cashierMainForm_btn_setOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_orderNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cashierMainForm_diahCount);
            this.Controls.Add(this.cashierMainForm_btn_addDish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cashierMainForm_list_dish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cashierMainForm_pickDate);
            this.Name = "CashierMainForm";
            this.Text = "Форма кассира";
            ((System.ComponentModel.ISupportInitialize)(this.cashierMainForm_diahCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private NumericUpDown cashierMainForm_diahCount;
        private Label label4;
        private Label label5;
        private Label label_fio;
        private Label label_orderNumber;
        private Label label8;
        private DataGridView dataGridView1;
        private Button cashierMainForm_btn_setOrder;
        private Button cashierMainForm_btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button cashierMainForm_btn_exit;
    }
}