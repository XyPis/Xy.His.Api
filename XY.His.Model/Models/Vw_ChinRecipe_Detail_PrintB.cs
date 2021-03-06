using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_ChinRecipe_Detail_PrintB
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public int MzRegId { get; set; }
        public string recipe_Num { get; set; }
        public string Spec { get; set; }
        public string Unit_Take { get; set; }
        public string Unit_Diag { get; set; }
        public string usagename { get; set; }
        public Nullable<decimal> Hz { get; set; }
        public decimal Dosage { get; set; }
        public decimal Totality { get; set; }
        public string Memo { get; set; }
        public string PrepareTime { get; set; }
        public int List_Num { get; set; }
        public bool IsCancel { get; set; }
        public string Item_Desc { get; set; }
        public decimal Price_In { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string PatTypeName { get; set; }
        public string LocationName { get; set; }
        public string SequenceNum { get; set; }
        public string Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> BabyMonth { get; set; }
        public string AddressHome { get; set; }
        public string IllDesc { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public string PhoneHome { get; set; }
        public Nullable<short> HowMany { get; set; }
        public string AccountNo { get; set; }
        public bool IsCharge { get; set; }
        public string RecipeMemo { get; set; }
    }
}
