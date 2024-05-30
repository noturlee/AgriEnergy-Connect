using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using FireBasics.Models;

namespace FireBasics.Models
{
    public partial class AgrienergyContext : DbContext
    {
        public AgrienergyContext()
        {
        }

        public AgrienergyContext(DbContextOptions<AgrienergyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=LEIGHCHESHP\\SQLEXPRESS;Initial Catalog=AGRIENERGY;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId).HasName("PK__CATEGORI__E7DA297C506BDF15");

                entity.ToTable("CATEGORIES");

                entity.HasIndex(e => e.CategoryName, "UQ__CATEGORI__9374460F1DEDC63F").IsUnique();

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY_NAME");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId).HasName("PK__PRODUCTS__52B41763DFDA4EBF");

                entity.ToTable("PRODUCTS");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
                entity.Property(e => e.Availability)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("AVAILABILITY");
                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
                entity.Property(e => e.FarmerId).HasColumnName("FARMER_ID");
                entity.Property(e => e.Price).HasColumnName("PRICE");
                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_DESCRIPTION");
                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRODUCT_NAME");
                entity.Property(e => e.ProductionDate).HasColumnName("PRODUCTION_DATE");
                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.HasOne(d => d.Category).WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__PRODUCTS__CATEGO__3E52440B");

                entity.HasOne(d => d.Farmer).WithMany(p => p.Products)
                    .HasForeignKey(d => d.FarmerId)
                    .HasConstraintName("FK__PRODUCTS__FARMER__3D5E1FD2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId).HasName("PK__USERS__F3BEEBFF1C2BC80A");

                entity.ToTable("USERS");

                entity.HasIndex(e => e.FirebaseUid, "UQ__USERS__97B07D8F489B4B76").IsUnique();

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
                entity.Property(e => e.Bio)
                    .HasColumnType("text")
                    .HasColumnName("BIO");
                entity.Property(e => e.Dob).HasColumnName("DOB");
                entity.Property(e => e.FirebaseUid)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("FIREBASE_UID");
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ROLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
