using CashStockReportApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashStockReportApp.Infrastructure.EFCore
{
    public class APIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database = EFCoreProject;user id=sa;Password=123456!a;TrustServerCertificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Product configurations
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(9,2)").IsRequired(); //zorunlu alan
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(128).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.CategoryId).IsRequired(false);

            modelBuilder.Entity<Product>() //One to many
                .HasOne<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.SetNull); 
            #endregion

            modelBuilder.Entity<Invoice>() //One to many
                .HasOne<Cashier>(i => i.Cashier)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CashierId);

            modelBuilder.Entity<Order>() //One to one 
                .HasOne(o => o.OrderInvoice)
                .WithOne(i => i.Order)
                .HasForeignKey<Invoice>(i => i.InvoiceOfOrderId);

            modelBuilder.Entity<Customer>() //one to one
                .HasOne(c=>c.Address)
                .WithOne(ca => ca.Customer)
                .HasForeignKey<CustomerAddress>(ca => ca.AdressOfCustomerId);
            //.HasForeignKey("FK_Customer_Adress");

            #region Order_Detail configuration
            modelBuilder.Entity<OrderDetail>() //Order details tablosunun PK modellemesi
                   .HasKey(e => new { e.OrderId, e.ProductId });

            modelBuilder.Entity<OrderDetail>()
                .ToTable("Order_Details");

            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.Qty).HasDefaultValue(1);

            modelBuilder.Entity<OrderDetail>()
                .Property(od => od.PricePerUnit).HasColumnType("money");

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .OnDelete(DeleteBehavior.ClientNoAction)
                .HasConstraintName("FK_Order_Details_Orders");

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId)
                .OnDelete(DeleteBehavior.ClientNoAction)
                .HasForeignKey("FK_Order_Details_Products"); 
            #endregion
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cashier> Cashiers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrdersDetail { get; set;}

        public DbSet<Product> Products { get; set; }

        public DbSet<Log> Logs { get; set; }

        public DbSet<CustomerAddress> CustomerAddresses { get; set; }

            
    }

    

    
    

}
