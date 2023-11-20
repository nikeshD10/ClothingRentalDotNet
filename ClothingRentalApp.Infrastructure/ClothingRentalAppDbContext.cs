using ClothingRentalApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingRentalApp.Infrastructure
{
    public class ClothingRentalAppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ClothingItem> ClothingItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        //public DbSet<RentalItem> RentalItems { get; set; }

        public string DbPath { get; private set; }

        public ClothingRentalAppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}ClothingRentalApp.db";

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

         => optionsBuilder.UseSqlite($"Data Source={DbPath}");//aq veubnebi rom es path gamoiyenos


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // *****************  For User ************************* //
            modelBuilder.Entity<Customer>(
                entityBuilder =>
                {
                    entityBuilder.Property(c => c.Email).IsRequired().HasMaxLength(256);
                    entityBuilder.HasIndex(c => c.Email).IsUnique();
                    entityBuilder.Property(c => c.Name).IsRequired().HasMaxLength(80);
                    entityBuilder.Property(c => c.Phone).IsRequired().HasMaxLength(15);
                }
            );

            modelBuilder.Entity<Customer>().HasKey(c => c.Id);

            // ****************  For Employee *********************** //
            modelBuilder.Entity<Employee>(
                    entityBuilder =>
                    {
                        entityBuilder.Property(e => e.Email).IsRequired().HasMaxLength(256);
                        entityBuilder.HasIndex(e => e.Email).IsUnique();
                        entityBuilder.Property(e => e.Name).IsRequired().HasMaxLength(80);
                        entityBuilder.Property(e => e.Password).IsRequired().HasMaxLength(40);
                        entityBuilder.Property(e => e.IsAdmin).HasDefaultValue(false);

                    }
                );

            modelBuilder.Entity<Employee>().HasKey(e => e.Id);

            // ***************   For Brand ********************* //
            modelBuilder.Entity<Brand>().Property(b => b.Name).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Brand>().HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<Brand>().HasKey(b => b.Id);


            // **************   For Category **************** //
            modelBuilder.Entity<Category>().Property(b => b.Name).IsRequired().HasMaxLength(45);
            modelBuilder.Entity<Category>().HasIndex(b => b.Name).IsUnique();
            modelBuilder.Entity<Category>().HasKey(b => b.Id);

            // ****************   For Payment *************** //
            modelBuilder.Entity<Payment>(
                    entityBuilder =>
                    {
                        entityBuilder.Property(p => p.PaymentDate).IsRequired();
                        entityBuilder.Property(p => p.PaymentAmount).IsRequired().HasColumnType("double");
                        entityBuilder.Property(p => p.PaymentMethod).IsRequired();
                    }
                );

            modelBuilder.Entity<Payment>().HasKey(p => p.Id);
            modelBuilder.Entity<Payment>().HasOne<Rental>(p => p.Rental).WithMany(rental => rental.Payments).HasForeignKey(p => p.RentalId);



            // ***************   For Clothing Item ************ //
            modelBuilder.Entity<ClothingItem>(
                    entityBuilder =>
                    {
                       // entityBuilder.Property
                    }
                );
        }



        public string PrintDbPath()
        {
            return DbPath;
        }
    }
}
