using System;
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
	public class TBL_ACEP_REPORTING_CONFIG
	{
		public DateTime CURRENT_PERIOD { get; set; }
		public decimal BANK_ID_BY_BB { get; set; }
		public decimal IS_ACTIVE { get; set; }
		[Key]
		public string ACEP_REPORTING_CONFIG_GUID { get; set; }
		public string CREATED_BY { get; set; }
		public DateTime CREATION_DT { get; set; }
		public string EDITED_BY { get; set; }
		public DateTime UPDATED_AT { get; set; }
		public DateTime SYSTEM_DT { get; set; }
		public decimal OPERATION_STATUS { get; set; }
		public decimal AUTHORIZATION_STATUS { get; set; }
		public string AUTHORIZED_BY { get; set; }
		public DateTime AUTHORIZATION_DATE { get; set; }
		public decimal IS_ENTRY_ENABLE { get; set; }
		public decimal OFFICE_ID { get; set; }
		public decimal RBL_BRANCH_CODE { get; set; }
	}
}