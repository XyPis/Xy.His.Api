using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InAdviceLong_BMap : EntityTypeConfiguration<Vw_InAdviceLong_B>
    {
        public Vw_InAdviceLong_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.AdviceTime, t.DoctorId, t.LocationId, t.HospId, t.GroupNum, t.ItemId, t.Dosage, t.Totality, t.UnitInId, t.IsAttach, t.IsSelf, t.LsSpecialUsage, t.LsExecLoc, t.IsSkin, t.OperTime, t.OperID, t.IsPrinted, t.IsChk, t.IsEnd, t.IsAuth, t.Memo, t.ExecLocId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DoctorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitInId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsSpecialUsage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsExecLoc)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SkinTest)
                .HasMaxLength(20);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            this.Property(t => t.ExecLocId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_InAdviceLong_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AdviceTime).HasColumnName("AdviceTime");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.IsAttach).HasColumnName("IsAttach");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.LsSpecialUsage).HasColumnName("LsSpecialUsage");
            this.Property(t => t.LsExecLoc).HasColumnName("LsExecLoc");
            this.Property(t => t.IsSkin).HasColumnName("IsSkin");
            this.Property(t => t.SkinTime).HasColumnName("SkinTime");
            this.Property(t => t.SkinTest).HasColumnName("SkinTest");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.IsPrinted).HasColumnName("IsPrinted");
            this.Property(t => t.IsChk).HasColumnName("IsChk");
            this.Property(t => t.ChkOperTime).HasColumnName("ChkOperTime");
            this.Property(t => t.ChkOperID).HasColumnName("ChkOperID");
            this.Property(t => t.IsEnd).HasColumnName("IsEnd");
            this.Property(t => t.EndOperTime).HasColumnName("EndOperTime");
            this.Property(t => t.EndOperID).HasColumnName("EndOperID");
            this.Property(t => t.EndDoctorID).HasColumnName("EndDoctorID");
            this.Property(t => t.IsAuth).HasColumnName("IsAuth");
            this.Property(t => t.AuthOperTime).HasColumnName("AuthOperTime");
            this.Property(t => t.AuthOperID).HasColumnName("AuthOperID");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsOtherFee).HasColumnName("IsOtherFee");
            this.Property(t => t.SN).HasColumnName("SN");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");
            this.Property(t => t.FirstDay).HasColumnName("FirstDay");
            this.Property(t => t.LastDay).HasColumnName("LastDay");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
        }
    }
}
