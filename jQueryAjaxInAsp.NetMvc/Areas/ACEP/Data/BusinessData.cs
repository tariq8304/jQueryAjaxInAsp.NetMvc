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
                       orderby a.BPD_GUID
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

        public static IQueryable<VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT> GetPurchaseDiscountDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       where (a.BPD_GUID == id)
                       select new VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       {
                           BPD_GUID = a.BPD_GUID,
                           OFFICE_ID = a.OFFICE_ID,
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

        public static IQueryable<VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT> GetPurchaseDiscountEditList(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       where (a.BPD_GUID == id)
                       select new VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       {
                           BPD_GUID = a.BPD_GUID,
                           OFFICE_ID = a.OFFICE_ID,
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


        public static IQueryable<VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT> GetPurchaseDiscountDeleteDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       where (a.BPD_GUID == id)
                       select new VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT
                       {
                           BPD_GUID = a.BPD_GUID,
                           OFFICE_ID = a.OFFICE_ID,
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
                       orderby a.EP_CATEGORY_ID
                       select new VM_TBL_ACEP_ECON_PUR_CATEGORY
                       {
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_NAME = a.EP_CATEGORY_NAME,
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
                       join b in db.TBL_ACEP_ECON_PUR_CATEGORY on a.EP_CATEGORY_ID equals b.EP_CATEGORY_ID
                       orderby a.EP_SUB_CATEGORY_ID ascending
                       select new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       {
                           EP_SUB_CATEGORY_ID = a.EP_SUB_CATEGORY_ID,
                           EP_SUB_CATEGORY_NAME = a.EP_SUB_CATEGORY_NAME,
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_Name = b.EP_CATEGORY_NAME,
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
                       orderby a.SUB_CAT_ID ascending
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
                       orderby a.ES_CATEGORY_ID
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
                       orderby a.ES_SUB_CATEGORY_ID
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
                       orderby a.SUB_CAT_ID ascending
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_CATEGORY> GetEconPurCategoryDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_CATEGORY
                       where (a.EP_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_CATEGORY
                       {
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_NAME = a.EP_CATEGORY_NAME,
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

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_CATEGORY> GetEconPurCategoryDeleteDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_CATEGORY
                       where (a.EP_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_CATEGORY
                       {
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_NAME = a.EP_CATEGORY_NAME,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_CATEGORY> GetEconPurCategoryEditList(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_CATEGORY
                       where (a.EP_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_CATEGORY
                       {
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_NAME = a.EP_CATEGORY_NAME,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY> GetEconPurSubCategoryDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_PUR_CATEGORY on a.EP_CATEGORY_ID equals b.EP_CATEGORY_ID
                       where (a.EP_SUB_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       {
                           EP_SUB_CATEGORY_ID = a.EP_SUB_CATEGORY_ID,
                           EP_SUB_CATEGORY_NAME = a.EP_SUB_CATEGORY_NAME,
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_Name = b.EP_CATEGORY_NAME,
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

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY> GetEconPurSubCategoryEditList(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       where (a.EP_SUB_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       {
                           EP_SUB_CATEGORY_ID = a.EP_SUB_CATEGORY_ID,
                           EP_SUB_CATEGORY_NAME = a.EP_SUB_CATEGORY_NAME,
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY> GetEconPurSubCategoryDeleteDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_PUR_CATEGORY on a.EP_CATEGORY_ID equals b.EP_CATEGORY_ID
                       where (a.EP_SUB_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       {
                           EP_SUB_CATEGORY_ID = a.EP_SUB_CATEGORY_ID,
                           EP_SUB_CATEGORY_NAME = a.EP_SUB_CATEGORY_NAME,
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_Name = b.EP_CATEGORY_NAME,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_TRANSACTION> GetEconPurTransactionDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_TRANSACTION
                       join b in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY on a.SUB_CAT_ID equals b.EP_SUB_CATEGORY_ID
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_PUR_TRANSACTION
                       {

                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
                           SUB_CAT_NAME = b.EP_SUB_CATEGORY_NAME,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_TRANSACTION> GetEconPurTransactionEditList(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_TRANSACTION
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_PUR_TRANSACTION
                       {
                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
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


        public static IQueryable<VM_TBL_ACEP_ECON_PUR_TRANSACTION> GetEconPurTransactionDeleteDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_TRANSACTION
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_PUR_TRANSACTION
                       {
                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
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


        public static IQueryable<VM_TBL_ACEP_ECON_SECTOR_CATEGORY> GetEconSecCategoryDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SECTOR_CATEGORY
                       where (a.ES_CATEGORY_ID == id)
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

        public static IQueryable<VM_TBL_ACEP_ECON_SECTOR_CATEGORY> GetEconSecCategoryDeleteDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SECTOR_CATEGORY
                       where (a.ES_CATEGORY_ID == id)
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


        public static IQueryable<VM_TBL_ACEP_ECON_SECTOR_CATEGORY> GetEconSecCategoryEditList(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SECTOR_CATEGORY
                       where (a.ES_CATEGORY_ID == id)
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


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY> GetEconSecSubCategoryDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_SECTOR_CATEGORY on a.ES_CATEGORY_ID equals b.ES_CATEGORY_ID
                       where (a.ES_SUB_CATEGORY_ID == id)
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

        public static IQueryable<VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY> GetEconSecSubCategoryEditList(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       where (a.ES_SUB_CATEGORY_ID == id)
                       select new VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       {
                           ES_SUB_CATEGORY_ID = a.ES_SUB_CATEGORY_ID,
                           ES_SUB_CATEGORY_NAME = a.ES_SUB_CATEGORY_NAME,
                           ES_CATEGORY_ID = a.ES_CATEGORY_ID,
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


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY> GetEconSecSubCategoryDeleteDetails(ACEPDBContext db, int id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_SECTOR_CATEGORY on a.ES_CATEGORY_ID equals b.ES_CATEGORY_ID
                       where (a.ES_SUB_CATEGORY_ID == id)
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


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_TRANSACTION> GetEconSecTransactionDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_TRANSACTION
                       join b in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY on a.SUB_CAT_ID equals b.ES_SUB_CATEGORY_ID
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_SEC_TRANSACTION
                       {

                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
                           SUB_CAT_NAME = b.ES_SUB_CATEGORY_NAME,
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


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_TRANSACTION> GetEconSecTransactionEditList(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_TRANSACTION
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_SEC_TRANSACTION
                       {
                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
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


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_TRANSACTION> GetEconSecTransactionDeleteDetails(ACEPDBContext db, string id)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_TRANSACTION
                       join b in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY on a.SUB_CAT_ID equals b.ES_SUB_CATEGORY_ID
                       where (a.TXN_GUID == id)
                       select new VM_TBL_ACEP_ECON_SEC_TRANSACTION
                       {
                           TXN_GUID = a.TXN_GUID,
                           OFFICEID = a.OFFICEID,
                           PERIOD = a.PERIOD,
                           SUB_CAT_ID = a.SUB_CAT_ID,
                           SUB_CAT_NAME = b.ES_SUB_CATEGORY_NAME,
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

        public static List<DropDownEconPurCategory> GetEconPurDropDownCategorylist(ACEPDBContext db)
        {
            List<DropDownEconPurCategory> result = new List<DropDownEconPurCategory>();
            var obj = db.TBL_ACEP_ECON_PUR_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconPurCategory model = new DropDownEconPurCategory();
                    model.EP_CATEGORY_ID = data.EP_CATEGORY_ID;
                    model.EP_CATEGORY_Name = data.EP_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }

        public static List<DropDownEconPurSubCategory> GetEconPurDropDownSubCategorylist(ACEPDBContext db)
        {
            List<DropDownEconPurSubCategory> result = new List<DropDownEconPurSubCategory>();
            var obj = db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconPurSubCategory model = new DropDownEconPurSubCategory();
                    model.EP_SUB_CATEGORY_ID = data.EP_SUB_CATEGORY_ID;
                    model.EP_SUB_CATEGORY_NAME = data.EP_SUB_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }


        public static List<DropDownEconSecCategory> GetEconSecDropDownCategorylist(ACEPDBContext db)
        {
            List<DropDownEconSecCategory> result = new List<DropDownEconSecCategory>();
            var obj = db.TBL_ACEP_ECON_SECTOR_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconSecCategory model = new DropDownEconSecCategory();
                    model.ES_CATEGORY_ID = data.ES_CATEGORY_ID;
                    model.ES_CATEGORY_NAME = data.ES_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }

        public static List<DropDownEconSecSubCategory> GetEconSecDropDownSubCategorylist(ACEPDBContext db)
        {
            List<DropDownEconSecSubCategory> result = new List<DropDownEconSecSubCategory>();
            var obj = db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconSecSubCategory model = new DropDownEconSecSubCategory();
                    model.ES_SUB_CATEGORY_ID = data.ES_SUB_CATEGORY_ID;
                    model.ES_SUB_CATEGORY_NAME = data.ES_SUB_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }

        public static IQueryable<VM_TBL_ACEP_ECON_PUR_TRANSACTION_MULTIPLE> GetEconPurSubCategoryMultipleEntryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_PUR_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_PUR_CATEGORY on a.EP_CATEGORY_ID equals b.EP_CATEGORY_ID
                       orderby a.EP_CATEGORY_ID, a.EP_SUB_CATEGORY_ID
                       select new VM_TBL_ACEP_ECON_PUR_TRANSACTION_MULTIPLE
                       {
                           EP_CATEGORY_ID = a.EP_CATEGORY_ID,
                           EP_CATEGORY_NAME = b.EP_CATEGORY_NAME,
                           SUB_CAT_ID = a.EP_SUB_CATEGORY_ID,
                           SUB_CAT_NAME = a.EP_SUB_CATEGORY_NAME
                       };

            return data;
        }


        public static IQueryable<VM_TBL_ACEP_ECON_SEC_TRANSACTION_MULTIPLE> GetEconSecSubCategoryMultipleEntryList(ACEPDBContext db)
        {
            var data = from a in db.TBL_ACEP_ECON_SEC_SUB_CATEGORY
                       join b in db.TBL_ACEP_ECON_SECTOR_CATEGORY on a.ES_CATEGORY_ID equals b.ES_CATEGORY_ID
                       orderby a.ES_CATEGORY_ID, a.ES_SUB_CATEGORY_ID
                       select new VM_TBL_ACEP_ECON_SEC_TRANSACTION_MULTIPLE
                       {
                           ES_CATEGORY_ID = a.ES_CATEGORY_ID,
                           ES_CATEGORY_NAME = b.ES_CATEGORY_NAME,
                           SUB_CAT_ID = a.ES_SUB_CATEGORY_ID,
                           SUB_CAT_NAME = a.ES_SUB_CATEGORY_NAME
                       };

            return data;
        }

        public static List<DropDownEconPurCategory> GetEconPurCategoryMultipleInput(ACEPDBContext db)
        {
            List<DropDownEconPurCategory> result = new List<DropDownEconPurCategory>();
            var obj = db.TBL_ACEP_ECON_PUR_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconPurCategory model = new DropDownEconPurCategory();
                    model.EP_CATEGORY_ID = data.EP_CATEGORY_ID;
                    model.EP_CATEGORY_Name = data.EP_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }


        public static List<DropDownEconSecCategory> GetEconSecCategoryMultipleInput(ACEPDBContext db)
        {
            List<DropDownEconSecCategory> result = new List<DropDownEconSecCategory>();
            var obj = db.TBL_ACEP_ECON_SECTOR_CATEGORY.Select(u => u).ToList();
            if (obj != null && obj.Count() > 0)
            {
                foreach (var data in obj)
                {
                    DropDownEconSecCategory model = new DropDownEconSecCategory();
                    model.ES_CATEGORY_ID = data.ES_CATEGORY_ID;
                    model.ES_CATEGORY_NAME = data.ES_CATEGORY_NAME;
                    result.Add(model);
                }
            }

            return result;
        }


    }

}