using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ecom.API.Models
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

        public virtual DbSet<AnswerMaster> AnswerMaster { get; set; }
        public virtual DbSet<BrandMaster> BrandMaster { get; set; }
        public virtual DbSet<CategoryAttributeMaster> CategoryAttributeMaster { get; set; }
        public virtual DbSet<CategoryMaster> CategoryMaster { get; set; }
        public virtual DbSet<CategoryVarianceDetails> CategoryVarianceDetails { get; set; }
        public virtual DbSet<CountryMaster> CountryMaster { get; set; }
        public virtual DbSet<ImageMaster> ImageMaster { get; set; }
        public virtual DbSet<ImpoterMaster> ImpoterMaster { get; set; }
        public virtual DbSet<ListingVarianceDetails> ListingVarianceDetails { get; set; }
        public virtual DbSet<ManufacturingMaster> ManufacturingMaster { get; set; }
        public virtual DbSet<OfferMaster> OfferMaster { get; set; }
        public virtual DbSet<OfferTerms> OfferTerms { get; set; }
        public virtual DbSet<OfferTypeMaster> OfferTypeMaster { get; set; }
        public virtual DbSet<ProductListing> ProductListing { get; set; }
        public virtual DbSet<QuestionMaster> QuestionMaster { get; set; }
        public virtual DbSet<ReviewMaster> ReviewMaster { get; set; }
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
            modelBuilder.Entity<AnswerMaster>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.AnswerMaster)
                    .HasForeignKey(d => d.QuestionId)
                    .HasConstraintName("FK_AnswerMaster_QuestionMaster");
            });

            modelBuilder.Entity<BrandMaster>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryAttributeMaster>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryAttributeMaster)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryAttributeMaster_CategoryMaster");
            });

            modelBuilder.Entity<CategoryMaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_CategoryMaster_CategoryMaster");
            });

            modelBuilder.Entity<CategoryVarianceDetails>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryVarianceDetails)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryVarianceDetails_CategoryMaster");

                entity.HasOne(d => d.VarianceMaster)
                    .WithMany(p => p.CategoryVarianceDetails)
                    .HasForeignKey(d => d.VarianceMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryVarianceDetails_VarianceMaster");
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageMaster>(entity =>
            {
                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductListing)
                    .WithMany(p => p.ImageMaster)
                    .HasForeignKey(d => d.ProductListingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageMaster_ImageMaster");
            });

            modelBuilder.Entity<ImpoterMaster>(entity =>
            {
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
                entity.Property(e => e.AddressLine)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfferMaster>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OfferMaster)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferMaster_ProductListing");
            });

            modelBuilder.Entity<OfferTerms>(entity =>
            {
                entity.Property(e => e.TermText)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Offer)
                    .WithMany(p => p.OfferTerms)
                    .HasForeignKey(d => d.OfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferTerms_OfferMaster");
            });

            modelBuilder.Entity<OfferTypeMaster>(entity =>
            {
                entity.Property(e => e.OfferType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductListing>(entity =>
            {
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

            modelBuilder.Entity<QuestionMaster>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductListing)
                    .WithMany(p => p.QuestionMaster)
                    .HasForeignKey(d => d.ProductListingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionMaster_ProductListing");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuestionMaster)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionMaster_Users");
            });

            modelBuilder.Entity<ReviewMaster>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ReviewText)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductListing)
                    .WithMany(p => p.ReviewMaster)
                    .HasForeignKey(d => d.ProductListingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewMaster_ProductListing");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReviewMaster)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReviewMaster_Users");
            });

            modelBuilder.Entity<ShippingType>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxMaster>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
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
