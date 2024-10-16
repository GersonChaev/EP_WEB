using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial20240221100940_DOMAIN.Data;

public partial class Parcial20240221100940Context : DbContext
{
    public Parcial20240221100940Context()
    {
    }

    public Parcial20240221100940Context(DbContextOptions<Parcial20240221100940Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Competency> Competency { get; set; }

    public virtual DbSet<JobOffer> JobOffer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302405;Database=Parcial20240221100940;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Competency>(entity =>
        {
            entity.HasKey(e => e.Id2).HasName("pk_id2");

            entity.Property(e => e.Id2)
                .ValueGeneratedNever()
                .HasColumnName("id2");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobOffer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
