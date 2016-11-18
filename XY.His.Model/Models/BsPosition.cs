using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPosition
    {
        public BsPosition()
        {
            this.NfInfects = new List<NfInfect>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public int InfSystemId { get; set; }
        public virtual BsInfSystem BsInfSystem { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
    }
}
