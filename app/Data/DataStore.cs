using app.Models.Domain;

namespace app.Data
{
    public static class DataStore
    {
        public static User? CurrentUser { get; set; } = null;
    }
}
