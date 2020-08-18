using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecom.Data.Models
{
    public partial class ECOMContext : DbContext
    {
        public ECOMContext()
        {
        }

        public ECOMContext(DbContextOptions<ECOMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BrandMaster> BrandMaster { get; set; }
        public virtual DbSet<CategoryAttributeMaster> CategoryAttributeMaster { get; set; }
        public virtual DbSet<CategoryMaster> CategoryMaster { get; set; }
        public virtual DbSet<CategoryVarianceDetails> CategoryVarianceDetails { get; set; }
        public virtual DbSet<CountryMaster> CountryMaster { get; set; }
        public virtual DbSet<ImpoterMaster> ImpoterMaster { get; set; }
        public virtual DbSet<ListingVarianceDetails> ListingVarianceDetails { get; set; }
        public virtual DbSet<ManufacturingMaster> ManufacturingMaster { get; set; }
        public virtual DbSet<ProductListing> ProductListing { get; set; }
        public virtual DbSet<ShippingType> ShippingType { get; set; }
        public virtual DbSet<TaxMaster> TaxMaster { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VarianceMaster> VarianceMaster { get; set; }
        public virtual DbSet<VarianceValue> VarianceValue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Initial Catalog = ECOM; Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandMaster>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryAttributeMaster>(entity =>
            {
                entity.HasKey(e => e.CategoryAttributeId);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

              
            });

            

            modelBuilder.Entity<CategoryVarianceDetails>(entity =>
            {
                entity.HasKey(e => e.CategoryVarianceId);

              
                entity.HasOne(d => d.VarianceMaster)
                    .WithMany(p => p.CategoryVarianceDetails)
                    .HasForeignKey(d => d.VarianceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryVarianceDetails_VarianceMaster");
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImpoterMaster>(entity =>
            {
                entity.HasKey(e => e.ImpoterId);

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListingVarianceDetails>(entity =>
            {
                entity.HasKey(e => e.ListingVarianceId);

                entity.HasOne(d => d.ProductListing)
                    .WithMany(p => p.ListingVarianceDetails)
                    .HasForeignKey(d => d.ProductListingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListingVarianceDetails_ProductListing");

                entity.HasOne(d => d.VarianceMaster)
                    .WithMany(p => p.ListingVarianceDetails)
                    .HasForeignKey(d => d.VarianceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListingVarianceDetails_VarianceMaster");

                entity.HasOne(d => d.VarianceValue)
                    .WithMany(p => p.ListingVarianceDetails)
                    .HasForeignKey(d => d.VarianceValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ListingVarianceDetails_VarianceValue");
            });

            modelBuilder.Entity<ManufacturingMaster>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductListing>(entity =>
            {
                entity.HasKey(e => e.ListingId);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasColumnName("HSNCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListingText)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Mrp).HasColumnName("MRP");

                entity.Property(e => e.ParentListingText).HasMaxLength(25);

                entity.Property(e => e.SellerSku)
                    .IsRequired()
                    .HasColumnName("SellerSKU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription).IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Impoter)
                    .WithMany(p => p.ProductListing)
                    .HasForeignKey(d => d.ImpoterId)
                    .HasConstraintName("FK_ProductListing_ImpoterMaster");

                entity.HasOne(d => d.Manufacturing)
                    .WithMany(p => p.ProductListing)
                    .HasForeignKey(d => d.ManufacturingId)
                    .HasConstraintName("FK_ProductListing_ManufacturingMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProductListing)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductListing_Users");
            });

            modelBuilder.Entity<ShippingType>(entity =>
            {
                entity.HasKey(e => e.ShippingId);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxMaster>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.Property(e => e.TaxId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Email).HasMaxLength(320);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VarianceMaster>(entity =>
            {
                entity.HasKey(e => e.VarianceId);

                entity.Property(e => e.VarianceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VarianceValue>(entity =>
            {
                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
