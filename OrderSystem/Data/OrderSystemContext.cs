using Microsoft.EntityFrameworkCore;
using OrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Data
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext(DbContextOptions<OrderSystemContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Machine> Machines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Admin>("Admin")
                .HasValue<Customer>("Customer")
                .HasValue<Operator>("Operator")
                .HasValue<Planner>("Planner");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.CreatedByUser)
                .WithMany()
                .HasForeignKey(o => o.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.EndedByUser)
                .WithMany()
                .HasForeignKey(o => o.EndedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.LastEditByUser)
                .WithMany()
                .HasForeignKey(o => o.LastEditBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.MachineObject)
                .WithMany()
                .HasForeignKey(o => o.Machine)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
