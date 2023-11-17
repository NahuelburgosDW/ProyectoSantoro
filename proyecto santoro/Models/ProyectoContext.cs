using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyecto_santoro.Models;

public partial class ProyectoContext : DbContext
{
    public ProyectoContext()
    {
    }

    public ProyectoContext(DbContextOptions<ProyectoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Table1> Table1s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseSqlServer(Configuration.GetConnectionString("NombreDeTuCadenaDeConexion"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table1>(entity =>
        {
            entity.ToTable("Table_1");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
