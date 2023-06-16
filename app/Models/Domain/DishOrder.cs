using app.Models.Base;

namespace app.Models.Domain
{
    public class DishOrder : EntityBase
    {
        public Dish Dish { get; set; }
        public int DishId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public int CountDish { get; set; }
    }
}
