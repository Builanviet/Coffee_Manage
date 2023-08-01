using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace KATINAT_COFFEE_SHOP.Models
{
    public partial class QuanLyKatinatContext : DbContext
    {
        public QuanLyKatinatContext()
        {
        }

        public QuanLyKatinatContext(DbContextOptions<QuanLyKatinatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Bill> Bills { get; set; } = null!;
        public virtual DbSet<BillInfo> BillInfos { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public virtual DbSet<FoodShippingOrder> FoodShippingOrders { get; set; } = null!;
        public virtual DbSet<ShippingOrder> ShippingOrders { get; set; } = null!;
        public virtual DbSet<ShippingOrderNote> ShippingOrderNotes { get; set; } = null!;
        public virtual DbSet<TableFood> TableFoods { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("value"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__Account__C9F28457098E25C5");

                entity.ToTable("Account");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'A')");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut).HasColumnType("date");

                entity.Property(e => e.IdAccount)
                    .HasMaxLength(100)
                    .HasColumnName("idAccount");

                entity.Property(e => e.IdTable).HasColumnName("idTable");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdAccountNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__idAccount__300424B4");

                entity.HasOne(d => d.IdTableNavigation)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.IdTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__idTable__30F848ED");
            });

            modelBuilder.Entity<BillInfo>(entity =>
            {
                entity.ToTable("BillInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.IdBill).HasColumnName("idBill");

                entity.Property(e => e.IdFood).HasColumnName("idFood");

                entity.HasOne(d => d.IdBillNavigation)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.IdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillInfo__count__34C8D9D1");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.BillInfos)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillInfo__idFood__35BCFE0A");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("Food");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCategory).HasColumnName("idCategory");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Chưa đặt tên')");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.IdCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Food__num__1ED998B2");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.ToTable("FoodCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Chưa đặt tên')");
            });

            modelBuilder.Entity<FoodShippingOrder>(entity =>
            {
                entity.ToTable("Food_ShippingOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdFood).HasColumnName("idFood");

                entity.Property(e => e.IdShippingOrder).HasColumnName("idShippingOrder");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.FoodShippingOrders)
                    .HasForeignKey(d => d.IdFood)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Food_Ship__idFoo__2C3393D0");

                entity.HasOne(d => d.IdShippingOrderNavigation)
                    .WithMany(p => p.FoodShippingOrders)
                    .HasForeignKey(d => d.IdShippingOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Food_Shippi__num__2B3F6F97");
            });

            modelBuilder.Entity<ShippingOrder>(entity =>
            {
                entity.ToTable("ShippingOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCheckIn)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCheckOut).HasColumnType("date");

                entity.Property(e => e.IdConfirm)
                    .HasMaxLength(100)
                    .HasColumnName("idConfirm");

                entity.Property(e => e.IdRequest)
                    .HasMaxLength(100)
                    .HasColumnName("idRequest");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.IdConfirmNavigation)
                    .WithMany(p => p.ShippingOrderIdConfirmNavigations)
                    .HasForeignKey(d => d.IdConfirm)
                    .HasConstraintName("FK__ShippingO__idCon__239E4DCF");

                entity.HasOne(d => d.IdRequestNavigation)
                    .WithMany(p => p.ShippingOrderIdRequestNavigations)
                    .HasForeignKey(d => d.IdRequest)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShippingO__idReq__22AA2996");
            });

            modelBuilder.Entity<ShippingOrderNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdShippingOrder).HasColumnName("idShippingOrder");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.NoteDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdShippingOrderNavigation)
                    .WithMany(p => p.ShippingOrderNotes)
                    .HasForeignKey(d => d.IdShippingOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShippingO__idShi__276EDEB3");
            });

            modelBuilder.Entity<TableFood>(entity =>
            {
                entity.ToTable("TableFood");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("(N'Chưa có tên')");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .HasColumnName("status")
                    .HasDefaultValueSql("(N'Trống')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
