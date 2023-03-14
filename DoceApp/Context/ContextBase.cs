using DoceApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DoceApp.Context
{
    public class ContextBase : DbContext
    {
            public ContextBase()
            {

            }
            public ContextBase(DbContextOptions<ContextBase> options) : base(options)
            {

            }

            public DbSet<Loginn> logins { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySQL("DoceApp");

                }
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Loginn>(e =>
                {
                    modelBuilder.Entity<Loginn>().Property(n => n.Nickname).IsRequired();
                    modelBuilder.Entity<Loginn>().HasKey(i => i.UserId);


                });

            }
        }
    }
}
}
