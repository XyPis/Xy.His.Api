using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblPhoneMsgMap : EntityTypeConfiguration<GblPhoneMsg>
    {
        public GblPhoneMsgMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PhoneNum)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Message)
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
            this.ToTable("GblPhoneMsg");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PhoneNum).HasColumnName("PhoneNum");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.PlanTime).HasColumnName("PlanTime");
            this.Property(t => t.IsSend).HasColumnName("IsSend");
            this.Property(t => t.SendTime).HasColumnName("SendTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.GblPhoneMsgs)
                .HasForeignKey(d => d.OperId);

        }
    }
}
