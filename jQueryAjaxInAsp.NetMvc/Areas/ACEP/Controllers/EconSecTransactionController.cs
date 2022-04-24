using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jQueryAjaxInAsp.NetMvc.Areas.ACEP.Data;
using jQueryAjaxInAsp.NetMvc.Areas.ACEP.Model;
using jQueryAjaxInAsp.NetMvc.Areas.ACEP.ViewModels;

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Controllers
{
    public class EconSecTransactionController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/EconSecTransaction
        public async Task<ActionResult> Index()
        {
            var result = await BusinessData.GetEconSecTransactionList(db).ToListAsync();
            return View(result);
        }

        // GET: ACEP/EconSecTransaction/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            var result = await BusinessData.GetEconSecTransactionDetails(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: ACEP/EconSecTransaction/Create
        public ActionResult Create()
        {
            ViewBag.SubCategoryDropDown = new SelectList(BusinessData.GetEconSecDropDownSubCategorylist(db).ToList(), "ES_SUB_CATEGORY_ID", "ES_SUB_CATEGORY_NAME");
            return View();
        }

        // POST: ACEP/EconSecTransaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "OFFICEID,PERIOD,SUB_CAT_ID,SANCTION_LIMIT,DISBURSEMENT,RECOVERY,SS,DF,BL,SMA,SD,OVERDUE,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_SEC_TRANSACTION obj_vm)
        {
            //tBL_ACEP_ECON_SEC_TRANSACTION.TXN_GUID = Guid.NewGuid().ToString();

            obj_vm.TXN_GUID = Guid.NewGuid().ToString();
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_SEC_TRANSACTION()
                {
                    TXN_GUID = obj_vm.TXN_GUID,
                    OFFICEID = obj_vm.OFFICEID,
                    PERIOD = obj_vm.PERIOD,
                    SUB_CAT_ID = obj_vm.SUB_CAT_ID,
                    SANCTION_LIMIT = obj_vm.SANCTION_LIMIT,
                    DISBURSEMENT = obj_vm.DISBURSEMENT,
                    RECOVERY = obj_vm.RECOVERY,
                    SS = obj_vm.SS,
                    DF = obj_vm.DF,
                    BL = obj_vm.BL,
                    SMA = obj_vm.SMA,
                    SD = obj_vm.SD,
                    OVERDUE = obj_vm.OVERDUE,
                    CREATED_BY = obj_vm.CREATED_BY,
                    CREATION_DT = obj_vm.CREATION_DT,
                    EDITED_BY = obj_vm.EDITED_BY,
                    UPDATED_AT = obj_vm.UPDATED_AT,
                    SYSTEM_DT = obj_vm.SYSTEM_DT,
                    OPERATION_STATUS = obj_vm.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = obj_vm.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = obj_vm.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = obj_vm.AUTHORIZATION_DATE
                };

                db.TBL_ACEP_ECON_SEC_TRANSACTION.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj_vm);
        }

        #region Create Multiple
        public async Task<ActionResult> CreateMultiple()
        {
            var obj = await BusinessData.GetEconSecSubCategoryMultipleEntryList(db).ToListAsync();
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateMultiple(List<VM_TBL_ACEP_ECON_SEC_TRANSACTION_MULTIPLE> obj_vm)
        {
            foreach (VM_TBL_ACEP_ECON_SEC_TRANSACTION_MULTIPLE mr in obj_vm)
            {
                mr.TXN_GUID = Guid.NewGuid().ToString();
                //db.TBL_ACEP_ECON_PUR_TRANSACTION.Add(tBL_ACEP_ECON_PUR_TRANSACTION);

                var model = new TBL_ACEP_ECON_SEC_TRANSACTION
                {
                    TXN_GUID = mr.TXN_GUID,
                    OFFICEID = mr.OFFICEID,
                    PERIOD = mr.PERIOD,
                    SUB_CAT_ID = mr.SUB_CAT_ID,
                    SANCTION_LIMIT = mr.SANCTION_LIMIT,
                    DISBURSEMENT = mr.DISBURSEMENT,
                    RECOVERY = mr.RECOVERY,
                    SS = mr.SS,
                    DF = mr.DF,
                    BL = mr.BL,
                    SMA = mr.SMA,
                    SD = mr.SD,
                    OVERDUE = mr.OVERDUE,
                    CREATED_BY = mr.CREATED_BY,
                    CREATION_DT = mr.CREATION_DT,
                    EDITED_BY = mr.EDITED_BY,
                    UPDATED_AT = mr.UPDATED_AT,
                    SYSTEM_DT = mr.SYSTEM_DT,
                    OPERATION_STATUS = mr.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = mr.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = mr.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = mr.AUTHORIZATION_DATE
                };
                db.TBL_ACEP_ECON_SEC_TRANSACTION.Add(model);
                await db.SaveChangesAsync();

                //await db.SaveChangesAsync();
                //try
                //{
                //    await db.SaveChangesAsync();
                //}

                //catch(DbEntityValidationException e)
                //{
                //    Console.WriteLine(e);
                //}


            }

            return RedirectToAction("Index");
            //return View(obj_vm);

        }
        #endregion

        // GET: ACEP/EconSecTransaction/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            ViewBag.SubCategoryDropDown = new SelectList(BusinessData.GetEconSecDropDownSubCategorylist(db).ToList(), "ES_SUB_CATEGORY_ID", "ES_SUB_CATEGORY_NAME");

            var result = await BusinessData.GetEconSecTransactionEditList(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconSecTransaction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TXN_GUID,OFFICEID,PERIOD,SUB_CAT_ID,SANCTION_LIMIT,DISBURSEMENT,RECOVERY,SS,DF,BL,SMA,SD,OVERDUE,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_SEC_TRANSACTION obj_vm)
        {
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_SEC_TRANSACTION
                {
                    TXN_GUID = obj_vm.TXN_GUID,
                    OFFICEID = obj_vm.OFFICEID,
                    PERIOD = obj_vm.PERIOD,
                    SUB_CAT_ID = obj_vm.SUB_CAT_ID,
                    SANCTION_LIMIT = obj_vm.SANCTION_LIMIT,
                    DISBURSEMENT = obj_vm.DISBURSEMENT,
                    RECOVERY = obj_vm.RECOVERY,
                    SS = obj_vm.SS,
                    DF = obj_vm.DF,
                    BL = obj_vm.BL,
                    SMA = obj_vm.SMA,
                    SD = obj_vm.SD,
                    OVERDUE = obj_vm.OVERDUE,
                    CREATED_BY = obj_vm.CREATED_BY,
                    CREATION_DT = obj_vm.CREATION_DT,
                    EDITED_BY = obj_vm.EDITED_BY,
                    UPDATED_AT = obj_vm.UPDATED_AT,
                    SYSTEM_DT = obj_vm.SYSTEM_DT,
                    OPERATION_STATUS = obj_vm.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = obj_vm.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = obj_vm.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = obj_vm.AUTHORIZATION_DATE
                };


                db.Entry(model).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj_vm);
        }

        // GET: ACEP/EconSecTransaction/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            var result = await BusinessData.GetEconSecTransactionDeleteDetails(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconSecTransaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            TBL_ACEP_ECON_SEC_TRANSACTION tBL_ACEP_ECON_SEC_TRANSACTION = await db.TBL_ACEP_ECON_SEC_TRANSACTION.FindAsync(id);
            db.TBL_ACEP_ECON_SEC_TRANSACTION.Remove(tBL_ACEP_ECON_SEC_TRANSACTION);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public async Task<ActionResult> GetEconTranDTList()
        {
            var result = await BusinessData.GetEconSecTransactionList(db).ToListAsync();
            return Json(new { data = result }, JsonRequestBehavior.AllowGet);
        }
    }
}
