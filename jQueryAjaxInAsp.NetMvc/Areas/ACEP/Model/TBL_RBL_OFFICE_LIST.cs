
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
    public class TBL_RBL_OFFICE_LIST
    {
        public string ROUTING_NO { get; set; }
        public decimal OFFICEID { get; set; }
        public decimal RBLOFFICEID { get; set; }
        public string RBL_BRANCHCODE { get; set; }
        public decimal RBL_BRANCHCODE_FLOAT { get; set; }
        public string RBL_OFFICENAME { get; set; }
        public string OFFICESTATUS { get; set; }
        public decimal IS_BRANCH_OFFICE { get; set; }
        public decimal RBL_ZONEID { get; set; }
        public string RBL_ZONALOFFICENAME { get; set; }
        public decimal RBL_DIVISION_ID { get; set; }
        public string RBL_DIVISIONALOFFICENAME { get; set; }
        public decimal ISADBRANCH { get; set; }
        public decimal BRANCHADCODE { get; set; }
        [Key]
        public string OFFICE_LIST_GUID { get; set; }
        public decimal SBS_CODE_GENERATED_BY_BB { get; set; }
        public decimal BANK_ID_GENERATED_BY_BB { get; set; }
        public decimal IS_CORPORATE1_BRANCH { get; set; }
    }
}