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
            this.docsListForm_btn_delete = new System.Windows.Forms.Button();
            this.docsListForm_btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.docsListForm_list_documents = new System.Windows.Forms.DataGridView();
            this.docsListForm_btn_saveToFole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.docsListForm_list_documents)).BeginInit();
            this.SuspendLayout();
            // 
            // docsListForm_btn_delete
            // 
            this.docsListForm_btn_delete.Location = new System.Drawing.Point(195, 674);
            this.docsListForm_btn_delete.Name = "docsListForm_btn_delete";
            this.docsListForm_btn_delete.Size = new System.Drawing.Size(164, 42);
            this.docsListForm_btn_delete.TabIndex = 8;
            this.docsListForm_btn_delete.Text = "Удалить";
            this.docsListForm_btn_delete.UseVisualStyleBackColor = true;
            this.docsListForm_btn_delete.Click += new System.EventHandler(this.docsListForm_btn_delete_Click);
            // 
            // docsListForm_btn_back
            // 
            this.docsListForm_btn_back.Location = new System.Drawing.Point(10, 9);
            this.docsListForm_btn_back.Name = "docsListForm_btn_back";
            this.docsListForm_btn_back.Size = new System.Drawing.Size(109, 30);
            this.docsListForm_btn_back.TabIndex = 7;
            this.docsListForm_btn_back.Text = "Назад";
            this.docsListForm_btn_back.UseVisualStyleBackColor = true;
            this.docsListForm_btn_back.Click += new System.EventHandler(this.docsListForm_btn_back_Click);
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
            this.docsListForm_list_documents.AllowUserToAddRows = false;
            this.docsListForm_list_documents.AllowUserToDeleteRows = false;
            this.docsListForm_list_documents.AllowUserToResizeColumns = false;
            this.docsListForm_list_documents.AllowUserToResizeRows = false;
            this.docsListForm_list_documents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.docsListForm_list_documents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docsListForm_list_documents.Location = new System.Drawing.Point(10, 45);
            this.docsListForm_list_documents.Name = "docsListForm_list_documents";
            this.docsListForm_list_documents.ReadOnly = true;
            this.docsListForm_list_documents.RowTemplate.Height = 28;
            this.docsListForm_list_documents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.docsListForm_list_documents.Size = new System.Drawing.Size(751, 623);
            this.docsListForm_list_documents.TabIndex = 5;
            // 
            // docsListForm_btn_saveToFole
            // 
            this.docsListForm_btn_saveToFole.Location = new System.Drawing.Point(414, 674);
            this.docsListForm_btn_saveToFole.Name = "docsListForm_btn_saveToFole";
            this.docsListForm_btn_saveToFole.Size = new System.Drawing.Size(164, 42);
            this.docsListForm_btn_saveToFole.TabIndex = 10;
            this.docsListForm_btn_saveToFole.Text = "Сохранить в файл";
            this.docsListForm_btn_saveToFole.UseVisualStyleBackColor = true;
            this.docsListForm_btn_saveToFole.Click += new System.EventHandler(this.docsListForm_btn_saveToFole_Click);
            // 
            // DocsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 725);
            this.Controls.Add(this.docsListForm_btn_saveToFole);
            this.Controls.Add(this.docsListForm_btn_delete);
            this.Controls.Add(this.docsListForm_btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.docsListForm_list_documents);
            this.Name = "DocsListForm";
            this.Text = "Форма списка документов";
            this.Load += new System.EventHandler(this.DocsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.docsListForm_list_documents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button docsListForm_btn_delete;
        private Button docsListForm_btn_back;
        private Label label1;
        private DataGridView docsListForm_list_documents;
        private Button docsListForm_btn_saveToFole;
    }
}