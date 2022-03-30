
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
	public class TBL_ACEP_ECON_SEC_SUB_CATEGORY
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ES_SUB_CATEGORY_ID { get; set; }
		public string ES_SUB_CATEGORY_NAME { get; set; }
		public int? ES_CATEGORY_ID { get; set; }
		public string CREATED_BY { get; set; }
		public DateTime? CREATION_DT { get; set; }
		public string EDITED_BY { get; set; }
		public DateTime? UPDATED_AT { get; set; }
		public DateTime? SYSTEM_DT { get; set; }
		public decimal? OPERATION_STATUS { get; set; }
		public decimal? AUTHORIZATION_STATUS { get; set; }
		public string AUTHORIZED_BY { get; set; }
		public DateTime? AUTHORIZATION_DATE { get; set; }
	}
}