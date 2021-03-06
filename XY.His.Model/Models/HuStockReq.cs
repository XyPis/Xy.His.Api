using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuStockReq
    {
        public HuStockReq()
        {
            this.HuStockReqdtls = new List<HuStockReqdtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<System.DateTime> ValideTime { get; set; }
        public string ApplyIdea { get; set; }
        public string ApplyHander { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> CompId { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuStockReqdtl> HuStockReqdtls { get; set; }
    }
}
