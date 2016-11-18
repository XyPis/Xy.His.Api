using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblFunTraceMap : EntityTypeConfiguration<GblFunTrace>
    {
        public GblFunTraceMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblFunTrace");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DebugMode).HasColumnName("DebugMode");
            this.Property(t => t.FuntionId).HasColumnName("FuntionId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.GblFuction)
                .WithMany(t => t.GblFunTraces)
                .HasForeignKey(d => d.FuntionId);

        }
    }
}
