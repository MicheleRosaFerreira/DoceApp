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
		public DbSet<Departament> Departament { get; set; }
		public DbSet<Confectionery> Confectionery { get; set; }	
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
			modelBuilder.Entity<Departament>(e =>
			{
				modelBuilder.Entity<Departament>().HasKey(i => i.Id);
				modelBuilder.Entity<Departament>().Property(p => p.Name).IsRequired();
				modelBuilder.Entity<Departament>().Property(p => p.Icon).IsRequired();
			});

			modelBuilder.Entity<Confectionery>().HasKey(i => i.Id);
			modelBuilder.Entity<Confectionery>().Property(p => p.Name).IsRequired();
			modelBuilder.Entity<Confectionery>().Property(p => p.Price).IsRequired();
			modelBuilder.Entity<Confectionery>().Property(p => p.Description).IsRequired();
			modelBuilder.Entity<Confectionery>().Property(p => p.Weight).IsRequired();
			modelBuilder.Entity<Confectionery>().Property(p => p.Link).IsRequired();

			modelBuilder.Entity<Confectionery>()
			.HasOne<Departament>(d => d.departament)
			.WithOne(d => d.confectionery)
			.HasForeignKey<Departament>(d => d.Id);
		}
	}
}


