namespace app.Models.Domain
{
    /// <summary>
    /// Динамический справочник имен ингредиентов
    /// </summary>
    public class IngredientKind
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; } = new();
    }
}
