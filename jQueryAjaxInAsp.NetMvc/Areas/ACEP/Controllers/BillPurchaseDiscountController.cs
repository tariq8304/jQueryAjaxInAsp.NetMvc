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

namespace jQueryAjaxInAsp.NetMvc.Areas.ACEP.Controllers
{
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
            TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT = await db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.FindAsync(id);
            if (tBL_ACEP_BILL_PURCHASE_DISCOUNT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
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
        public async Task<ActionResult> Create([Bind(Include = "BPD_GUID,OFFICE_ID,PERIOD,BPD_AMOUNT,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT)
        {
            if (ModelState.IsValid)
            {
                db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.Add(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
        }

        // GET: ACEP/BillPurchaseDiscount/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT = await db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.FindAsync(id);
            if (tBL_ACEP_BILL_PURCHASE_DISCOUNT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
        }

        // POST: ACEP/BillPurchaseDiscount/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BPD_GUID,OFFICE_ID,PERIOD,BPD_AMOUNT,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_ACEP_BILL_PURCHASE_DISCOUNT).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
        }

        // GET: ACEP/BillPurchaseDiscount/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_BILL_PURCHASE_DISCOUNT tBL_ACEP_BILL_PURCHASE_DISCOUNT = await db.TBL_ACEP_BILL_PURCHASE_DISCOUNT.FindAsync(id);
            if (tBL_ACEP_BILL_PURCHASE_DISCOUNT == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_BILL_PURCHASE_DISCOUNT);
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
