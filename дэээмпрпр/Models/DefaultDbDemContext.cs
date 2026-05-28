using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace дэээмпрпр.Models;

public partial class DefaultDbDemContext : DbContext
{
    public DefaultDbDemContext()
    {
    }

    public DefaultDbDemContext(DbContextOptions<DefaultDbDemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Addre> Addres { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=mysql-1b282e9e-dem.h.aivencloud.com;port=23200;uid=avnadmin;password=AVNS_ojJSJ61IETU3J2BEq4m;database=default_db_dem", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.8-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Addre>(entity =>
        {
            entity.HasKey(e => e.Idaddres).HasName("PRIMARY");

            entity.ToTable("addres");

            entity.Property(e => e.Idaddres)
                .ValueGeneratedNever()
                .HasColumnName("idaddres");
            entity.Property(e => e.Addres)
                .HasMaxLength(45)
                .HasColumnName("addres");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.Idcategoria).HasName("PRIMARY");

            entity.ToTable("categoria");

            entity.Property(e => e.Idcategoria).HasColumnName("idcategoria");
            entity.Property(e => e.CategoriaName)
                .HasMaxLength(45)
                .HasColumnName("categoria_name");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Idclient).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Idclient).HasColumnName("idclient");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Fio)
                .HasMaxLength(45)
                .HasColumnName("fio");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Patronomik)
                .HasMaxLength(45)
                .HasColumnName("patronomik");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Role).HasColumnName("role");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Idmanufacturer).HasName("PRIMARY");

            entity.ToTable("manufacturer");

            entity.Property(e => e.Idmanufacturer).HasColumnName("idmanufacturer");
            entity.Property(e => e.ManufacturName)
                .HasMaxLength(45)
                .HasColumnName("manufactur_name");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Idorder).HasName("PRIMARY");

            entity.ToTable("order");

            entity.HasIndex(e => e.AddresId, "addres_id_idx");

            entity.HasIndex(e => e.StatusId, "status_id_idx");

            entity.Property(e => e.Idorder).HasColumnName("idorder");
            entity.Property(e => e.AddresId).HasColumnName("addres_id");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.DataDeliviry).HasColumnName("data_deliviry");
            entity.Property(e => e.DataOrder).HasColumnName("data_order");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.OrderStructure)
                .HasMaxLength(45)
                .HasColumnName("order_structure");
            entity.Property(e => e.Patronomic)
                .HasMaxLength(45)
                .HasColumnName("patronomic");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.Surname)
                .HasMaxLength(45)
                .HasColumnName("surname");

            entity.HasOne(d => d.Addres).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AddresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("addres_id");

            entity.HasOne(d => d.Status).WithMany(p => p.Orders)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Idproduct).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.CategoryId, "category_id_idx");

            entity.HasIndex(e => e.ManufacturerId, "manufacturer_id_idx");

            entity.HasIndex(e => e.SuppliersId, "suppliers_id_idx");

            entity.HasIndex(e => e.UnitId, "unit_id_idx");

            entity.Property(e => e.Idproduct).HasColumnName("idproduct");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description)
                .HasMaxLength(45)
                .HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Photo)
                .HasMaxLength(45)
                .HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasPrecision(10)
                .HasColumnName("price");
            entity.Property(e => e.SuppliersId).HasColumnName("suppliers_id");
            entity.Property(e => e.UnitId).HasColumnName("unit_id");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("category_id");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.Products)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("manufacturer_id");

            entity.HasOne(d => d.Suppliers).WithMany(p => p.Products)
                .HasForeignKey(d => d.SuppliersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("suppliers_id");

            entity.HasOne(d => d.Unit).WithMany(p => p.Products)
                .HasForeignKey(d => d.UnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("unit_id");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Idrole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.Idrole).HasColumnName("idrole");
            entity.Property(e => e.RoleName)
                .HasMaxLength(45)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Idstatus).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.Idstatus).HasColumnName("idstatus");
            entity.Property(e => e.StatusName)
                .HasMaxLength(45)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Idsuppliers).HasName("PRIMARY");

            entity.ToTable("suppliers");

            entity.Property(e => e.Idsuppliers).HasColumnName("idsuppliers");
            entity.Property(e => e.SuppliersName)
                .HasMaxLength(45)
                .HasColumnName("suppliers_name");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.Idunit).HasName("PRIMARY");

            entity.ToTable("unit");

            entity.Property(e => e.Idunit).HasColumnName("idunit");
            entity.Property(e => e.UnitName)
                .HasMaxLength(45)
                .HasColumnName("unit_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.Role, "role_idx");

            entity.Property(e => e.Iduser).HasColumnName("iduser");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");

            entity.HasOne(d => d.RoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
