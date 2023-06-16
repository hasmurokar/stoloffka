using app.Data;
using app.Domain;
using app.Enums;
using app.Models.Common.DataGridView;
using app.Models.Domain;
using app.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app.Forms
{
    public partial class DocsListForm : Form
    {
        private AppDbContext db;
        private BindingList<DocumentDishItem> listDishes = new();
        public DocsListForm()
        {
            InitializeComponent();
            db = new AppDbContext();
        }
        private void DocsListForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            DataGridView_ChangeColumnName();
            foreach (DataGridViewColumn column in docsListForm_list_documents.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void DataGridView_ChangeColumnName()
        {
            docsListForm_list_documents.Columns[1].HeaderText = "Название";
            docsListForm_list_documents.Columns[2].HeaderText = "Дата создания";
        }
        private void docsListForm_btn_back_Click(object sender, EventArgs e)
        {

            var chefMainForm = new ChefMainForm();
            this.Close();
            chefMainForm.Show();
        }

        private void docsListForm_btn_delete_Click(object sender, EventArgs e)
        {
            var selectedRow = docsListForm_list_documents.SelectedRows[0];
            DialogResult result = MessageBox.Show(
                                    "Удалить документ?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                var recordToDelete = db.Documents.FirstOrDefault(r => r.Id == selectedId);
                if (recordToDelete != null)
                {
                    recordToDelete.State = EnityStateEnum.Archived;
                    db.SaveChanges();
                    UpdateTable();
                }
            }
        }
        private void UpdateTable()
        {
            var data = db.Documents.Select(e => new
            {
                e.Id,
                e.Name,
                e.Date,
            }).ToList();
            docsListForm_list_documents.DataSource = data;
        }

        private void docsListForm_btn_saveToFole_Click(object sender, EventArgs e)
        {
            var selectedRow = docsListForm_list_documents.SelectedRows[0];
            DialogResult result = MessageBox.Show(
                                    "Cохранить документ?",
                                    "Сообщение",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                var recordToSave = db.Documents.FirstOrDefault(r => r.Id == selectedId);
                if (recordToSave != null)
                {
                    var documentService = new DocumentService();
                    try
                    {
                        documentService.GenerateDocReportDish(recordToSave.Id);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка при сохранении файла.");
                        return;
                    }
                }
            }
            docsListForm_list_documents.DataSource = new BindingList<DocumentDishItem>();
            MessageBox.Show("ГОТОВО!");
        }
    }
}
