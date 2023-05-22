namespace app.Models.Domain
{
    public class DocumentDish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// Содержимое документа
        /// </summary>
        public string Content { get; set; }
    }
}
