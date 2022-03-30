using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class CommonViewModel
    {

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