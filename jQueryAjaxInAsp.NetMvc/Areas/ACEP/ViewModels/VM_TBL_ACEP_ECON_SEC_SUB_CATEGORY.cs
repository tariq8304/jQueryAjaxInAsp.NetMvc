
using System;
using System.Collections.Generic;
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
		[Required(ErrorMessage = "Please enter Sub Category Name")]
		public string ES_SUB_CATEGORY_NAME { get; set; }

		[DisplayName("Category ID")]
		[Required(ErrorMessage = "Please enter Category Name")]
		public int? ES_CATEGORY_ID { get; set; }

		[DisplayName("Category Name")]
		public string ES_CATEGORY_NAME { get; set; }

		public List<DropDownEconSecCategory> DropDownEconSecCategoryList { get; set; }
		public List<DropDownEconSecSubCategory> DropDownEconSecSubCategoryList { get; set; }
	}

	public class DropDownEconSecCategory
	{
		public int ES_CATEGORY_ID { get; set; }
		public string ES_CATEGORY_NAME { get; set; }
	}

	public class DropDownEconSecSubCategory
	{

		public int ES_SUB_CATEGORY_ID { get; set; }
		public string ES_SUB_CATEGORY_NAME { get; set; }
	}
}