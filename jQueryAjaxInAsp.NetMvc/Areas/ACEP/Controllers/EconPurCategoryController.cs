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
    public class EconPurCategoryController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/EconPurCategory
        public async Task<ActionResult> Index()
        {
            var result = await BusinessData.GetEconPurCategoryList(db).ToListAsync();
            return View(result);
        }

        // GET: ACEP/EconPurCategory/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = await BusinessData.GetEconPurCategoryDetails(db, id).FirstOrDefaultAsync();

            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: ACEP/EconPurCategory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ACEP/EconPurCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EP_CATEOGRY_NAME,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_PUR_CATEGORY obj_vm_cat)
        {
            int max_cat_id = db.TBL_ACEP_ECON_PUR_CATEGORY.Select(p => p.EP_CATEGORY_ID).DefaultIfEmpty(0).Max() + 1;
            obj_vm_cat.EP_CATEGORY_ID = max_cat_id;
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_PUR_CATEGORY
                {
                    EP_CATEGORY_ID = obj_vm_cat.EP_CATEGORY_ID,
                    EP_CATEGORY_NAME = obj_vm_cat.EP_CATEGORY_NAME,
                    CREATED_BY = obj_vm_cat.CREATED_BY,
                    CREATION_DT = obj_vm_cat.CREATION_DT,
                    EDITED_BY = obj_vm_cat.EDITED_BY,
                    UPDATED_AT = obj_vm_cat.UPDATED_AT,
                    SYSTEM_DT = obj_vm_cat.SYSTEM_DT,
                    OPERATION_STATUS = obj_vm_cat.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = obj_vm_cat.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = obj_vm_cat.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = obj_vm_cat.AUTHORIZATION_DATE
                };

                db.TBL_ACEP_ECON_PUR_CATEGORY.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj_vm_cat);
        }

        // GET: ACEP/EconPurCategory/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = await BusinessData.GetEconPurCategoryEditList(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconPurCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EP_CATEGORY_ID,EP_CATEGORY_NAME,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_PUR_CATEGORY obj_vm)
        {
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_PUR_CATEGORY()
                {
                    EP_CATEGORY_ID = obj_vm.EP_CATEGORY_ID,
                    EP_CATEGORY_NAME = obj_vm.EP_CATEGORY_NAME,
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

        // GET: ACEP/EconPurCategory/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var result = await BusinessData.GetEconPurCategoryDeleteDetails(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconPurCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TBL_ACEP_ECON_PUR_CATEGORY tBL_ACEP_ECON_PUR_CATEGORY = await db.TBL_ACEP_ECON_PUR_CATEGORY.FindAsync(id);
            db.TBL_ACEP_ECON_PUR_CATEGORY.Remove(tBL_ACEP_ECON_PUR_CATEGORY);
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
