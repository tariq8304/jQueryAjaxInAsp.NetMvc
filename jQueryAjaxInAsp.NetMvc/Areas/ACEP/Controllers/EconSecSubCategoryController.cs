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
    public class EconSecSubCategoryController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/EconSecSubCategory
        public async Task<ActionResult> Index()
        {
            var result = await BusinessData.GetEconSecSubCategoryList(db).ToListAsync();
            return View(result);
        }

        // GET: ACEP/EconSecSubCategory/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = await BusinessData.GetEconSecSubCategoryDetails(db, id).FirstOrDefaultAsync();

            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
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
        public async Task<ActionResult> Create([Bind(Include = "ES_SUB_CATEGORY_NAME,ES_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY obj_vm_sub_cat)
        {
            int max_sub_cat_id = db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Select(p => p.ES_SUB_CATEGORY_ID).DefaultIfEmpty(0).Max() + 1;
            obj_vm_sub_cat.ES_SUB_CATEGORY_ID = max_sub_cat_id;
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_SEC_SUB_CATEGORY
                {
                    ES_SUB_CATEGORY_ID = obj_vm_sub_cat.ES_SUB_CATEGORY_ID,
                    ES_SUB_CATEGORY_NAME = obj_vm_sub_cat.ES_SUB_CATEGORY_NAME,
                    ES_CATEGORY_ID = obj_vm_sub_cat.ES_CATEGORY_ID,
                    CREATED_BY = obj_vm_sub_cat.CREATED_BY,
                    CREATION_DT = obj_vm_sub_cat.CREATION_DT,
                    EDITED_BY = obj_vm_sub_cat.EDITED_BY,
                    UPDATED_AT = obj_vm_sub_cat.UPDATED_AT,
                    SYSTEM_DT = obj_vm_sub_cat.SYSTEM_DT,
                    OPERATION_STATUS = obj_vm_sub_cat.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = obj_vm_sub_cat.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = obj_vm_sub_cat.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = obj_vm_sub_cat.AUTHORIZATION_DATE
                };


                db.TBL_ACEP_ECON_SEC_SUB_CATEGORY.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj_vm_sub_cat);
        }

        // GET: ACEP/EconSecSubCategory/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);

            var result = await BusinessData.GetEconSecSubCategoryEditList(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconSecSubCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ES_SUB_CATEGORY_ID,ES_SUB_CATEGORY_NAME,ES_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_SEC_SUB_CATEGORY obj_vm_sub_cat)
        {
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_SEC_SUB_CATEGORY
                {
                    ES_SUB_CATEGORY_ID = obj_vm_sub_cat.ES_SUB_CATEGORY_ID,
                    ES_SUB_CATEGORY_NAME = obj_vm_sub_cat.ES_SUB_CATEGORY_NAME,
                    ES_CATEGORY_ID = obj_vm_sub_cat.ES_CATEGORY_ID,
                    CREATED_BY = obj_vm_sub_cat.CREATED_BY,
                    CREATION_DT = obj_vm_sub_cat.CREATION_DT,
                    EDITED_BY = obj_vm_sub_cat.EDITED_BY,
                    UPDATED_AT = obj_vm_sub_cat.UPDATED_AT,
                    SYSTEM_DT = obj_vm_sub_cat.SYSTEM_DT,
                    OPERATION_STATUS = obj_vm_sub_cat.OPERATION_STATUS,
                    AUTHORIZATION_STATUS = obj_vm_sub_cat.AUTHORIZATION_STATUS,
                    AUTHORIZED_BY = obj_vm_sub_cat.AUTHORIZED_BY,
                    AUTHORIZATION_DATE = obj_vm_sub_cat.AUTHORIZATION_DATE

                };
                db.Entry(model).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj_vm_sub_cat);
        }

        // GET: ACEP/EconSecSubCategory/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = await BusinessData.GetEconSecSubCategoryDeleteDetails(db, id).FirstOrDefaultAsync();
            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
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
