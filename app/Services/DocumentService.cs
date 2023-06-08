using app.Domain;
using app.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace app.Services
{
    public class DocumentService
    {

        public void Generate(int documentDishId)
        {
            using var db = new AppDbContext();
            var entity = db.Documents
                .Include(x => x.DishDocumentRelations)
                .ThenInclude(x => x.Dish).FirstOrDefault(d => d.Id == documentDishId);
            string text = CreateText(entity);

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

        private static string CreateText(DocumentDish document)
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
    }
}
