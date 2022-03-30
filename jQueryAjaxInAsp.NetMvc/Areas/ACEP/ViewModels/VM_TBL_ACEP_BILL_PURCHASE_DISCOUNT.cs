using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT : CommonViewModel
    {

        public string BPD_GUID { get; set; }

        
        [DisplayName("Branch ID")]
        public int OFFICE_ID { get; set; }
        
        
        [DisplayName("Branch Name")]
        public string OFFICE_NAME { get; set; }

        
        [DisplayName("Period")]
        public DateTime? PERIOD { get; set; }

        [Required(ErrorMessage = "Please enter BPD Amount")]
        [Range(0, double.MaxValue, ErrorMessage = "The BPD Amount {0} must be greater than {1}.")]
        [DisplayName("BPD Amount(TK)")]
        public decimal? BPD_AMOUNT { get; set; }        
    }

}