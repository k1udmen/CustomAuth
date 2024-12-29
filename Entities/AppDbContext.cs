using Microsoft.EntityFrameworkCore;

namespace CustomAuth.Entities
{
    public class AppDbContext : DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options ): base(options) 
        {
            
        }

        //DbSet tanımlanması
        public DbSet<UserAccount> UserAccounts { get; set; }

        //Model conf'u yapılıyor
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
