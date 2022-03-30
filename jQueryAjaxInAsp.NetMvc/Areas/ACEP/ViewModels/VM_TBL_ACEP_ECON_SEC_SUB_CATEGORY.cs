
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY : CommonViewModel
	{
		[DisplayName("Sub Category ID")]
		public int ES_SUB_CATEGORY_ID { get; set; }

		[DisplayName("Sub Category Name")]
		public string ES_SUB_CATEGORY_NAME { get; set; }

		[DisplayName("Category ID")]
		public int? ES_CATEGORY_ID { get; set; }

		[DisplayName("Category Name")]
		public string ES_CATEGORY_NAME { get; set; }


	}
}