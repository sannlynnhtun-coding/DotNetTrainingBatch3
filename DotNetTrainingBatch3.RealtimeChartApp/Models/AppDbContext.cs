using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch3.RealtimeChartApp.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblPieChart> TblPieCharts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblPieChart>(entity =>
        {
            entity.HasKey(e => e.PieChartId);

            entity.ToTable("Tbl_PieChart");

            entity.Property(e => e.PieChartLabel)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
