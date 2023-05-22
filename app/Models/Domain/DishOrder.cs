using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models.Domain
{
    public class DishOrder
    {
        public int Id { get; set; }
        public List<Dish> Dishes { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
    }
}
