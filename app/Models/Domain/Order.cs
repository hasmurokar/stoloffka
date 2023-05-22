using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        
        public User User { get; set; }
        public int UserId { get; set; }
        public List<DishOrder> DishOrders { get; set; } = new();
    }
}
