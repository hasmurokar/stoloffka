using app.Enums;

namespace app.Models.Common.DataGridView
{
    public class DishListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public string Type { get; set; }
    }
}
