using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemLocationMap : EntityTypeConfiguration<BsItemLocation>
    {
        public BsItemLocationMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItemLocation");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.FeeHsMzId).HasColumnName("FeeHsMzId");
            this.Property(t => t.FeeHsZyId).HasColumnName("FeeHsZyId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTake).HasColumnName("UnitTake");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.IsLocDrug).HasColumnName("IsLocDrug");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.IsLocUse).HasColumnName("IsLocUse");

            // Relationships
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.FrequencyId);
            this.HasOptional(t => t.BsHsFeety)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.FeeHsMzId);
            this.HasOptional(t => t.BsHsFeety1)
                .WithMany(t => t.BsItemLocations1)
                .HasForeignKey(d => d.FeeHsZyId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsLocation1)
                .WithMany(t => t.BsItemLocations1)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsUnit)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.UnitTake);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.BsItemLocations)
                .HasForeignKey(d => d.UsageId);

        }
    }
}
