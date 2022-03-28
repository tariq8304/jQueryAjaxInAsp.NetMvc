
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
    public class TBL_ACEP_DATA_ENTRY_STATUS
    {
        [Key]
        public decimal STATUS_ID { get; set; }
        public string STATUS_NAME { get; set; }
    }

}