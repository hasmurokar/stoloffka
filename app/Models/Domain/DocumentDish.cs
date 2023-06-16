using app.Models.Base;

namespace app.Models.Domain
{
    public class DocumentDish : EntityBase
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }
        public List<DishDocumentRelation> DishDocumentRelations { get; set; } = new();
    }
}
