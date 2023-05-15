namespace app.Forms
{
    partial class DocsListForm
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
            this.docsListForm_btn_update = new System.Windows.Forms.Button();
            this.docsListForm_btn_delete = new System.Windows.Forms.Button();
            this.docsListForm_btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.docsListForm_list_documents = new System.Windows.Forms.DataGridView();
            this.docsListForm_btn_print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.docsListForm_list_documents)).BeginInit();
            this.SuspendLayout();
            // 
            // docsListForm_btn_update
            // 
            this.docsListForm_btn_update.Location = new System.Drawing.Point(787, 304);
            this.docsListForm_btn_update.Name = "docsListForm_btn_update";
            this.docsListForm_btn_update.Size = new System.Drawing.Size(164, 42);
            this.docsListForm_btn_update.TabIndex = 9;
            this.docsListForm_btn_update.Text = "Редактировать";
            this.docsListForm_btn_update.UseVisualStyleBackColor = true;
            // 
            // docsListForm_btn_delete
            // 
            this.docsListForm_btn_delete.Location = new System.Drawing.Point(787, 256);
            this.docsListForm_btn_delete.Name = "docsListForm_btn_delete";
            this.docsListForm_btn_delete.Size = new System.Drawing.Size(164, 42);
            this.docsListForm_btn_delete.TabIndex = 8;
            this.docsListForm_btn_delete.Text = "Удалить";
            this.docsListForm_btn_delete.UseVisualStyleBackColor = true;
            // 
            // docsListForm_btn_back
            // 
            this.docsListForm_btn_back.Location = new System.Drawing.Point(10, 9);
            this.docsListForm_btn_back.Name = "docsListForm_btn_back";
            this.docsListForm_btn_back.Size = new System.Drawing.Size(109, 30);
            this.docsListForm_btn_back.TabIndex = 7;
            this.docsListForm_btn_back.Text = "Назад";
            this.docsListForm_btn_back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(301, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Список документов";
            // 
            // docsListForm_list_documents
            // 
            this.docsListForm_list_documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docsListForm_list_documents.Location = new System.Drawing.Point(10, 45);
            this.docsListForm_list_documents.Name = "docsListForm_list_documents";
            this.docsListForm_list_documents.RowTemplate.Height = 28;
            this.docsListForm_list_documents.Size = new System.Drawing.Size(751, 623);
            this.docsListForm_list_documents.TabIndex = 5;
            // 
            // docsListForm_btn_print
            // 
            this.docsListForm_btn_print.Location = new System.Drawing.Point(787, 352);
            this.docsListForm_btn_print.Name = "docsListForm_btn_print";
            this.docsListForm_btn_print.Size = new System.Drawing.Size(164, 42);
            this.docsListForm_btn_print.TabIndex = 10;
            this.docsListForm_btn_print.Text = "Распечатать";
            this.docsListForm_btn_print.UseVisualStyleBackColor = true;
            // 
            // DocsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 675);
            this.Controls.Add(this.docsListForm_btn_print);
            this.Controls.Add(this.docsListForm_btn_update);
            this.Controls.Add(this.docsListForm_btn_delete);
            this.Controls.Add(this.docsListForm_btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docsListForm_list_documents);
            this.Name = "DocsListForm";
            this.Text = "Форма списка документов";
            ((System.ComponentModel.ISupportInitialize)(this.docsListForm_list_documents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button docsListForm_btn_update;
        private Button docsListForm_btn_delete;
        private Button docsListForm_btn_back;
        private Label label1;
        private DataGridView docsListForm_list_documents;
        private Button docsListForm_btn_print;
    }
}