using System;
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_REPORTING_CONFIG : CommonViewModel
	{
		public DateTime? CURRENT_PERIOD { get; set; }
		public decimal? BANK_ID_BY_BB { get; set; }
		public decimal? IS_ACTIVE { get; set; } 
		public string ACEP_REPORTING_CONFIG_GUID { get; set; } 
		public decimal? IS_ENTRY_ENABLE { get; set; }
		public decimal? OFFICE_ID { get; set; }
		public decimal? RBL_BRANCH_CODE { get; set; }
	}
}