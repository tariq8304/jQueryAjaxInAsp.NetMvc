
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model
{
	public class TBL_ACEP_ECON_SEC_TRANSACTION
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public string TXN_GUID { get; set; }
		public int? OFFICEID { get; set; }
		public DateTime? PERIOD { get; set; }
		public int? SUB_CAT_ID { get; set; }
		public decimal? SANCTION_LIMIT { get; set; }
		public decimal? DISBURSEMENT { get; set; }
		public decimal? RECOVERY { get; set; }
		public decimal? SS { get; set; }
		public decimal? DF { get; set; }
		public decimal? BL { get; set; }
		public decimal? SMA { get; set; }
		public decimal? SD { get; set; }
		public decimal? OVERDUE { get; set; }
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