using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKGROUPDEPARTMENTMap : EntityTypeConfiguration<CKGROUPDEPARTMENT>
    {
        public CKGROUPDEPARTMENTMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WBCODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PYCODE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(200);

            this.Property(t => t.F2)
                .HasMaxLength(200);

            this.Property(t => t.F3)
                .HasMaxLength(200);

            this.Property(t => t.F4)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CKGROUPDEPARTMENT");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.ISACTIVE).HasColumnName("ISACTIVE");
            this.Property(t => t.WBCODE).HasColumnName("WBCODE");
            this.Property(t => t.PYCODE).HasColumnName("PYCODE");
            this.Property(t => t.OPERID).HasColumnName("OPERID");
            this.Property(t => t.OPERTIME).HasColumnName("OPERTIME");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ICONINDEX).HasColumnName("ICONINDEX");
        }
    }
}
