using System;
using System.Linq;
using TokenBasedAuthenticationWebAPI_Demo.Data;
using TokenBasedAuthenticationWebAPI_Demo.Models;

namespace TokenBasedAuthenticationWebAPI_Demo.Repository
{
    public class UserRepository : IDisposable
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public User ValidateUser(string username, string password)
        {
            return db.Users.FirstOrDefault(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
            && user.Password == password);
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}