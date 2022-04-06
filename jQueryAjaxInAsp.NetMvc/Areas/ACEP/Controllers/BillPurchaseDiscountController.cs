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
    [Authorize]
    public class BillPurchaseDiscountController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/BillPurchaseDiscount
        public async Task<ActionResult> Index()
        {
            var result = await BusinessData.GetPurchaseDiscountList(db).ToListAsync();
            return View(result);
        }

        // GET: ACEP/BillPurchaseDiscount/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            var result = await BusinessData.GetPurchaseDiscountDetails(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: ACEP/BillPurchaseDiscount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACEP/BillPurchaseDiscount/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BPD_GUID,OFFICE_ID,PERIOD,BPD_AMOUNT,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT obj_vm)
        {
            obj_vm.BPD_GUID = Guid.NewGuid().ToString();
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_BILL_PURCHASE_DISCOUNT()
                {
                    BPD_GUID = obj_vm.BPD_GUID,
                    OFFICE_ID = obj_vm.OFFICE_ID,
                    PERIOD = obj_vm.PERIOD,
                    BPD_AMOUNT = obj_vm.BPD_AMOUNT,
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

                db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj_vm);
        }

        // GET: ACEP/BillPurchaseDiscount/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            var result = await BusinessData.GetPurchaseDiscountEditList(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/BillPurchaseDiscount/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BPD_GUID,OFFICE_ID,PERIOD,BPD_AMOUNT,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_BILL_PURCHASE_DISCOUNT obj_vm)
        {
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_BILL_PURCHASE_DISCOUNT
                {
                    BPD_GUID = obj_vm.BPD_GUID,
                    OFFICE_ID = obj_vm.OFFICE_ID,
                    PERIOD = obj_vm.PERIOD,
                    BPD_AMOUNT = obj_vm.BPD_AMOUNT,
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

        // GET: ACEP/BillPurchaseDiscount/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TBL_ACEP_ECON_PUR_TRANSACTION tBL_ACEP_ECON_PUR_TRANSACTION = await db.TBL_ACEP_ECON_PUR_TRANSACTION.FindAsync(id);

            var result = await BusinessData.GetPurchaseDiscountDeleteDetails(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/BillPurchaseDiscount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT = await db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.FindAsync(id);
            db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.Remove(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
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
    }
}
