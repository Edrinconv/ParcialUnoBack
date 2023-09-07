using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialUno.Models;

public partial class ParcialCorteUnoContext : DbContext
{
    public ParcialCorteUnoContext()
    {
    }

    public ParcialCorteUnoContext(DbContextOptions<ParcialCorteUnoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Dueño> Dueños { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-A8KULQ5\\SQLEXPRESS; Database=ParcialCorteUno;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.HasKey(e => e.IdComida);

            entity.Property(e => e.IdComida)
                .ValueGeneratedNever()
                .HasColumnName("idComida");
            entity.Property(e => e.NombreComida)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreComida");
            entity.Property(e => e.PrecioComida).HasColumnName("precioComida");
            entity.Property(e => e.PresentacionComidaKg).HasColumnName("presentacionComidaKG");
            entity.Property(e => e.StockComida).HasColumnName("stockComida");
        });

        modelBuilder.Entity<Dueño>(entity =>
        {
            entity.HasKey(e => e.IdDueño);

            entity.ToTable("Dueño");

            entity.Property(e => e.IdDueño)
                .ValueGeneratedNever()
                .HasColumnName("idDueño");
            entity.Property(e => e.CorreoDueño)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correoDueño");
            entity.Property(e => e.DireccionDueño)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccionDueño");
            entity.Property(e => e.NombreDueño)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreDueño");
            entity.Property(e => e.TelefonoDueño).HasColumnName("telefonoDueño");
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.IdMascota);

            entity.Property(e => e.IdMascota)
                .ValueGeneratedNever()
                .HasColumnName("idMascota");
            entity.Property(e => e.NombreMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreMascota");
            entity.Property(e => e.PesoMascota).HasColumnName("pesoMascota");
            entity.Property(e => e.RazaMascota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("razaMascota");
            entity.Property(e => e.TamañoMascota).HasColumnName("tamañoMascota");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
