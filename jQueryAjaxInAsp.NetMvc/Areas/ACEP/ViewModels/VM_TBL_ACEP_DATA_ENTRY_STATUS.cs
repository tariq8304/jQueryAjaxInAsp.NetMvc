
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class VM_TBL_ACEP_DATA_ENTRY_STATUS
    {
        [Key]
        public decimal STATUS_ID { get; set; }
        public string STATUS_NAME { get; set; }
    }

}