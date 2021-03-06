using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkIllAdviceMap : EntityTypeConfiguration<CkIllAdvice>
    {
        public CkIllAdviceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .HasMaxLength(255);

            this.Property(t => t.IllDesc)
                .HasMaxLength(255);

            this.Property(t => t.OrderBy)
                .HasMaxLength(255);

            this.Property(t => t.Advice)
                .HasMaxLength(255);

            this.Property(t => t.F1)
                .HasMaxLength(255);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkIllAdvice");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestTypeId).HasColumnName("TestTypeId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.Advice).HasColumnName("Advice");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
