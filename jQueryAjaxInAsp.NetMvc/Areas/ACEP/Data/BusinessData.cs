using jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Data
{
    public class BusinessData
    {
        public static IQueryable<VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT> GetPurchaseDiscountList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       join b in db.TBL_RBL_OFFICE_LIST on a.OFFICE_ID equals b.OFFICEID
                       select new VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       {
                           BPD_GUID = a.BPD_GUID,
                           OFFICE_ID = a.OFFICE_ID,
                           OFFICE_NAME = b.RBL_OFFICENAME,
                           PERIOD = a.PERIOD,
                           BPD_AMOUNT = a.BPD_AMOUNT,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_CATEGORY> GetEconPurCategoryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_CATEGORY
                       select new VM_TBL_ACEP_ECON_PUR_CATEGORY
                       {
                           EP_CATEOGRY_ID = a.EP_CATEOGRY_ID,
                           EP_CATEOGRY_NAME = a.EP_CATEOGRY_NAME,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY> GetEconPurSubCategoryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_PUR_CATEGORY on a.EP_CATEGORY_ID equals b.EP_CATEOGRY_ID
                       select new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       {
                           EP_SUB_CATEGORY_ID = a.EP_SUB_CATEGORY_ID,
                           EP_SUB_CATEGORY_NAME = a.EP_SUB_CATEGORY_NAME,
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_Name = b.EP_CATEOGRY_NAME,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_TRANSACTION> GetEconPurTransactionList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_TRANSACTION
                       join c in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY on a.SUB_CAT_ID equals c.EP_SUB_CATEGORY_ID
                       join b in db.TBL_RBL_OFFICE_LIST on a.OFFICEID equals b.OFFICEID
                       select new VM_TBL_ACEP_ECON_PUR_TRANSACTION
                       {

                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           OFFICENAME = b.RBL_OFFICENAME,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
                           SUB_CAT_NAME = c.EP_SUB_CATEGORY_NAME,
                           SANCTION_LIMIT = a.SANCTION_LIMIT ?? 0,
                           DISBURSEMENT = a.DISBURSEMENT ?? 0,
                           RECOVERY = a.RECOVERY ?? 0,
                           SS = a.SS ?? 0,
                           DF = a.DF ?? 0,
                           BL = a.BL ?? 0,
                           SMA = a.SMA ?? 0,
                           SD = a.SD ?? 0,
                           OVERDUE = a.OVERDUE ?? 0,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_SECTOR_CATEGORY> GetEconSecCategoryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_SECTOR_CATEGORY
                       select new VM_TBL_ACEP_ECON_SECTOR_CATEGORY
                       {
                           ES_CATEGORY_ID = a.ES_CATEGORY_ID,
                           ES_CATEGORY_NAME = a.ES_CATEGORY_NAME,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY> GetEconSecSubCategoryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_SECTOR_CATEGORY on a.ES_CATEGORY_ID equals b.ES_CATEGORY_ID
                       select new VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       {
                           ES_SUB_CATEGORY_ID = a.ES_SUB_CATEGORY_ID,
                           ES_SUB_CATEGORY_NAME = a.ES_SUB_CATEGORY_NAME,
                           ES_CATEGORY_ID = a.ES_CATEGORY_ID,
                           ES_CATEGORY_NAME = b.ES_CATEGORY_NAME,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_TRANSACTION> GetEconSecTransactionList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_TRANSACTION
                       join c in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY on a.SUB_CAT_ID equals c.ES_SUB_CATEGORY_ID
                       join b in db.TBL_RBL_OFFICE_LIST on a.OFFICEID equals b.OFFICEID
                       select new VM_TBL_ACEP_ECON_SEC_TRANSACTION
                       {

                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           OFFICENAME = b.RBL_OFFICENAME,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
                           SUB_CAT_NAME = c.ES_SUB_CATEGORY_NAME,
                           SANCTION_LIMIT = a.SANCTION_LIMIT ?? 0,
                           DISBURSEMENT = a.DISBURSEMENT ?? 0,
                           RECOVERY = a.RECOVERY ?? 0,
                           SS = a.SS ?? 0,
                           DF = a.DF ?? 0,
                           BL = a.BL ?? 0,
                           SMA = a.SMA ?? 0,
                           SD = a.SD ?? 0,
                           OVERDUE = a.OVERDUE ?? 0,
                           CREATED_BY = a.CREATED_BY,
                           CREATION_DT = a.CREATION_DT,
                           EDITED_BY = a.EDITED_BY,
                           UPDATED_AT = a.UPDATED_AT,
                           SYSTEM_DT = a.SYSTEM_DT,
                           OPERATION_STATUS = a.OPERATION_STATUS,
                           AUTHORIZATION_STATUS = a.AUTHORIZATION_STATUS,
                           AUTHORIZED_BY = a.AUTHORIZED_BY,
                           AUTHORIZATION_DATE = a.AUTHORIZATION_DATE
                       };
            return data;
        }
    }
}