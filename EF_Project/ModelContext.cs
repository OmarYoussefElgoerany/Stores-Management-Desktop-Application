using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_Project
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
            : base("name=ModelContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EmployeeManger> EmployeeMangers { get; set; }
        public virtual DbSet<OrderLog> OrderLogs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplyPermission> SupplyPermissions { get; set; }
        public virtual DbSet<SupplyPermissionLog> SupplyPermissionLogs { get; set; }
        public virtual DbSet<Transfer> Transfers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customer)
                .HasForeignKey(e => e.Fk_CustomerID);

            modelBuilder.Entity<EmployeeManger>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeManger>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeManger>()
                .HasMany(e => e.Stores)
                .WithOptional(e => e.EmployeeManger)
                .HasForeignKey(e => e.EmployeManger);

            modelBuilder.Entity<OrderLog>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.SerialNum)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderLogs)
                .WithOptional(e => e.Order)
                .HasForeignKey(e => e.Fk_OrderID);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderLogs)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Fk_ProductID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Transfers)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Fk_ProductID);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SupplyPermissionLogs)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.Fk_ProductID);

            modelBuilder.Entity<Store>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.Fk_StoreID);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.SupplyPermissions)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.Fk_StoreID);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Transfers)
                .WithOptional(e => e.Store)
                .HasForeignKey(e => e.Fk_FromStoreID);

            modelBuilder.Entity<Store>()
                .HasMany(e => e.Transfers1)
                .WithOptional(e => e.Store1)
                .HasForeignKey(e => e.Fk_ToStoreID);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.OrderLogs)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.Fk_SupplierID);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Transfers)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.Fk_SupplierID);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.SupplyPermissionLogs)
                .WithOptional(e => e.Supplier)
                .HasForeignKey(e => e.Fk_SupplierID);

            modelBuilder.Entity<SupplyPermission>()
                .HasMany(e => e.SupplyPermissionLogs)
                .WithOptional(e => e.SupplyPermission)
                .HasForeignKey(e => e.Fk_SupplyPermissionId);

            modelBuilder.Entity<SupplyPermissionLog>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Transfer>()
                .Property(e => e.Quantity)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Unit)
                .HasForeignKey(e => e.Fk_UnitID);
        }
    }
}
