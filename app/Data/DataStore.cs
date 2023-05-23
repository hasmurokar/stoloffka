using app.Models.Domain;

namespace app.Data
{
    public static class DataStore
    {
        public static User? CurrentUser { get; set; } = null;
        public static int? UserUpdateId { get; set; } = null;
        public static int? DishUpdateId { get; set; } = null;
    }
}
