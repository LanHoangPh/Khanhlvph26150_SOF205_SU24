using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1._DAL.Models;

public partial class Sof205FinalTestContext : DbContext
{
    public Sof205FinalTestContext()
    {
    }

    public Sof205FinalTestContext(DbContextOptions<Sof205FinalTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Chunhan> Chunhans { get; set; }

    public virtual DbSet<Congty> Congties { get; set; }

    public virtual DbSet<Cuahang> Cuahangs { get; set; }

    public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Thucung> Thucungs { get; set; }

    public virtual DbSet<Trungtam> Trungtams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-F7IUT789;Database=SOF205_FINAL_TEST;TrustServerCertificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chunhan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUNHAN__3213E83FE78EC574");

            entity.ToTable("CHUNHAN");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Congty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CONGTY__3213E83FEE582CCE");

            entity.ToTable("CONGTY");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Cuahang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUAHANG__3213E83F853B569F");

            entity.ToTable("CUAHANG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCn).HasColumnName("idCN");
            entity.Property(e => e.Loaihang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("loaihang");
            entity.Property(e => e.Mota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mota");
            entity.Property(e => e.Ngaydangky).HasColumnName("ngaydangky");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Cuahangs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("FKCH_TT");
        });

        modelBuilder.Entity<Nhacungcap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHACUNGC__3213E83F0409C363");

            entity.ToTable("NHACUNGCAP");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHANVIEN__3213E83FC6367E49");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.IdCn).HasColumnName("idCN");
            entity.Property(e => e.Ngaytuyendung).HasColumnName("ngaytuyendung");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sodienthoai");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("FKNV_CT");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3213E83FC02EA85A");

            entity.ToTable("SANPHAM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Giatien).HasColumnName("giatien");
            entity.Property(e => e.IdNcc).HasColumnName("idNCC");
            entity.Property(e => e.Mota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("mota");
            entity.Property(e => e.Soluongtonkho).HasColumnName("soluongtonkho");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");

            entity.HasOne(d => d.IdNccNavigation).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.IdNcc)
                .HasConstraintName("FK_SP_NCC");
        });

        modelBuilder.Entity<Thucung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__THUCUNG__3213E83FA86BDED4");

            entity.ToTable("THUCUNG");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCn).HasColumnName("idCN");
            entity.Property(e => e.Loai)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("loai");
            entity.Property(e => e.Maulong)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("maulong");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.Thucungs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("FK_TC_CN");
        });

        modelBuilder.Entity<Trungtam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRUNGTAM__3213E83FF1E43CDB");

            entity.ToTable("TRUNGTAM");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("diachi");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("ten");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
