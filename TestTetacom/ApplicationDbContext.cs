using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TestTetacom.Model;

namespace TestTetacom;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<GroupedWellStatus> GroupedWellStatuses { get; set; }    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupedWellStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("grouped_well_status");

            entity.HasIndex(e => new { e.WellId, e.StartDt }, "grouped_well_status_un").IsUnique();

            entity.Property(e => e.BitDepthAfter).HasColumnName("bit_depth_after");
            entity.Property(e => e.EndDt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_dt");
            entity.Property(e => e.FullDuration).HasColumnName("full_duration");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IsDayChange)
                .HasDefaultValue(false)
                .HasColumnName("is_day_change");
            entity.Property(e => e.MdAfter).HasColumnName("md_after");
            entity.Property(e => e.MdBefore).HasColumnName("md_before");
            entity.Property(e => e.NewDayDuration).HasColumnName("new_day_duration");
            entity.Property(e => e.NewDayStartDt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("new_day_start_dt");
            entity.Property(e => e.OldDayDuration).HasColumnName("old_day_duration");
            entity.Property(e => e.OldDayEndDt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("old_day_end_dt");
            entity.Property(e => e.StartDt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_dt");
            entity.Property(e => e.Val).HasColumnName("val");
            entity.Property(e => e.WellId).HasColumnName("well_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
