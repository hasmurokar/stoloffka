namespace app.Models.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public decimal Weight { get; set; }

        public IngredientKind Kind { get; set; }
        public int KindId { get; set; }
        public List<Dish> Dishes { get; set; } = new();
    }
}
