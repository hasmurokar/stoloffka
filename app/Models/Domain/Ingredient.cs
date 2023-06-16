using app.Models.Base;

namespace app.Models.Domain
{
    public class Ingredient : EntityBase
    {
        public decimal Weight { get; set; }

        public IngredientKind Kind { get; set; }
        public int KindId { get; set; }
        public List<Dish> Dishes { get; set; } = new();
    }
}
