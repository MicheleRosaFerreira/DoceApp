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
		public DbSet<Login> Login { get; set; }
		public DbSet<Users> User { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("DoceApp");
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Login>(e =>
			{
				modelBuilder.Entity<Login>().HasKey(i => i.User_Login_Id);
				modelBuilder.Entity<Login>().Property(p => p.Nickname).IsRequired();
				modelBuilder.Entity<Login>().Property(p => p.Password).IsRequired();

			});
			modelBuilder.Entity<Users>(e =>
			{
				modelBuilder.Entity<Users>()
				.HasOne<Login>(u => u.userLogin)
				.WithOne(l => l.Nickname)
				.HasForeignKey(Login_User_Id);

				modelBuilder.Entity<Users>().Property(p => p.Name).IsRequired();	
				modelBuilder.Entity<Users>().Property(p => p.Cpf).IsRequired();	
				modelBuilder.Entity<Users>().Property(p => p.Birthdate).IsRequired();	
				modelBuilder.Entity<Users>().Property(p => p.Email).IsRequired();	
			});


		}
	}
}


