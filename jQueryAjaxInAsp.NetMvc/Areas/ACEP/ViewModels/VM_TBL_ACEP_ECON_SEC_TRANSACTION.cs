
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
	public class VM_TBL_ACEP_ECON_SEC_TRANSACTION : CommonViewModel
	{
		 
		public string TXN_GUID { get; set; }


		[DisplayName("Office ID")]
		public int? OFFICEID { get; set; }

		[DisplayName("Office Name")]
		public string OFFICENAME { get; set; }

		[DisplayName("Reporting Date")]
		public DateTime? PERIOD { get; set; }

		public int? SUB_CAT_ID { get; set; }

		[DisplayName("Sub Category Name")]
		public string SUB_CAT_NAME { get; set; }

		[Required(ErrorMessage = "Please enter Sanction Limit Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Sanction Limit Amount {0} must be greater than {1}.")]
		[DisplayName("Sanction Limit")]
		public decimal? SANCTION_LIMIT { get; set; }

		[Required(ErrorMessage = "Please enter Disbursement Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Disbursement Amount {0} must be greater than {1}.")]
		[DisplayName("Disbursement")]
		public decimal? DISBURSEMENT { get; set; }

		[Required(ErrorMessage = "Please enter Recovery Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Recovery Amount {0} must be greater than {1}.")]
		[DisplayName("Recovery")]
		public decimal? RECOVERY { get; set; }

		[Required(ErrorMessage = "Please enter Sub Standard (SS) Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Sub Standard (SS) Amount {0} must be greater than {1}.")]
		[DisplayName("Sub Standard (SS)")]
		public decimal? SS { get; set; }

		[Required(ErrorMessage = "Please enter Doubtful (DF) Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Doubtful (DF) Amount {0} must be greater than {1}.")]
		[DisplayName("Doubtful (DF)")]
		public decimal? DF { get; set; }

		[Required(ErrorMessage = "Please enter Bad And Loss (BL) Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Bad And Loss (BL) Amount {0} must be greater than {1}.")]
		[DisplayName("Bad And Loss (BL)")]
		public decimal? BL { get; set; }

		[Required(ErrorMessage = "Please enter Special Mention Account (SMA) Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Special Mention Account (SMA) Amount {0} must be greater than {1}.")]
		[DisplayName("Special Mention Account (SMA)")]
		public decimal? SMA { get; set; }

		[Required(ErrorMessage = "Please enter Standard (SD) Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Special Standard (SD) Amount {0} must be greater than {1}.")]
		[DisplayName("Standard (SD)")]
		public decimal? SD { get; set; }

		[Required(ErrorMessage = "Please enter Overdue Amount")]
		[Range(0, double.MaxValue, ErrorMessage = "The Special Overdue Amount {0} must be greater than {1}.")]
		[DisplayName("Overdue")]
		public decimal? OVERDUE { get; set; }
	 
	}
}