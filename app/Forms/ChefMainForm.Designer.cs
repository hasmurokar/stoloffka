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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
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
            this.chefMainForm_btn_printDoc = new System.Windows.Forms.Button();
            this.chefMainForm_btn_viewDishes = new System.Windows.Forms.Button();
            this.chefMainForm_btn_viewDocs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_document)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(823, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите название блюда";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(285, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во порций:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 83);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вам потребуется ингредиентов:";
            // 
            // chefMainForm_label_dishName
            // 
            this.chefMainForm_label_dishName.AutoSize = true;
            this.chefMainForm_label_dishName.Location = new System.Drawing.Point(12, 160);
            this.chefMainForm_label_dishName.Name = "chefMainForm_label_dishName";
            this.chefMainForm_label_dishName.Size = new System.Drawing.Size(285, 19);
            this.chefMainForm_label_dishName.TabIndex = 12;
            this.chefMainForm_label_dishName.Text = "______________________________________________";
            // 
            // chefMainForm_date
            // 
            this.chefMainForm_date.Location = new System.Drawing.Point(508, 75);
            this.chefMainForm_date.Name = "chefMainForm_date";
            this.chefMainForm_date.Size = new System.Drawing.Size(200, 26);
            this.chefMainForm_date.TabIndex = 13;
            // 
            // chefMainForm_list_count
            // 
            this.chefMainForm_list_count.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chefMainForm_list_count.Location = new System.Drawing.Point(13, 223);
            this.chefMainForm_list_count.Name = "chefMainForm_list_count";
            this.chefMainForm_list_count.RowTemplate.Height = 28;
            this.chefMainForm_list_count.Size = new System.Drawing.Size(285, 357);
            this.chefMainForm_list_count.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчетный документ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Выберите дату";
            // 
            // cfehMainForm_btn_addToDoc
            // 
            this.cfehMainForm_btn_addToDoc.Location = new System.Drawing.Point(13, 586);
            this.cfehMainForm_btn_addToDoc.Name = "cfehMainForm_btn_addToDoc";
            this.cfehMainForm_btn_addToDoc.Size = new System.Drawing.Size(284, 34);
            this.cfehMainForm_btn_addToDoc.TabIndex = 17;
            this.cfehMainForm_btn_addToDoc.Text = "Добавить в документ";
            this.cfehMainForm_btn_addToDoc.UseVisualStyleBackColor = true;
            // 
            // chefMainForm_list_document
            // 
            this.chefMainForm_list_document.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chefMainForm_list_document.Location = new System.Drawing.Point(354, 117);
            this.chefMainForm_list_document.Name = "chefMainForm_list_document";
            this.chefMainForm_list_document.RowTemplate.Height = 28;
            this.chefMainForm_list_document.Size = new System.Drawing.Size(519, 329);
            this.chefMainForm_list_document.TabIndex = 18;
            // 
            // chefMainForm_btn_saveDoc
            // 
            this.chefMainForm_btn_saveDoc.Location = new System.Drawing.Point(354, 452);
            this.chefMainForm_btn_saveDoc.Name = "chefMainForm_btn_saveDoc";
            this.chefMainForm_btn_saveDoc.Size = new System.Drawing.Size(144, 27);
            this.chefMainForm_btn_saveDoc.TabIndex = 19;
            this.chefMainForm_btn_saveDoc.Text = "Сохранить";
            this.chefMainForm_btn_saveDoc.UseVisualStyleBackColor = true;
            // 
            // chefMainForm_btn_clearListDoc
            // 
            this.chefMainForm_btn_clearListDoc.Location = new System.Drawing.Point(774, 452);
            this.chefMainForm_btn_clearListDoc.Name = "chefMainForm_btn_clearListDoc";
            this.chefMainForm_btn_clearListDoc.Size = new System.Drawing.Size(99, 27);
            this.chefMainForm_btn_clearListDoc.TabIndex = 20;
            this.chefMainForm_btn_clearListDoc.Text = "Очистить";
            this.chefMainForm_btn_clearListDoc.UseVisualStyleBackColor = true;
            // 
            // chefMainForm_btn_printDoc
            // 
            this.chefMainForm_btn_printDoc.Location = new System.Drawing.Point(504, 452);
            this.chefMainForm_btn_printDoc.Name = "chefMainForm_btn_printDoc";
            this.chefMainForm_btn_printDoc.Size = new System.Drawing.Size(138, 27);
            this.chefMainForm_btn_printDoc.TabIndex = 21;
            this.chefMainForm_btn_printDoc.Text = "Распечатать";
            this.chefMainForm_btn_printDoc.UseVisualStyleBackColor = true;
            // 
            // chefMainForm_btn_viewDishes
            // 
            this.chefMainForm_btn_viewDishes.Location = new System.Drawing.Point(488, 524);
            this.chefMainForm_btn_viewDishes.Name = "chefMainForm_btn_viewDishes";
            this.chefMainForm_btn_viewDishes.Size = new System.Drawing.Size(267, 34);
            this.chefMainForm_btn_viewDishes.TabIndex = 22;
            this.chefMainForm_btn_viewDishes.Text = "Просмотреть список блюд";
            this.chefMainForm_btn_viewDishes.UseVisualStyleBackColor = true;
            // 
            // chefMainForm_btn_viewDocs
            // 
            this.chefMainForm_btn_viewDocs.Location = new System.Drawing.Point(488, 564);
            this.chefMainForm_btn_viewDocs.Name = "chefMainForm_btn_viewDocs";
            this.chefMainForm_btn_viewDocs.Size = new System.Drawing.Size(267, 34);
            this.chefMainForm_btn_viewDocs.TabIndex = 23;
            this.chefMainForm_btn_viewDocs.Text = "Просмотреть список документов";
            this.chefMainForm_btn_viewDocs.UseVisualStyleBackColor = true;
            // 
            // ChefMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 623);
            this.Controls.Add(this.chefMainForm_btn_viewDocs);
            this.Controls.Add(this.chefMainForm_btn_viewDishes);
            this.Controls.Add(this.chefMainForm_btn_printDoc);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "ChefMainForm";
            this.Text = "Форма расчета повара";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chefMainForm_list_document)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button3;
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
        private Button chefMainForm_btn_printDoc;
        private Button chefMainForm_btn_viewDishes;
        private Button chefMainForm_btn_viewDocs;
    }
}