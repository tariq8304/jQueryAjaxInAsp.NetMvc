
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY : CommonViewModel
	{
		[DisplayName("Sub Category ID")]
		public int EP_SUB_CATEGORY_ID { get; set; }


		[DisplayName("Sub Category Name")]
		public string EP_SUB_CATEGORY_NAME { get; set; }


		[DisplayName("Category Id")]
		public int? EP_CATEGORY_ID { get; set; }


		[DisplayName("Category Name")]
		public string EP_CATEGORY_Name { get; set; }

	}
}