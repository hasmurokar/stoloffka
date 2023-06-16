using app.Enums;
using app.Models.Base;

namespace app.Models.Domain
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public EnumRole Role { get; set; }


        public List<Dish> Dishes { get; set; } = new();
        public List<Order> Orders { get; set; } = new();
    }
}
