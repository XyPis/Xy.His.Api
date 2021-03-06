using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InDayAdd
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int ItemId { get; set; }
        public string BeginTime { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
