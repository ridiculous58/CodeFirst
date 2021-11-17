using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Infrastructure.Context
{
    public class CodeFirstContext : DbContext
    {

        public CodeFirstContext(DbContextOptions<CodeFirstContext> options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; } // BaseEntity + User 

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Product> Products { get; set; }

        public DbSet<Role> Roles { get; set; }


        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .HasOne(x => x.User)
            //    .WithOne(x => x.Employee)
            //    .HasForeignKey<Employee>(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }


    }
}
