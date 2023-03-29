﻿using DoceApp.Models;
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
                    //modelBuilder.Entity<Login>(e => { e.ToTable("LOGIN"))};
                    modelBuilder.Entity<Login>().HasKey(i => i.User_Login_Id);
					modelBuilder.Entity<Login>().Property(n => n.Nickname).IsRequired();
                  
				});

            }
     }
}


