
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_ECON_PUR_CATEGORY : CommonViewModel
	{
		[DisplayName("Category Id")]
		public int EP_CATEOGRY_ID { get; set; }
		[DisplayName("Category Name")]
		public string EP_CATEOGRY_NAME { get; set; }
		 
	}
}