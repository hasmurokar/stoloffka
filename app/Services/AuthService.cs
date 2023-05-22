using app.Data;
using app.Domain;
using Microsoft.EntityFrameworkCore;

namespace app.Services
{
    public class AuthService
    {
        public async Task<bool> LogIn(string login, string password)
        {
            using var db = new AppDbContext();
            var user = await db.Users.FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
            DataStore.CurrentUser = user;
            return user is not null;
        }
        public void LogOut()
        {
            var user = DataStore.CurrentUser = null;
        }
    }
}
