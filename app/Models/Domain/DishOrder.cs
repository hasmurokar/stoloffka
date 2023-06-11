namespace app.Models.Domain
{
    public class DishOrder
    {
        public int Id { get; set; }
        public Dish Dish { get; set; }
        public int DishId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
        public int CountDish { get; set; }
    }
}
