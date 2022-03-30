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
    public class EconSecSubCategoryController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/EconSecSubCategory
        public async Task<ActionResult> Index()
        {
            return View(await db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.ToListAsync());
        }

        // GET: ACEP/EconSecSubCategory/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY = await db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.FindAsync(id);
            if (tBL_ACEP_ECON_SEC_SUB_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
        }

        // GET: ACEP/EconSecSubCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACEP/EconSecSubCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ES_SUB_CATEGORY_NAME,ES_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY)
        {
            int max_sub_cat_id = db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Select(p => p.ES_SUB_CATEGORY_ID).DefaultIfEmpty(0).Max() + 1;
            tBL_ACEP_ECON_SEC_SUB_CATEGORY.ES_SUB_CATEGORY_ID = max_sub_cat_id;

            if (ModelState.IsValid)
            {
                db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Add(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
        }

        // GET: ACEP/EconSecSubCategory/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY = await db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.FindAsync(id);
            if (tBL_ACEP_ECON_SEC_SUB_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
        }

        // POST: ACEP/EconSecSubCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ES_SUB_CATEGORY_ID,ES_SUB_CATEGORY_NAME,ES_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_ACEP_ECON_SEC_SUB_CATEGORY).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
        }

        // GET: ACEP/EconSecSubCategory/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY = await db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.FindAsync(id);
            if (tBL_ACEP_ECON_SEC_SUB_CATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
        }

        // POST: ACEP/EconSecSubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TBL_ACEP_ECON_SEC_SUB_CATEGORY tBL_ACEP_ECON_SEC_SUB_CATEGORY = await db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.FindAsync(id);
            db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Remove(tBL_ACEP_ECON_SEC_SUB_CATEGORY);
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
