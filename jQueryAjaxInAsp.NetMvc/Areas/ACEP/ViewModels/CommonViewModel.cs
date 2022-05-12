using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class CommonViewModel
    {
        [DisplayName("Created By")]
        public string CREATED_BY { get; set; }

        [DisplayName("Creation Date")]
        public DateTime? CREATION_DT { get; set; }

        [DisplayName("Edited By")]
        public string EDITED_BY { get; set; }

        [DisplayName("Updated At")]
        public DateTime? UPDATED_AT { get; set; }

        [DisplayName("System Date")]
        public DateTime? SYSTEM_DT { get; set; }

        [DisplayName("Operation Status")]
        public decimal? OPERATION_STATUS { get; set; }

        [DisplayName("Authorization Status")]
        public decimal? AUTHORIZATION_STATUS { get; set; }

        [DisplayName("Authorized By")]
        public string AUTHORIZED_BY { get; set; }

        [DisplayName("Authorization Date")]
        public DateTime? AUTHORIZATION_DATE { get; set; }

    }
}