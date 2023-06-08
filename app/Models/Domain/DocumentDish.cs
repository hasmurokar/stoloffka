namespace app.Models.Domain
{
    public class DocumentDish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public List<DishDocumentRelation> DishDocumentRelations { get; set; } = new();
    }
}
