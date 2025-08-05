using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models;

public partial class HouseContext : DbContext
{
    public HouseContext(DbContextOptions<HouseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<House> House { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<House>(entity =>
        {
            entity.HasKey(e => e.HouseID).HasName("PK_House2");

            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
