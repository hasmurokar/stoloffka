namespace app.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        public List<DishOrder> DishOrders { get; set; } = new();
    }
}
