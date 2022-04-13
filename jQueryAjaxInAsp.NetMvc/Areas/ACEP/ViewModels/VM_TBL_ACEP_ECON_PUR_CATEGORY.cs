
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_ECON_PUR_CATEGORY : CommonViewModel
	{
		[DisplayName("Category Id")]
		public int EP_CATEGORY_ID { get; set; }

		[Required(ErrorMessage = "Please Enter Category Name")]
		[DisplayName("Category Name")]
		public string EP_CATEGORY_NAME { get; set; }

        internal Task FirstOrDefaultAsync()
        {
            throw new NotImplementedException();
        }
    }
}