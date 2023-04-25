using DoceApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

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
		public DbSet<User> User { get; set; }
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
			modelBuilder.Entity<User>(e =>
			{
				modelBuilder.Entity<User>().Property(p => p.Name).IsRequired();	
				modelBuilder.Entity<User>().Property(p => p.Cpf).IsRequired();	
				modelBuilder.Entity<User>().Property(p => p.Birthdate).IsRequired();	
				modelBuilder.Entity<User>().Property(p => p.Email).IsRequired();

				modelBuilder.Entity<User>()
				.HasOne<Login>(u => u.userLogin)
				.WithOne(u => u.users)
				.HasForeignKey<Login>(e => e.User_Id);
			});


		}
	}
}


