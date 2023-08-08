using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zulu.API.Models;

public partial class RncdDbContext : DbContext
{
    public RncdDbContext()
    {
    }

    public RncdDbContext(DbContextOptions<RncdDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aspirante> Aspirantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=S1-DIXX-SQL10;Database=RNCD_II;User ID=AppRNCD_II;Password=q2uh51r9BC1VU5;;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aspirante>(entity =>
        {
            entity.HasKey(e => e.NumeroDeRegistroConsecutivo);

            entity.ToTable("Aspirante");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.CUIL).HasMaxLength(11);
            entity.Property(e => e.CorreoElectronico).HasMaxLength(100);
            entity.Property(e => e.EnteCertificador).HasMaxLength(256);
            entity.Property(e => e.FechaCreacion).HasColumnType("date");
            entity.Property(e => e.FechaEmisionCertificado).HasColumnType("date");
            entity.Property(e => e.FechaModificacion).HasColumnType("date");
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.FechaVencimientoCertificado).HasColumnType("date");
            entity.Property(e => e.Genero).HasMaxLength(50);
            entity.Property(e => e.KilometrosDispuestoADesplazarse).HasMaxLength(20);
            entity.Property(e => e.LeyDescripcion).HasMaxLength(10);
            entity.Property(e => e.LeyNumero).HasMaxLength(10);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NumeroDeCertificado).HasMaxLength(15);
            entity.Property(e => e.NumeroDeRegistroInformativo).HasMaxLength(25);
            entity.Property(e => e.OtroElementoDeApoyo).HasMaxLength(100);
            entity.Property(e => e.Telefonos)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
