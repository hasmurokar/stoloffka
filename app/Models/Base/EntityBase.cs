using app.Enums;

namespace app.Models.Base
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public EnityStateEnum State { get; set; }
    }
}
