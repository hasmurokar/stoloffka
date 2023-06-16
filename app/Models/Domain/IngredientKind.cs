using app.Models.Base;

namespace app.Models.Domain
{
    /// <summary>
    /// Динамический справочник имен ингредиентов
    /// </summary>
    public class IngredientKind : EntityBase
    {
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new();
    }
}
