using System;
using DigitalWare.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DigitalWare.Infraestructure.Data
{
    public partial class DigitalWareContext : DbContext
    {
        public DigitalWareContext()
        {
        }

        public DigitalWareContext(DbContextOptions<DigitalWareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<FacturaProducto> FacturaProducto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Factura_Cliente");
            });

            modelBuilder.Entity<FacturaProducto>(entity =>
            {
                entity.HasOne(d => d.Factura)
                    .WithMany(p => p.FacturaProducto)
                    .HasForeignKey(d => d.FacturaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FacturaProducto_Factura");

                entity.HasOne(d => d.Producto)
                    .WithMany(p => p.FacturaProducto)
                    .HasForeignKey(d => d.ProductoId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FacturaProducto_Producto");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.Property(e => e.FechaActualizacion).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });           
        }        
    }
}
