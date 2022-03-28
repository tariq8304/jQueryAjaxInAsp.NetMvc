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
    public class DataEntryStatusController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/DataEntryStatus
        public async Task<ActionResult> Index()
        {
            return View(await db.TBL_ACEP_DATA_ENTRY_STATUS.ToListAsync());
        }

        // GET: ACEP/DataEntryStatus/Details/5
        public async Task<ActionResult> Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS = await db.TBL_ACEP_DATA_ENTRY_STATUS.FindAsync(id);
            if (tBL_ACEP_DATA_ENTRY_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_DATA_ENTRY_STATUS);
        }

        // GET: ACEP/DataEntryStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACEP/DataEntryStatus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "STATUS_ID,STATUS_NAME")] TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS)
        {
            if (ModelState.IsValid)
            {
                db.TBL_ACEP_DATA_ENTRY_STATUS.Add(tBL_ACEP_DATA_ENTRY_STATUS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tBL_ACEP_DATA_ENTRY_STATUS);
        }

        // GET: ACEP/DataEntryStatus/Edit/5
        public async Task<ActionResult> Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS = await db.TBL_ACEP_DATA_ENTRY_STATUS.FindAsync(id);
            if (tBL_ACEP_DATA_ENTRY_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_DATA_ENTRY_STATUS);
        }

        // POST: ACEP/DataEntryStatus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "STATUS_ID,STATUS_NAME")] TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_ACEP_DATA_ENTRY_STATUS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tBL_ACEP_DATA_ENTRY_STATUS);
        }

        // GET: ACEP/DataEntryStatus/Delete/5
        public async Task<ActionResult> Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS = await db.TBL_ACEP_DATA_ENTRY_STATUS.FindAsync(id);
            if (tBL_ACEP_DATA_ENTRY_STATUS == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_DATA_ENTRY_STATUS);
        }

        // POST: ACEP/DataEntryStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(decimal id)
        {
            TBL_ACEP_DATA_ENTRY_STATUS tBL_ACEP_DATA_ENTRY_STATUS = await db.TBL_ACEP_DATA_ENTRY_STATUS.FindAsync(id);
            db.TBL_ACEP_DATA_ENTRY_STATUS.Remove(tBL_ACEP_DATA_ENTRY_STATUS);
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
