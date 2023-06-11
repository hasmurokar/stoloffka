using app.Domain;
using app.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace app.Services
{
    public class DocumentService
    {

        public void GenerateDocReportDish(int documentDishId)
        {
            using var db = new AppDbContext();
            var entity = db.Documents
                .Include(x => x.DishDocumentRelations)
                .ThenInclude(x => x.Dish).FirstOrDefault(d => d.Id == documentDishId);
            string text = CreateTextReportDish(entity);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Text Document";
            var fileName = entity.Name.Replace(':', '-');
            saveFileDialog.FileName = fileName;

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var writer = new StreamWriter(filePath))
                {
                    writer.Write(text);
                }
            }
            else
                throw new Exception();
        }

        private static string CreateTextReportDish(DocumentDish document)
        {
            var text = $"                    Отчетный документ №{document.Id}\n";
            text += $"                   Дата: {document.Date}\n";
            var relations = document.DishDocumentRelations;
            for (int i = 0; i < relations.Count; i++)
            {
                text += $"{i+1}. {relations[i].Dish.Name}, Кол-во порций: {relations[i].CountDish}, Общая стоимость: {relations[i].Dish.Price * relations[i].CountDish}\n";
            }
            return text;
        }

        public void GenerateBillReport(int billId)
        {
            using var db = new AppDbContext();
            var entity = db.Orders
                .Include(x => x.DishOrders)
                .ThenInclude(x => x.Dish)
                .Include(x => x.User)
                .FirstOrDefault(d => d.Id == billId);
            string text = CreateTextReportOrder(entity);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Text Document";
            var fileName = $"Заказ № {entity.Id}";
            saveFileDialog.FileName = fileName;

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var writer = new StreamWriter(filePath))
                {
                    writer.Write(text);
                }
            }
            else
                throw new Exception();
        }

        private static string CreateTextReportOrder(Order bill)
        {
            var text = $"                    Заказ №{bill.Id}\n";
            text += $"                   Дата: {bill.Date}\n";
            text += $"           ФИО кассира: {bill.User.Name}\n";
            var relations = bill.DishOrders;
            for (int i = 0; i < relations.Count; i++)
            {
                text += $"{i + 1}. {relations[i].Dish.Name}, Кол-во порций: {relations[i].CountDish}, Стоимость 1 порции: {relations[i].Dish.Price}\n";
            }
            text += $"\n           Стоимость заказа: {bill.TotalPrice}\n";
            return text;
        }
    }
}
