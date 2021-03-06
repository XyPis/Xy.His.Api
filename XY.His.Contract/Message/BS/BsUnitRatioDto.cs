using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsUnitRatioDto : DtoBase
    {
        public int ItemId { get; set; }
        public int UnitId1 { get; set; }
        public int UnitId2 { get; set; }
        public decimal DrugRatio { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
