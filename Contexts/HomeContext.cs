using CODStats.Models;
using Microsoft.EntityFrameworkCore;

namespace CODStats.Contexts
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
            public DbSet<User> Users {get; set;}
            public DbSet<Team> Teams {get; set;}
    }
}