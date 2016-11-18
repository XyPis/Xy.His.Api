using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InEmrChangeMap : EntityTypeConfiguration<InEmrChange>
    {
        public InEmrChangeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Modified)
                .HasMaxLength(50);

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
            this.ToTable("InEmrChange");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EmrId).HasColumnName("EmrId");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Modified).HasColumnName("Modified");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsUse).HasColumnName("IsUse");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
