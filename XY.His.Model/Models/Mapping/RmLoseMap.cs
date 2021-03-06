using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmLoseMap : EntityTypeConfiguration<RmLose>
    {
        public RmLoseMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RmLose");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.Operid).HasColumnName("Operid");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.SignDate).HasColumnName("SignDate");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.RmLoses)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmLoses)
                .HasForeignKey(d => d.RoomId);

        }
    }
}
