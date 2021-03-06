using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsTestPaperMap : EntityTypeConfiguration<BsTestPaper>
    {
        public BsTestPaperMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.QuestionId)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.UsersId)
                .HasMaxLength(300);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsTestPaper");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.GenerateTime).HasColumnName("GenerateTime");
            this.Property(t => t.QuestionId).HasColumnName("QuestionId");
            this.Property(t => t.UsersId).HasColumnName("UsersId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
