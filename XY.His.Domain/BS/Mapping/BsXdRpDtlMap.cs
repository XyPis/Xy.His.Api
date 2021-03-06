using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsXdRpDtlMap : EntityTypeConfiguration<BsXdRpDtl>
    {
        public BsXdRpDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsXdRpDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.XdRpId).HasColumnName("XdRpId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.FeeTotality).HasColumnName("FeeTotality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");

            // Relationships
        }
    }
}
