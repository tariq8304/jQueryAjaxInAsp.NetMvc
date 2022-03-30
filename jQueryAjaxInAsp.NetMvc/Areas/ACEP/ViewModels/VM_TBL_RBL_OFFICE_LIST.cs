
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class VM_TBL_RBL_OFFICE_LIST  
    {
        public string ROUTING_NO { get; set; }
        public int? OFFICEID { get; set; }
        public int? RBLOFFICEID { get; set; }
        public string RBL_BRANCHCODE { get; set; }
        public decimal RBL_BRANCHCODE_FLOAT { get; set; }
        public string RBL_OFFICENAME { get; set; }
        public string OFFICESTATUS { get; set; }
        public int? IS_BRANCH_OFFICE { get; set; }
        public int? RBL_ZONEID { get; set; }
        public string RBL_ZONALOFFICENAME { get; set; }
        public int? RBL_DIVISION_ID { get; set; }
        public string RBL_DIVISIONALOFFICENAME { get; set; }
        public int? ISADBRANCH { get; set; }
        public decimal BRANCHADCODE { get; set; }
        [Key]
        public string OFFICE_LIST_GUID { get; set; }
        public decimal SBS_CODE_GENERATED_BY_BB { get; set; }
        public decimal BANK_ID_GENERATED_BY_BB { get; set; }
        public int? IS_CORPORATE1_BRANCH { get; set; }
    }
}