using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsItemYbMap : EntityTypeConfiguration<BsItemYb>
    {
        public BsItemYbMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.YbCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.YbDesc)
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

            this.Property(t => t.DrugCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItemYb");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.YbCode).HasColumnName("YbCode");
            this.Property(t => t.YbDesc).HasColumnName("YbDesc");
            this.Property(t => t.LsYbType).HasColumnName("LsYbType");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.LsAuthstatus).HasColumnName("LsAuthstatus");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.DrugCode).HasColumnName("DrugCode");

            // Relationships            

        }
    }
}
