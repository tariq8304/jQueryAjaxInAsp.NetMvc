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
    public class EconPurSubCategoryController : Controller
    {
        private ACEPDBContext db = new ACEPDBContext();

        // GET: ACEP/EconPurSubCategory
        public async Task<ActionResult> Index()
        {
            var result = await BusinessData.GetEconPurSubCategoryList(db).ToListAsync();
            return View(result);
        }

        // GET: ACEP/EconPurSubCategory/Details/5
        public async Task<ActionResult> Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = await BusinessData.GetEconPurSubCategoryDetails(db, id).FirstOrDefaultAsync();

            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // GET: ACEP/EconPurSubCategory/Create
        public ActionResult Create()
        {
            VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY model = new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY();
            model.DropDownEconPurCategoryList = BusinessData.GetEconPurDropDownCategorylist(db).ToList();
            return View(model);
        }

        // POST: ACEP/EconPurSubCategory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EP_SUB_CATEGORY_NAME,EP_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY obj_vm_sub_cat)
        {
            int max_sub_cat_id = db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.Select(p => p.EP_SUB_CATEGORY_ID).DefaultIfEmpty(0).Max() + 1;
            obj_vm_sub_cat.EP_SUB_CATEGORY_ID = max_sub_cat_id;
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_PUR_SUB_CATEGORY
                {
                    EP_SUB_CATEGORY_ID = obj_vm_sub_cat.EP_SUB_CATEGORY_ID,
                    EP_SUB_CATEGORY_NAME = obj_vm_sub_cat.EP_SUB_CATEGORY_NAME,
                    EP_CATEGORY_ID = obj_vm_sub_cat.EP_CATEGORY_ID,
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


                db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.Add(model);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(obj_vm_sub_cat);
        }

        // GET: ACEP/EconPurSubCategory/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //List<category> cat = _business.ViewAllcat().ToList();
            //List<Books> book = _business.ViewAllBooks().ToList();
            //return View(new MyViewModel() { Cats = cat, Books = book);
            //VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY dropdwonmodel = new VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY();
            //model.DropDownEconPurCategoryList = BusinessData.GetEconPurDropDownCategorylist(db).ToList();
            //dropdwonmodel.DropDownEconPurCategoryList = BusinessData.GetEconPurDropDownCategorylist(db).ToList();

            ViewBag.categoryDropDown = new SelectList(BusinessData.GetEconPurDropDownCategorylist(db).ToList(), "EP_CATEGORY_ID", "EP_CATEGORY_Name");



            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);

            var result = await BusinessData.GetEconPurSubCategoryEditList(db, id).FirstOrDefaultAsync();
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);



        }

        // POST: ACEP/EconPurSubCategory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EP_SUB_CATEGORY_ID,EP_SUB_CATEGORY_NAME,EP_CATEGORY_ID,CREATED_BY,CREATION_DT,EDITED_BY,UPDATED_AT,SYSTEM_DT,OPERATION_STATUS,AUTHORIZATION_STATUS,AUTHORIZED_BY,AUTHORIZATION_DATE")] VM_TBL_ACEP_ECON_PUR_SUB_CATEGORY obj_vm_sub_cat)
        {
            if (ModelState.IsValid)
            {
                var model = new TBL_ACEP_ECON_PUR_SUB_CATEGORY
                {
                    EP_SUB_CATEGORY_ID = obj_vm_sub_cat.EP_SUB_CATEGORY_ID,
                    EP_SUB_CATEGORY_NAME = obj_vm_sub_cat.EP_SUB_CATEGORY_NAME,
                    EP_CATEGORY_ID = obj_vm_sub_cat.EP_CATEGORY_ID,
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

        // GET: ACEP/EconPurSubCategory/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var result = await BusinessData.GetEconPurSubCategoryDeleteDetails(db, id).FirstOrDefaultAsync();
            //TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);
            if (result == null)
            {
                return HttpNotFound();
            }
            return View(result);
        }

        // POST: ACEP/EconPurSubCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TBL_ACEP_ECON_PUR_SUB_CATEGORY tBL_ACEP_ECON_PUR_SUB_CATEGORY = await db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.FindAsync(id);
            db.TBL_ACEP_ECON_PUR_SUB_CATEGORY.Remove(tBL_ACEP_ECON_PUR_SUB_CATEGORY);
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
