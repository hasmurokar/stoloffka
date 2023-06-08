namespace app.Models.Common
{
    internal class OutputCountedIngredients
    {
        public string Name { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
