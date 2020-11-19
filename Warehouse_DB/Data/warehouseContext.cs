using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Warehouse_DB.Models;

namespace Warehouse_DB.Data
{
    public partial class warehouseContext : DbContext
    {
        public warehouseContext()
        {
        }

        public warehouseContext(DbContextOptions<warehouseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                // optionsBuilder.UseSqlite("Data Source=E:\\Учёба\\БД\\Warehouse_DB\\warehouse.db");
                // optionsBuilder.UseSqlite("Data Source=warehouse.db");
                optionsBuilder.UseSqlServer("Data Source (localdb)\\MSSQLLocalDB;Initial Catalog Warehouse_db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnType("INT");

                entity.Property(e => e.ConsumedProduct1Id)
                    .HasColumnName("Consumed_Product_1_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.ConsumedProduct2Id)
                    .HasColumnName("Consumed_Product_2_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.ConsumedProduct3Id)
                    .HasColumnName("Consumed_Product_3_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.Name).HasColumnType("INT");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("INT");

                entity.HasOne(d => d.ConsumedProduct1)
                    .WithMany(p => p.CustomerConsumedProduct1)
                    .HasForeignKey(d => d.ConsumedProduct1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ConsumedProduct2)
                    .WithMany(p => p.CustomerConsumedProduct2)
                    .HasForeignKey(d => d.ConsumedProduct2Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ConsumedProduct3)
                    .WithMany(p => p.CustomerConsumedProduct3)
                    .HasForeignKey(d => d.ConsumedProduct3Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnType("INT");

                entity.Property(e => e.Age).HasColumnType("INT");

                entity.Property(e => e.FullName)
                    .HasColumnName("Full_Name")
                    .HasColumnType("INT");

                entity.Property(e => e.PassportInformation)
                    .HasColumnName("Passport_Information")
                    .HasColumnType("INT");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("INT");

                entity.Property(e => e.PositionId)
                    .HasColumnName("Position_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.Sex).HasColumnType("INT");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionId)
                    .HasColumnName("Position_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Duties).HasColumnType("INT");

                entity.Property(e => e.Name).HasColumnType("INT");

                entity.Property(e => e.Requests).HasColumnType("INT");

                entity.Property(e => e.Salary).HasColumnType("INT");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Manufacturer).HasColumnType("INT");

                entity.Property(e => e.Name).HasColumnType("INT");

                entity.Property(e => e.Package).HasColumnType("INT");

                entity.Property(e => e.ShelfLife)
                    .HasColumnName("Shelf_Life")
                    .HasColumnType("INT");

                entity.Property(e => e.StorageConditions)
                    .HasColumnName("Storage_Conditions")
                    .HasColumnType("INT");

                entity.Property(e => e.TypeId)
                    .HasColumnName("Type_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Product_Type");

                entity.Property(e => e.TypeId)
                    .HasColumnName("Type_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("INT");

                entity.Property(e => e.Feature).HasColumnType("INT");

                entity.Property(e => e.Name).HasColumnType("INT");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_ID")
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnType("INT");

                entity.Property(e => e.Name).HasColumnType("INT");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasColumnType("INT");

                entity.Property(e => e.SuppliedProduct1Id)
                    .HasColumnName("Supplied_Product_1_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.SuppliedProduct2Id)
                    .HasColumnName("Supplied_Product_2_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.SuppliedProduct3Id)
                    .HasColumnName("Supplied_Product_3_ID")
                    .HasColumnType("INT");

                entity.HasOne(d => d.SuppliedProduct1)
                    .WithMany(p => p.ProviderSuppliedProduct1)
                    .HasForeignKey(d => d.SuppliedProduct1Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuppliedProduct2)
                    .WithMany(p => p.ProviderSuppliedProduct2)
                    .HasForeignKey(d => d.SuppliedProduct2Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SuppliedProduct3)
                    .WithMany(p => p.ProviderSuppliedProduct3)
                    .HasForeignKey(d => d.SuppliedProduct3Id)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.Price).HasColumnType("INT");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_ID")
                    .HasColumnType("INT");

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.SupplyDate)
                    .HasColumnName("Supply_Date")
                    .HasColumnType("INT");

                entity.Property(e => e.TypeOfDelivery)
                    .HasColumnName("Type_of_Delivery")
                    .HasColumnType("INT");

                entity.Property(e => e.Volume).HasColumnType("INT");

                entity.HasOne(d => d.Customer)
                    .WithMany()
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Provider)
                    .WithMany()
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
