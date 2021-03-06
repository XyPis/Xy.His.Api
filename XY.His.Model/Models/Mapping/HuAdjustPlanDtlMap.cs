using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuAdjustPlanDtlMap : EntityTypeConfiguration<HuAdjustPlanDtl>
    {
        public HuAdjustPlanDtlMap()
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
            this.ToTable("HuAdjustPlanDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuAdjustPlanDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.HuAdjustPlan)
                .WithMany(t => t.HuAdjustPlanDtls)
                .HasForeignKey(d => d.BillId);

        }
    }
}
