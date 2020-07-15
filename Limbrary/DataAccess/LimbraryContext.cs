using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Limbrary
{
    public partial class LimbraryContext : DbContext
    {
        public LimbraryContext()
        {
        }

        public LimbraryContext(DbContextOptions<LimbraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Rentals> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(DataAccess.SecretConfiguration.secret);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.BooksId)
                    .HasName("PK__Books__C223F3B4BDD4F196");

                entity.Property(e => e.BooksId)
                    .HasColumnName("Books_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgeGroup)
                    .HasColumnName("Age_Group")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Author)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InStock).HasColumnName("In_Stock");

                entity.Property(e => e.Title)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB286997290133B");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .HasColumnName("Home_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rentals>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Rentals__F1E4607B27B3696B");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdultBooks).HasColumnName("Adult_Books");

                entity.Property(e => e.ChildrensBooks).HasColumnName("Childrens_Books");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.TotalBooks).HasColumnName("Total_Books");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("Total_Cost")
                    .HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
