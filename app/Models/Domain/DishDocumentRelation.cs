using app.Models.Base;

namespace app.Models.Domain
{
    public class DishDocumentRelation : EntityBase
    {
        public Dish Dish { get; set; }
        public int DishId { get; set; }
        public DocumentDish DocumentDish { get; set; }
        public int DocumentDishId { get; set; }
        public int CountDish { get; set; }
    }
}
