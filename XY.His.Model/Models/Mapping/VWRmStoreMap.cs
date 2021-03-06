using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VWRmStoreMap : EntityTypeConfiguration<VWRmStore>
    {
        public VWRmStoreMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InBatchNo, t.RoomId, t.ItemId, t.UnitId, t.StockPrice, t.RetailPrice, t.StockNum, t.InstoreNum, t.IsBalance });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstoreNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemCode)
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VWRmStores");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.InstoreNum).HasColumnName("InstoreNum");
            this.Property(t => t.StoreDate).HasColumnName("StoreDate");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.IsBalance).HasColumnName("IsBalance");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.UnderLineKc).HasColumnName("UnderLineKc");
            this.Property(t => t.UperLineKc).HasColumnName("UperLineKc");
            this.Property(t => t.NormalLineKc).HasColumnName("NormalLineKc");
            this.Property(t => t.ProAreaId).HasColumnName("ProAreaId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.RetailTotal).HasColumnName("RetailTotal");
            this.Property(t => t.PriceTotal).HasColumnName("PriceTotal");
        }
    }
}
