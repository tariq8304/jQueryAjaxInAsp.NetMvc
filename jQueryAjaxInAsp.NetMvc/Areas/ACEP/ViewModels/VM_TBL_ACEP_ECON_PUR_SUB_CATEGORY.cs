
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels
{
    public class VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY : CommonViewModel
    {
        [DisplayName("Sub Category ID")]
        public int EP_SUB_CATEGORY_ID { get; set; }


        [DisplayName("Sub Category Name")]
        [Required(ErrorMessage = "Please enter Sub Category Name")]
        public string EP_SUB_CATEGORY_NAME { get; set; }


        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Please enter Category Name")]
        public int? EP_CATEGORY_ID { get; set; }


        [DisplayName("Category Name")]
        public string EP_CATEGORY_Name { get; set; }

        public List<DropDownEconPurCategory> DropDownEconPurCategoryList { get; set; }
        public List<DropDownEconPurSubCategory> DropDownEconPurSubCategoryList { get; set; }


    }

    public class DropDownEconPurCategory
    {
        public int? EP_CATEGORY_ID { get; set; }
        public string EP_CATEGORY_Name { get; set; }
    }

    public class DropDownEconPurSubCategory
    {

        public int EP_SUB_CATEGORY_ID { get; set; }
        public string EP_SUB_CATEGORY_NAME { get; set; }
    }
}