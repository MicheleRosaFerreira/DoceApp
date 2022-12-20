//using DoceApp.Models.Entidades;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Options;

//namespace DoceApp.Context
//{
//	public class DoceAppContext : DbContext
//	{
//		public DoceAppContext() { }
//		public DoceAppContext(DbContextOptions<DoceAppContext> options) : base(options) { }
		 
//		public DbSet<Login> Acess { get; set; }
//		public DbSet<People> Peoples { get; set; }
//		public DbSet<Confectionery> Confectioneries { get; set; }
//		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//		{
//			if(optionsBuilder.IsConfigured) 
//			{ 
//			optionsBuilder.UseSqlServer();
//			}
//		}
//		protected override void OnModelCreating(ModelBuilder modelBuilder)
//		{
//			modelBuilder.Entity<People>()
//		     .ToTable("People")
//			 .Property(p => p.Id)
//			 .HasColumnName("Id")
//			 .HasDefaultValue(0)
//			 .IsRequired();
//		}
//	}
//}
