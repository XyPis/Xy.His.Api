using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InAdviceWeekDayMap : EntityTypeConfiguration<InAdviceWeekDay>
    {
        public InAdviceWeekDayMap()
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
            this.ToTable("InAdviceWeekDay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AdviceId).HasColumnName("AdviceId");
            this.Property(t => t.WeekDay).HasColumnName("WeekDay");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.InAdviceLong)
                .WithMany(t => t.InAdviceWeekDays)
                .HasForeignKey(d => d.AdviceId);

        }
    }
}
