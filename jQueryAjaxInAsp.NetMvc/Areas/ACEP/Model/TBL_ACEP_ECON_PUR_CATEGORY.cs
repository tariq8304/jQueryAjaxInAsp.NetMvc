
using System;
using System.ComponentModel.DataAnnotations;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
	public class TBL_ACEP_ECON_PUR_CATEGORY
	{
		[Key]
		public int EP_CATEOGRY_ID { get; set; }
		public string EP_CATEOGRY_NAME { get; set; }
		public string CREATED_BY { get; set; }
		public DateTime CREATION_DT { get; set; }
		public string EDITED_BY { get; set; }
		public DateTime UPDATED_AT { get; set; }
		public DateTime SYSTEM_DT { get; set; }
		public decimal OPERATION_STATUS { get; set; }
		public decimal AUTHORIZATION_STATUS { get; set; }
		public string AUTHORIZED_BY { get; set; }
		public DateTime AUTHORIZATION_DATE { get; set; }
	}
}