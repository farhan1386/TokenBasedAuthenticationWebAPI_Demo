using System.Data.Entity;
using TokenBasedAuthenticationWebAPI_Demo.Models;

namespace TokenBasedAuthenticationWebAPI_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("UserDB")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}