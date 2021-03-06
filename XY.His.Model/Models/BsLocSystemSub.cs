using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsLocSystemSub
    {
        public BsLocSystemSub()
        {
            this.BsLocSystemSub2 = new List<BsLocSystemSub2>();
        }

        public int ID { get; set; }
        public int MainId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsLocSystem BsLocSystem { get; set; }
        public virtual ICollection<BsLocSystemSub2> BsLocSystemSub2 { get; set; }
    }
}
