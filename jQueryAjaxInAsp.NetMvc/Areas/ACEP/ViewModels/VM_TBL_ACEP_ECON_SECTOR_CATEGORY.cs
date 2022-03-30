
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class VM_TBL_ACEP_ECON_SECTOR_CATEGORY : CommonViewModel
    {
        [DisplayName("Category Id")]
        public int ES_CATEGORY_ID { get; set; }

        [DisplayName("Category Name")]
        public string ES_CATEGORY_NAME { get; set; }

    }
}