using app.Enums;

namespace app.Models.Domain
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public EnumDishType Type { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new();
        public List<DishOrder> DishOrders { get; set; } = new();
    }
}
