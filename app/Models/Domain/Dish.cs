using app.Enums;
using app.Models.Base;

namespace app.Models.Domain
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public EnumDishType Type { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new();
        public List<DishOrder> DishOrders { get; set; } = new();
        public List<DishDocumentRelation> DishDocumentRelations { get; set; } = new();
    }
}
