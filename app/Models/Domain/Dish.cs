using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models.Domain
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string Contents { get; set; }
        public decimal Weight { get; set; }
        public EnumDishType Type { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<Dish> Dishes { get; set; } = new();
    }
}
